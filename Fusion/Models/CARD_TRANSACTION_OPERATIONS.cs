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
    
    public partial class CARD_TRANSACTION_OPERATIONS
    {
        public long TRANSACTION_ID { get; set; }
        public Nullable<int> OPERATION_TYPE { get; set; }
        public int OPERATION_PARAM_ID { get; set; }
        public Nullable<long> TRANSACTION_LINK { get; set; }
        public string DOP_INFO { get; set; }
        public System.Guid GUID { get; set; }
        public System.Guid TRANSACT_GUID { get; set; }
    }
}
