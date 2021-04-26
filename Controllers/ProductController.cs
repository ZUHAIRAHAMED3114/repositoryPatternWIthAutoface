using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using depenDencyInjectionWIthAutoFac.Models;

namespace depenDencyInjectionWIthAutoFac.Controllers
{
    public class ProductController : ApiController
    {
        private readonly Irepository<Product>  productRepository;

        public ProductController(Irepository<Product> repository) {
            this.productRepository = repository;
        }

        // GET: api/Product
        public IEnumerable<Product> Get()
        {
           return productRepository.GetAll().Result;
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            return productRepository.Get(id).Result;
        }

        // POST: api/Product
        public void Post([FromBody]Product value)
        {
            productRepository.Add(value);

        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
