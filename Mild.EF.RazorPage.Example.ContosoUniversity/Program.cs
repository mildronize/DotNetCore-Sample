using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Microsoft.Extensions.DependencyInjection;
using Mild.EF.RazorPage.Example.ContosoUniversity.Data;

namespace Mild.EF.RazorPage.Example.ContosoUniversity
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var host = CreateHostBuilder(args).Build();

            // Create the database if it doesn't exist
            // More info: https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code#create-the-database
            CreateDbIfNotExists(host);

            host.Run();
        }

        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<SchoolContext>();
                    // The `EnsureCreated` method takes no action if a database for the context exists. 
                    // If no database exists, it creates the database and schema. 
                    // 
                    // `EnsureCreated `enables the following workflow for handling data model changes:
                    //  - Delete the database. Any existing data is lost.
                    //  - Change the data model. For example, add an EmailAddress field.
                    //  - Run the app.
                    //  - EnsureCreated creates a database with the new schema.
                    // 
                    // This workflow works early in development when the schema is rapidly evolving, 
                    // as long as data doesn't need to be preserved. The situation is different when 
                    // data that has been entered into the database needs to be preserved. When that
                    // is the case, use migrations. 
                    // 
                    // Later in the tutorial series, the database is 
                    // deleted that was created by EnsureCreated and migrations is used. A database 
                    // that is created by EnsureCreated can't be updated by using migrations.
                    // More info: https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code#create-the-database
                    // 
                    // Same as `synchronize mode` in TypeORM - Helpful for development, 
                    context.Database.EnsureCreated();
                    // Add seed for DB
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
