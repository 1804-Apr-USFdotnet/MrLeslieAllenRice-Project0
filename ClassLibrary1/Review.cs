//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int rvId { get; set; }
        public string rName { get; set; }
        public string rAddress { get; set; }
        public Nullable<decimal> rRating { get; set; }
        public string rSummary { get; set; }
        public int fk_rId { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
    }
}