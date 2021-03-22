using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace LoggerInAspNet
{
    public class LoggerMiddleware
    {
        RequestDelegate _next;
        ILogger<LoggerMiddleware> logger;

        public LoggerMiddleware(RequestDelegate next, ILogger<LoggerMiddleware> logger)
        {
            _next = next;
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            logger.LogInformation("Processing request {0}", context.Request.Path);
            await context.Response.WriteAsync("Hello<p></p>");
            await _next.Invoke(context);
        }
    }
}
