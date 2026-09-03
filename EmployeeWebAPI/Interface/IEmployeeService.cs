using EmployeeWebAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Interface
{
    public interface IEmployeeService
    {
        Task<List<Employee_Model>> GetAllEmployeesAsync(int company_id);
        Task<Employee_Model?> GetEmployeeByIdAsync(int company_id, int employee_id);
        Task<bool> CreateEmployeeAsync(Employee_Model employee, bool isNewEmployee);
    }
}
