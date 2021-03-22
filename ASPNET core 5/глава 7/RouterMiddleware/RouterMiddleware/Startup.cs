using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouterMiddleware
{

    //public class Startup
    //{
    //    public void Configure(IApplicationBuilder app)
    //    {
    //        var routeBuilder = new RouteBuilder(app);

    //        routeBuilder.MapMiddlewareGet("{controller}/{action}", app =>
    //        {
    //            app.Run(async context =>
    //            {
    //                await context.Response.WriteAsync("Hello from MapMiddlewareGet");
    //            });
    //        });
    //        app.UseRouter(routeBuilder.Build());
    //        app.Run(async (context) =>
    //        {
    //            await context.Response.WriteAsync("Hello World!");
    //        });
    //    }
    //}

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
            var myRouteHandle = new RouteHandler(async context =>
            {
                await context.Response.WriteAsync("Hello Asp.net core Router<p></p>");
                var content = context.GetRouteValue("controller").ToString();
                await context.Response.WriteAsync("Controller:" + content + "<p></p>");
                content = context.GetRouteValue("a").ToString();
                await context.Response.WriteAsync("action:" + content + "<p></p>");
            });

            var routeBuilder = new RouteBuilder(app, myRouteHandle);

            routeBuilder.MapRoute("default", "{controller:double}/{a=index}",null,constraints: new { a = new AlphaRouteConstraint() });

            app.UseRouter(routeBuilder.Build());


            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello World<p></p>");
                await context.Response.WriteAsync(context.Request.Path);
            });
        }

    }
}
