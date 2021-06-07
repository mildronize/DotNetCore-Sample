using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Mild.EF.RazorPage.Example.ContosoUniversity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Mild.EF.RazorPage.Example.ContosoUniversity
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Performance considerations 
            // In general, a web page shouldn't be loading an arbitrary number of rows. 
            // A query should use paging or a limiting approach. For example, the preceding 
            // query could use Take to limit the rows returned:
            // 
            // Enumerating a large table in a view could return a partially constructed HTTP 200 response if a database exception occurs part way through the enumeration.
            // MaxModelBindingCollectionSize defaults to 1024.
            // 
            // In this case: we set the maximum rows for display is 100
            // 
            // warn: Microsoft.EntityFrameworkCore.Query[10102]
            // The query uses a row limiting operator ('Skip'/'Take') without an 'OrderBy' operator. This may lead to unpredictable results. 
            // More info: https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code#performance-considerations
            var myMaxModelBindingCollectionSize = Convert.ToInt32(
                Configuration["MyMaxModelBindingCollectionSize"] ?? "100");
            services.Configure<MvcOptions>(options =>
                options.MaxModelBindingCollectionSize = myMaxModelBindingCollectionSize);


            services.AddRazorPages();

            // ASP.NET Core is built with [dependency injection](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0). 
            // Services such as the `SchoolContext` are registered with dependency injection during app startup.
            // Components that require these services, such as Razor Pages, are provided these services via
            // constructor parameters. The constructor code that gets a database context instance is shown later in the tutorial. 
            // 
            // The scaffolding tool automatically registered the context class with the dependency injection container.
            // More info: https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code#startupcs
            services.AddDbContext<SchoolContext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("SchoolContext")));

            // The Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore NuGet package provides ASP.NET Core 
            // middleware for Entity Framework Core error pages. This middleware helps to detect and diagnose 
            // errors with Entity Framework Core migrations.
            // More info: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-5.0
            services.AddDatabaseDeveloperPageExceptionFilter();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
