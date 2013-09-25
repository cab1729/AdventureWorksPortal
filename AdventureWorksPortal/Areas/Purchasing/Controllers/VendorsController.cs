using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdventureWorks.Domain.ModelObjects.Entities;
using AdventureWorks.Domain.ServiceObjects;
using AdventureWorksPortal.Areas.Purchasing.Models;

namespace AdventureWorksPortal.Areas.Purchasing.Controllers
{
    [Authorize]
    public class VendorsController : Controller
    {
        //
        // GET: /Vendors/

        public ActionResult Index()
        {
            var vendors = ServiceFactoryAccess.VendorSO.getVendors();
            return View(vendors.ToList());
        }

        //
        // GET: /Vendors/Details/5

        public ActionResult Details(int id = 0)
        {
            Vendor vendor = ServiceFactoryAccess.VendorSO.getVendorDetails(id);
            if (vendor == null)
            {
                return HttpNotFound();
            }

            VendorAddressContactModel vendorAddressContact = new VendorAddressContactModel();
            vendorAddressContact.Vendor = vendor;
            vendorAddressContact.VendorAddress = 
                ServiceFactoryAccess.VendorSO.getVendorAddress(id);
            vendorAddressContact.VendorContact =
                ServiceFactoryAccess.VendorSO.getVendorContact(id);

            return View(vendorAddressContact);
        }

        //
        // GET: /Vendors/Create

        public ActionResult Create()
        {
            ViewBag.BusinessEntityID = 
                new SelectList(ServiceFactoryAccess.VendorSO.getBusinessEntities(), 
                    "BusinessEntityID", "BusinessEntityID");
            return View();
        }

        //
        // POST: /Vendors/Create

        [HttpPost]
        public ActionResult Create(Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                ServiceFactoryAccess.VendorSO.addVendor(vendor);
                return RedirectToAction("Index");
            }

            ViewBag.BusinessEntityID = 
                new SelectList(ServiceFactoryAccess.VendorSO.getBusinessEntities(), 
                    "BusinessEntityID", "BusinessEntityID", vendor.BusinessEntityID);
            return View(vendor);
        }

        //
        // GET: /Vendors/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Vendor vendor = ServiceFactoryAccess.VendorSO.getVendorDetails(id);
            if (vendor == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusinessEntityID = 
                new SelectList(ServiceFactoryAccess.VendorSO.getBusinessEntities(), 
                    "BusinessEntityID", "BusinessEntityID", vendor.BusinessEntityID);
            return View(vendor);
        }

        //
        // POST: /Vendors/Edit/5

        [HttpPost]
        public ActionResult Edit(Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                ServiceFactoryAccess.VendorSO.editVendor(vendor);
                return RedirectToAction("Index");
            }
            ViewBag.BusinessEntityID = 
                new SelectList(ServiceFactoryAccess.VendorSO.getBusinessEntities(), 
                    "BusinessEntityID", "BusinessEntityID", vendor.BusinessEntityID);
            return View(vendor);
        }

        //
        // GET: /Vendors/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Vendor vendor = ServiceFactoryAccess.VendorSO.getVendorDetails(id);
            if (vendor == null)
            {
                return HttpNotFound();
            }
            return View(vendor);
        }

        //
        // POST: /Vendors/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceFactoryAccess.VendorSO.deleteVendor(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            //db.Dispose();
            base.Dispose(disposing);
        }
    }
}