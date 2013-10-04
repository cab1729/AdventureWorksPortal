using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.ModelObjects.Entities
{
    /// <summary>
    /// Define "buddy classes" for adding annotations to entity classes generated
    /// from .edmx model
    /// </summary>
    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
    }

    public class ProductMetadata 
    {
        [Display(Name = "Product Number")]
        public string ProductNumber { get; set; }
        [Display(Name = "Make Flag")]
        public bool MakeFlag { get; set; }
        [Display(Name = "Finished Goods Flag")]
        public bool FinishedGoodsFlag { get; set; }
        [Display(Name = "Safety Stock Level")]
        public short SafetyStockLevel { get; set; }
        [Display(Name = "Reorder Point")]
        public short ReorderPoint { get; set; }
        [Display(Name = "Standard Cost")]
        public decimal StandardCost { get; set; }
        [Display(Name = "List Price")]
        public decimal ListPrice { get; set; }
        [Display(Name = "Size Unit")]
        public string SizeUnitMeasureCode { get; set; }
        [Display(Name = "Weight Unit")]
        public string WeightUnitMeasureCode { get; set; }
        [Display(Name = "Days to Manufacture")]
        public int DaysToManufacture { get; set; }
        [Display(Name = "Product Line")]
        public string ProductLine { get; set; }
        public string Style { get; set; }
        [Display(Name = "Product Subcategory ID")]
        public Nullable<int> ProductSubcategoryID { get; set; }
        [Display(Name = "Model ID")]
        public Nullable<int> ProductModelID { get; set; }
        [Display(Name = "Sell Start Date")]
        public System.DateTime SellStartDate { get; set; }
        [Display(Name = "Sell End Date")]
        public Nullable<System.DateTime> SellEndDate { get; set; }
        [Display(Name = "Discontinued Date")]
        public Nullable<System.DateTime> DiscontinuedDate { get; set; }
    }

    [MetadataType(typeof(ProductModelMetadata))]
    public partial class ProductModel
    {   
    }

    public class ProductModelMetadata
    {
        [Display(Name = "Product Model")]
        public string Name { get; set; }
    }

    [MetadataType(typeof(ProductSubcategoryMetadata))]
    public partial class ProductSubcategory
    {
    }

    public class ProductSubcategoryMetadata
    {
        [Display(Name = "Product Subcategory")]
        public string Name { get; set; }
    }

    [MetadataType(typeof(ProductInventoryMetadata))]
    public partial class ProductInventory
    {
    }

    public class ProductInventoryMetadata
    {
        [Display(Name = "Product Id")]
        public int ProductID { get; set; }
        [Display(Name = "Location Id")]
        public short LocationID { get; set; }
        [Display(Name = "Shelf")]
        public string Shelf { get; set; }
        [Display(Name = "Bin")]
        public byte Bin { get; set; }
        [Display(Name = "Quantity")]
        public short Quantity { get; set; }
    }

    [MetadataType(typeof(ProductCostHistoryMetadata))]
    public partial class ProductCostHistory
    {
    }

    public class ProductCostHistoryMetadata
    {
        [Display(Name = "Start Date")]
        public System.DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public Nullable<System.DateTime> EndDate { get; set; }
        [Display(Name = "Standard Cost")]
        public decimal StandardCost { get; set; }
    }

    [MetadataType(typeof(ProductVendorMetadata))]
    public partial class ProductVendor
    {
    }

    public class ProductVendorMetadata
    {
        [Display(Name = "Avg Lead Time")]
        public int AverageLeadTime { get; set; }
        [Display(Name = "Standard Price")]
        public decimal StandardPrice { get; set; }
        [Display(Name = "Last Receipt Cost")]
        public Nullable<decimal> LastReceiptCost { get; set; }
        [Display(Name = "Last Receipt Date")]
        public Nullable<System.DateTime> LastReceiptDate { get; set; }
        [Display(Name = "Min Order Qty")]
        public int MinOrderQty { get; set; }
        [Display(Name = "Max Order Qty")]
        public int MaxOrderQty { get; set; }
        [Display(Name = "On Order Qty")]
        public Nullable<int> OnOrderQty { get; set; }
        [Display(Name = "Unit Measure Code")]
        public string UnitMeasureCode { get; set; }
    }

    [MetadataType(typeof(BIllOfMaterialMetadata))]
    public partial class BillOfMaterial
    {
    }

    public class BIllOfMaterialMetadata
    {
        [Display(Name = "Start Date")]
        public System.DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public Nullable<System.DateTime> EndDate { get; set; }
        [Display(Name = "Unit of Measure")]
        public string UnitMeasureCode { get; set; }
        [Display(Name = "BOM Level")]
        public short BOMLevel { get; set; }
        [Display(Name = "Per Assembly Qty")]
        public decimal PerAssemblyQty { get; set; }
    }

    [MetadataType(typeof(LocationMetadata))]
    public partial class Location
    {
    }

    public class LocationMetadata
    {
        [Display(Name = "Location Id")]
        public short LocationID { get; set; }
        [Display(Name = "Location Name")]
        public string Name { get; set; }
        [Display(Name = "Cost Rate")]
        public decimal CostRate { get; set; }
        [Display(Name = "Availability")]
        public decimal Availability { get; set; }
    }

    [MetadataType(typeof(UnitMeasureMetadata))]
    public partial class UnitMeasure
    {
    }

    public class UnitMeasureMetadata
    {
        [Display(Name = "Unit")]
        public string Name { get; set; }
    }

    [MetadataType(typeof(PurchaseOrderHeaderMetadata))]
    public partial class PurchaseOrderHeader
    {
    }

    public class PurchaseOrderHeaderMetadata
    {
        [Display(Name = "Purchase Order Id")]
        public int PurchaseOrderID { get; set; }
        [Display(Name = "Revision Number")]
        public byte RevisionNumber { get; set; }
        [Display(Name = "Order Date")]
        public System.DateTime OrderDate { get; set; }
        [Display(Name = "Ship Date")]
        public Nullable<System.DateTime> ShipDate { get; set; }
        [Display(Name = "Sub Total")]
        public decimal SubTotal { get; set; }
        [Display(Name = "Tax Amount")]
        public decimal TaxAmt { get; set; }
        [Display(Name = "Freight")]
        public decimal Freight { get; set; }
        [Display(Name = "Total Due")]
        public decimal TotalDue { get; set; }
    }

    [MetadataType(typeof(PurchaseOrderDetailMetadata))]
    public partial class PurchaseOrderDetail
    {
    }

    public class PurchaseOrderDetailMetadata
    {
        [Display(Name = "Due Date")]
        public System.DateTime DueDate { get; set; }
        [Display(Name = "Order Qty")]
        public short OrderQty { get; set; }
        public int ProductID { get; set; }
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Line Total")]
        public decimal LineTotal { get; set; }
        [Display(Name = "Received Qty")]
        public decimal ReceivedQty { get; set; }
        [Display(Name = "Rejected Qty")]
        public decimal RejectedQty { get; set; }
        [Display(Name = "Stocked Qty")]
        public decimal StockedQty { get; set; }
    }

    [MetadataType(typeof(SalesOrderHeaderMetadata))]
    public partial class SalesOrderHeader
    {
    }

    public class SalesOrderHeaderMetadata
    {
        [Display(Name = "Revision Number")]
        public byte RevisionNumber { get; set; }
        [Display(Name = "Order Date")]
        public System.DateTime OrderDate { get; set; }
        [Display(Name = "Due Date")]
        public System.DateTime DueDate { get; set; }
        [Display(Name = "Ship Date")]
        public Nullable<System.DateTime> ShipDate { get; set; }
        [Display(Name = "Online Order Flag")]
        public bool OnlineOrderFlag { get; set; }
        [Display(Name = "Sales Order Number")]
        public string SalesOrderNumber { get; set; }
        [Display(Name = "PO Number")]
        public string PurchaseOrderNumber { get; set; }
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }
        [Display(Name = "CC Approval Code")]
        public string CreditCardApprovalCode { get; set; }
        [Display(Name = "Subtotal")]
        public decimal SubTotal { get; set; }
        [Display(Name = "Tax Amount")]
        public decimal TaxAmt { get; set; }
        [Display(Name = "Freight")]
        public decimal Freight { get; set; }
        [Display(Name = "Total Due")]
        public decimal TotalDue { get; set; }
    }

    [MetadataType(typeof(SalesOrderDetailMetadata))]
    public partial class SalesOrderDetai
    {
    }

    public class SalesOrderDetailMetadata
    {
        [Display(Name = "Carrier Tracking Number")]
        public string CarrierTrackingNumber { get; set; }
        [Display(Name = "Order Qty")]
        public short OrderQty { get; set; }
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Unit Price Discount")]
        public decimal UnitPriceDiscount { get; set; }
        [Display(Name = "Line Total")]
        public decimal LineTotal { get; set; }
    }

    [MetadataType(typeof(SalesPersonMetadata))]
    public partial class SalesPerson
    {
    }

    public class SalesPersonMetadata
    {
        [Display(Name = "Sales Quota")]
        public Nullable<decimal> SalesQuota { get; set; }
        [Display(Name = "Bonus")]
        public decimal Bonus { get; set; }
        [Display(Name = "Commision Pct")]
        public decimal CommissionPct { get; set; }
        [Display(Name = "Sales YTD")]
        public decimal SalesYTD { get; set; }
        [Display(Name = "Sales Last Year")]
        public decimal SalesLastYear { get; set; }
    }

    [MetadataType(typeof(VendorMetadata))]
    public partial class Vendor
    {
    }

    public class VendorMetadata
    {
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }
        [Display(Name = "Credit Rating")]
        public byte CreditRating { get; set; }
        [Display(Name = "Preferred Vendor Status")]
        public bool PreferredVendorStatus { get; set; }
        [Display(Name = "Active Flag")]
        public bool ActiveFlag { get; set; }
        [Display(Name = "Purchasing Web Service URL")]
        public string PurchasingWebServiceURL { get; set; }
        [Display(Name = "Modified Date")]
        public System.DateTime ModifiedDate { get; set; }
    }

    [MetadataType(typeof(PersonMetadata))]
    public partial class Person
    {
    }

    public class PersonMetadata
    {
        [Display(Name = "Person Type")]
        public string PersonType { get; set; }
        [Display(Name = "Name Style")]
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle")]
        public string MiddleName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Suffix")]
        public string Suffix { get; set; }
        [Display(Name = "Email Promotion")]
        public int EmailPromotion { get; set; }
        [Display(Name = "Addt'l Contact Info")]
        public string AdditionalContactInfo { get; set; }
        [Display(Name = "Demographics")]
        public string Demographics { get; set; }
    }

    [MetadataType(typeof(AddressMetadata))]
    public partial class Address
    {
    }

    public class AddressMetadata
    {
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
    }

    [MetadataType(typeof(StateProvinceMetadata))]
    public partial class StateProvince
    {
    }

    public class StateProvinceMetadata
    {
        [Display(Name = "State/Province Name")]
        public string Name { get; set; }
    }

    [MetadataType(typeof(CountryRegionMetadata))]
    public partial class CountryRegion
    {
    }

    public class CountryRegionMetadata
    {
        [Display(Name = "Country/Region Name")]
        public string Name { get; set; }
    }

    [MetadataType(typeof(vVendorWithAddressMetadata))]
    public partial class vVendorWithAddress
    {
    }

    public class vVendorWithAddressMetadata
    {
        [Display(Name = "Business Entity Id")]
        public int BusinessEntityID { get; set; }
        [Display(Name = "Vendor Name")]
        public string Name { get; set; }
        [Display(Name = "Address Type")]
        public string AddressType { get; set; }
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State/Province")]
        public string StateProvinceName { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Display(Name = "Country/Region")]
        public string CountryRegionName { get; set; }
    }

    [MetadataType(typeof(vVendorWithContactMetadata))]
    public partial class vVendorWithContact
    {
    }

    public class vVendorWithContactMetadata
    {
        [Display(Name = "Business Entity Id")]
        public int BusinessEntityID { get; set; }
        [Display(Name = "Vendor Name")]
        public string Name { get; set; }
        [Display(Name = "Contact Type")]
        public string ContactType { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Suffix")]
        public string Suffix { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Phone Number Type")]
        public string PhoneNumberType { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Email Promotion")]
        public int EmailPromotion { get; set; }
    }
}