using Company.Employee.Application;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Employee.Infrastructure
{
    public class EmployeeRepository(AppDbContext _context) : IEmployeeRepository
    {
        private readonly AppDbContext context=_context;

        public async Task<ICollection<Domain.Employee>> GetEmployees()
        {
           var employees=  await context.Employees.ToListAsync();

            return  employees;
        }

        public async Task<Domain.Employee> AddEmployee( EmployeeDTO employee)
        {
            var emp = new Domain.Employee { 
                empName=employee.empName, 
            };

            await context.Employees.AddAsync(emp);
            await context.SaveChangesAsync();
            return emp;
        }

        public async Task<Domain.Employee> UpdateEmployee(int id, EmployeeDTO employeeDTO)
        {
            var emp = await context.Employees.FindAsync(id);
            if(emp is not null)
            {
                emp.empName = employeeDTO.empName;
                context.Employees.Update(emp);
                await context.SaveChangesAsync();
            }

            return emp;
        }
        public async Task<Domain.Employee> DeleteEmployee(int id)
        {
            var emp = await context.Employees.FindAsync(id);
            if(emp is not null)
                 context.Employees.Remove(emp);
            await context.SaveChangesAsync();

            return emp;
        }
        public async Task<Domain.Employee> GetEmployeeById(int id)
        {
            var emp = await context.Employees.FindAsync(id);
            return emp;
        }
    }
}
