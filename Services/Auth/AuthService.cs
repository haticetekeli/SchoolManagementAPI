using Microsoft.EntityFrameworkCore;
using SchoolManagementAPI.Data;
using SchoolManagementAPI.Models;
using System.Security.Cryptography;
using System.Text;

namespace SchoolManagementAPI.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;

        public AuthService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Register(string username, string password)
        {
            if (await _context.Users.AnyAsync(u => u.Username == username))
                return false;

            var user = new User
            {
                Username = username,
                Password = HashPassword(password)
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null) return false;
            
            return user.Password == HashPassword(password);
        }

        public Task<bool> ChangePassword(string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAccount()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Logout()
        {
            throw new NotImplementedException();
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
