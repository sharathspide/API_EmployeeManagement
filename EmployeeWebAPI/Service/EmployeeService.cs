using EmployeeWebAPI.Interface;
using EmployeeWebAPI.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Service
{
    public class EmployeeService : IEmployeeService
    {
        //mock Data
        public List<Employee_Model> employees_Data = new List<Employee_Model> { 
            // Company: 1
            new Employee_Model { 
                employee_id = 1, 
                company_id = 1,
                employee_name = "Sharath RA",
                address = new Address { 
                    permanantAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99", 
                    presentAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99"
                },
                zipcode = "600099",
                authorized_admin = 1,
                country = "India",
                state = "Tamil Nadu",
                created_by = 1,
                updated_by = 1,
                created_date = DateTime.Now,
                updated_date = DateTime.Now,
                contact_number = new Contact
                {
                    mobileNumber = "+91 8825575005",
                    phoneNumber = "1234567890",
                },
                dateOfJoining = DateTime.Now,
                lastLoginDate = DateTime.Now,
                lastLoginTime = TimeOnly.FromDateTime(DateTime.Now),
                yearsOfExperiance = " ",
            },
            // Company: 1
            new Employee_Model {
                employee_id = 2,
                company_id = 1,
                employee_name = "Sharathspide",
                address = new Address {
                    permanantAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99",
                    presentAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99"
                },
                zipcode = "600099",
                authorized_admin = 1,
                country = "India",
                state = "Tamil Nadu",
                created_by = 1,
                updated_by = 2,
                created_date = DateTime.Now,
                updated_date = DateTime.Now,
                contact_number = new Contact
                {
                    mobileNumber = "+91 8825575005",
                    phoneNumber = "1234567890",
                },
                dateOfJoining = DateTime.Now,
                lastLoginDate = DateTime.Now,
                lastLoginTime = TimeOnly.FromDateTime(DateTime.Now),
                yearsOfExperiance = " ",
            },
            // Company: 1
            new Employee_Model {
                employee_id = 3,
                company_id = 1,
                employee_name = "Sachin",
                address = new Address {
                    permanantAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99",
                    presentAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99"
                },
                zipcode = "600099",
                authorized_admin = 1,
                country = "India",
                state = "Tamil Nadu",
                created_by = 1,
                updated_by = 3,
                created_date = DateTime.Now,
                updated_date = DateTime.Now,
                contact_number = new Contact
                {
                    mobileNumber = "+91 8825575005",
                    phoneNumber = "1234567890",
                },
                dateOfJoining = DateTime.Now,
                lastLoginDate = DateTime.Now,
                lastLoginTime = TimeOnly.FromDateTime(DateTime.Now),
                yearsOfExperiance = " ",
            },
            // Company: 2
            new Employee_Model {
                employee_id = 4,
                company_id = 2,
                employee_name = "Sharath RA",
                address = new Address {
                    permanantAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99",
                    presentAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99"
                },
                zipcode = "600099",
                authorized_admin = 4,
                country = "India",
                state = "Tamil Nadu",
                created_by = 4,
                updated_by = 4,
                created_date = DateTime.Now,
                updated_date = DateTime.Now,
                contact_number = new Contact
                {
                    mobileNumber = "+91 8825575005",
                    phoneNumber = "1234567890",
                },
                dateOfJoining = DateTime.Now,
                lastLoginDate = DateTime.Now,
                lastLoginTime = TimeOnly.FromDateTime(DateTime.Now),
                yearsOfExperiance = " ",
            },
            // Company: 2
            new Employee_Model {
                employee_id = 5,
                company_id = 2,
                employee_name = "sharathspide",
                address = new Address {
                    permanantAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99",
                    presentAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99"
                },
                zipcode = "600099",
                authorized_admin = 4,
                country = "India",
                state = "Tamil Nadu",
                created_by = 4,
                updated_by = 4,
                created_date = DateTime.Now,
                updated_date = DateTime.Now,
                contact_number = new Contact
                {
                    mobileNumber = "+91 8825575005",
                    phoneNumber = "1234567890",
                },
                dateOfJoining = DateTime.Now,
                lastLoginDate = DateTime.Now,
                lastLoginTime = TimeOnly.FromDateTime(DateTime.Now),
                yearsOfExperiance = " ",
            },
            // Company = 2
            new Employee_Model {
                employee_id = 6,
                company_id = 2,
                employee_name = "Ashwin",
                address = new Address {
                    permanantAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99",
                    presentAddress = "No.17/A, 5th Street, Indra Nagar, Puthagaram, Vinayagapuram, CHennai-99"
                },
                zipcode = "600099",
                authorized_admin = 4,
                country = "India",
                state = "Tamil Nadu",
                created_by = 4,
                updated_by = 5,
                created_date = DateTime.Now,
                updated_date = DateTime.Now,
                contact_number = new Contact
                {
                    mobileNumber = "+91 8825575005",
                    phoneNumber = "1234567890",
                },
                dateOfJoining = DateTime.Now,
                lastLoginDate = DateTime.Now,
                lastLoginTime = TimeOnly.FromDateTime(DateTime.Now),
                yearsOfExperiance = " ",
            }
        };

        /// <summary>
        /// Get all employees for the company 
        /// </summary>
        /// <param name="company_id"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<List<Employee_Model>> GetAllEmployeesAsync(int company_id)
        {
            try
            {
                var employees = new List<Employee_Model>();
                if (company_id == 0)
                {
                    throw new ArgumentException($"Invalid company Information, {company_id}");
                }
                else
                {
                    //employees = employees_Data.Select(x => x.company_id == company_id).ToList();
                    employees = employees_Data.FindAll(x => x.company_id == company_id);
                }
                if (employees.Any() && employees != null)
                {
                    return await Task.FromResult(employees);
                }
                else
                {
                    throw new Exception("No Employees found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
                throw;
            }
        }

        /// <summary>
        /// Get an employee detail for a company based on the id of the user
        /// </summary>
        /// <param name="company_id"></param>
        /// <param name="employee_id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<Employee_Model?> GetEmployeeByIdAsync(int company_id, int employee_id) 
        {
            try
            {
                var employee = new Employee_Model();
                if (company_id != 0 && employee_id != 0)
                {
                    employee = employees_Data.FirstOrDefault(x => x.company_id == company_id && x.employee_id == employee_id);
                }
                else
                {
                    throw new Exception("Invalid Company or Employee search");
                }
                return await Task.FromResult(employee);
            }
            catch (Exception e)
            {  
                Console.WriteLine(e.Message );
                throw new Exception($"Something went wrong while searching or getting the employee {e.Message}", e);
            }
        }
    }
}
