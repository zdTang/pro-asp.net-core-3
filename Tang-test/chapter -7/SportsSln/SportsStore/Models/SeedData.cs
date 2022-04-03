using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace SportsStore.Models
{
    public static class SeedData
    {
        // IApplicationBuilder is used for setup pipeline, such as middleware
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            // Access Dbcontext via app
            // Can we access DbContext via DI ?
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider
                .GetRequiredService<StoreDbContext>();

            //if (context.Database.GetPendingMigrations().Any())--Original synchronous approach
            //if pending migrations, then migrate it to database
            if (context.Database.GetPendingMigrationsAsync().GetAwaiter().GetResult().Any())
            {
                //context.Database.Migrate();
                await context.Database.MigrateAsync();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(new Product
                {
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Category = "Watersports",
                    Price = 275
                },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Human Chess Board",
                        Description = "A fun game for the family",
                        Category = "Chess",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess",
                        Price = 1200
                    });
                //context.SaveChanges();
                await context.SaveChangesAsync();
            }
        }
    }
}