using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AdventureWorksServices.Products
{
    using AdventureWorks.Domain.ModelObjects.DataTransfer;

    [ServiceContract]
    public interface IProductCatalogService
    {
        [OperationContract]
        IEnumerable<ProductDTO> GetProductList();

        [OperationContract]
        ProductDTO GetProductDetail(int id);
    }
}
