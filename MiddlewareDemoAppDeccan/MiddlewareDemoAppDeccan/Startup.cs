﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MiddlewareDemoAppDeccan
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        private static void HandleMapTest1(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Map Test 1---<br>----");
            });
        }
       

        //    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        //{



        //    app.Map("/map1", HandleMapTest1);
        //    app.Map("/map2", app1 =>
        //    {
        //        app1.Run(async context1 =>
        //        {
        //            await context1.Response.WriteAsync("Map Test 2--<br>----");
        //        });
        //    });

        //    //app.Use(async (context, next) =>
        //    //{
        //    //    // Do work that doesn't write to the Response.
        //    //    await context.Response.WriteAsync("Before from Use1!----<br>");
        //    //    await next.Invoke();
        //    //    await context.Response.WriteAsync("After from Use1-----<br>");
        //    //    // Do logging or other work that doesn't write to the Response.
        //    //});
        //    //app.Use(async (context, next) =>
        //    //{
        //    //    // Do work that doesn't write to the Response.
        //    //    await context.Response.WriteAsync("Before from Use2-----<br>");
        //    //    await next.Invoke();
        //    //    await context.Response.WriteAsync("After from Use2-----<br>");
        //    //    //await next.Invoke();
        //    //    // Do logging or other work that doesn't write to the Response.
        //    //});
        //    app.Run(async context =>
        //    {
        //        await context.Response.WriteAsync("From Run Nan Map Delegate----<br>");
        //    });

        //}

        //This method gets called by the runtime.Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            UrlInfo url = new UrlInfo()
            {
                str = "------------------This IS The LogOutPut-----------------"
            };
            app.UseLogUrl(url);
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

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
