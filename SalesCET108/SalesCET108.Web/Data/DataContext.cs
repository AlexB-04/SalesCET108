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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasIndex(c => c.Name)
                .IsUnique();
        }
    }
}