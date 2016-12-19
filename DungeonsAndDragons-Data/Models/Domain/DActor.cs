using System;

namespace DungeonsAndDragons_Data.Models.Domain
{
    public class DActor : IEntity
    {
        public int? Id { get; set; }
        public int ActorTypeId { get; set; }
        public int? MapAreaId { get; set; }

        public DActor()
        {
        }

        public DActor(int? id, int actorTypeId, int? mapAreaId)
        {
            Id = id;
            ActorTypeId = actorTypeId;
            MapAreaId = mapAreaId;
        }
    }
}
