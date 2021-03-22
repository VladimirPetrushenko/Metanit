using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingApp
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
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.Use(async (context, next) =>
            {
                Endpoint endpoint = context.GetEndpoint();

                if (endpoint != null)
                {
                    var routingPattern = (endpoint as Microsoft.AspNetCore.Routing.RouteEndpoint)?.RoutePattern.RawText;

                    await context.Response.WriteAsync($"Name: {endpoint.DisplayName} <p></p>");
                    await context.Response.WriteAsync($"Route pattern: {routingPattern}<p></p>");
                }
                else
                {
                    await context.Response.WriteAsync("End point is not defined");
                }
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });

                endpoints.MapGet("/index", async context =>
                {
                    await context.Response.WriteAsync("Hello Index!");
                });

                endpoints.MapGet("/about", async context =>
                {
                    await context.Response.WriteAsync("Hello About!");
                });
            });
        }
    }
}
