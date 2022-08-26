using Microsoft.EntityFrameworkCore;

namespace DemoWebApplication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
