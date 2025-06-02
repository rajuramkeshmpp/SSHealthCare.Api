using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SSHealthCare.Api.DTO.Request;
using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SSHealthCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       
        private readonly IUser _user;
        private readonly IRole _role;
        private readonly IUserRole _userRole;

        private readonly IConfiguration _configuration;

        public UserController(IUser user, IConfiguration configuration, IRole role, IUserRole userRole)
        {
            _user = user;
            _configuration = configuration;
            _role = role;
            _userRole = userRole;
        }

        [HttpPost("Register")]
        public IActionResult Register(UserRegister userRegister)
        {
            User user = new User()
            { 
                Id = userRegister.Id,
                Email = userRegister.Email,
                Password = userRegister.Password,
                Firstname = userRegister.Firstname,
                Lastname = userRegister.Lastname,
                Mobile = userRegister.Mobile
            };
            var result = _user.AddUser(user);
            return Ok("Register successfully.");
        }

        [HttpPost("Login")]
        public IActionResult Login(UserLogin userLogin)
        {
            var user = _user.Login(userLogin.Email, userLogin.Password);

            if (user == null)
                return Ok(new { token = "", name = "", role = "", success = "400" });

            var userRole = _userRole.GetUserRoleById(user.Id);

            if (userRole == null)
                return Ok(new { token = "", name = "", role = "", success = "401" });
            else
            {
                var role = _role.GetRoleById(userRole.RoleId);
                var company = new Company() { Id = 1, Name = "Shiwansh Solutions", Image = "jobportal.png" };  //_company.GetCompanyById(role.CompanyId);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Role, role.Name),
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddHours(Convert.ToDouble(_configuration["Jwt:ExpiresInHours"])),
                    signingCredentials: creds
                );
                var jwt = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(new { token = jwt, user = user, role = role, success = "200", company = company });
            }
        }

        [HttpGet("GetAllUser")]
        public IActionResult GetAllUser()
        {
            return Ok(_user.GetAllUser());
        }

        [HttpGet("GetAllUserForTaskManager")]
        public IActionResult GetAllUserForTaskManager()
        {
            return Ok(_user.GetAllUserForTaskManager());
        }

    }
}
