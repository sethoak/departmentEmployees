using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentsEmployeeAPI.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department Name is required")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Department Name should be between 2 and 10 characters")]
        public string DeptName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
