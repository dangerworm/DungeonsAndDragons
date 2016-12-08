using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DungeonsAndDragons_Data
{
    public static class IDbCommandExtensions
    {
        public static IDbCommand AddWithValue(this IDbCommand command, string parameterName, object parameterValue, DbType parameterType)
        {
            Verify.ValidString(parameterName, nameof(parameterName));

            if (parameterValue == null)
            {
                parameterValue = DBNull.Value;
            }

            command.AddParameter(parameterName, parameterType).SetValue(parameterValue);

            return command;
        }

        public static IDbCommand AddIntTable(this IDbCommand command, string parameterName, IEnumerable<int> values)
        {
            Verify.ValidString(parameterName, nameof(parameterName));

            var parameter = new SqlParameter(parameterName, BuildTableValuedParameters.BuildTable(values ?? new List<int>()))
            {
                SqlDbType = SqlDbType.Structured
            };

            command.Parameters.Add(parameter);

            return command;
        }

        public static IDbCommand AddKeyValue<TId, TValue>(this IDbCommand command, string parameterName, IEnumerable<KeyValuePair<TId, TValue>> list)
        {
            var statusParam = new SqlParameter(parameterName, BuildTableValuedParameters.BuildIdValueTable(list))
            {
                SqlDbType = SqlDbType.Structured
            };
            command.Parameters.Add(statusParam);
            return command;
        }

        public static IDbDataParameter AddParameter(this IDbCommand command, string name, DbType parameterType)
        {
            if (parameterType == DbType.Time)
            {
                var sqlParameter = new SqlParameter(name, SqlDbType.Time);
                command.Parameters.Add(sqlParameter);

                return sqlParameter;
            }

            var parameter = command.CreateParameter();
            parameter.DbType = parameterType;
            parameter.ParameterName = name;
            command.Parameters.Add(parameter);
            return parameter;
        }

        public static IDbDataParameter AddParameter(this IDbCommand command, string name, DbType parameterType, ParameterDirection direction)
        {
            if (parameterType == DbType.Time)
            {
                var sqlParameter = new SqlParameter(name, SqlDbType.Time);
                sqlParameter.Direction = direction;
                command.Parameters.Add(sqlParameter);

                return sqlParameter;
            }

            var parameter = command.CreateParameter();
            parameter.DbType = parameterType;
            parameter.ParameterName = name;
            parameter.Direction = direction;
            command.Parameters.Add(parameter);
            return parameter;
        }

        public static IDbDataParameter AddReturnValue(this IDbCommand command)
        {
            var parameter = command.CreateParameter();
            parameter.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(parameter);
            return parameter;
        }

        public static IDbDataParameter AddOutput(this IDbCommand command, string name, DbType parameterType)
        {
            if (parameterType == DbType.Time)
            {
                var sqlParameter = new SqlParameter(name, SqlDbType.Time);
                sqlParameter.Direction = ParameterDirection.InputOutput;
                command.Parameters.Add(sqlParameter);

                return sqlParameter;
            }

            return command.AddParameter(name, parameterType, ParameterDirection.InputOutput);
        }

        public static IDbDataParameter AddOutputWithValue(this IDbCommand command, string name, object parameterValue, DbType parameterType)
        {
            if (parameterType == DbType.Time)
            {
                var sqlParameter = new SqlParameter(name, SqlDbType.Time);
                sqlParameter.Direction = ParameterDirection.InputOutput;
                sqlParameter.Value = parameterValue;

                command.Parameters.Add(sqlParameter);

                return sqlParameter;
            }

            return command.AddParameter(name, parameterType, ParameterDirection.InputOutput, parameterValue);
        }

        public static IDbDataParameter AddParameter(this IDbCommand command, string name, DbType parameterType, ParameterDirection direction, object parameterValue)
        {
            if (parameterType == DbType.Time)
            {
                var sqlParameter = new SqlParameter(name, SqlDbType.Time);
                sqlParameter.Direction = direction;
                sqlParameter.Value = parameterValue;

                command.Parameters.Add(sqlParameter);

                return sqlParameter;
            }

            var parameter = command.CreateParameter();
            parameter.DbType = parameterType;
            parameter.ParameterName = name;
            parameter.Direction = direction;
            command.Parameters.Add(parameter);
            parameter.SetValue(parameterValue);
            return parameter;
        }

        public static IDbDataParameter AddParameter(this IDbCommand command, string name, DbType parameterType, int size)
        {
            if (parameterType == DbType.Time)
            {
                var sqlParameter = new SqlParameter(name, SqlDbType.Time, size);
                command.Parameters.Add(sqlParameter);

                return sqlParameter;
            }

            var parameter = command.AddParameter(name, parameterType);
            parameter.Size = size;
            return parameter;
        }

        public static IDbDataParameter AddParameter(this IDbCommand command, string name, DbType parameterType, ParameterDirection direction, int size)
        {
            if (parameterType == DbType.Time)
            {
                var sqlParameter = new SqlParameter(name, SqlDbType.Time, size);
                sqlParameter.Direction = direction;
                command.Parameters.Add(sqlParameter);

                return sqlParameter;
            }

            var parameter = command.AddParameter(name, parameterType, direction);
            parameter.Size = size;
            return parameter;
        }

        public static IDbDataParameter AddParameter(this IDbCommand command, string name, IEnumerable<int> value)
        {
            var parameter = new SqlParameter(name, BuildTableValuedParameters.BuildTable(value));
            parameter.SqlDbType = SqlDbType.Structured;
            command.Parameters.Add(parameter);
            return parameter;
        }

        public static IDbDataParameter AddParameter<TEnum>(this IDbCommand command, string name, IEnumerable<TEnum> value)
            where TEnum : struct
        {
            var parameter = new SqlParameter(name, BuildTableValuedParameters.BuildTable(value));
            parameter.SqlDbType = SqlDbType.Structured;
            command.Parameters.Add(parameter);
            return parameter;
        }

        public static void SetValue(this IDbDataParameter parameter, object value)
        {
            if (value != null)
            {
                parameter.Value = value;
            }
            else
            {
                parameter.Value = DBNull.Value;
            }
        }

        public static void SetValue<TValue>(this IDbDataParameter parameter, TValue? value) where TValue : struct
        {
            if (value.HasValue)
            {
                parameter.Value = value.Value;
            }
            else
            {
                parameter.Value = DBNull.Value;
            }
        }

        public static string GetDetails(this IDbCommand command)
        {
            var result = new StringBuilder();

            result.AppendLine();
            result.AppendLine("Command details:");
            result.AppendLine();
            result.AppendLine($"Connection String: {command.Connection.ConnectionString}");
            result.AppendLine($"Is using transaction: {command.Transaction != null}");
            result.AppendLine($"Command Type: {command.CommandType}");
            result.AppendLine($"Command Text: {command.CommandText}");
            result.AppendLine();
            result.AppendLine("Command Parameters:");
            result.AppendLine();

            foreach (IDbDataParameter parameter in command.Parameters)
            {
                result.AppendFormat("Name: {0} | ", parameter.ParameterName);
                result.AppendFormat("Type: {0} | ", parameter.DbType);
                result.AppendFormat("Direction: {0} | ", parameter.Direction);
                result.AppendFormat("Value: {0}{1}", parameter.Value, Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
