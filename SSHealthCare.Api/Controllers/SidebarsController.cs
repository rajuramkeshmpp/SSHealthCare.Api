
using Microsoft.AspNetCore.Mvc;
using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;

namespace SSHealthCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SidebarsController : ControllerBase
    {
        private readonly ISidebar _sidebar;
        public SidebarsController(ISidebar sidebar)
        {
            _sidebar = sidebar;
        }
        [HttpGet("GetAllSidebar")]
        public IActionResult GetAllSidebar()
        {
            return Ok(_sidebar.GetAll());
        }

        [HttpGet("GetSidebarByRoleId")]
        public IActionResult GetSidebarByRoleId(int roleId)
        {
            var sidebars = _sidebar.GetSidebbarByRoleId(roleId);
            if (sidebars == null)
                return NotFound($"sidebar with ID {roleId} not found.");

            return Ok(sidebars);
        }

        [HttpPost("AddSidebar")]
        public IActionResult AddSidebar(Sidebar sidebar)
        {
            if (sidebar == null)
                return BadRequest("Invalid sidebar data.");
            var result = _sidebar.AddSidebar(sidebar);
            return Ok("Sidebar added successfully.");
        }
    }
}
