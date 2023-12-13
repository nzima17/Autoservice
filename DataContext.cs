using Microsoft.EntityFrameworkCore;

namespace Autoservice
{
    public class DataContext : DbContext


    {
        public DbSet<User> Users { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Catalog> ServiceCatalog { get; set; }

        public DbSet<Order> ClientOrders { get; set; }

        public DbSet<SpareParts> SparePartsList { get; set; }

        public DataContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Autoservice.db");
        }

    }
}
