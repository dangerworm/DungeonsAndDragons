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
                reader.Get<int>(PlayerCharactersCol.Id),
                reader.Get<int>(PlayerCharactersCol.ActorId),
                reader.Get<string>(PlayerCharactersCol.Name),
                reader.Get<int>(PlayerCharactersCol.ClassId),
                reader.Get<int>(PlayerCharactersCol.ParagonPathId),
                reader.Get<int>(PlayerCharactersCol.EpicDestinyId),
                reader.Get<int>(PlayerCharactersCol.ExperiencePoints),
                reader.Get<int>(PlayerCharactersCol.RaceId),
                reader.Get<int>(PlayerCharactersCol.Age),
                reader.Get<int>(PlayerCharactersCol.GenderId),
                reader.Get<string>(PlayerCharactersCol.Height),
                reader.Get<int>(PlayerCharactersCol.WeightPounds),
                reader.Get<int>(PlayerCharactersCol.AlignmentId),
                reader.Get<int>(PlayerCharactersCol.DeityId)
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

        private enum PlayerCharactersCol
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
