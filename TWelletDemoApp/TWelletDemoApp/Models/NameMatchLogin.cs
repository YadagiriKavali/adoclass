using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TWelletDemoApp.Models
{
    public class NameMatchLogin
    {
        [Key]
        public int UserId { get; set; }
        public string EmpId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
