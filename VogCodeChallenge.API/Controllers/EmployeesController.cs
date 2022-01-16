using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.Services.Services.Interfaces;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employees = _employeeService.GetAll();

            return StatusCode(statusCode: StatusCodes.Status200OK, employees);
        }

        [HttpGet]
        [Route("department/{departmentId:long}")]
        public IActionResult GetByDepartment([FromRoute]long departmentId)
        {
            var employees = _employeeService.GetByDepartment(departmentId);

            return StatusCode(statusCode: StatusCodes.Status200OK, employees);
        }
    }
}
