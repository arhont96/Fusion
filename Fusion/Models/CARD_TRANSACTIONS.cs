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
    
    public partial class CARD_TRANSACTIONS
    {
        public CARD_TRANSACTIONS()
        {
            this.CARD_TRANSACTION_NOTES = new HashSet<CARD_TRANSACTION_NOTES>();
        }
    
        public long TRANSACTION_ID { get; set; }
        public Nullable<long> TRANSACTION_LINK { get; set; }
        public Nullable<System.DateTime> TRANSACTION_TIME { get; set; }
        public Nullable<int> TRANSACTION_TYPE { get; set; }
        public Nullable<short> OPERATION_TYPE { get; set; }
        public Nullable<long> ACCOUNT_ID { get; set; }
        public Nullable<decimal> SUMM { get; set; }
        public Nullable<long> CARD_CODE { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<int> CLIENT_ID { get; set; }
        public Nullable<int> UNIT_ID { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public Nullable<long> EXTERNAL_ID { get; set; }
        public Nullable<int> EXTERNAL_INDEX { get; set; }
        public System.Guid GUID { get; set; }
        public System.Guid TRANSACT_GUID { get; set; }
        public Nullable<System.DateTime> TRANSACTION_DELAY { get; set; }
        public Nullable<System.DateTime> TRANSACTION_TIME_ORIGINAL { get; set; }
    
        public virtual ICollection<CARD_TRANSACTION_NOTES> CARD_TRANSACTION_NOTES { get; set; }
    }
}
