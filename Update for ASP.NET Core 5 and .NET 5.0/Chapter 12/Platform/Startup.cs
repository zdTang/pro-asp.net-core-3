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
                options.CityName = "Albany";  // Dependency Injection and override the default value as well  
            });
        }
        
        // pass IOptions parameter to this method.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IOptions<MessageOptions> msgOptions) {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Test middleware work with return pipeline
             /*
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Custom Middleware1 --coming \n");
                await next();
                await context.Response.WriteAsync($"\n Custom Middleware1 --Status Code:{context.Response.StatusCode}");
            });
            
            // Short-Circuiting

            app.Use(async (context, next) =>
            {
                if (context.Request.Path.ToString() == "/short")
                {
                    await context.Response.WriteAsync($"Request Short Circuited");
                    // short-circuiting the sequential middleware at this point !
                    // Be aware, here we are not pass execution to next() any more !!
                }
                else
                {
                    await next();
                }
                
            });
                 
            
             // Configuration with options pattern

             app.Use(async (context, next) =>
             {
                 if (context.Request.Path.ToString() == "/location")
                 {
                     MessageOptions opts = msgOptions.Value;
                     await context.Response.WriteAsync($"this is {opts.CountryName},{opts.CityName}");
                     // short-circuiting the sequential middleware at this point !
                     // Be aware, here we are not pass execution to next() any more !!
                 }
                 else
                 {
                     await next();
                 }
                
             });
             
        */
            /*
            // Create a custom Middle ware: Approach one
            // The downside of this approach is it is not easy to re-use this middleware
            app.Use(async (context, next) =>
            {
                if(context.Request.Method==HttpMethods.Get && context.Request.Query["custom"]=="true")
                {
                    await context.Response.WriteAsync("Custom Middleware2 \n");
                }
                await next();
                await context.Response.WriteAsync($"\n Custom Middleware2 --Status Code:{context.Response.StatusCode}");
            });
            //branch
            app.MapWhen(context=>context.Request.Query.Keys.Contains("branch"), branch =>
            {
                //branch.UseMiddleware<QueryStringMiddleWare>();
                branch.Run(new QueryStringMiddleWare().Invoke);  // Invoke is the method of middleware
                branch.Run(async (context) =>
                {
                    await context.Response.WriteAsync($"Branch Middleware");
                    // By using "Run" explicitly, no opportunity to pass the execution to "next"
                });
            });
            
            
            */
            
            //Add custom middleware: Approach two
            //app.UseMiddleware<QueryStringMiddleWare>();
            app.UseMiddleware<LocationMiddleware>();

            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapGet("/", async context => {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
