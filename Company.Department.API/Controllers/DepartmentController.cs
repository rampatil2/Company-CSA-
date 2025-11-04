using Company.Department.Application;
using Microsoft.AspNetCore.Mvc;

namespace Company.Department.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController(IDepartmentRepository departmentRepository) : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository = departmentRepository;
        [HttpGet]
        public async Task<IActionResult> GetDepartments()
        {
          var dept = await   _departmentRepository.GetDepartments();
            return Ok(dept);
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartment(DepartmentDTO deptDto)
        {
            var dept= await _departmentRepository.AddEmployee(deptDto);

            return Ok(dept);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateDepartment(int id , DepartmentDTO deptDto)
        {
            var dept = await _departmentRepository.UpdateEmployee(id, deptDto);
            return Ok(dept);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult > DeleteEmployee(int id)
        {
            var dept= await _departmentRepository.DeleteEmployee(id);
            return Ok(dept);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var dept=await _departmentRepository.GetDepartmentById(id);
            return Ok(dept);
        }
    }
}
