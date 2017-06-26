using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIs.Models;

namespace WebAPIs.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private static List<Product> products = new List<Product>()
        {
            new Product { ID = 1, Name = "Green Peppers" },
            new Product { ID = 2, Name = "Soft Taco" },
            new Product { ID = 3, Name = "Chipotle Sauce" }
        };

        [HttpGet]
        public List<Product> Get()
        {
            return products;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = products.SingleOrDefault(p => p.ID == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}