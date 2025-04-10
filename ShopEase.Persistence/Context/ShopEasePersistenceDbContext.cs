using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopEase.Domain.Entities;

namespace ShopEase.Persistence.Context
{
    public class ShopEasePersistenceDbContext : DbContext
    {
        public ShopEasePersistenceDbContext(DbContextOptions<ShopEasePersistenceDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShopEasePersistenceDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
