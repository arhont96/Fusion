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
    
    public partial class data_shcr_PLDoc_details
    {
        public System.Guid GUID { get; set; }
        public Nullable<System.Guid> server_guid { get; set; }
        public Nullable<short> Deleted { get; set; }
        public Nullable<System.DateTime> dateinsert { get; set; }
        public Nullable<int> RID { get; set; }
        public Nullable<int> spec_rid { get; set; }
        public Nullable<int> good_rid { get; set; }
        public Nullable<int> measure_rid { get; set; }
        public Nullable<double> sum_no_tax { get; set; }
        public Nullable<double> nds { get; set; }
        public Nullable<double> nsp { get; set; }
        public string code_text { get; set; }
        public Nullable<int> code_num { get; set; }
        public string good_name { get; set; }
        public Nullable<int> good_type { get; set; }
        public string measure_name { get; set; }
    }
}
