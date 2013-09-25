using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorksPortal.Areas.Products.Controllers
{
    using AdventureWorks.Domain.ModelObjects.Entities;
    using AdventureWorks.Domain.ServiceObjects;
    using AdventureWorks.Domain.ServiceObjects.Products;

    [Authorize]
    public class CatalogController : Controller
    {
        //
        // GET: /Products/Catalog/

        public ActionResult Index()
        {
            return View(ServiceFactoryAccess.ProductSO.getProductList());
        }

        //
        // GET: /Products/Catalog/Details/5

        public ActionResult Details(int id = 0)
        {
            Product product = 
                ServiceFactoryAccess.ProductSO.getProductDetail(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // GET: /Products/Catalog/Create

        public ActionResult Create()
        {
            ViewBag.ProductModelID = 
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductModels(), 
                        "ProductModelID", "Name");
            ViewBag.ProductSubcategoryID = 
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductSubcategories(), 
                        "ProductSubcategoryID", "Name");
            ViewBag.SizeUnitMeasureCode = 
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getUnitMeasures(), 
                        "UnitMeasureCode", "Name");
            ViewBag.WeightUnitMeasureCode =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getUnitMeasures(), 
                        "UnitMeasureCode", "Name");
            ViewBag.ProductID =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductDocuments(), 
                        "ProductID", "ProductID");
            return View();
        }

        //
        // POST: /Products/Catalog/Create

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ServiceFactoryAccess.ProductSO.addProduct(product);
                return RedirectToAction("Index");
            }

            ViewBag.ProductModelID =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductModels(),
                        "ProductModelID", "Name", product.ProductModelID);
            ViewBag.ProductSubcategoryID =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductSubcategories(),
                        "ProductSubcategoryID", "Name", product.ProductSubcategoryID);
            ViewBag.SizeUnitMeasureCode =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getUnitMeasures(),
                        "UnitMeasureCode", "Name", product.SizeUnitMeasureCode);
            ViewBag.WeightUnitMeasureCode =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getUnitMeasures(),
                        "UnitMeasureCode", "Name", product.WeightUnitMeasureCode);
            ViewBag.ProductID =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductDocuments(),
                        "ProductID", "ProductID", product.ProductID);
            return View(product);
        }

        //
        // GET: /Products/Catalog/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Product product = ServiceFactoryAccess.ProductSO.getProductDetail(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductModelID =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductModels(),
                        "ProductModelID", "Name", product.ProductModelID);
            ViewBag.ProductSubcategoryID =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductSubcategories(),
                        "ProductSubcategoryID", "Name", product.ProductSubcategoryID);
            ViewBag.SizeUnitMeasureCode =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getUnitMeasures(),
                        "UnitMeasureCode", "Name", product.SizeUnitMeasureCode);
            ViewBag.WeightUnitMeasureCode =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getUnitMeasures(),
                        "UnitMeasureCode", "Name", product.WeightUnitMeasureCode);
            ViewBag.ProductID =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductDocuments(),
                        "ProductID", "ProductID", product.ProductID);
            return View(product);
        }

        //
        // POST: /Products/Catalog/Edit/5

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                ServiceFactoryAccess.ProductSO.editProduct(product);
                return RedirectToAction("Index");
            }
            ViewBag.ProductModelID =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductModels(),
                        "ProductModelID", "Name", product.ProductModelID);
            ViewBag.ProductSubcategoryID =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductSubcategories(),
                        "ProductSubcategoryID", "Name", product.ProductSubcategoryID);
            ViewBag.SizeUnitMeasureCode =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getUnitMeasures(),
                        "UnitMeasureCode", "Name", product.SizeUnitMeasureCode);
            ViewBag.WeightUnitMeasureCode =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getUnitMeasures(),
                        "UnitMeasureCode", "Name", product.WeightUnitMeasureCode);
            ViewBag.ProductID =
                new SelectList(
                        ServiceFactoryAccess.ProductSO.getProductDocuments(),
                        "ProductID", "ProductID", product.ProductID);
            return View(product);
        }

        //
        // GET: /Products/Catalog/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Product product = ServiceFactoryAccess.ProductSO.getProductDetail(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // POST: /Products/Catalog/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceFactoryAccess.ProductSO.deleteProduct(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}