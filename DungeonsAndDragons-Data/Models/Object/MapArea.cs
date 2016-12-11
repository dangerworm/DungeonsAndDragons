using System.Collections.Generic;
using DungeonsAndDragons_Data.Models.Domain;

namespace DungeonsAndDragons_Data.Models.Object
{
    public class MapArea : DMapArea
    {
        public IReadOnlyCollection<PlayerCharacter> Players { get; set; }
        public IReadOnlyCollection<MapArea> MapAreas { get; set; }

        public MapArea()
        {
        }

        public MapArea(IReadOnlyCollection<PlayerCharacter> players,
                    IReadOnlyCollection<MapArea> mapAreas)
        {
            Players = players;
            MapAreas = mapAreas;
        }
    }
}
