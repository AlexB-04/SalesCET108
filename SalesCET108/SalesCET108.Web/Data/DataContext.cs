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

        public DbSet<Product> Products { get; set; } = null!;
    }
}