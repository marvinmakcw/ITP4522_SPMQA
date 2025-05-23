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
    
    public partial class LstStaff
    {
        public LstStaff()
        {
            this.LstStores = new HashSet<LstStore>();
            this.RcdSales = new HashSet<RcdSale>();
        }
    
        public string StaffID { get; set; }
        public string StaffFName { get; set; }
        public string StaffLName { get; set; }
        public string StaffGndr { get; set; }
        public int Tel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string DeptID { get; set; }
        public string RoleID { get; set; }
    
        public virtual LstDept LstDept { get; set; }
        public virtual LstRole LstRole { get; set; }
        public virtual ICollection<LstStore> LstStores { get; set; }
        public virtual ICollection<RcdSale> RcdSales { get; set; }
    }
}
