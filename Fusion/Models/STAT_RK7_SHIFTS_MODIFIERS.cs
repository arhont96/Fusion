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
    
    public partial class STAT_RK7_SHIFTS_MODIFIERS
    {
        public System.Guid GLOBALSHIFTGUID { get; set; }
        public Nullable<System.Guid> WAITERGUID { get; set; }
        public Nullable<System.Guid> CASHIERGUID { get; set; }
        public Nullable<System.Guid> RESTAURANTGUID { get; set; }
        public Nullable<System.Guid> MIDSERVERGUID { get; set; }
        public Nullable<System.Guid> STATIONGUID { get; set; }
        public Nullable<System.Guid> CURRENCYGUID { get; set; }
        public Nullable<System.Guid> DISHGUID { get; set; }
        public Nullable<System.Guid> MODIFIERGUID { get; set; }
        public Nullable<System.Guid> MODIGROUPGUID { get; set; }
        public Nullable<System.Guid> PRINTCHECKGUID { get; set; }
        public Nullable<System.DateTime> SHIFTDATE { get; set; }
        public string WAITER { get; set; }
        public string CASHIER { get; set; }
        public string RESTAURANT { get; set; }
        public string MIDSERVER { get; set; }
        public string STATION { get; set; }
        public string CURRENCY { get; set; }
        public string ORDERNAME { get; set; }
        public string DISH { get; set; }
        public string MODIFIER { get; set; }
        public string MODIGROUP { get; set; }
        public Nullable<decimal> PRICE { get; set; }
        public Nullable<float> QUANTITY { get; set; }
        public Nullable<decimal> PRLISTSUM { get; set; }
        public Nullable<int> CHECKCOUNT { get; set; }
        public Nullable<int> ORDERCOUNT { get; set; }
    }
}
