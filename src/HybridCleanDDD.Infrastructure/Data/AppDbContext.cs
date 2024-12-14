using HybridCleanDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HybridCleanDDD.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet for Orders
        public DbSet<Order> Orders { get; set; }
    }
}
