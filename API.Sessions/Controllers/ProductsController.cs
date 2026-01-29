using API.Sessions.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace API.Sessions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        public static List<Product> products = new List<Product>
        {
            new Product{ Id=1, Name="Laptop",Price=40000 },
            new Product{ Id=2, Name="Mouse", Price=500},
            new Product{ Id=3, Name="Keyboard", Price=999},
            new Product{ Id=4, Name="Printer", Price=15000},

        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        [HttpPost]
        public void Post([FromBody] Product product)
        {
            products.Add(product);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            products[id] = product;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            products.RemoveAt(id);
        }
    }
}
