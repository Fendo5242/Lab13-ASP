using Microsoft.EntityFrameworkCore;

namespace Lab13.Models
{
    public class StoreContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Detail> Details { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=LAB1504-09\\SQLEXPRESS;Database=market;User Id=Fendo;Password=123456;trustservercertificate=True");

        }
    }
}
