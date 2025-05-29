using Microsoft.AspNetCore.Mvc;
using SchoolManagementAPI.Models;

namespace SchoolManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private static List<User> users = new() {
        new User { Username = "admin", Password = "1234" }
    };

        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            var exists = users.Any(u => u.Username == user.Username && u.Password == user.Password);
            if (!exists) return Unauthorized("Invalid credentials");
            return Ok("Giriş başarılı!");
        }
    }
}
