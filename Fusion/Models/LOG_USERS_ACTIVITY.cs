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
    
    public partial class LOG_USERS_ACTIVITY
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> AT_TIME { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public string TABLE_NAME { get; set; }
        public string FIELDS { get; set; }
        public string TEXT { get; set; }
        public string ACTION { get; set; }
    }
}