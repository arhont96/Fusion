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
    
    public partial class PLG_IR_DATASETPARAMETERS
    {
        public string GUIDSTRING { get; set; }
        public string PARAMETERNAME { get; set; }
        public string NAME { get; set; }
        public string ALTNAME { get; set; }
        public Nullable<int> DATATYPE { get; set; }
        public Nullable<short> ISNECESSAR { get; set; }
        public Nullable<short> ISFIXED { get; set; }
        public string FIXEDSTRINGVALUE { get; set; }
        public Nullable<int> FIXEDINTEGERVALUE { get; set; }
        public string DIMDICTIONARY { get; set; }
        public string DIMDICTFIELD { get; set; }
        public byte[] SQLQUERY { get; set; }
        public Nullable<short> MAX_COUNT { get; set; }
        public Nullable<short> TYPELISTFROMSQL { get; set; }
        public Nullable<short> UCSPRESET { get; set; }
        public Nullable<short> STATUS { get; set; }
        public Nullable<System.Guid> TRANSACT_GUID { get; set; }
        public Nullable<short> SORTORDERIR { get; set; }
        public Nullable<short> NOT_VISIBLE_FILTER { get; set; }
        public string DESCR { get; set; }
    }
}
