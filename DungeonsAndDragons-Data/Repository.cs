using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons_Data
{
    public abstract class Repository<TEntity>
    {
        protected bool CustomGetReader;

        protected UnitOfWork UnitOfWork { get; }

        protected Repository(UnitOfWork unitOfWork, bool customGetReader = false)
        {
            Verify.NotNull(unitOfWork, nameof(unitOfWork));

            UnitOfWork = unitOfWork;
            CustomGetReader = customGetReader;
        }

        protected TEntity Get(IDbCommand command)
        {
            if (CustomGetReader)
            {
                return Get(command, Map);
            }

            try
            {
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return default(TEntity);
                    }

                    return Map(reader);
                }
            }
            catch (DbException exception)
            {
                if (command.Transaction != null)
                {
                    var dataResult = new DataResult(DataResultType.UnknownError, "Sorry, an unexpected error has occurred.", "A database exception occurred when trying to load.", exception);
                    dataResult.Data.Add("Command Details", command.GetDetails());

                    UnitOfWork.AddDataResult(dataResult);
                }

                exception.Data.Add("Paystream.ExceptionData.StringValue", command.GetDetails());
                throw;
            }
        }

        protected IReadOnlyCollection<TEntity> GetList(IDbCommand command)
        {
            if (CustomGetReader)
            {
                return GetList(command, MapList);
            }

            try
            {
                using (var reader = command.ExecuteReader())
                {
                    var items = new List<TEntity>();
                    while (reader.Read())
                    {
                        items.Add(Map(reader));
                    }
                    return items;
                }
            }
            catch (DbException exception)
            {
                if (command.Transaction != null)
                {
                    var dataResult = new DataResult(DataResultType.UnknownError, "Sorry, an unexpected error has occurred.", "A database exception occurred when trying to load.", exception);
                    dataResult.Data.Add("Command Details", command.GetDetails());

                    UnitOfWork.AddDataResult(dataResult);
                }

                exception.Data.Add("Paystream.ExceptionData.StringValue", command.GetDetails());
                throw;
            }
        }

        protected T Get<T>(IDbCommand command, Func<IDataReader, T> map)
        {
            try
            {
                using (var reader = command.ExecuteReader())
                {
                    return map(reader);
                }
            }
            catch (DbException exception)
            {
                if (command.Transaction != null)
                {
                    var dataResult = new DataResult(DataResultType.UnknownError, "Sorry, an unexpected error has occurred.", "A database exception occurred when trying to load.", exception);
                    dataResult.Data.Add("Command Details", command.GetDetails());

                    UnitOfWork.AddDataResult(dataResult);
                }

                exception.Data.Add("Paystream.ExceptionData.StringValue", command.GetDetails());
                throw;
            }
        }

        protected IReadOnlyCollection<T> GetList<T>(IDbCommand command, Func<IDataReader, IReadOnlyCollection<T>> map)
        {
            try
            {
                using (var reader = command.ExecuteReader())
                {
                    return map(reader);
                }
            }
            catch (DbException exception)
            {
                if (command.Transaction != null)
                {
                    var dataResult = new DataResult(DataResultType.UnknownError, "Sorry, an unexpected error has occurred.", "A database exception occurred when trying to load.", exception);
                    dataResult.Data.Add("Command Details", command.GetDetails());

                    UnitOfWork.AddDataResult(dataResult);
                }

                exception.Data.Add("Paystream.ExceptionData.StringValue", command.GetDetails());
                throw;
            }
        }

        protected DataResult<TEntity> Save(IDbCommand command, TEntity value, IDbDataParameter idParameter)
        {
            DataResult<TEntity> dataResult;
            string commandType = "create";
            var failureType = DataResultType.UnableToCreateRecord;
            if (command.CommandText.ToLower().EndsWith("update"))
            {
                commandType = "update";
                failureType = DataResultType.UnableToUpdateRecord;
            }

            try
            {
                var returnValueParameter = command.AddReturnValue();

                // don't use result from ExecuteNonQuery as not reliable and NOCOUNT might be set to ON
                command.ExecuteNonQuery();

                int result = (int)returnValueParameter.Value;

                if (result > 0)
                {
                    if (idParameter.Value != DBNull.Value)
                    {
                        dataResult = new DataResult<TEntity>(value, (int)idParameter.Value, DataResultType.Success,
                            "Success", "Record created/updated successfully.");
                    }
                    else
                    {
                        dataResult = new DataResult<TEntity>(value, DataResultType.UnknownRecord,
                            "Sorry, an unexpected error has occurred.", "Unable to retrieve the record id.");
                    }
                }
                else
                {
                    string message = $"Unable to {commandType} record. No records affected.";

                    dataResult = new DataResult<TEntity>(value, failureType, "Sorry, an unexpected error has occurred.",
                        message);
                }
            }
            catch (DbException exception)
            {
                string message = $"Unable to {commandType} record. An exception occurred with the database.";

                dataResult = new DataResult<TEntity>(value, failureType, "Sorry, an unexpected error has occurred.", message,
                    exception);
            }

            dataResult.Data.Add("Command Details", command.GetDetails());

            UnitOfWork.AddDataResult(dataResult);
            return dataResult;
        }

        protected DataResult Delete(IDbCommand command)
        {
            return ExecuteNonQuery(command);
        }

        protected DataResult ExecuteNonQuery(IDbCommand command)
        {
            DataResult dataResult;
            string commandType = "create";
            var failureType = DataResultType.UnableToCreateRecord;
            if (command.CommandText.ToLower().EndsWith("update"))
            {
                commandType = "update";
                failureType = DataResultType.UnableToUpdateRecord;
            }
            else if (command.CommandText.ToLower().EndsWith("delete"))
            {
                commandType = "delete";
                failureType = DataResultType.UnableToDeleteRecord;
            }

            try
            {
                var returnValueParameter = command.AddReturnValue();

                // don't use result from ExecuteNonQuery as not reliable and NOCOUNT might be set to ON
                command.ExecuteNonQuery();

                int result = (int)returnValueParameter.Value;

                if (result > 0) //TODO: need to change this to allow Daily Timesheets
                {
                    dataResult = new DataResult(DataResultType.Success, "Success",
                        $"Record {commandType}d successfully.");
                }
                else
                {
                    string message = $"Unable to {commandType} record. No records affected.";

                    dataResult = new DataResult(failureType, "Sorry, an unexpected error has occurred.", message);
                }
            }
            catch (DbException exception)
            {
                string message = $"Unable to {commandType} record. An exception occurred with the database.";

                dataResult = new DataResult(failureType, "Sorry, an unexpected error has occurred.", message, exception);
            }

            dataResult.Data.Add("Command Details", command.GetDetails());

            UnitOfWork.AddDataResult(dataResult);
            return dataResult;
        }

        protected DataResult<int> ExecuteNonQueryWithId(IDbCommand command, IDbDataParameter idParameter)
        {
            DataResult<int> dataResult;
            string commandType = "create";
            var failureType = DataResultType.UnableToCreateRecord;
            if (command.CommandText.ToLower().EndsWith("update"))
            {
                commandType = "update";
                failureType = DataResultType.UnableToUpdateRecord;
            }
            else if (command.CommandText.ToLower().EndsWith("delete"))
            {
                commandType = "delete";
                failureType = DataResultType.UnableToDeleteRecord;
            }
            else if (command.CommandText.ToLower().EndsWith("save"))
            {
                commandType = "save";
                failureType = DataResultType.UnableToUpdateRecord;
            }

            try
            {
                var returnValueParameter = command.AddReturnValue();

                // don't use result from ExecuteNonQuery as not reliable and NOCOUNT might be set to ON
                command.ExecuteNonQuery();

                int result = (int)returnValueParameter.Value;

                if (result > 0)
                {
                    if (idParameter.Value != DBNull.Value)
                    {
                        dataResult = new DataResult<int>((int)idParameter.Value, (int)idParameter.Value,
                            DataResultType.Success, "Success",
                            "Record created/updated successfully.");
                    }
                    else
                    {
                        dataResult = new DataResult<int>(DataResultType.UnknownError,
                            "Sorry, an unexpected error has occurred.",
                            "Unable to retrieve the record id.");
                    }
                }
                else
                {
                    string message = $"Unable to {commandType} record. No records affected.";

                    dataResult = new DataResult<int>(failureType, "Sorry, an unexpected error has occurred.", message);
                }
            }
            catch (DbException exception)
            {
                string message = $"Unable to {commandType} record. An exception occurred with the database.";

                dataResult = new DataResult<int>(failureType, "Sorry, an unexpected error has occurred.", message, exception);
            }

            dataResult.Data.Add("Command Details", command.GetDetails());

            UnitOfWork.AddDataResult(dataResult);
            return dataResult;
        }

        protected abstract TEntity Map(IDataReader reader);

        protected virtual IReadOnlyCollection<TEntity> MapList(IDataReader reader)
        {
            throw new NotImplementedException("CustomGetReader is set to true but MapList has not been implemented.");
        }
    }
}
