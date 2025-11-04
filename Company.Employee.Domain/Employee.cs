using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Employee.Domain
{
    public class Employee
    {
        [Key]
        public int empId { get; set; }
        public  string empName { get; set; }
    }
}
