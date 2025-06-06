﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopEase.Identity.Configurations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "41776008 - 6086 - 1a1a - b923 - 2879a6680b9a",
                    Name = "SELLER",
                    NormalizedName = "SELLER"
                },
                new IdentityRole
                {
                    Id = "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a",
                    Name = "User",
                    NormalizedName = "USER"
                }
            );
        }
    }
}
