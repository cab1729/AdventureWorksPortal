using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Domain.ServiceObjects
{
    using AdventureWorks.Domain.ServiceObjects.Products;
    using AdventureWorks.Domain.ServiceObjects.Purchasing;
    using AdventureWorks.Domain.ServiceObjects.Sales;

    /// <summary>
    /// Abstract factory class that creates service objects
    /// Gof design pattern: Factory
    /// </summary>
    public abstract class ServiceFactory
    {
        public abstract IProductSO ProductSO { get; }
        public abstract IPurchaseOrderSO PurchaseOrderSO { get; }
        public abstract IVendorSO VendorSO { get; }
        public abstract IOrdersSO OrdersSO { get; }
    }

    /// <summary>
    /// Create specific service objects from the concrete class
    /// GoF design pattern: Factory
    /// </summary>
    public class SOFactory : ServiceFactory
    {
        /// <summary>
        /// returns a specific service object
        /// </summary>
        public override IProductSO ProductSO
        { 
            get { return (ProductSO)Activator.CreateInstance(typeof(ProductSO), true); } 
        }

        public override IPurchaseOrderSO PurchaseOrderSO
        {
            get { return (PurchaseOrderSO)Activator.CreateInstance(typeof(PurchaseOrderSO), true); }
        }

        public override IVendorSO VendorSO
        {
            get { return (VendorSO)Activator.CreateInstance(typeof(VendorSO), true); }
        }

        public override IOrdersSO OrdersSO
        {
            get { return (OrdersSO)Activator.CreateInstance(typeof(OrdersSO), true); }
        }
    }
}
