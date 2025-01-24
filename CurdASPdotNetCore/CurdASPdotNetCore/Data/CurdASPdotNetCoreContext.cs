using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CurdASPdotNetCore.Models;

namespace CurdASPdotNetCore.Models
{
    public class CurdASPdotNetCoreContext : DbContext
    {
        public CurdASPdotNetCoreContext (DbContextOptions<CurdASPdotNetCoreContext> options)
            : base(options)
        {
        }
    

        public DbSet<CurdASPdotNetCore.Models.Employee> Employee { get; set; }
        public DbSet<CurdASPdotNetCore.Models.Department> Department { get; set; }
    }

}
