using DungeonsAndDragons_Data.Enums;

namespace DungeonsAndDragons_Data.Models.Domain
{
    public class DPlayerCharacter : IEntity
    {
        public int? Id { get; set; }
        public int ActorId { get; set; }
        public string Name { get; set; }
        public Classes ClassId { get; set; }
        public int ParagonPathId { get; set; }
        public int EpicDestinyId { get; set; }
        public int ExperiencePoints { get; set; }
        public Races RaceId { get; set; }
        public int Age { get; set; }
        public Genders GenderId { get; set; }
        public string Height { get; set; }
        public int WeightPounds { get; set; }
        public int AlignmentId { get; set; }
        public Deities DeityId { get; set; }

        public DPlayerCharacter()
        {
        }

        public DPlayerCharacter(int? id, int actorId, string name, Classes classId, int paragonPathId,
            int epicDestinyId, int experiencePoints, Races raceId, int age, Genders genderId,
            string height, int weightPounds, int alignmentId, Deities deityId)
        {
            Id = id;
            ActorId = actorId;
            Name = name;
            ClassId = classId;
            ParagonPathId = paragonPathId;
            EpicDestinyId = epicDestinyId;
            ExperiencePoints = experiencePoints;
            RaceId = raceId;
            Age = age;
            GenderId = genderId;
            Height = height;
            WeightPounds = weightPounds;
            AlignmentId = alignmentId;
            DeityId = deityId;
        }
    }
}
