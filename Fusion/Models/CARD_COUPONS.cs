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
    
    public partial class CARD_COUPONS
    {
        public long COUPON_ID { get; set; }
        public string COUPON_CODE { get; set; }
        public Nullable<long> PEOPLE_ID { get; set; }
        public Nullable<int> RELEASE_ID { get; set; }
        public Nullable<int> COUPON_TYPE_ID { get; set; }
        public Nullable<System.DateTime> DATE_FROM { get; set; }
        public Nullable<System.DateTime> DATE_TO { get; set; }
        public string NOTES { get; set; }
        public Nullable<int> FLAGS { get; set; }
        public Nullable<short> DELETED { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public System.Guid GUID { get; set; }
        public System.Guid TRANSACT_GUID { get; set; }
    }
}