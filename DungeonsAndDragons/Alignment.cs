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
    
    public partial class Alignment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alignment()
        {
            this.Deities = new HashSet<Deity>();
            this.NonPlayerCharacters = new HashSet<NonPlayerCharacter>();
            this.PlayerCharacters = new HashSet<PlayerCharacter>();
        }
    
        public int AlignmentId { get; set; }
        public string Name { get; set; }
        public int AuthorityLevelId { get; set; }
        public int CompassionLevelId { get; set; }
    
        public virtual AuthorityLevel AuthorityLevel { get; set; }
        public virtual CompassionLevel CompassionLevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deity> Deities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NonPlayerCharacter> NonPlayerCharacters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerCharacter> PlayerCharacters { get; set; }
    }
}
