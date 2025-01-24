using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDemoAppDeccan
{
    public class LogURLMiddleware
    {
        private readonly RequestDelegate _next;
        string message;
        public LogURLMiddleware(RequestDelegate next, UrlInfo url)//, object o1, object o2
        {
            message = url.str;
            _next = next;
        }
        public Task Invoke(HttpContext context)
        {
            Console.WriteLine(message + context.Request.Path);
            //Write code here to Save the URL in database or File
            // Call the next delegate/middleware in the pipeline
            return this._next(context);
        }
    }
   public  class UrlInfo
    {
        public string str;

    }
    public static class LogURLMiddlewareExtensions
    {
        public static IApplicationBuilder UseLogUrl(this IApplicationBuilder app, UrlInfo url)//, object ob1, object ob2
        {
            return app.UseMiddleware<LogURLMiddleware>(url);//ob1, ob2
        }
    }
}
