using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.ModelObjects.DataTransfer
{
    using AdventureWorks.Domain.ModelObjects.Entities;
    
    [DataContract(IsReference=true, Name="Product")]
    public class ProductDTO
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string ProductNumber { get; set; }
        [DataMember]
        public bool MakeFlag { get; set; }
        [DataMember]
        public bool FinishedGoodsFlag { get; set; }
        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public short SafetyStockLevel { get; set; }
        [DataMember]
        public short ReorderPoint { get; set; }
        [DataMember]
        public decimal StandardCost { get; set; }
        [DataMember]
        public decimal ListPrice { get; set; }
        [DataMember]
        public string Size { get; set; }
        [DataMember]
        public string SizeUnitMeasureCode { get; set; }
        [DataMember]
        public string WeightUnitMeasureCode { get; set; }
        [DataMember]
        public Nullable<decimal> Weight { get; set; }
        [DataMember]
        public int DaysToManufacture { get; set; }
        [DataMember]
        public string ProductLine { get; set; }
        [DataMember]
        public string Class { get; set; }
        [DataMember]
        public string Style { get; set; }
        [DataMember]
        public Nullable<int> ProductSubcategoryID { get; set; }
        [DataMember]
        public Nullable<int> ProductModelID { get; set; }
        [DataMember]
        public System.DateTime SellStartDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> SellEndDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DiscontinuedDate { get; set; }

        [DataMember]
        public virtual ICollection<ProductInventoryDTO> ProductInventories { get; set; }
    }
}
