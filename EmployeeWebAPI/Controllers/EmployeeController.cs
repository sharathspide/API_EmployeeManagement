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

        [HttpGet]
        public async Task<ActionResult<Employee_Model>> GetEmployeeByIdAsync([FromQuery] int company_id, [FromQuery] int employee_id)
        {
            try
            {
                var employee = await _employeeService.GetEmployeeByIdAsync(company_id, employee_id);
                if (employee == null)
                {
                    return NotFound("Not able to fetch the required data!!");
                }
                return Ok(employee);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, "An error occurred while retrieving employees.");
            }
        }
    }
}
