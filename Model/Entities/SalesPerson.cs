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
    using System.Runtime.Serialization;
    using System.ComponentModel.DataAnnotations;
    
    public partial class SalesPerson
    {
        public SalesPerson()
        {
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            this.SalesPersonQuotaHistories = new HashSet<SalesPersonQuotaHistory>();
            this.SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
            this.Stores = new HashSet<Store>();
        }
    
        public int BusinessEntityID { get; set; }
        public Nullable<int> TerritoryID { get; set; }
        [Display (Name = "Sales Quota")]
        public Nullable<decimal> SalesQuota { get; set; }
        [Display(Name = "Bonus")]
        public decimal Bonus { get; set; }
        [Display(Name = "Commission Pct")]
        public decimal CommissionPct { get; set; }
        [Display(Name = "Sales YTD")]
        public decimal SalesYTD { get; set; }
        [Display(Name = "Sales Last Year")]
        public decimal SalesLastYear { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
