using Microsoft.EntityFrameworkCore;

namespace SVC_Supplier.Models
{
    public class SvcSupplierContext : DbContext
    {
        public DbSet<UserDb> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string workingDirectory = Directory.GetCurrentDirectory();
            string dbPath = Path.Combine(workingDirectory, "Database", "Database.db");

            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
