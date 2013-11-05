using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdventureWorksServices.Products
{
    using AdventureWorks.Domain.ServiceObjects;
    using AdventureWorks.Domain.ModelObjects.DataTransfer;
    
    public class ProductCatalogService : IProductCatalogService
    {
        public IEnumerable<ProductDTO> GetProductList()
        {
            return ServiceFactoryAccess.ProductSO.getProductDTOList();
        }

        public ProductDTO GetProductDetail(int id)
        {
            return ServiceFactoryAccess.ProductSO.getProductDTODetail(id);
        }
    }
}
