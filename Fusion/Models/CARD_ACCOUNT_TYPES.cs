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
    
    public partial class CARD_ACCOUNT_TYPES
    {
        public int ACCOUNT_TYPE_ID { get; set; }
        public Nullable<int> PARENT_ID { get; set; }
        public string NAME { get; set; }
        public Nullable<short> DELETED { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<short> ACCOUNT_CLASS { get; set; }
        public Nullable<short> LEVEL_CHANGE_CONDITION { get; set; }
        public Nullable<int> TRANSACTION_DEBIT_ID { get; set; }
        public Nullable<int> TRANSACTION_CREDIT_ID { get; set; }
        public Nullable<short> IS_ACTIVE { get; set; }
        public Nullable<System.DateTime> SUBSCRIBE_DATE_FROM { get; set; }
        public Nullable<System.DateTime> SUBSCRIBE_DATE_TO { get; set; }
        public string SCRIPT_FILENAME { get; set; }
        public Nullable<int> FLAGS { get; set; }
        public System.Guid GUID { get; set; }
        public System.Guid TRANSACT_GUID { get; set; }
        public Nullable<int> TIME_LIFE { get; set; }
        public Nullable<int> TIME_DELAY { get; set; }
    }
}