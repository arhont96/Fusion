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
    
    public partial class data_shcr_expdoc
    {
        public System.Guid GUID { get; set; }
        public Nullable<System.Guid> server_guid { get; set; }
        public Nullable<System.DateTime> dateinsert { get; set; }
        public Nullable<int> doc_rid { get; set; }
        public string code_text { get; set; }
        public Nullable<int> code_num { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> options { get; set; }
        public Nullable<int> saler_rid { get; set; }
        public Nullable<int> exp_rid { get; set; }
        public string saler_name { get; set; }
        public string exp_name { get; set; }
        public string note { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<int> create_time { get; set; }
        public Nullable<System.DateTime> edit_date { get; set; }
        public Nullable<int> edit_time { get; set; }
        public string create_user { get; set; }
        public string edit_user { get; set; }
    }
}
