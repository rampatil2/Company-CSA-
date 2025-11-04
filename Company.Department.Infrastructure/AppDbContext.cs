using Microsoft.EntityFrameworkCore;

namespace Company.Department.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }
        
      public DbSet<Domain.DepartmentC> Departments { get; set; }
    }
}
