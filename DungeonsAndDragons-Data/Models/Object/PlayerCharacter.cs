using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Models.Object
{
    public class PlayerCharacter : DPlayerCharacter
    {
        public PlayerCharacter()
        {
        }

        public PlayerCharacter(int id, int actorId, string name, int classId, int paragonPathId,
            int epicDestinyId, int experiencePoints, int raceId, int age, int genderId, string height,
            int weightPounds, int alignmentId, int deityId) 
            : base(id, actorId, name, classId, paragonPathId, epicDestinyId, experiencePoints,
                  raceId, age, genderId, height, weightPounds, alignmentId, deityId)
        {
        }
    }
}
