using DungeonsAndDragons_Data.Enums;

namespace DungeonsAndDragons.Models
{
    public class AbilityScoreModel
    {
        public Abilities Ability { get; set; }

        public int ActorScore { get; set; }

        public int FeatureBonus { get; set; }

        public int RaceBonus { get; set; }

        public int Total => ActorScore + FeatureBonus + RaceBonus;
    }
}