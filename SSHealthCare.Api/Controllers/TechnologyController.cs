using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;

namespace SSHealthCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly ITechnology _technology;
        public TechnologyController(ITechnology technology)
        {
            _technology = technology;
        }
        [HttpGet("GetAlltechnology")]
        public IActionResult GetAlltechnology()
        {
            return Ok(_technology.GetAllTechnology());
        }
        [HttpPost("Addtechnology")]
        public IActionResult Addtechnologyy(Technology technology)
        {
            if (technology == null)
                return BadRequest("Invalid technology data.");
            var result = _technology.AddTechnology(technology);
            return Ok("technology added successfully.");
        }
    }
}
