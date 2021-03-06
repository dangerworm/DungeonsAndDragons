﻿using System.Collections.Generic;
using DungeonsAndDragons_Data.Models.Domain;
using System;

namespace DungeonsAndDragons_Data.Models.Object
{
    public class Game : DGame
    {
        public IReadOnlyCollection<PlayerCharacter> Players { get; set; }
        public IReadOnlyCollection<MapArea> MapAreas { get; set; }

        public Game()
        {
        }

        public Game(int? id, string name, DateTime startDate)
            :base(id, name, startDate)
        {
        }

        public Game(int? id, string name, DateTime startDate,
                    IReadOnlyCollection<PlayerCharacter> players,
                    IReadOnlyCollection<MapArea> mapAreas)
            :base(id, name, startDate)
        {
            Players = players;
            MapAreas = mapAreas;
        }
    }
}
