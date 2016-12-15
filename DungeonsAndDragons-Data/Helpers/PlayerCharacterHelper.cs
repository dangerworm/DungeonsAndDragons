using System.Collections.Generic;
using System.Data;
using DungeonsAndDragons_Data.Enums;
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
                reader.Get<Classes>(PlayerCharactersCol.ClassId),
                reader.Get<int>(PlayerCharactersCol.ParagonPathId),
                reader.Get<int>(PlayerCharactersCol.EpicDestinyId),
                reader.Get<int>(PlayerCharactersCol.ExperiencePoints),
                reader.Get<Races>(PlayerCharactersCol.RaceId),
                reader.Get<int>(PlayerCharactersCol.Age),
                reader.Get<Genders>(PlayerCharactersCol.GenderId),
                reader.Get<string>(PlayerCharactersCol.Height),
                reader.Get<int>(PlayerCharactersCol.WeightPounds),
                reader.Get<int>(PlayerCharactersCol.AlignmentId),
                reader.Get<Deities>(PlayerCharactersCol.DeityId)
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
