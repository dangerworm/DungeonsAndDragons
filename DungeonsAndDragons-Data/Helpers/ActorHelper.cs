using System.Collections.Generic;
using System.Data;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Helpers
{
    public static class ActorHelper
    {
        public static DActor ParseReader(IDataReader reader)
        {
            return new DActor(
                reader.Get<int>(ActorsCol.Id),
                reader.Get<int>(ActorsCol.ActorTypeId),
                reader.Get<int?>(ActorsCol.MapAreaId)
            );
        }

        public static IEnumerable<DActor> ParseMultipleReader(IDataReader reader)
        {
            var actors = new List<DActor>();

            while (reader.Read())
            {
                actors.Add(ParseReader(reader));
            }

            return actors;
        }

        private enum ActorsCol
        {
            Id,
            ActorTypeId,
            MapAreaId
        }
    }
}



