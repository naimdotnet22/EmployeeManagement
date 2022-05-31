using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeInfo.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddEditEmployee(Employee employee);
        Task<string> DeleteEmployee(Employee employee);
        Task<Employee> GetEmployeeById(int id);
        Task<List<Employee>> GetEmployees();
    }
}