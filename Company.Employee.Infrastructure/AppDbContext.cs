using Microsoft.EntityFrameworkCore;

namespace Company.Employee.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        public DbSet<Domain.Employee> Employees { get; set; }
    }
}
