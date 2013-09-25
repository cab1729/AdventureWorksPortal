using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdventureWorks.Domain.ModelObjects.Entities;
using AdventureWorks.Domain.ServiceObjects;

namespace AdventureWorksPortal.Areas.Sales.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        //
        // GET: /Sales/Orders/

        public ActionResult Index()
        {
            var salesorderheaders =
                ServiceFactoryAccess.OrdersSO.getOrders();
            return View(salesorderheaders.ToList());
        }

        //
        // GET: /Sales/Orders/Details/5

        public ActionResult Details(int id = 0)
        {
            SalesOrderHeader salesorderheader = 
                ServiceFactoryAccess.OrdersSO.getOrderHeaderDetails(id);
            if (salesorderheader == null)
            {
                return HttpNotFound();
            }
            return View(salesorderheader);
        }

        //
        // GET: /Sales/Orders/Create

        public ActionResult Create()
        {
            ViewBag.BillToAddressID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getAddresses(), 
                    "AddressID", "AddressLine1");
            ViewBag.ShipToAddressID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getAddresses(), 
                    "AddressID", "AddressLine1");
            ViewBag.ShipMethodID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getShipMethods(), 
                    "ShipMethodID", "Name");
            ViewBag.CreditCardID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getCreditCards(), 
                    "CreditCardID", "CardType");
            ViewBag.CurrencyRateID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getCurrencyRates(), 
                    "CurrencyRateID", "FromCurrencyCode");
            ViewBag.CustomerID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getCustomers(), 
                    "CustomerID", "AccountNumber");
            ViewBag.SalesPersonID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getSalesPersons(), 
                    "BusinessEntityID", "BusinessEntityID");
            ViewBag.TerritoryID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getSalesTerritories(), 
                    "TerritoryID", "Name");
            return View();
        }

        //
        // POST: /Sales/Orders/Create

        [HttpPost]
        public ActionResult Create(SalesOrderHeader salesorderheader)
        {
            if (ModelState.IsValid)
            {
                ServiceFactoryAccess.OrdersSO.addOrder(salesorderheader);
                return RedirectToAction("Index");
            }

            ViewBag.BillToAddressID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getAddresses(), 
                    "AddressID", "AddressLine1", salesorderheader.BillToAddressID);
            ViewBag.ShipToAddressID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getAddresses(), 
                    "AddressID", "AddressLine1", salesorderheader.ShipToAddressID);
            ViewBag.ShipMethodID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getShipMethods(), 
                    "ShipMethodID", "Name", salesorderheader.ShipMethodID);
            ViewBag.CreditCardID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getCreditCards(), 
                    "CreditCardID", "CardType", salesorderheader.CreditCardID);
            ViewBag.CurrencyRateID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getCurrencyRates(), 
                    "CurrencyRateID", "FromCurrencyCode", salesorderheader.CurrencyRateID);
            ViewBag.CustomerID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getCustomers(), 
                    "CustomerID", "AccountNumber", salesorderheader.CustomerID);
            ViewBag.SalesPersonID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getSalesPersons(), 
                    "BusinessEntityID", "BusinessEntityID", salesorderheader.SalesPersonID);
            ViewBag.TerritoryID = 
                new SelectList(ServiceFactoryAccess.OrdersSO.getSalesTerritories(), 
                    "TerritoryID", "Name", salesorderheader.TerritoryID);
            return View(salesorderheader);
        }

        //
        // GET: /Sales/Orders/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SalesOrderHeader salesorderheader = 
                ServiceFactoryAccess.OrdersSO.getOrderHeaderDetails(id);
            if (salesorderheader == null)
            {
                return HttpNotFound();
            }
            ViewBag.BillToAddressID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getAddresses(),
                    "AddressID", "AddressLine1", salesorderheader.BillToAddressID);
            ViewBag.ShipToAddressID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getAddresses(),
                    "AddressID", "AddressLine1", salesorderheader.ShipToAddressID);
            ViewBag.ShipMethodID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getShipMethods(),
                    "ShipMethodID", "Name", salesorderheader.ShipMethodID);
            ViewBag.CreditCardID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getCreditCards(),
                    "CreditCardID", "CardType", salesorderheader.CreditCardID);
            ViewBag.CurrencyRateID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getCurrencyRates(),
                    "CurrencyRateID", "FromCurrencyCode", salesorderheader.CurrencyRateID);
            ViewBag.CustomerID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getCustomers(),
                    "CustomerID", "AccountNumber", salesorderheader.CustomerID);
            ViewBag.SalesPersonID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getSalesPersons(),
                    "BusinessEntityID", "BusinessEntityID", salesorderheader.SalesPersonID);
            ViewBag.TerritoryID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getSalesTerritories(),
                    "TerritoryID", "Name", salesorderheader.TerritoryID);
            return View(salesorderheader);
        }

        //
        // POST: /Sales/Orders/Edit/5

        [HttpPost]
        public ActionResult Edit(SalesOrderHeader salesorderheader)
        {
            if (ModelState.IsValid)
            {
                ServiceFactoryAccess.OrdersSO.editOrder(salesorderheader);
                return RedirectToAction("Index");
            }
            ViewBag.BillToAddressID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getAddresses(),
                    "AddressID", "AddressLine1", salesorderheader.BillToAddressID);
            ViewBag.ShipToAddressID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getAddresses(),
                    "AddressID", "AddressLine1", salesorderheader.ShipToAddressID);
            ViewBag.ShipMethodID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getShipMethods(),
                    "ShipMethodID", "Name", salesorderheader.ShipMethodID);
            ViewBag.CreditCardID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getCreditCards(),
                    "CreditCardID", "CardType", salesorderheader.CreditCardID);
            ViewBag.CurrencyRateID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getCurrencyRates(),
                    "CurrencyRateID", "FromCurrencyCode", salesorderheader.CurrencyRateID);
            ViewBag.CustomerID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getCustomers(),
                    "CustomerID", "AccountNumber", salesorderheader.CustomerID);
            ViewBag.SalesPersonID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getSalesPersons(),
                    "BusinessEntityID", "BusinessEntityID", salesorderheader.SalesPersonID);
            ViewBag.TerritoryID =
                new SelectList(ServiceFactoryAccess.OrdersSO.getSalesTerritories(),
                    "TerritoryID", "Name", salesorderheader.TerritoryID);
            return View(salesorderheader);
        }

        //
        // GET: /Sales/Orders/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SalesOrderHeader salesorderheader = 
                ServiceFactoryAccess.OrdersSO.getOrderHeaderDetails(id);
            if (salesorderheader == null)
            {
                return HttpNotFound();
            }
            return View(salesorderheader);
        }

        //
        // POST: /Sales/Orders/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceFactoryAccess.OrdersSO.deleteOrder(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}