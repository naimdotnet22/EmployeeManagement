using EmployeeInfo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employee;
        public EmployeeController(IEmployeeRepository employee)
        {
            _employee = employee;
        }

        [HttpGet("GetEmployees")]
        public async Task<List<Employee>> GetEmployees()
        {
            return await _employee.GetEmployees();
        }

        [HttpGet("GetEmployeeById/{id}")]
        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _employee.GetEmployeeById(id);
        }

        [HttpPost("AddEditEmployee")]
        public async Task<Employee> AddEditEmployee(Employee employee)
        {
            return await _employee.AddEditEmployee(employee);
        }

        [HttpPost("DeleteEmployee")]
        public async Task<string> DeleteEmployee(Employee employee)
        {
            return await _employee.DeleteEmployee(employee);
        }
    }
}
