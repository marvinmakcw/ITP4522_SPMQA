//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class LstSupplier
    {
        public LstSupplier()
        {
            this.LstItems = new HashSet<LstItem>();
        }
    
        public string SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public int Tel { get; set; }
    
        public virtual ICollection<LstItem> LstItems { get; set; }
    }
}
