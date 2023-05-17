using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs.Employee
{
    public class EmployeeCreateDto
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
