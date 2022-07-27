using InventoryManagement0.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement0.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet <Inventory> InventoryTable { get; set; }

        public DbSet <Login> LoginTable { get; set; }
    }
}
