using System;
using System.Collections.Generic;
using System.Data;

namespace DungeonsAndDragons_Data
{
    public static class GameHelper
    {
        public static Game ParseReader(IDataReader reader)
        {
            return new Game(
                reader.Get<int>(GamesCol.Id),
                reader.Get<string>(GamesCol.Name),
                reader.Get<DateTime>(GamesCol.StartDate)
            );
        }

        public static IEnumerable<Game> ParseMultipleReader(IDataReader reader)
        {
            var games = new List<Game>();

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
