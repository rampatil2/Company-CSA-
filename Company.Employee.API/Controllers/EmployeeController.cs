using Company.Employee.Application;
using Microsoft.AspNetCore.Mvc;

namespace Company.Employee.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
           var employees= await _employeeRepository.GetEmployees();

            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeDTO employeeDTO )
        {
           var employee = await _employeeRepository.AddEmployee(employeeDTO);

            return Ok(employee);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeeDTO dto)
        {
           var emp = await _employeeRepository.UpdateEmployee(id, dto);

            return Ok(emp);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
           var emp = await _employeeRepository.DeleteEmployee(id);

            return Ok(emp);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
           var emp=  await _employeeRepository.GetEmployeeById(id);

            return Ok(emp);

        }
    }
}
