//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorks.Domain.ModelObjects.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        public Location()
        {
            this.ProductInventories = new HashSet<ProductInventory>();
            this.WorkOrderRoutings = new HashSet<WorkOrderRouting>();
        }
    
        public short LocationID { get; set; }
        public string Name { get; set; }
        public decimal CostRate { get; set; }
        public decimal Availability { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}
