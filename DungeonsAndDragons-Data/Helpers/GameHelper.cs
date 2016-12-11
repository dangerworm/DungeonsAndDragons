using System;
using System.Collections.Generic;
using System.Data;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Helpers
{
    public static class GameHelper
    {
        public static DGame ParseReader(IDataReader reader)
        {
            return new DGame(
                reader.Get<int>(GamesCol.Id),
                reader.Get<string>(GamesCol.Name),
                reader.Get<DateTime>(GamesCol.StartDate)
            );
        }

        public static IEnumerable<DGame> ParseMultipleReader(IDataReader reader)
        {
            var games = new List<DGame>();

            while (reader.Read())
            {
                games.Add(ParseReader(reader));
            }

            return games;
        }

        private enum GamesCol
        {
            Id,
            Name,
            StartDate
        }
    }
}
