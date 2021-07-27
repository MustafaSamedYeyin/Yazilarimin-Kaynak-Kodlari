using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HashNode.WebApp
{
    public class Startup
    {
      

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello World");
                await next();
            });
            app.Map("/Mustafa", (config) =>
            {
                config.Run(async (context) =>
                {
                   await context.Response.WriteAsync(" Hello Mustafa");
                });
            });
        }
    }
}
