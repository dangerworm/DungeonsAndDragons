using System;

namespace DungeonsAndDragons_Data
{
    public class Game
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public Game(int gameId, string name, DateTime startDate)
        {
            Id = gameId;
            Name = name;
            StartDate = startDate;
        }
    }
}
