using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace SVC_Supplier.Models
{
    public class SvcSupplierContext : DbContext
    {
        public DbSet<UserDb> Users { get; set; }
        public DbSet<ProductDb> Products { get; set; }
        public DbSet<OrderDb> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string workingDirectory = Directory.GetCurrentDirectory();
            string dbPath = Path.Combine(workingDirectory, "Database", "Database.db");

            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
