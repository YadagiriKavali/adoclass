using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CURDOprations.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string DeptName { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Department")]
        public int FKDeptId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public Department Departments{ get; set; }
    }
}
