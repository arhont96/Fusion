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
    
    public partial class RPT_REPORTS
    {
        public int Report_ID { get; set; }
        public string Name { get; set; }
        public Nullable<short> Is_Group { get; set; }
        public Nullable<int> Parent_ID { get; set; }
        public Nullable<short> Deleted { get; set; }
        public Nullable<int> Filter_ID { get; set; }
        public string Filter_Params { get; set; }
        public string Filter_Last_Values { get; set; }
        public Nullable<int> Database_ID { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public Nullable<short> Report_Type { get; set; }
        public string Security_ID { get; set; }
        public string Report_Description { get; set; }
        public Nullable<short> Report_Generator { get; set; }
        public string Params { get; set; }
        public Nullable<int> Direct_Database_ID { get; set; }
    }
}
