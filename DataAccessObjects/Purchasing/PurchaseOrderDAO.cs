using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects;
using System.Data.Entity;

namespace AdventureWorks.Domain.DataAccessObjects.Purchasing
{
    using AdventureWorks.Domain.DataAccessObjects;
    using AdventureWorks.Domain.ModelObjects.Entities;

    public interface IPurchaseOrderDAO
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

    public class PurchaseOrderDAO : IPurchaseOrderDAO
    {
        private AdventureWorksModelContainer _db = new AdventureWorksModelContainer();
        
        public IEnumerable<PurchaseOrderHeader> getPurchaseOrderHeaders()
        {
            var purchaseorderheaders =
                _db.PurchaseOrderHeaders.OrderByDescending(p => p.ModifiedDate).Take(400)
                    .Include("Employee")
                    .Include("ShipMethod")
                    .Include("Vendor");
            return purchaseorderheaders.ToList();        
        }

        public PurchaseOrderHeader getPurchaseOrderHeaderDetails(int id)
        {
            PurchaseOrderHeader purchaseorderheader =
                _db.PurchaseOrderHeaders
                    .Include("Employee")
                    .Include("ShipMethod")
                    .Include("Vendor")
                    .Include(p => p.PurchaseOrderDetails.Select(c => c.Product))
                    .Single(p => p.PurchaseOrderID == id);
            
            return purchaseorderheader;
        }

        public void addPurchaseOrder(PurchaseOrderHeader po)
        {
            _db.PurchaseOrderHeaders.Add(po).ModifiedDate = System.DateTime.Now;
            _db.SaveChanges();
        }

        public void editPurchaseOrder(PurchaseOrderHeader po)
        {
            _db.PurchaseOrderHeaders.Attach(po).ModifiedDate = System.DateTime.Now; 
            _db.Entry(po).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void deletePurchaseOrder(int id)
        {
            PurchaseOrderHeader po = _db.PurchaseOrderHeaders.Single(p => p.PurchaseOrderID == id);
            _db.Entry(po).State = EntityState.Deleted;
            _db.PurchaseOrderHeaders.Remove(po);
            _db.SaveChanges();
        }

        public IEnumerable<Employee> getEmployees()
        {
            return _db.Employees.AsEnumerable<Employee>();
        }
        public IEnumerable<ShipMethod> getShipMethods()
        {
            return _db.ShipMethods.AsEnumerable<ShipMethod>();
        }
        public IEnumerable<Vendor> getVendors()
        {
            return _db.Vendors.AsEnumerable<Vendor>();
        }
    }
}
