//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_DemoExam_11_5_2022
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductOfOrder
    {
        public int OrderId { get; set; }
        public string ProductArticle { get; set; }
        public int Count { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}