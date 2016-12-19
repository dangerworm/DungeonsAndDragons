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
    
    public partial class AttackClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AttackClass()
        {
            this.ClassWeaponProficienciesBridges = new HashSet<ClassWeaponProficienciesBridge>();
            this.Weapons = new HashSet<Weapon>();
        }
    
        public int AttackClassId { get; set; }
        public int AttackTypeId { get; set; }
        public Nullable<int> DamageNumDice { get; set; }
        public Nullable<int> DamageDieSides { get; set; }
        public Nullable<int> WeaponMultiplyer { get; set; }
        public Nullable<int> Range1 { get; set; }
        public Nullable<int> Range2 { get; set; }
        public int IsSightRange { get; set; }
    
        public virtual AttackType AttackType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassWeaponProficienciesBridge> ClassWeaponProficienciesBridges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}
