using Microsoft.EntityFrameworkCore;
using SalesCET108.Web.Data.Entities;

namespace SalesCET108.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>()
                .HasIndex(s => new { s.Name, s.CountryId })
                .IsUnique();

            modelBuilder.Entity<City>()
                .HasIndex(c => new { c.Name, c.StateId })
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}