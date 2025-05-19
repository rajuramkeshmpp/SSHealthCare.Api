
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Register(User user) 
        {
            var result = _user.AddUser(user);
            return Ok("Register successfully.");
        }

        [HttpGet("GetAllUser")]
        public IActionResult GetAllUser()
        {
            return Ok(_user.GetAllUser());
        }
    }
}
