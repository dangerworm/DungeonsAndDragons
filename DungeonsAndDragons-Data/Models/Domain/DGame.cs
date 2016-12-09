using System;

namespace DungeonsAndDragons_Data.Models.Domain
{
    public class DGame : IEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public DGame()
        {
        }

        public DGame(int? id, string name, DateTime startDate)
        {
            Id = id;
            Name = name;
            StartDate = startDate;
        }
    }
}
