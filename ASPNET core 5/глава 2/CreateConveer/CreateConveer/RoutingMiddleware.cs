using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateConveer
{
    public class RoutingMiddleware
    {
        RequestDelegate _next;

        public RoutingMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path.Value.ToLower();

            if(path == "/" || path == "/index")
            {
                await context.Response.WriteAsync("Home page");
            }
            else if (path == "/about")
            {
                await context.Response.WriteAsync("About page");
            }
            else
            {
                context.Response.StatusCode = 404;
            }
        }
    }
}
