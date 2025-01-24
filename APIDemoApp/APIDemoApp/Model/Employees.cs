using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemoApp.Model
{
    public class Employees
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string salary { get; set; }

    }
}
