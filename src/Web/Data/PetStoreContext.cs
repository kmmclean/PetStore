using Microsoft.EntityFrameworkCore;
using PetStore.Web.Models.Entities;

namespace PetStore.Web.Data
{
    public class PetStoreContext : DbContext
    {
        public PetStoreContext(DbContextOptions<PetStoreContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}