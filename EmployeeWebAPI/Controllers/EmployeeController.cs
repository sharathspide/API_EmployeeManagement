using Microsoft.AspNetCore.Mvc;
using EmployeeWebAPI.Model;

namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public List<Employee_Model> employees = new List<Employee_Model>
        {
            new Employee_Model()
        };

        [HttpGet("{company_id}")]
        public ActionResult<List<Employee_Model>> GetAllEmployee(int company_id)
        {
            // return all employees or filter by company_id as needed
            var result = employees.FindAll(e => e.company_id == company_id);
            return Ok(result);
        }
    }
}
