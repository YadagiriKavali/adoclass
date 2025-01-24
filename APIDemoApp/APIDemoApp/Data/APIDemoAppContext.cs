using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIDemoApp.Model;

namespace APIDemoApp.Models
{
    public class APIDemoAppContext : DbContext
    {
        public APIDemoAppContext (DbContextOptions<APIDemoAppContext> options)
            : base(options)
        {
        }

        public DbSet<APIDemoApp.Model.Employees> Employees { get; set; }
    }
}
