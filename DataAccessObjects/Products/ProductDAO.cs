using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects;
using System.Data.Entity;

namespace AdventureWorks.Domain.DataAccessObjects.Products
{
    using AdventureWorks.Domain.DataAccessObjects;
    using AdventureWorks.Domain.ModelObjects.Entities;

    public interface IProductDAO
    {
        IEnumerable<Product> getProductList();
        Product getProductDetail(int id);
        void addProduct(Product product);
        void editProduct(Product product);
        void deleteProduct(int id);
        IEnumerable<ProductModel> getProductModels();
        IEnumerable<ProductSubcategory> getProductSubcategories();
        IEnumerable<UnitMeasure> getUnitMeasures();
        IEnumerable<ProductDocument> getProductDocuments();
    }
    
    public class ProductDAO : IProductDAO
    {
        private DAHelper da = new DAHelper();
        private AdventureWorksModelContainer _db = new AdventureWorksModelContainer();

        public IEnumerable<Product> getProductList()
        {
            var products = 
                _db.Products
                    .Include("ProductModel")
                    .Include("ProductSubcategory")
                    .Include("UnitMeasure")
                    .Include("UnitMeasure1")
                    .Include("ProductDocument");
            return products.ToList();
        }

        public Product getProductDetail(int id)
        {
            Product product = _db.Products
                .Include("ProductModel")
                .Include("ProductSubcategory")
                .Include("UnitMeasure")
                .Include("UnitMeasure1")
                .Include("ProductDocument")
                .Include(p => p.ProductInventories.Select(i => i.Location))
                .SingleOrDefault(p => p.ProductID == id);
            return product;
        }

        public void addProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();

        }

        public void editProduct(Product product)
        {
            _db.Products.Attach(product);
            _db.Entry(product).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void deleteProduct(int id)
        {
            Product product = _db.Products.Single(p => p.ProductID == id);
            _db.Entry(product).State = EntityState.Deleted;
            _db.Products.Remove(product);
            _db.SaveChanges();
        }

        public IEnumerable<ProductModel> getProductModels()
        {
            return _db.ProductModels.AsEnumerable<ProductModel>();
        }

        public IEnumerable<ProductSubcategory> getProductSubcategories()
        {
            return _db.ProductSubcategories.AsEnumerable<ProductSubcategory>();
        }

        public IEnumerable<UnitMeasure> getUnitMeasures()
        {
            return _db.UnitMeasures.AsEnumerable<UnitMeasure>();
        }

        public IEnumerable<ProductDocument> getProductDocuments()
        {
            return _db.ProductDocuments.AsEnumerable<ProductDocument>();
        }
    }
}
