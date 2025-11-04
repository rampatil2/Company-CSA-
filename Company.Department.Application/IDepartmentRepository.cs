namespace Company.Department.Application
{
    public interface IDepartmentRepository
    {
        public Task<ICollection<Domain.DepartmentC>> GetDepartments();
        public Task<Domain.DepartmentC> AddEmployee(DepartmentDTO deptDto);

        public Task<Domain.DepartmentC> UpdateEmployee(int id, DepartmentDTO deptDto);
        public Task<Domain.DepartmentC> DeleteEmployee(int id);
        public Task<Domain.DepartmentC> GetDepartmentById(int id);
    }
}
