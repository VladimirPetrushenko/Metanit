using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateConveer
{
    public class ErrorHandleMiddleware
    {
        RequestDelegate _next;

        public ErrorHandleMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next.Invoke(context);

            if(context.Response.StatusCode == 403)
            {
                await context.Response.WriteAsync("Accept denied");
            }
            if(context.Response.StatusCode == 404)
            {
                await context.Response.WriteAsync("Page not found");
            }
        } 
    }
}
