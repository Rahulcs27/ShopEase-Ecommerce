using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ShopEase.Application.Contracts.Identity;
using ShopEase.Application.Exceptions;
using ShopEase.Application.Models;
using ShopEase.Identity.Models;

namespace ShopEase.Identity.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public readonly UserManager<ApplicationUser> _userManager;
        public readonly SignInManager<ApplicationUser> _signInManager;
        public AuthenticationService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<AuthenticationResponse> Login(AuthenticationRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new InvalidCredentialsException();
            }
            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (result.Succeeded)
            {
                return new AuthenticationResponse
                {
                    UserId = user.Id,
                    Email = user.Email,
                };
            }
            else
            {
                throw new Exception("Invalid login attempt");
            }
        }
        public async Task<RegistrationResponse> Register(RegistrationRequest request)
        {
            var existingUser = await _userManager.FindByEmailAsync(request.Email);
            if (existingUser != null)
            {
                throw new UserAlreadyExistsException();
            }

            var user = new ApplicationUser
            {
                UserName = request.Username,
                Email = request.Email,
                Address = request.Address,
                ProfilePicture = request.ProfilePicture,
                Name = request.Name,
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
                return new RegistrationResponse()
                {
                    UserId = user.Id
                };
            }
            else
            {
                throw new Exception("User registration failed");
            }
        }
    }
}
