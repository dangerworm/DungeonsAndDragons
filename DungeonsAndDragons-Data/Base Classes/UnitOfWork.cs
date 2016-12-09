using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;

namespace DungeonsAndDragons_Data
{
    public class UnitOfWork
    {
        private readonly DbConnectionFactory _connectionFactory;
        private readonly string _connectionString;
        private readonly string _id;
        private readonly object @lock;
        private IDbConnection _connection;
        private List<DataResult> _results;

        private SqlTransaction _transaction;

        public bool HasConnection => _connection != null;

        public UnitOfWork(string connectionString)
        {
            Verify.NotNull(connectionString, nameof(connectionString));

            _connectionFactory = new DbConnectionFactory();
            _connectionString = connectionString;

            _id = Guid.NewGuid().ToString();
            @lock = new object();
        }

        public UnitOfWork Begin()
        {
            // provide a lock to stop multiple threads accessing this method
            if (HttpRuntime.AppDomainAppId == null)
            {
                Monitor.Enter(@lock);
            }

            if (_connection != null && _connection.State != ConnectionState.Closed)
            {
                return this;
                throw new InvalidOperationException("Unit of Work has already been started. You must call End() before calling Begin() again.");
            }

            _connection = _connectionFactory.Make(_connectionString);
            _connection.Open();

            _results = new List<DataResult>();
            return this;
        }

        public void End()
        {
            if (_connection == null)
            {
                throw new InvalidOperationException("Unit of work has not been started. You must call Begin() before calling End().");
            }

            if (_connection.State != ConnectionState.Open)
            {
                throw new InvalidOperationException("Unit of work has been started, but another process has closed the connection.");
            }

            if (_transaction != null)
            {
                EndTransaction();
            }

            _connection.Close();
            _connection.Dispose();
            _connection = null;

            // release the lock so the unit of work can be accessed again
            if (HttpRuntime.AppDomainAppId == null)
            {
                Monitor.Exit(@lock);
            }
        }

        public IDbConnection GetConnection()
        {
            if (_connection == null)
            {
                throw new InvalidOperationException("You must call Begin() before you can access the connection.");
            }

            return _connection;
        }

        public IDbTransaction GetTransaction()
        {
            return _transaction;
        }

        public void BeginTransaction()
        {
            if (_transaction != null)
            {
                throw new InvalidOperationException(
                    "Transaction has already been started. You must call EndTransaction() before calling BeginTransaction() again.");
            }

            _transaction = (SqlTransaction)GetConnection().BeginTransaction();
        }

        public void EndTransaction()
        {
            if (_transaction == null)
            {
                throw new InvalidOperationException("You must call BeginTransaction() before EndTransaction().");
            }

            if (!IsSuccess())
            {
                Rollback();
            }
            else
            {
                Commit();
            }
        }

        public void Commit()
        {
            if (_transaction == null)
            {
                throw new InvalidOperationException("You must call BeginTransaction() before Commit().");
            }

            _transaction.Commit();
            _transaction.Dispose();
            _transaction = null;
            _results.Clear();
        }

        public void Rollback()
        {
            if (_transaction == null)
            {
                throw new InvalidOperationException("You must call BeginTransaction() before Rollback().");
            }

            _transaction.Rollback();
            _transaction.Dispose();
            _transaction = null;
            _results.Clear();
        }

        public IDbCommand CreateCommand()
        {
            var command = _connection.CreateCommand();
            command.Transaction = _transaction;

            return command;
        }

        public IDbCommand CreateCommand(CommandType type)
        {
            var command = _connection.CreateCommand();
            command.Transaction = _transaction;
            command.CommandType = type;

            return command;
        }

        public IDbCommand CreateCommand(CommandType type, string text)
        {
            var command = _connection.CreateCommand();
            command.Transaction = _transaction;
            command.CommandType = type;
            command.CommandText = text;

            return command;
        }

        public IDbCommand CreateStoredProcedure(string text)
        {
            return CreateCommand(CommandType.StoredProcedure, text);
        }

        public void AddDataResult(DataResult result)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            _results.Add(result);
        }

        public IEnumerable<DataResult> GetAllDataResults()
        {
            return new ReadOnlyCollection<DataResult>(_results);
        }

        public DataResult GetLastDataResult()
        {
            return _results.LastOrDefault();
        }

        public bool IsSuccess()
        {
            return !_results.Any(x => x.Type != DataResultType.Success && x.Type != DataResultType.NotRequired);
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                EndTransaction();
            }

            if (_connection != null)
            {
                End();
            }
        }

        public override string ToString()
        {
            return "UnitOfWork-" + _id;
        }
    }
}