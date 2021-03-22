using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CreateMyServices
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMessageSender, EmailMessageSender>();
            services.AddTransient<IUpTimeService, UpTimeServiceSecond>();
        }

        public void Configure(IApplicationBuilder app, IMessageSender messageSender)
        {
            messageSender = new SmsMessageSender();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(messageSender.Send());
            });
        }
    }
}
