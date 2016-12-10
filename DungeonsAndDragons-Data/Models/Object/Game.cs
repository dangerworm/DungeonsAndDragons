using System.Collections.Generic;
using System.Collections.ObjectModel;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Models.Object
{
    public class Game : DGame
    {
        public IReadOnlyCollection<PlayerCharacter> Players { get; set; }

        public Game()
        {
        }

        public Game(IReadOnlyCollection<PlayerCharacter> players)
        {
            Players = players;
        }
    }
}
