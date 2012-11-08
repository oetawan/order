using Order.Data.Contract;
using Order.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Order.Web.Controllers
{
    public class ProductsController : ApiControllerBase
    {
        public ProductsController(IOrderUow uow)
        {
            Uow = uow;
        }

        // GET api/product
        public IEnumerable<Product> Get()
        {
            return Uow.Products.GetAll().OrderBy(p => p.Name);
        }

        public Product Get(int id)
        {
            return Uow.Products.GetById(id);
        }

        public HttpResponseMessage Post(Product product)
        {
            Uow.Products.Add(product);
            Uow.Commit();

            var response = Request.CreateResponse(HttpStatusCode.Created, product);

            response.Headers.Location =
                new Uri(Url.Link("DefaultApi", product.Id));

            return response;
        }

        public HttpResponseMessage Put(Product product)
        {
            Uow.Products.Update(product);
            Uow.Commit();

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        public HttpResponseMessage Delete(int id)
        {
            Uow.Products.Delete(id);
            Uow.Commit();

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}