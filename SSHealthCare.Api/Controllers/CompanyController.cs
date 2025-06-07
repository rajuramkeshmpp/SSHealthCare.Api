
using Microsoft.AspNetCore.Mvc;
using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;

namespace SSHealthCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompany _company;
        public CompanyController(ICompany company)
        {
            _company = company;
        }
        [HttpGet("GetAllCompany")]
        public IActionResult GetAllCompany()
        {
            return Ok(_company.GetAllCompany());
        }

        [HttpGet("GetCompanyById/{id}")]
        public IActionResult GetCompanyById(int id)
        {
            var company = _company.GetComapnyById(id);
            if (company == null)
                return NotFound($"Company with ID {id} not found.");

            return Ok(company);
        }

        [HttpPut("UpdateCompany")]
        public IActionResult UpdateCompany( Company company)
        {
         
            var result = _company.UpdateCompany(company);
            return Ok("Company updated successfully.");

        }

        [HttpPost("AddCompany")]
        public IActionResult AddCompany(Company company)
        {
            if (company == null)
                return BadRequest("Invalid company data.");
            var result = _company.AddComapany(company);
            return Ok("company added successfully.");
        }

        [HttpDelete("DeleteCompany/{id}")]
        public IActionResult DeleteCompany(int id)
        {
            var result = _company.DeleteCompany(id);
            return Ok("Company deleted successfully.");
        }
    }
}
