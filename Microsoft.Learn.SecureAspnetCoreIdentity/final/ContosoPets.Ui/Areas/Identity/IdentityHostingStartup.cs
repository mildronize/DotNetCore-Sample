using System;
using Npgsql;
using ContosoPets.Ui.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ContosoPets.Ui.Areas.Identity.IdentityHostingStartup))]
namespace ContosoPets.Ui.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                // Note: Using Azure Key Vault for production, see in the original article.
                services.AddDbContext<ContosoPetsAuth>(options =>
                    options.UseNpgsql(context.Configuration.GetConnectionString("ContosoPetsAuthConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddDefaultUI()
                    .AddEntityFrameworkStores<ContosoPetsAuth>();
            });
        }
    }
}