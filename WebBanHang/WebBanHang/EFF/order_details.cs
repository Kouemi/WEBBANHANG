//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanHang.EFF
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_details
    {
        public int order_id { get; set; }
        public int product_id { get; set; }
        public decimal quantity { get; set; }
        public Nullable<decimal> unit_price { get; set; }
        public decimal discount { get; set; }
        public string order_detail_status { get; set; }
        public Nullable<System.DateTime> date_allocated { get; set; }
    
        public virtual orders orders { get; set; }
        public virtual products products { get; set; }
    }
}
