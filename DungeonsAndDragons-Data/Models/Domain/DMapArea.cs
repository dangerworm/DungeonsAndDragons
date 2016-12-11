using System;

namespace DungeonsAndDragons_Data.Models.Domain
{
    public class DMapArea : IEntity
    {
        public int? Id { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string FlavourText { get; set; }
        public int? ShopId { get; set; }
        public byte[] Image { get; set; }
        public int? ParentMapAreaId { get; set; }
        public decimal? ParentMapAreaLocationN { get; set; }
        public decimal? ParentMapAreaLocationE { get; set; }

        public DMapArea()
        {
        }

        public DMapArea(int? id, int typeId, string name, string flavourText, int? shopId,
            byte[] image, int? parentMapAreaId, decimal? locationN, decimal? locationE)
        {
            Id = id;
            TypeId = typeId;
            Name = name;
            FlavourText = flavourText;
            ShopId = shopId;
            Image = image;
            ParentMapAreaId = parentMapAreaId;
            ParentMapAreaLocationN = locationN;
            ParentMapAreaLocationE = locationE;
        }
    }
}
