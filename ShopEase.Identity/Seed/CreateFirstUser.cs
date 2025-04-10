using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopEase.Identity.Models;

namespace ShopEase.Identity.Seed
{
    public class CreateFirstUser : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                new ApplicationUser
                {
                    Id = "41776008 - 6086 - 1a1b - b923 - 2879a6680b9a",
                    Name = "Rahul",
                    UserName = "Rahul",
                    NormalizedUserName = "RAHUL",
                    ProfilePicture = "https://example.com/rahul.jpg",
                    Email = "Rahul@shopease.com",
                    NormalizedEmail = "Rahul@SHOPEASE.COM",
                    Address ="Virar",
                    PasswordHash = hasher.HashPassword(null, "Rahulseller@27")
                },
                new ApplicationUser
                {
                    Id = "41776008 - 6086 - 1b1b - b923 - 2879a6680b9a",
                    Name = "Om",
                    UserName = "Om",
                    ProfilePicture = "https://example.com/om.jpg",
                    NormalizedUserName = "OM",
                    Email = "om@shopease.com",
                    NormalizedEmail = "OM@SHOPEASE.COM",
                    Address = "Kurla",
                    PasswordHash = hasher.HashPassword(null, "Omuser@27")
                }
              );
        }
    }
}
