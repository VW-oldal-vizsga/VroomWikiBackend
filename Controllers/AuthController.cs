using Backend_Webshop.Controllers;
using Backend_Webshop.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Security.Claims;
using VroomWiki.Data;

using VroomWiki.Models;
using VroomWiki.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VroomWiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        
        private readonly AuthRepository authRepository;
        public AuthController(AuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }

        // GET: api/<AuthController>


        [HttpPost("login")]
        public IActionResult Login(object loginData)
        {
            return this.Run(() =>
            {
                var user = authRepository.Login(loginData.Deserialize<LoginModel>());
                if (user == null)
                    return Unauthorized(new
                    {
                        message = "Invalid username or password"
                    });
                return Ok(user);
            });
        }

        [HttpPost("registration")]
        public IActionResult Registration(object registrationData)
        {
            return this.Run(() =>
            {
                var user = authRepository.RegisterUser(registrationData.Deserialize<User>());
                if (user == null)
                    return BadRequest(new
                    {
                        message = "Unsuccessfull registration"
                    });
                return Ok(user);
            });
        }

        [HttpPost("logout")]
        [Authorize]
        public IActionResult logout()
        {
            return this.Run(() =>
            {
                authRepository.Logout(this.User.Claims.FirstOrDefault(c => c.Type == "Token")?.Value);
                return Ok();
            });
        }

        [HttpGet]
        [Authorize]
        public IActionResult Check()
        {
            return this.Run(() =>
            {
                return Ok(new
                {
                    validTo = DateTime.Parse(this.User.Claims.FirstOrDefault(c => c.Type == "ValidTo")?.Value),
                    Email = this.User.Claims.FirstOrDefault(c => c.Type == "Email")?.Value,
                    Roles = this.User.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value),
                    Token = this.User.Claims.FirstOrDefault(c => c.Type == "Token")?.Value,
                });
            });
        }
    }
}
