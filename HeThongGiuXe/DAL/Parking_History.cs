//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HeThongGiuXe
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parking_History
    {
        public int ID_parking { get; set; }
        public string license_plate { get; set; }
        public System.DateTime check_in_at { get; set; }
        public Nullable<System.DateTime> check_out_at { get; set; }
        public bool is_payment { get; set; }
        public int price { get; set; }
        public Nullable<int> customer_ID { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}