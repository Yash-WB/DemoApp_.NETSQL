using DemoApp.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Data
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}