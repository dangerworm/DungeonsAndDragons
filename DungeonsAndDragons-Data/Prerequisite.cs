//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DungeonsAndDragons_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prerequisite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prerequisite()
        {
            this.Powers = new HashSet<Power>();
        }
    
        public int PrerequisiteId { get; set; }
        public Nullable<int> FeatureId { get; set; }
        public Nullable<int> PowerId { get; set; }
        public Nullable<int> CombatLevel { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> RaceId { get; set; }
        public Nullable<int> SizeId { get; set; }
        public Nullable<int> DeityId { get; set; }
        public Nullable<int> PrerequisiteFeatureId { get; set; }
        public Nullable<int> AbilityValueId { get; set; }
        public Nullable<int> MinAbilityScore { get; set; }
        public Nullable<int> TrainedSkillId { get; set; }
        public Nullable<int> WeaponGroupId { get; set; }
    
        public virtual AbilityValue AbilityValue { get; set; }
        public virtual Class Class { get; set; }
        public virtual Deity Deity { get; set; }
        public virtual Feature Feature { get; set; }
        public virtual Feature Feature1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Power> Powers { get; set; }
        public virtual Power Power { get; set; }
        public virtual Race Race { get; set; }
        public virtual Size Size { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual WeaponGroup WeaponGroup { get; set; }
    }
}
