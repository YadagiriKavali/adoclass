using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CURDOprations.Models
{
    public class CURDOprationsContext : DbContext
    {
        public CURDOprationsContext (DbContextOptions<CURDOprationsContext> options)
            : base(options)
        {
        }

        public DbSet<CURDOprations.Models.Employee> Employee{ get; set; }
        public DbSet<CURDOprations.Models.Department> Department{ get; set; }
    }
}
