using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DungeonsAndDragons_Data
{
    public class DbConnectionFactory
    {
        private readonly DbProviderFactory _dbProviderFactory;

        public DbConnectionFactory(string provider = null)
        {
            if (string.IsNullOrWhiteSpace(provider))
            {
                provider = "System.Data.SqlClient";
            }
            _dbProviderFactory = DbProviderFactories.GetFactory(provider);
        }

        public IDbConnection Make()
        {
            return (SqlConnection) _dbProviderFactory.CreateConnection();
        }

        public IDbConnection Make(string connectionString)
        {
            var connection = Make();
            connection.ConnectionString = connectionString;
            return connection;
        }

        public IDbConnection Make(string connectionString, IDbTransaction transaction)
        {
            if (transaction != null)
            {
                return transaction.Connection;
            }

            return Make(connectionString);
        }

        public DbConnectionStringBuilder GetConnectionStringBuilder()
        {
            return _dbProviderFactory.CreateConnectionStringBuilder();
        }

        public DbConnectionStringBuilder GetConnectionStringBuilder(string connectionString)
        {
            var builder = _dbProviderFactory.CreateConnectionStringBuilder();
            builder.ConnectionString = connectionString;
            return builder;
        }
    }
}
