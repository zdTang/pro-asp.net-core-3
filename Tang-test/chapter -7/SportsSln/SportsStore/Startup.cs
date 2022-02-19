using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

namespace SportsStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<StoreDbContext>();
            // Configure DbContext option one
            /*services.AddDbContext<StoreDbContext>(opts =>
            {
                opts.UseSqlServer(Configuration["ConnectionStrings:SportsStoreConnection"]);
            });*/
            
            // By using Repository Pattern. we define an Interface and implement it 
            // We then register it as service
            // We can rely on Interface other than an solid implementation by DI
            
            services.AddScoped<IStoreRepository, EFStoreRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,StoreDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapRazorPages();
                endpoints.MapDefaultControllerRoute();
            });
            
            //SeedData.EnsurePopulated(app);
            SeedData.EnsurePopulated(context);
        }
    }
}
