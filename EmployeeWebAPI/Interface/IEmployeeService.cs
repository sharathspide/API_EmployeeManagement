using EmployeeWebAPI.Model;

namespace EmployeeWebAPI.Interface
{
    public interface IEmployeeService
    {
        Task<List<Employee_Model>> GetAllEmployeesAsync(int company_id);
        Task<Employee_Model?> GetEmployeeByIdAsync(int company_id, int employee_id);
    }
}
