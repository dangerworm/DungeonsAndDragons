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
    
    public partial class PlayerCharacterLanguagesBridge
    {
        public int PlayerCharacterLanguageId { get; set; }
        public int PlayerCharacterId { get; set; }
        public int LanguageId { get; set; }
    
        public virtual Language Language { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }
    }
}