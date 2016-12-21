using System.ComponentModel.DataAnnotations;
using DungeonsAndDragons_Data;
using DungeonsAndDragons_Data.Enums;

namespace DungeonsAndDragons.Models
{
    public class PlayerCharacterModel
    {
        public int? Id { get; set; }
        public int ActorId { get; set; }
        [Required(ErrorMessage = "Please enter a name for your character")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please select your character's class")]
        public Classes ClassId { get; set; }
        public int? ParagonPathId { get; set; }
        public int? EpicDestinyId { get; set; }
        public int ExperiencePoints { get; set; }
        [Required(ErrorMessage = "Please select your character's race")]
        public Races RaceId { get; set; }
        [Range(16, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please select your character's gender")]
        public Genders GenderId { get; set; }
        public string Height { get; set; }
        public int WeightPounds { get; set; }
        [Required(ErrorMessage = "Please select your character's alignment")]
        public Alignments AlignmentId { get; set; }
        public Deities? DeityId { get; set; }

        public PlayerCharacterModel()
        {
        }

        public PlayerCharacterModel(int? id, int actorId, string name, Classes classId, int? paragonPathId,
            int? epicDestinyId, int experiencePoints, Races raceId, int age, Genders genderId,
            string height, int weightPounds, Alignments alignmentId, Deities? deityId)
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
