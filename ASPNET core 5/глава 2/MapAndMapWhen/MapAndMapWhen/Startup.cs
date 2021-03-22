using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapAndMapWhen
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Map("/index", app =>
            {
                app.Run(async context =>
                {
                    await context.Response.WriteAsync("Index Page from anonim delegate");
                });
            });

            app.Map("/about", About);

            app.Map("/home", home =>
            {
                home.Map("/contact", Contact);
                home.Map("/newTable", About);
                home.Run(async context => await context.Response.WriteAsync("this page was not found"));
            });

            app.MapWhen(context =>
            {
                return context.Request.Query.ContainsKey("id") &&
                        context.Request.Query["id"] == "5";
            }, Contact);

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Page not found");
            });
        }
        private static void About(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("About Page from new static method");
            });
        }
        private static void Contact(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Contact Page from new method");
            });
        }
    }
}
