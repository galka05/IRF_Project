//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_ar0ez3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int SalesID { get; set; }
        public int ProductFK { get; set; }
        public string Sales_2014 { get; set; }
        public string Sales_2015 { get; set; }
        public string Sales_2016 { get; set; }
        public string Sales_2017 { get; set; }
        public string Sales_2018 { get; set; }
        public string Sales_2019 { get; set; }
    
        public virtual Product Product { get; set; }
    }
}