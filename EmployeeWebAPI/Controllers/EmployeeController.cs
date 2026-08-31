using Microsoft.AspNetCore.Mvc;
using EmployeeWebAPI.Model;
using EmployeeWebAPI.Interface;

namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService) 
        { 
            _employeeService = employeeService;
        }
        
        [HttpGet("{company_id}")]
        public async Task<ActionResult<List<Employee_Model>>> GetAllEmployee(int company_id)
        {
            try
            {
                var result = await _employeeService.GetAllEmployeesAsync(company_id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, "An error occurred while retrieving employees.");
            }
        }
    }
}
