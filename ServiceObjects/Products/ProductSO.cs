using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Domain.ServiceObjects.Products
{
    using AdventureWorks.Domain.DataAccessObjects;
    using AdventureWorks.Domain.DataAccessObjects.Products;
    using AdventureWorks.Domain.ModelObjects.Entities;

    public interface IProductSO
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

    public class ProductSO : IProductSO
    {
        private IProductDAO _ProductDAO = DAOFactory.Instance.ProductDAO;

        public IEnumerable<Product> getProductList()
        {
            return _ProductDAO.getProductList();
        }

        public Product getProductDetail(int id)
        {
            return _ProductDAO.getProductDetail(id);
        }

        public void addProduct(Product product)
        {
            _ProductDAO.addProduct(product);
        }

        public void editProduct(Product product)
        {
            _ProductDAO.editProduct(product);
        }

        public void deleteProduct(int id)
        {
            _ProductDAO.deleteProduct(id);
        }

        public IEnumerable<ProductModel> getProductModels()
        {
            return _ProductDAO.getProductModels();
        }

        public IEnumerable<ProductSubcategory> getProductSubcategories()
        {
            return _ProductDAO.getProductSubcategories();
        }

        public IEnumerable<UnitMeasure> getUnitMeasures()
        {
            return _ProductDAO.getUnitMeasures();
        }

        public IEnumerable<ProductDocument> getProductDocuments()
        {
            return _ProductDAO.getProductDocuments();
        }
    }
}
