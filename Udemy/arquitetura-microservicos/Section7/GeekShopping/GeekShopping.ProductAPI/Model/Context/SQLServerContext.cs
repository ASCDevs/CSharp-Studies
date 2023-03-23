using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class SQLServerContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public SQLServerContext(IConfiguration configuration){ 
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Product> Products { get; set;}
    }
}
