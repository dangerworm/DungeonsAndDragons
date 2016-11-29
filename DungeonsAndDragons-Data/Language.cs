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
    
    public partial class Language
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Language()
        {
            this.LanguageRacesBridges = new HashSet<LanguageRacesBridge>();
            this.PlayerCharacterLanguagesBridges = new HashSet<PlayerCharacterLanguagesBridge>();
        }
    
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public int ScriptId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LanguageRacesBridge> LanguageRacesBridges { get; set; }
        public virtual Script Script { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerCharacterLanguagesBridge> PlayerCharacterLanguagesBridges { get; set; }
    }
}
