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
    
    public partial class CASHMANDOCS
    {
        public System.Guid GUID { get; set; }
        public Nullable<System.Guid> SAFEGUID { get; set; }
        public Nullable<int> DOCTYPE { get; set; }
        public string PRINTNUMBER { get; set; }
        public string BAGNUM { get; set; }
        public string SEALNUM { get; set; }
        public Nullable<System.Guid> CORRGROUPGUID { get; set; }
        public Nullable<System.Guid> CORRGUID { get; set; }
        public Nullable<System.Guid> CORRGUID2 { get; set; }
        public string CORRNAME { get; set; }
        public Nullable<int> CURRID { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<decimal> AMOUNTLINK { get; set; }
        public Nullable<System.Guid> CASHMANGUID { get; set; }
        public Nullable<System.DateTime> POSTDATE { get; set; }
        public Nullable<System.DateTime> REPORTDATE { get; set; }
        public Nullable<int> OPERID { get; set; }
        public Nullable<int> REASONID { get; set; }
        public Nullable<int> MIDSERVER { get; set; }
        public Nullable<int> REGID { get; set; }
        public Nullable<int> CASHINOUTID { get; set; }
        public string COMMENT { get; set; }
        public Nullable<short> COMMITED { get; set; }
        public Nullable<System.Guid> TRANSACT_GUID { get; set; }
    }
}
