using EmployeeWebAPI.DBModel;
using EmployeeWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Data
{
    public class EmployeeDbContext(DbContextOptions<EmployeeDbContext> options): DbContext(options)
    {
        public DbSet<EmployeeDBModel> Employees => Set<EmployeeDBModel>();
    }
}
