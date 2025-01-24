using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CURDCore.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string DeptName { get; set; }

        [Required]
        public bool IsActive { get; set; }

        // Navigation property to establish the one-to-many relationship with Employee
        public ICollection<Employee> Employees { get; set; }
    }


    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FKDeptId { get; set; }

        [Required]
        [StringLength(255)]
        public string EmpName { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Salary { get; set; }

        [Required]
        public bool IsActive { get; set; }

        // Navigation property to establish the many-to-one relationship with Department
        [ForeignKey("FKDeptId")]
        public Department Department { get; set; }
    }
}
