using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Products.InMemory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Products.InMemory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        
        // GET: api/Products
        [HttpGet]
        //public IEnumerable<Product> Get()
        //{
        //    //return new string[] { "value1", "value2" };
        //    if (!products.Any())
        //    {
        //        return NoContent();
        //    }
        //    return products;
        //}
        
        public IActionResult Get()
        {
            //return new string[] { "value1", "value2" };
            if (!products.Any())
            {
                return NoContent();
            }
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                products.Add(product);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id!=product.Id)
            {
                return BadRequest("Product Ids do not match");
            }

            var existingProduct = products.Find(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            //update
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.DateAdded = product.DateAdded;
            existingProduct.Category = product.Category;
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingProduct = products.Find(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            else
            {
                products.Remove(existingProduct);
                return Ok();
            }
        }

        static Category category = new Category
        {
            Id = 1,
            Name = "Electronics"
        };

        static List<Product> products = new List<Product>
        {
            new Product{
                Id=1, Name="Laptop", Price = 50000, DateAdded = new DateTime(2019,1,1), Category= category },
            new Product{ Id=2, Name="Ipad", Price = 56000, DateAdded = new DateTime(2018,1,1), Category= category }
        };
    }
}
