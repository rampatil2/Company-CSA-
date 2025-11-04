using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Department.Domain
{
    public class DepartmentC
    {
        [Key]
        public int deptId { get; set; }
        public string deptName { get; set; }
    }
}
