using API.Sessions.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Sessions.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
