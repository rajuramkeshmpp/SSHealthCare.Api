
using Microsoft.AspNetCore.Mvc;
using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;

namespace SSHealthCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRole _userRole;
        public UserRoleController(IUserRole userRole)
        {
            _userRole = userRole;
        }
        [HttpGet("GetAllUserRole")]
        public IActionResult GetAllUserRole() 
        {
            return Ok(_userRole.GetAllUserRole());
        }
        [HttpPost("AddUserRole")]
        public IActionResult AddUserRole(UserRole userRole)
        {
            return Ok(_userRole.AddUserRole(userRole));
        }
    }
}
