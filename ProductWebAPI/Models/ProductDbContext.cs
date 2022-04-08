using Microsoft.EntityFrameworkCore;

namespace ProductWebAPI.Models
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        public List<Product> GetProducts() => Products.Local.ToList<Product>();
    }
}
