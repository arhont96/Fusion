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
    
    public partial class IR_SCHEDULE_REPORTS
    {
        public string GUIDSTRING { get; set; }
        public Nullable<int> CODE { get; set; }
        public string NAME { get; set; }
        public string ALTNAME { get; set; }
        public string IR_REPORT { get; set; }
        public string IR_SCHEDULE_CALENDAR { get; set; }
        public byte[] FILTER { get; set; }
        public Nullable<short> STATUS { get; set; }
        public Nullable<short> EXPORT_TYPE { get; set; }
        public Nullable<short> UCSPRESET { get; set; }
        public Nullable<System.Guid> TRANSACT_GUID { get; set; }
        public string PASSDATA { get; set; }
        public string IR_EDITRIGHT { get; set; }
        public Nullable<int> DBLANG { get; set; }
        public Nullable<int> ARCHIVE { get; set; }
        public Nullable<int> EXPDATA { get; set; }
    }
}
