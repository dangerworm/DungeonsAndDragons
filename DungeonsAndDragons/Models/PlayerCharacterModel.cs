using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DungeonsAndDragons_Data.Enums;
using DungeonsAndDragons_Data.Models.Object;

namespace DungeonsAndDragons.Models
{
    public class PlayerCharacterModel
    {
        public IEnumerable<AbilityScoreModel> AbilityScores { get; set; }

        public int? Id { get; set; }

        public int ActorId { get; set; }

        [Required(ErrorMessage = "Please enter a name for your character")]
        public string Name { get; set; }

        [Display(Name = "Class")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select your character's class")]
        public Classes ClassId { get; set; }

        [Display(Name = "Paragon Path")]
        public int? ParagonPathId { get; set; }

        [Display(Name = "Epic Destiny")]
        public int? EpicDestinyId { get; set; }

        [Display(Name = "Experience Points (XP)")]
        public int ExperiencePoints { get; set; }

        [Display(Name = "Race")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select your character's race")]
        public Races RaceId { get; set; }

        [Required(ErrorMessage = "Please enter your character's age")]
        [Range(16, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Age { get; set; }

        [Display(Name = "Gender")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select your character's gender")]
        public Genders GenderId { get; set; }

        public string Height { get; set; }

        [Display(Name = "Weight (lb)")]
        public int WeightPounds { get; set; }

        [Display(Name = "Alignment")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select your character's alignment")]
        public Alignments AlignmentId { get; set; }

        [Display(Name = "Deity")]
        public Deities? DeityId { get; set; }

        public PlayerCharacterModel()
        {
        }

        public PlayerCharacterModel(PlayerCharacter player)
        {
            Id = player.Id;
            ActorId = player.ActorId;
            Name = player.Name;
            ClassId = player.ClassId;
            ParagonPathId = player.ParagonPathId;
            EpicDestinyId = player.EpicDestinyId;
            ExperiencePoints = player.ExperiencePoints;
            RaceId = player.RaceId;
            Age = player.Age;
            GenderId = player.GenderId;
            Height = player.Height;
            WeightPounds = player.WeightPounds;
            AlignmentId = player.AlignmentId;
            DeityId = player.DeityId;
        }

        public PlayerCharacterModel(PlayerCharacter player, IEnumerable<AbilityScoreModel> abilityScores)
            :this (player)
        {
            AbilityScores = abilityScores;
        }
    }
}
