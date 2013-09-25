using System;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorksPortal.Models.Entities
{
    /// <summary>
    /// Define "buddy classes" for adding annotations to entity classes generated
    /// from .edmx models
    /// </summary>
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
        public class ProductMetaData 
        {
            [Display(Name = "Product Number")]
            public global::System.String ProductNumber { get; set; }
            [Display(Name = "Make Flag")]
            public global::System.Boolean MakeFlag { get; set; }
            [Display(Name = "Finished Goods Flag")]
            public global::System.Boolean FinishedGoodsFlag { get; set; }
            [Display(Name = "Safety Stock Level")]
            public global::System.Int16 SafetyStockLevel { get; set; }
            [Display(Name = "Reorder Point")]
            public global::System.Int16 ReorderPoint { get; set; }
            [Display(Name = "Standard Cost")]
            public global::System.Decimal StandardCost { get; set; }
            [Display(Name = "List Price")]
            public global::System.Decimal ListPrice { get; set; }
            [Display(Name = "Size Unit")]
            public global::System.String SizeUnitMeasureCode { get; set; }
            [Display(Name = "Weight Unit")]
            public global::System.String WeightUnitMeasureCode { get; set; }
            [Display(Name = "Days to Manufacture")]
            public global::System.Int32 DaysToManufacture { get; set; }
            [Display(Name = "Product Line")]
            public global::System.String ProductLine { get; set; }
            [Display(Name = "Sell Start Date")]
            public global::System.DateTime SellStartDate { get; set; }
            [Display(Name = "Sell End Date")]
            public Nullable<global::System.DateTime> SellEndDate { get; set; }
            [Display(Name = "Discontinued Date")]
            public Nullable<global::System.DateTime> DiscontinuedDate { get; set; }
        }
    }

    [MetadataType(typeof(ProductModelMetaData))]
    public partial class ProductModel
    {
        public class ProductModelMetaData
        {
            [Display(Name = "Product Model")]
            public global::System.String Name { get; set; }
        }
    }

    [MetadataType(typeof(ProductSubcategoryMetaData))]
    public partial class ProductSubcategory
    {
        public class ProductSubcategoryMetaData
        {
            [Display(Name = "Product Subcategory")]
            public global::System.String Name { get; set; }
        }
    }

    [MetadataType(typeof(UnitMeasureMetaData))]
    public partial class UnitMeasure
    {
        public class UnitMeasureMetaData
        {
            [Display(Name = "Unit")]
            public global::System.String Name { get; set; }
        }
    }
}