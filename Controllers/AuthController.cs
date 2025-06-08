using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementAPI.Models;
using SchoolManagementAPI.Services.Auth;

namespace SchoolManagementAPI.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.Register(model.Username, model.Password);
            if (result)
            {
                return Ok(new { message = "Kullanıcı başarıyla kaydedildi!" });
            }
            
            return BadRequest(new { message = "Kullanıcı kaydı başarısız oldu. Lütfen tekrar deneyin." });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.Login(model.Username, model.Password);
            if (result)
            {
                return Ok(new { message = "Giriş başarılı!" });
            }
            
            return Unauthorized(new { message = "Geçersiz kullanıcı adı veya şifre." });
        }
    }
}
