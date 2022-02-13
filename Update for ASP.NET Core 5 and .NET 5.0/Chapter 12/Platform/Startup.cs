using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Platform {
    public class Startup {

        public void ConfigureServices(IServiceCollection services) {
            services.Configure<MessageOptions>(options => {
                options.CityName = "Albany";
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Create a custom Middle ware: Approach one
            // The downside of this approach is it is not easy to re-use this middleware
            app.Use(async (context, next) =>
            {
                if(context.Request.Method==HttpMethods.Get && context.Request.Query["custom"]=="true")
                {
                    await context.Response.WriteAsync("Custom Middleware \n");
                }
                await next();
            });
            //Add custom middleware: Approach two
            app.UseMiddleware<QueryStringMiddleWare>();
            //app.UseMiddleware<LocationMiddleware>();

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapGet("/", async context => {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
