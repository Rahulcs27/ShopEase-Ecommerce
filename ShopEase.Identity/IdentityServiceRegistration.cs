using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopEase.Application.Contracts.Identity;
using ShopEase.Identity.Context;
using ShopEase.Identity.Models;
using ShopEase.Identity.Services;

namespace ShopEase.Identity
{
    public static class IdentityServiceRegistration
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShopEaseIdentityDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ShopEaseIdentityDbContext>()
                    .AddDefaultTokenProviders();
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}
