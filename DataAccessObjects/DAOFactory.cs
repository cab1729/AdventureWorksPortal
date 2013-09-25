using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Domain.DataAccessObjects
{
    using AdventureWorks.Domain.DataAccessObjects.Products;
    using AdventureWorks.Domain.DataAccessObjects.Purchasing;
    using AdventureWorks.Domain.DataAccessObjects.Sales;

    public class DAOFactory
    {
        private static DAOFactory _daoFactory;

        /// <summary>
        /// Private constructor to avoid instantiation
        /// </summary>
        private DAOFactory() 
        {
        }

        public static DAOFactory Instance
        {
            get 
            {
                if (_daoFactory == null)
                {
                    _daoFactory = new DAOFactory();
                }
                return _daoFactory;
            }
        }

        public IProductDAO ProductDAO
        {
            get { return new ProductDAO(); }
        }

        public IPurchaseOrderDAO PurchaseOrderDAO
        {
            get { return new PurchaseOrderDAO(); }
        }

        public IVendorDAO VendorDAO
        {
            get { return new VendorDAO(); }
        }

        public IOrdersDAO OrdersDAO
        {
            get { return new OrdersDAO(); }
        }
    }
}
