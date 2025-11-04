using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Employee.Application
{
    public interface IEmployeeRepository
    {
        public  Task<ICollection<Domain.Employee>> GetEmployees();
        public  Task<Domain.Employee> AddEmployee(EmployeeDTO employee);

        public Task<Domain.Employee> UpdateEmployee(int id, EmployeeDTO employeeDTO);
        public Task<Domain.Employee> DeleteEmployee(int id);
        public Task<Domain.Employee> GetEmployeeById(int id);
    }
}
