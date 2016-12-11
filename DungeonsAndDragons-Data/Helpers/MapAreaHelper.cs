using System.Collections.Generic;
using System.Data;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Helpers
{
    public static class MapAreaHelper
    {
        public static DMapArea ParseReader(IDataReader reader)
        {
            return new DMapArea(
                reader.Get<int>(MapAreasCol.Id),
                reader.Get<int>(MapAreasCol.TypeId),
                reader.Get<string>(MapAreasCol.Name),
                reader.Get<string>(MapAreasCol.FlavourText),
                reader.Get<int?>(MapAreasCol.ShopId),
                reader.Get<byte[]>(MapAreasCol.MapImage),
                reader.Get<int?>(MapAreasCol.ParentMapAreaId),
                reader.Get<decimal?>(MapAreasCol.ParentMapAreaLocationN),
                reader.Get<decimal?>(MapAreasCol.ParentMapAreaLocationE)
            );
        }

        public static IEnumerable<DMapArea> ParseMultipleReader(IDataReader reader)
        {
            var values = new List<DMapArea>();

            while (reader.Read())
            {
                values.Add(ParseReader(reader));
            }

            return values;
        }

        private enum MapAreasCol
        {
            Id,
            TypeId,
            Name,
            FlavourText,
            ShopId,
            MapImage,
            ParentMapAreaId,
            ParentMapAreaLocationN,
            ParentMapAreaLocationE
        }
    }
}
