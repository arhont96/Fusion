//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fusion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TEMPACTIVITYLIST
    {
        public int RECORDID { get; set; }
        public int SERVERID { get; set; }
        public string OBJREFNO { get; set; }
        public string OBJIDENT { get; set; }
        public Nullable<System.DateTime> LASTSEEN { get; set; }
        public Nullable<short> ONLINE { get; set; }
        public string TRANSACT_GUID { get; set; }
        public Nullable<int> TEMPDATAKIND { get; set; }
        public Nullable<int> TEMPDATASIGN { get; set; }
        public Nullable<int> TEMPSERVERID { get; set; }
    }
}
