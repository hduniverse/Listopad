using Listopad.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Listopad.WebAPI.Controllers
{
    [EnableCorsAttribute("http://localhost:62204", "*", "*")]
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            var productsRepository = new ProductRepository();
            return productsRepository.Retrieve();
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        public IEnumerable<Product> Get(string search)
        {
            var productsRepository = new ProductRepository();
            var products = productsRepository.Retrieve();
            return products;//.Where(p => p.ProductCode.Contains(search));

        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
