using Microsoft.AspNetCore.Mvc;
using SSHealthCare.Api.DTO.Request;
using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;

namespace SSHealthCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }

        [HttpPost("Register")]
        public IActionResult Register(UserRegister userRegister)
        {
            User user = new User()
            { 
                Id = userRegister.Id,
                Name = userRegister.Name,
                Email = userRegister.Email,
                Password = userRegister.Password
            };
            var result = _user.AddUser(user);
            return Ok("Register successfully.");
        }

        [HttpPost("Login")]
        public IActionResult Login(UserLogin userLogin)
        {
            var user = _user.Login(userLogin.Email, userLogin.Password);

            if (user != null)
            {
                return Ok(new { status = 200, user = user });
            }

            return NotFound(new { message = "Invalid email or password" });
        }
    }
}
