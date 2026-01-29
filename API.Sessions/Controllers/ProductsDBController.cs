using API.Sessions.Data;
using API.Sessions.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Sessions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsDBController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsDBController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
           return _context.Products.ToList();
        }

        // GET api/<ProductDBController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _context.Products.Find(id);
        }

        // POST api/<ProductDBController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        // PUT api/<ProductDBController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            var productinDB = _context.Products.Find(id);
            productinDB.Name = product.Name;
            productinDB.Price = product.Price;
            _context.SaveChanges();

        }

        // DELETE api/<ProductDBController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var p = _context.Products.Find(id);
            _context.Products.Remove(p);
            _context.SaveChanges();

        }
    }
}
