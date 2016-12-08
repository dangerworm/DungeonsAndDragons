using System;
using System.Collections.Generic;
using System.Data;

namespace DungeonsAndDragons_Data
{
    public static class BuildTableValuedParameters
    {
        private static DataTable GetIntListTable()
        {
            var table = new DataTable("list");
            table.Columns.Add("Id", typeof(int));

            return table;
        }

        public static DataTable BuildTable(IEnumerable<int> integers)
        {
            var table = GetIntListTable();

            foreach (var integer in integers)
            {
                table.Rows.Add(integer);
            }

            return table;
        }

        public static DataTable BuildTable<TEnum>(IEnumerable<TEnum> values)
            where TEnum : struct
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new InvalidOperationException("TEnum must be an enum");
            }

            var table = GetIntListTable();

            foreach (var value in values)
            {
                table.Rows.Add(value);
            }

            return table;
        }

        private static DataTable GetIdValueListTable<TId, TValue>()
        {
            var table = new DataTable("list");
            table.Columns.Add("Id", typeof(TId));
            table.Columns.Add("Value", typeof(TValue));

            return table;
        }

        public static DataTable BuildIdValueTable<TId, TValue>(IEnumerable<KeyValuePair<TId, TValue>> valuePairs)
        {
            var table = GetIdValueListTable<TId, TValue>();

            foreach (var pair in valuePairs)
            {
                var row = table.NewRow();
                row["Id"] = pair.Key;
                row["Value"] = pair.Value;

                table.Rows.Add(row);
            }
            return table;
        }
    }
}
