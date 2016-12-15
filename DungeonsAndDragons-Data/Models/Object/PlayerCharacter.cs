using DungeonsAndDragons_Data.Enums;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Models.Object
{
    public class PlayerCharacter : DPlayerCharacter
    {
        public PlayerCharacter()
        {
        }

        public PlayerCharacter(int id, int actorId, string name, Classes classId, int paragonPathId,
            int epicDestinyId, int experiencePoints, Races raceId, int age, Genders genderId, string height,
            int weightPounds, int alignmentId, Deities deityId) 
            : base(id, actorId, name, classId, paragonPathId, epicDestinyId, experiencePoints,
                  raceId, age, genderId, height, weightPounds, alignmentId, deityId)
        {
        }
    }
}
