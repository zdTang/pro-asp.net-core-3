using System;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Models;

namespace WebApp
{
    public static class WebServiceEndPoint
    {
        private static string BASEURL = "api/products";

        public static void MapWebService(this IEndpointRouteBuilder app)
        {
            // Retrieve specified Data
            app.MapGet($"{BASEURL}/{{id}}", async context =>
            {
                long key = long.Parse((context.Request.RouteValues["id"] as string)!);
                DataContext data = context.RequestServices.GetService<DataContext>();
                Product p = await data!.Products.FindAsync(key);
                if (p == null)
                {
                    context.Response.StatusCode = StatusCodes.Status404NotFound;
                }
                else
                {
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(JsonSerializer.Serialize<Product>(p));
                }
            });
            // Retrieve all data
            app.MapGet(BASEURL, async context =>
            {
                DataContext data = context.RequestServices.GetService<DataContext>();
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(JsonSerializer.Serialize<IEnumerable<Product>>(data!.Products));
            });
            // Post Data
            app.MapPost(BASEURL, async context =>
            {
                
                DataContext data = context.RequestServices.GetService<DataContext>();
                Product p = await JsonSerializer.DeserializeAsync<Product>(context.Request.Body);
                await data!.AddAsync(p!);
                await data.SaveChangesAsync();
                context.Response.StatusCode = StatusCodes.Status200OK;
             });
            
            
        }
    }
}