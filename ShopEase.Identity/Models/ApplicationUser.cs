using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ShopEase.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required,NotNull]
        public string Name { get; set; }

        [Required]
        public string? Address { get; set; }
        public string? ProfilePicture { get; set; }
    }
}
