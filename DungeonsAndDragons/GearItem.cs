//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DungeonsAndDragons
{
    using System;
    using System.Collections.Generic;
    
    public partial class GearItem
    {
        public int GearItemId { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int WeightPounds { get; set; }
        public Nullable<int> ImplementTypeId { get; set; }
        public Nullable<int> OwnerActorId { get; set; }
    
        public virtual Actor Actor { get; set; }
        public virtual ImplementType ImplementType { get; set; }
    }
}
