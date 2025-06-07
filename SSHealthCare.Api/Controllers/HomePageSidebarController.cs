using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;

namespace SSHealthCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageSidebarController : ControllerBase
    {
        public readonly IHomePageSidebar _homepagesidebar;
        public HomePageSidebarController(IHomePageSidebar homepagesidebar)
        {
            _homepagesidebar = homepagesidebar;
        }

        [HttpGet("GetAllHomeSidebar")]
        public IActionResult GetAllHomeSidebar()
        {
            return Ok(_homepagesidebar.GetAllHomePageSidebar());
        }

        [HttpGet("GetAllHomeSidebarByTechId")]
        public IActionResult GetAllHomeSidebarByTechId(int Id)
        {
            return Ok(_homepagesidebar.GetAllHomeSidebarByTechId(Id));
        }

        [HttpPost("AddHomeSidebar")]
        public IActionResult AddHomeSidebar(HomePageSidebar homePageSidebar)
        {
            if (homePageSidebar == null)
                return BadRequest("Invalid homePageSidebar data.");
            var result = _homepagesidebar.AddHomePageSidebar(homePageSidebar);
            return Ok("homePageSidebar added successfully.");
        }
    }
}
