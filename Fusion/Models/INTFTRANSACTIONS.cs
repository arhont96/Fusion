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
    
    public partial class INTFTRANSACTIONS
    {
        public int VISIT { get; set; }
        public int MIDSERVER { get; set; }
        public int CHECKUNI { get; set; }
        public int MINTERFACE { get; set; }
        public int SEQNUM { get; set; }
        public string CARDCODE { get; set; }
        public string KIND { get; set; }
        public string EXTSUBACCOUNT { get; set; }
        public Nullable<int> ORDER { get; set; }
        public string LINEGUID { get; set; }
        public Nullable<int> LINEUNI { get; set; }
        public string LINETAG { get; set; }
        public string EXTPLACEID { get; set; }
        public string EXTTRANSACTIONID { get; set; }
        public string EXTINFO { get; set; }
        public Nullable<decimal> VALUE { get; set; }
        public Nullable<System.DateTime> EXTDATETIME { get; set; }
        public Nullable<int> ISTATION { get; set; }
        public string TRANSACT_GUID { get; set; }
    }
}
