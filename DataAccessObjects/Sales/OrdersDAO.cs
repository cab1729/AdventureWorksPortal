using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects;
using System.Data.Entity;

namespace AdventureWorks.Domain.DataAccessObjects.Sales
{
    using AdventureWorks.Domain.DataAccessObjects;
    using AdventureWorks.Domain.ModelObjects.Entities;

    public interface IOrdersDAO
    {
        IEnumerable<SalesOrderHeader> getOrders();
        SalesOrderHeader getOrderHeaderDetails(int id);
        void addOrder(SalesOrderHeader salesorder);
        void editOrder(SalesOrderHeader salesorder);
        void deleteOrder(int id);

        IEnumerable<Address> getAddresses();
        IEnumerable<ShipMethod> getShipMethods();
        IEnumerable<CreditCard> getCreditCards();
        IEnumerable<CurrencyRate> getCurrencyRates();
        IEnumerable<Customer> getCustomers();
        IEnumerable<SalesPerson> getSalesPersons();
        IEnumerable<SalesTerritory> getSalesTerritories();
    }
    
    public class OrdersDAO : IOrdersDAO
    {
        private AdventureWorksModelContainer _db = new AdventureWorksModelContainer();
        
        public IEnumerable<SalesOrderHeader> getOrders()
        {
            // note: limit record count returned to 400 most recent (db table has >31K)
            var salesorderheaders =
                _db.SalesOrderHeaders
                    .OrderByDescending(s => s.ModifiedDate).Take(400)
                    .Include("Address")
                    .Include("Address1")
                    .Include("ShipMethod")
                    .Include("CreditCard")
                    .Include("CurrencyRate")
                    .Include("Customer")
                    .Include("SalesPerson")
                    .Include("SalesTerritory");
            return salesorderheaders.AsEnumerable<SalesOrderHeader>();
        }

        public SalesOrderHeader getOrderHeaderDetails(int id)
        {
            SalesOrderHeader salesorderheader = 
                _db.SalesOrderHeaders
                    .Include("Address")
                    .Include("Address1")
                    .Include("ShipMethod")
                    .Include("CreditCard")
                    .Include("CurrencyRate")
                    .Include("Customer")
                    .Include("SalesPerson")
                    .Include("SalesTerritory")
                    .Include(s => s.SalesOrderDetails)
                    .Single(s => s.SalesOrderID == id);
            return salesorderheader;
            
        }

        public void addOrder(SalesOrderHeader salesorder)
        {
            _db.SalesOrderHeaders.Add(salesorder).ModifiedDate = System.DateTime.Now;
            _db.SaveChanges();
        }

        public void editOrder(SalesOrderHeader salesorder)
        {
            _db.SalesOrderHeaders.Attach(salesorder).ModifiedDate = System.DateTime.Now;
            _db.Entry(salesorder).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void deleteOrder(int id)
        {
            SalesOrderHeader salesorderheader =
                _db.SalesOrderHeaders.Single(s => s.SalesOrderID == id);
            _db.Entry(salesorderheader).State = EntityState.Deleted;
            _db.SalesOrderHeaders.Remove(salesorderheader);
            _db.SaveChanges();
 
        }

        public IEnumerable<Address> getAddresses()
        {
            return _db.Addresses.AsEnumerable<Address>();
        }

        public IEnumerable<ShipMethod> getShipMethods()
        {
            return _db.ShipMethods.AsEnumerable<ShipMethod>();
        }

        public IEnumerable<CreditCard> getCreditCards()
        {
            return _db.CreditCards.AsEnumerable<CreditCard>();
        }

        public IEnumerable<CurrencyRate> getCurrencyRates()
        {
            return _db.CurrencyRates.AsEnumerable<CurrencyRate>();
        }

        public IEnumerable<Customer> getCustomers()
        {
            return _db.Customers.AsEnumerable<Customer>();
        }

        public IEnumerable<SalesPerson> getSalesPersons()
        {
            return _db.SalesPersons.AsEnumerable<SalesPerson>();
        }

        public IEnumerable<SalesTerritory> getSalesTerritories()
        {
            return _db.SalesTerritories.AsEnumerable<SalesTerritory>();
        }
    }
}
