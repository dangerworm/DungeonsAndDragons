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
    
    public partial class PowerEffectsBridge
    {
        public int PowerEffectId { get; set; }
        public int PowerId { get; set; }
        public int EffectId { get; set; }
    
        public virtual EffectType EffectType { get; set; }
        public virtual Power Power { get; set; }
    }
}
