
using Microsoft.AspNetCore.Mvc;

using SSHealthCare.Domain.Interfaces;

namespace SSHealthCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatus _status;
        public StatusController (IStatus status)
        {
            _status = status;
        }
        [HttpGet("GetAllStatus")]
        public IActionResult GetAllStatus() 
        {
            return Ok(_status.GetAllStatus());
        }
    }
}
