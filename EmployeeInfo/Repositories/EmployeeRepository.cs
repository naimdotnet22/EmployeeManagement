using EmployeeInfo.DbContexts;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;
        public EmployeeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Employee>> GetEmployees()
        {
            try
            {
                List<Employee> employees = _dbContext.Employees.ToList();
                return Task.FromResult(employees);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<Employee> GetEmployeeById(int id)
        {
            try
            {
                Employee employee = _dbContext.Employees.Find(id);
                return Task.FromResult(employee);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public Task<Employee> AddEditEmployee(Employee employee)
        {
            if (employee.Id > 0)
            {
                try
                {
                    _dbContext.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    Save();
                    return Task.FromResult(employee);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                try
                {
                    _dbContext.Employees.Add(employee);
                    Save();
                    return Task.FromResult(employee);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


        //public Task<Employee> DeleteEmployee(int id)
        //{
        //    try
        //    {
        //        var employee = _dbContext.Employees.Find(id);
        //        _dbContext.Employees.Remove(employee);
        //        Save();
        //        return Task.FromResult(employee);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}


        public Task<string> DeleteEmployee(Employee employee)
        {
            try
            {
                _dbContext.Employees.Remove(employee);
                Save();
                return Task.FromResult(employee.Name + " Deleted Successfully");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
