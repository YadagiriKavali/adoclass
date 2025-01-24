using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CURDDemoApp.Models
{
    public class CURDDemoAppContext : DbContext
    {
        public CURDDemoAppContext (DbContextOptions<CURDDemoAppContext> options)
            : base(options)
        {
        }

        //public DbSet<CURDDemoApp.Models.Employee> Employee { get; set; }

        //public DbSet<CURDDemoApp.Models.Department> Department { get; set; }

        //public DbSet<CURDDemoApp.Models.User> User { get; set; }

        //public DbSet<CURDDemoApp.Models.LoginProfile> LoginProfile { get; set; }

        public DbSet<CURDDemoApp.Models.AccountRegistrationVerification> AccountRegistrationVerification { get; set; }
        public DbSet<CURDDemoApp.Models.ApprovedData> ApprovedData { get; set; }
        public DbSet<CURDDemoApp.Models.AccountRegistration> AccountRegistration { get; set; } 

       
       
    }


    public class DSN_USER : DbContext
    {
        public DSN_USER(DbContextOptions<DSN_USER> options)
          : base(options)
        {
        }


        public DbSet<CURDDemoApp.Models.AccountRegistration> AccountRegistration { get; set; }
        public DbSet<CURDDemoApp.Models.AccountRegistrationVerification> AccountRegistrationVerification { get; set; }
        //public DbSet<CURDDemoApp.Models.AccountHolder> AccountHolder { get; set; }







    }




    }
