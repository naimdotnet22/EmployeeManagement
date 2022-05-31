using Microsoft.EntityFrameworkCore;
using Models;

namespace EmployeeInfo.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
