//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSDProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int CartId { get; set; }
        public Nullable<int> RamenId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Raman Raman { get; set; }
        public virtual User User { get; set; }
    }
}