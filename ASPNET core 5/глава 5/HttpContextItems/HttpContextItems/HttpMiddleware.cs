using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpContextItems
{
    public class HttpMiddleware
    {
        RequestDelegate _next;
        public HttpMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.ContentType = "text/html; charset=utf-8";
            context.Items["text"] = "new text in middleware class  <p></p>";
            await _next.Invoke(context);
        }
    }

    public class ContextView
    {
        RequestDelegate _next;
        public ContextView(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync(context.Items["text"].ToString());
            context.Items["text"] = "new text  ";
            context.Items.Add(1, "Здрасте<p></p>");
            await _next.Invoke(context);
        }
    }
}
