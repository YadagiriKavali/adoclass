using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CURDCore.Models;

namespace CURDCore.Models
{
    public class CURDCoreContext : DbContext
    {
        public CURDCoreContext (DbContextOptions<CURDCoreContext> options)
            : base(options)
        {
        }

        public DbSet<CURDCore.Models.Employee> Employee { get; set; }

        public DbSet<CURDCore.Models.Department> Department { get; set; }
    }
}
