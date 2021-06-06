using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenIddict.Abstractions;

namespace Mild.MVC.Authentication.Openiddict.OAuth2.AuthorizationCodeRefreshToken
{
    public class TestData : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;

        public TestData(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _serviceProvider.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<DbContext>();
            await context.Database.EnsureCreatedAsync(cancellationToken);

            var manager = scope.ServiceProvider.GetRequiredService<IOpenIddictApplicationManager>();

            if (await manager.FindByClientIdAsync("postman", cancellationToken) is null)
            {
                await manager.CreateAsync(new OpenIddictApplicationDescriptor
                {
                    // ClientId = "postman",
                    // ClientSecret = "postman-secret",
                    // DisplayName = "Postman",
                    // Permissions =
                    // {
                    //     OpenIddictConstants.Permissions.Endpoints.Token,
                    //     OpenIddictConstants.Permissions.GrantTypes.ClientCredentials,

                    //     OpenIddictConstants.Permissions.Prefixes.Scope + "api"
                    // }

                    ClientId = "postman",
                    ClientSecret = "postman-secret",
                    DisplayName = "Postman",
                    // For Authorization Code Flow with PKCE
                    RedirectUris = { new Uri("https://oauth.pstmn.io/v1/callback") },
                    Permissions =
                    {
                        // For Authorization Code Flow with PKCE
                        OpenIddictConstants.Permissions.Endpoints.Authorization,

                        OpenIddictConstants.Permissions.Endpoints.Token,

                        // For Authorization Code Flow with PKCE
                        OpenIddictConstants.Permissions.GrantTypes.AuthorizationCode,

                        OpenIddictConstants.Permissions.GrantTypes.RefreshToken,

                        OpenIddictConstants.Permissions.GrantTypes.ClientCredentials,
                        OpenIddictConstants.Permissions.Prefixes.Scope + "api",
                        OpenIddictConstants.Permissions.ResponseTypes.Code
                    }
                }, cancellationToken);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
