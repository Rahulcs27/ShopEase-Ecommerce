using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopEase.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "41776008 - 6086 - 1a1b - b923 - 2879a6680b9a",
                    RoleId = "41776008 - 6086 - 1a1a - b923 - 2879a6680b9a"
                },
                new IdentityUserRole<string>
                {
                    UserId = "41776008 - 6086 - 1b1b - b923 - 2879a6680b9a",
                    RoleId = "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a"
                }
            );
        }
    }
}
