//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetUserDetails
    {
        public int IdDetail { get; set; }
        public string IdUser { get; set; }
        public string Detail { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
