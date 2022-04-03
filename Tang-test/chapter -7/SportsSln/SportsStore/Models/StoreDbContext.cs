using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SportsStore.Models
{
    public class StoreDbContext : DbContext
    {
        public IConfiguration Configuration { get; }

        public StoreDbContext(DbContextOptions<StoreDbContext> options, IConfiguration configuration) : base(options)
        { Configuration = configuration; }

        public DbSet<Product> Products { set; get; }
        public DbSet<Order> Orders { set; get; }

        // Approach two:
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Configuration["ConnectionStrings:SportsStoreConnection"]);
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        }
    }
}