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
    
    public partial class ClassImplementProficienciesBridge
    {
        public int ClassImplementProficiencyId { get; set; }
        public int ClassId { get; set; }
        public int ImplementTypeId { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual ImplementType ImplementType { get; set; }
    }
}
