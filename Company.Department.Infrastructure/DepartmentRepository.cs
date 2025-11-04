using Company.Department.Application;
using Microsoft.EntityFrameworkCore;

namespace Company.Department.Infrastructure
{
    public class DepartmentRepository(AppDbContext _context) : IDepartmentRepository
    {
        private readonly AppDbContext context=_context;

        public async Task<ICollection<Domain.DepartmentC>> GetDepartments()
        {
            var depts = await context.Departments.ToListAsync();
            return depts;
        }
        public async Task<Domain.DepartmentC> AddEmployee(DepartmentDTO deptDto)
        {
            var dept = new Domain.DepartmentC
            {
                deptName = deptDto.deptName
            };

            await context.Departments.AddAsync(dept);
            await context.SaveChangesAsync();
            return dept;

        }

        public async Task<Domain.DepartmentC> UpdateEmployee(int id, DepartmentDTO deptDto)
        {
            var dept = await context.Departments.FindAsync(id);

            if(dept is not null)
            {
                dept.deptName = deptDto.deptName;
                context.Departments.Update(dept);
                await context.SaveChangesAsync();

            }
            return dept;
        }
        public async Task<Domain.DepartmentC> DeleteEmployee(int id)
        {
            var dept = await context.Departments.FindAsync(id);

            if (dept is not null)
            {
                context.Departments.Remove(dept);
                await context.SaveChangesAsync();

            }
            return dept;
        }

        public async Task<Domain.DepartmentC> GetDepartmentById(int id)
        {
            var dept = await context.Departments.FindAsync(id);

            return dept;
        }

    }
}
