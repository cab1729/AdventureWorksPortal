using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdventureWorksPortal.Areas.Products.Controllers
{
    using AdventureWorks.Domain.ServiceObjects;
    using AdventureWorks.Domain.ModelObjects.Entities;

    public class ProductsRESTController : ApiController
    {
        // GET api/productsrest
        public IEnumerable<Product> Get()
        {
            return ServiceFactoryAccess.ProductSO.getProductList();
        }

        // GET api/productsrest/5
        public Product Get(int id)
        {
            return ServiceFactoryAccess.ProductSO.getProductDetail(id);
        }

        // POST api/productsrest
        public void Post([FromBody]string value)
        {
        }

        // PUT api/productsrest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/productsrest/5
        public void Delete(int id)
        {
        }
    }
}
