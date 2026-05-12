using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ImportRc> ImportReceipts { get; set; }
        public DbSet<ImportRcDetail> ImportReceiptDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Devices> Devices { get; set; }
        public DbSet<ExportRc> ExportReceipts { get; set; }
        public DbSet<ExportRcDetail> ExportReceiptDetails { get; set; }
        
    }
}