using API.Sessions.Data;
using API.Sessions.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        // GET api/<ProductDBController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult>Get(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST api/<ProductDBController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<ProductDBController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Product product)
        {
            var p = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (p == null)
            {
                return NotFound();
            }
            else
            {
                p.Name = product.Name;
                p.Price = product.Price;
                await _context.SaveChangesAsync();
                return Ok("Product details updated");
            }

        }

        // DELETE api/<ProductDBController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var p = await _context.Products.FindAsync(id);
            _context.Products.Remove(p);
            await _context.SaveChangesAsync();
            return Ok("Product deleted");   

        }
    }
}
