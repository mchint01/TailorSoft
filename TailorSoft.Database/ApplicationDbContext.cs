using System.Data.Entity;
using TailorSoft.Database.Models;

namespace TailorSoft.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
          : base("DbContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Bill> Bills { get; set; }

        public DbSet<Log> Logs { get; set; }
    }
}
