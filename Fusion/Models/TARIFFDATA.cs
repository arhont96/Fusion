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
    
    public partial class TARIFFDATA
    {
        public int VISIT { get; set; }
        public int MIDSERVER { get; set; }
        public Nullable<int> ORDERIDENT { get; set; }
        public int TARIFFSIFR { get; set; }
        public Nullable<int> DEVICEID { get; set; }
        public Nullable<int> TARIFDETAILID { get; set; }
        public Nullable<int> CLOSEMANAGERID { get; set; }
        public Nullable<System.DateTime> STARTTIME { get; set; }
        public Nullable<System.DateTime> ENDTIME { get; set; }
        public Nullable<double> DURATION { get; set; }
        public Nullable<System.DateTime> TARIFFSTARTTIME { get; set; }
        public Nullable<System.DateTime> TARIFFENDTIME { get; set; }
        public Nullable<System.DateTime> TIMELIMIT { get; set; }
        public Nullable<decimal> MONEYLIMIT { get; set; }
        public Nullable<int> DEFAULTER { get; set; }
        public Nullable<int> TARIFFTYPEID { get; set; }
        public Nullable<short> REBOOTING { get; set; }
        public string EXTNUMBER { get; set; }
        public string TRANSACT_GUID { get; set; }
    }
}
