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
    
    public partial class CARD_OPERATION_PARAMS
    {
        public int OPERATION_PARAM_ID { get; set; }
        public Nullable<short> DELETED { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string NAME { get; set; }
        public Nullable<int> SCHEDULE_ID { get; set; }
        public Nullable<short> OPERATION_MODE { get; set; }
        public string PASCAL_SCRIPT { get; set; }
        public string FILE_NAME { get; set; }
        public Nullable<System.DateTime> NEXT_TIME { get; set; }
        public Nullable<System.DateTime> LAST_TIME { get; set; }
        public Nullable<short> CPU_PRIORITY { get; set; }
        public Nullable<int> CLIENT_ID { get; set; }
        public string CODE_NAME { get; set; }
        public System.Guid GUID { get; set; }
        public System.Guid TRANSACT_GUID { get; set; }
        public string NOTES_SHORT { get; set; }
        public string NOTES_LONG { get; set; }
        public Nullable<System.DateTime> FROM_TIME { get; set; }
        public Nullable<System.DateTime> TO_TIME { get; set; }
        public Nullable<int> EXTERNAL_CODE { get; set; }
    }
}
