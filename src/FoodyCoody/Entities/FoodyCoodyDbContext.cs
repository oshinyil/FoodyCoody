using Microsoft.EntityFrameworkCore;

namespace FoodyCoody.Entities
{
    public class FoodyCoodyDbContext : DbContext
    {
        public FoodyCoodyDbContext(DbContextOptions<FoodyCoodyDbContext> options)
            : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
