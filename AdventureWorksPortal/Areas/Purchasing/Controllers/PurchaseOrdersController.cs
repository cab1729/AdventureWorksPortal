using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using AdventureWorksPortal.Models.Entities;
using AdventureWorks.Domain.ModelObjects.Entities;
using AdventureWorks.Domain.ServiceObjects;

namespace AdventureWorksPortal.Areas.Purchasing.Controllers
{
    [Authorize]
    public class PurchaseOrdersController : Controller
    {
        private AdventureWorksModelContainer db = new AdventureWorksModelContainer();

        //
        // GET: /PurchaseOrders/

        public ActionResult Index()
        {
            var purchaseorderheaders =
                //db.PurchaseOrderHeaders.Include("Employee").Include("ShipMethod").Include("Vendor");
                ServiceFactoryAccess.PurchaseOrderSO.getPurchaseOrderHeaders();
            return View(purchaseorderheaders.ToList());
        }

        //
        // GET: /PurchaseOrders/Details/5

        public ActionResult Details(int id = 0)
        {
            PurchaseOrderHeader purchaseorderheader =
                //db.PurchaseOrderHeaders.Single(p => p.PurchaseOrderID == id);
                ServiceFactoryAccess.PurchaseOrderSO.getPurchaseOrderHeaderDetails(id);
            if (purchaseorderheader == null)
            {
                return HttpNotFound();
            }
            return View(purchaseorderheader);
        }

        //
        // GET: /PurchaseOrders/Create

        public ActionResult Create()
        {
            ViewBag.EmployeeID = 
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getEmployees(), 
                    "BusinessEntityID", "NationalIDNumber");
            ViewBag.ShipMethodID = 
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getShipMethods(), 
                    "ShipMethodID", "Name");
            ViewBag.VendorID = 
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getVendors(), 
                    "BusinessEntityID", "AccountNumber");
            return View();
        }

        //
        // POST: /PurchaseOrders/Create

        [HttpPost]
        public ActionResult Create(PurchaseOrderHeader purchaseorderheader)
        {
            if (ModelState.IsValid)
            {
                //db.PurchaseOrderHeaders.Add(purchaseorderheader);
                //db.SaveChanges();
                ServiceFactoryAccess.PurchaseOrderSO.addPurchaseOrder(purchaseorderheader);
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID =
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getEmployees(), 
                    "BusinessEntityID", "NationalIDNumber", purchaseorderheader.EmployeeID);
            ViewBag.ShipMethodID =
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getShipMethods(), 
                    "ShipMethodID", "Name", purchaseorderheader.ShipMethodID);
            ViewBag.VendorID =
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getVendors(), 
                    "BusinessEntityID", "AccountNumber", purchaseorderheader.VendorID);
            return View(purchaseorderheader);
        }

        //
        // GET: /PurchaseOrders/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PurchaseOrderHeader purchaseorderheader =
                //db.PurchaseOrderHeaders.Single(p => p.PurchaseOrderID == id);
                ServiceFactoryAccess.PurchaseOrderSO.getPurchaseOrderHeaderDetails(id);
            if (purchaseorderheader == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID =
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getEmployees(), 
                    "BusinessEntityID", "NationalIDNumber", purchaseorderheader.EmployeeID);
            ViewBag.ShipMethodID =
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getShipMethods(), 
                    "ShipMethodID", "Name", purchaseorderheader.ShipMethodID);
            ViewBag.VendorID =
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getVendors(), 
                    "BusinessEntityID", "AccountNumber", purchaseorderheader.VendorID);
            return View(purchaseorderheader);
        }

        //
        // POST: /PurchaseOrders/Edit/5

        [HttpPost]
        public ActionResult Edit(PurchaseOrderHeader purchaseorderheader)
        {
            if (ModelState.IsValid)
            {
                //db.PurchaseOrderHeaders.Attach(purchaseorderheader);
                //db.ObjectStateManager.ChangeObjectState(purchaseorderheader, EntityState.Modified);
                //db.SaveChanges();
                ServiceFactoryAccess.PurchaseOrderSO.editPurchaseOrder(purchaseorderheader);
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID =
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getEmployees(), 
                    "BusinessEntityID", "NationalIDNumber", purchaseorderheader.EmployeeID);
            ViewBag.ShipMethodID =
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getShipMethods(), 
                    "ShipMethodID", "Name", purchaseorderheader.ShipMethodID);
            ViewBag.VendorID =
                new SelectList(ServiceFactoryAccess.PurchaseOrderSO.getVendors(), 
                    "BusinessEntityID", "AccountNumber", purchaseorderheader.VendorID);
            return View(purchaseorderheader);
        }

        //
        // GET: /PurchaseOrders/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PurchaseOrderHeader purchaseorderheader =
                //db.PurchaseOrderHeaders.Single(p => p.PurchaseOrderID == id);
                ServiceFactoryAccess.PurchaseOrderSO.getPurchaseOrderHeaderDetails(id);
            if (purchaseorderheader == null)
            {
                return HttpNotFound();
            }
            return View(purchaseorderheader);
        }

        //
        // POST: /PurchaseOrders/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //PurchaseOrderHeader purchaseorderheader = 
            //    db.PurchaseOrderHeaders.Single(p => p.PurchaseOrderID == id);
            //db.PurchaseOrderHeaders.DeleteObject(purchaseorderheader);
            //db.SaveChanges();
            ServiceFactoryAccess.PurchaseOrderSO.deletePurchaseOrder(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            //db.Dispose();
            base.Dispose(disposing);
        }
    }
}