using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CreatedNewMiddleware
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate _next;
        private string pattern;

        public TokenMiddleware(RequestDelegate next, string pattern)
        {
            this._next = next;
            this.pattern = pattern;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["token"];
            if (token != pattern)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Token is invalid");
            }
            else
            {
                await context.Response.WriteAsync("Vse normalno\n");
                await _next.Invoke(context);
            }
        }
    }
}
