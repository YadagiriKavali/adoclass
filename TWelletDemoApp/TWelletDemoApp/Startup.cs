using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TWelletDemoApp.Models;
//using TWelletDemoApp.Data;

namespace TWelletDemoApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            // Configure session settings
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(50); // Session timeout
                options.Cookie.HttpOnly = true; // Makes the cookie HTTP-only
                options.Cookie.IsEssential = true; // Mark the cookie as essential
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<Semi_C3_StandardizedContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("DSN_USER"),
                   sqlOptions => sqlOptions.CommandTimeout(50) // Timeout in seconds
               )
               );


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=LoginProfiles}/{action=Login}/{id?}");
            });
        }
    }
}
