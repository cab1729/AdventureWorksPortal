using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorksPortal.Areas.Purchasing.Models
{
    using AdventureWorks.Domain.ModelObjects.Entities;

    /// <summary>
    /// ViewModel object for Vendor details
    /// 
    /// imlements Transfer Object pattern 
    /// </summary>
    public class VendorAddressContactModel
    {
        public Vendor Vendor { get; set; }
        public vVendorWithAddress VendorAddress { get; set; }
        public vVendorWithContact VendorContact { get; set; }
    }
}