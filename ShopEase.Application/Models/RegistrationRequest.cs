using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEase.Application.Models
{
    public class RegistrationRequest
    {
        public string Username { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public string? ProfilePicture { get; set; } = string.Empty;
        [Required,EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required,RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$).{4,10}$")]
        public string Password { get; set; } = string.Empty;
    }
}
