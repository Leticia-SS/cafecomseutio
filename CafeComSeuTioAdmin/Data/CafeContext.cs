using Microsoft.EntityFrameworkCore;

namespace CafeComSeuTioAdmin.Data
{
    public class CafeContext : DbContext
    {
        public CafeContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
