using System;
using System.Data;

namespace DungeonsAndDragons_Data
{
    public static class DataRecordExtensions
    {
        public static T Get<T>(this IDataRecord reader, Int32 columnIndex)
        {
            return Get<T>(reader, columnIndex, default(T));
        }

        public static T Get<T>(this IDataRecord reader, Enum enumColumnIndex)
        {
            return Get<T>(reader, enumColumnIndex, default(T));
        }

        public static T Get<T>(this IDataRecord reader, Enum enumColumnIndex, T nullValue)
        {
            return Get<T>(reader, Convert.ToInt32(enumColumnIndex), nullValue, enumColumnIndex.ToString());
        }

        public static T Get<T>(this IDataRecord reader, Int32 columnIndex, T nullValue)
        {
            return Get(reader, columnIndex, nullValue, null);
        }

        private static T Get<T>(IDataRecord reader, int columnIndex, T nullValue, string columnName)
        {
            if (reader.IsDBNull(columnIndex))
            {
                return nullValue;
            }

            // SQL char type is a string. Need to box and unbox to support generic
            if (typeof(T) == typeof(Char) || typeof(T) == typeof(Char?))
            {
                var stringResult = reader.GetString(columnIndex);

                if (stringResult.Length == 1)
                {
                    return (T)(Object)(stringResult[0]);
                }

                return nullValue;
            }

            try
            {
                return (T)(reader[columnIndex]);
            }
            catch (InvalidCastException exception)
            {
                throw new InvalidOperationException("Requested type does not match SQL data type. "
                    + String.Format("Column: {0}, Attempted Type: {1}.", columnName ?? columnIndex.ToString(), typeof(T).Name),
                    exception);
            }
        }
    }
}
