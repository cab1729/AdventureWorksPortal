using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Domain.ServiceObjects.Purchasing
{
    using AdventureWorks.Domain.DataAccessObjects;
    using AdventureWorks.Domain.DataAccessObjects.Purchasing;
    using AdventureWorks.Domain.ModelObjects.Entities;

    public interface IPurchaseOrderSO
    {
        IEnumerable<PurchaseOrderHeader> getPurchaseOrderHeaders();
        PurchaseOrderHeader getPurchaseOrderHeaderDetails(int id);
        void addPurchaseOrder(PurchaseOrderHeader po);
        void editPurchaseOrder(PurchaseOrderHeader po);
        void deletePurchaseOrder(int id);

        IEnumerable<Employee> getEmployees();
        IEnumerable<ShipMethod> getShipMethods();
        IEnumerable<Vendor> getVendors();
    }
    
    public class PurchaseOrderSO : IPurchaseOrderSO
    {
        private IPurchaseOrderDAO _PurchaseOrderDAO = DAOFactory.Instance.PurchaseOrderDAO;

        public IEnumerable<PurchaseOrderHeader> getPurchaseOrderHeaders()
        {
            return _PurchaseOrderDAO.getPurchaseOrderHeaders();
        }
        
        public PurchaseOrderHeader getPurchaseOrderHeaderDetails(int id)
        {
            return _PurchaseOrderDAO.getPurchaseOrderHeaderDetails(id);
        }
        
        public void addPurchaseOrder(PurchaseOrderHeader po)
        {
            _PurchaseOrderDAO.addPurchaseOrder(po);
        }
        
        public void editPurchaseOrder(PurchaseOrderHeader po)
        {
            _PurchaseOrderDAO.editPurchaseOrder(po);
        }

        public void deletePurchaseOrder(int id)
        {
            _PurchaseOrderDAO.deletePurchaseOrder(id);
        }

        public IEnumerable<Employee> getEmployees()
        {
            return _PurchaseOrderDAO.getEmployees();
        }
        public IEnumerable<ShipMethod> getShipMethods()
        {
            return _PurchaseOrderDAO.getShipMethods();
        }
        public IEnumerable<Vendor> getVendors()
        {
            return _PurchaseOrderDAO.getVendors();
        }
    }
}
