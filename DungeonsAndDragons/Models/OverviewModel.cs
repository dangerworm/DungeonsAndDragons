using DungeonsAndDragons_Data.Models.Object;

namespace DungeonsAndDragons.Models
{
    public class OverviewModel
    {
        public Game[] Games { get; set; }
        public PlayerCharacter[] Players { get; set; }

        public OverviewModel(Game[] games, PlayerCharacter[] players)
        {
            Games = games;
            Players = players;
        }
    }
}