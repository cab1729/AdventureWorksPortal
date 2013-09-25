using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Domain.ServiceObjects.Sales
{
    using AdventureWorks.Domain.DataAccessObjects;
    using AdventureWorks.Domain.DataAccessObjects.Sales;
    using AdventureWorks.Domain.ModelObjects.Entities;

    public interface IOrdersSO
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

    public class OrdersSO : IOrdersSO
    {
        private IOrdersDAO _OrdersDAO = DAOFactory.Instance.OrdersDAO;

        public IEnumerable<SalesOrderHeader> getOrders()
        {
            return _OrdersDAO.getOrders();
        }

        public SalesOrderHeader getOrderHeaderDetails(int id)
        {
            return _OrdersDAO.getOrderHeaderDetails(id);
        }

        public void addOrder(SalesOrderHeader salesorder)
        {
            _OrdersDAO.addOrder(salesorder);
        }

        public void editOrder(SalesOrderHeader salesorder)
        {
            _OrdersDAO.editOrder(salesorder);
        }

        public void deleteOrder(int id)
        {
            _OrdersDAO.deleteOrder(id);
        }

        public IEnumerable<Address> getAddresses()
        {
            return _OrdersDAO.getAddresses();
        }

        public IEnumerable<ShipMethod> getShipMethods()
        {
            return _OrdersDAO.getShipMethods();
        }

        public IEnumerable<CreditCard> getCreditCards()
        {
            return _OrdersDAO.getCreditCards();
        }

        public IEnumerable<CurrencyRate> getCurrencyRates()
        {
            return _OrdersDAO.getCurrencyRates();
        }

        public IEnumerable<Customer> getCustomers()
        {
            return _OrdersDAO.getCustomers();
        }

        public IEnumerable<SalesPerson> getSalesPersons()
        {
            return _OrdersDAO.getSalesPersons();
        }

        public IEnumerable<SalesTerritory> getSalesTerritories()
        {
            return _OrdersDAO.getSalesTerritories();
        }
    }
}
