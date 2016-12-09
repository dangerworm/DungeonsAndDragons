using System.Collections.Generic;
using System.Data;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Helpers
{
    public static class PlayerCharacterHelper
    {
        public static DPlayerCharacter ParseReader(IDataReader reader)
        {
            return new DPlayerCharacter(
                reader.Get<int>(GamesCol.Id),
                reader.Get<int>(GamesCol.ActorId),
                reader.Get<string>(GamesCol.Name),
                reader.Get<int>(GamesCol.ClassId),
                reader.Get<int>(GamesCol.ParagonPathId),
                reader.Get<int>(GamesCol.EpicDestinyId),
                reader.Get<int>(GamesCol.ExperiencePoints),
                reader.Get<int>(GamesCol.RaceId),
                reader.Get<int>(GamesCol.Age),
                reader.Get<int>(GamesCol.GenderId),
                reader.Get<string>(GamesCol.Height),
                reader.Get<int>(GamesCol.WeightPounds),
                reader.Get<int>(GamesCol.AlignmentId),
                reader.Get<int>(GamesCol.DeityId)
            );
        }

        public static IEnumerable<DPlayerCharacter> ParseMultipleReader(IDataReader reader)
        {
            var values = new List<DPlayerCharacter>();

            while (reader.Read())
            {
                values.Add(ParseReader(reader));
            }

            return values;
        }

        private enum GamesCol
        {
            Id,
            ActorId,
            Name,
            ClassId,
            ParagonPathId,
            EpicDestinyId,
            ExperiencePoints,
            RaceId,
            Age,
            GenderId,
            Height,
            WeightPounds,
            AlignmentId,
            DeityId
        }
    }
}
