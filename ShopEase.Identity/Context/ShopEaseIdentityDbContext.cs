using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopEase.Identity.Configurations;
using ShopEase.Identity.Seed;

namespace ShopEase.Identity.Context
{
    public class ShopEaseIdentityDbContext : IdentityDbContext
    {
        public ShopEaseIdentityDbContext(DbContextOptions<ShopEaseIdentityDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new CreateFirstUser());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        }

    }
}
