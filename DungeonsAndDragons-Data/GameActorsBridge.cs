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
    
    public partial class GameActorsBridge
    {
        public int GameActorBridgeId { get; set; }
        public int GameId { get; set; }
        public int ActorId { get; set; }
    
        public virtual Actor Actor { get; set; }
        public virtual Game Game { get; set; }
    }
}
