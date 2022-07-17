using Microsoft.EntityFrameworkCore;

namespace Student_API.Models
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
