using System.Collections.Generic;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Models.Object
{
    public class Game : DGame
    {
        public List<PlayerCharacter> Players { get; set; }

        public Game()
        {
            Players = new List<PlayerCharacter>();
        }

        public Game(List<PlayerCharacter> players)
        {
            Players = players;
        }
    }
}
