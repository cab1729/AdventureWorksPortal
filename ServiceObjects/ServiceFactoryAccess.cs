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
    /// This class encapsulates the details of creating service specific 
    /// objects. It returns the appropriate service objects 
    /// 
    /// GoF Design Patterns: Factory, Singleton, Proxy. 
    /// </summary>
    /// <remarks>
    /// This class makes extensive use of the Factory pattern in determining which 
    /// service specific objects to return.
    /// 
    /// This class is similar to a Singleton -- it is a static class, only one 'instance' ever will exist.
    /// 
    /// This class is a Proxy in that it 'stands in' for the actual service Object Factory.
    /// </remarks>
    public static class ServiceFactoryAccess
    {
        // The static field initializers below are thread safe.
        // Furthermore, they are executed in the order in which they appear
        // in the class declaration. Note: if a static constructor
        // is present you want to initialize these in that constructor.
        private static readonly ServiceFactory _sf = new SOFactory();

        public static IProductSO ProductSO { get { return _sf.ProductSO; } }
        public static IPurchaseOrderSO PurchaseOrderSO { get { return _sf.PurchaseOrderSO; } }
        public static IVendorSO VendorSO { get { return _sf.VendorSO; } }
        public static IOrdersSO OrdersSO { get { return _sf.OrdersSO; } }
    }
}
