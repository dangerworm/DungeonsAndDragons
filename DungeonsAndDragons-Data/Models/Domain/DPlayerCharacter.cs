namespace DungeonsAndDragons_Data.Models.Domain
{
    public class DPlayerCharacter : IEntity
    {
        public int? Id { get; set; }
        public int ActorId { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public int ParagonPathId { get; set; }
        public int EpicDestinyId { get; set; }
        public int ExperiencePoints { get; set; }
        public int RaceId { get; set; }
        public int Age { get; set; }
        public int GenderId { get; set; }
        public string Height { get; set; }
        public int WeightPounds { get; set; }
        public int AlignmentId { get; set; }
        public int DeityId { get; set; }

        public DPlayerCharacter()
        {
        }

        public DPlayerCharacter(int id, int actorId, string name, int classId, int paragonPathId, int epicDestinyId, int experiencePoints, int raceId, int age, int genderId, string height, int weightPounds, int alignmentId, int deityId)
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
