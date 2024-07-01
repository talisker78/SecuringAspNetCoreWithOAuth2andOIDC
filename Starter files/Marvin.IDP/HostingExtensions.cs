using Marvin.IDP.DbContexts;
using Marvin.IDP.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Marvin.IDP;

internal static class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        // configures IIS out-of-process settings
        builder.Services.Configure<IISOptions>(iis =>
        {
            iis.AuthenticationDisplayName = "Windows";
            iis.AutomaticAuthentication = false;
        });
        // ...or configures IIS in-process settings
        builder.Services.Configure<IISServerOptions>(iis =>
        {
            iis.AuthenticationDisplayName = "Windows";
            iis.AutomaticAuthentication = false;
        });


        // uncomment if you want to add a UI
        builder.Services.AddRazorPages();

        builder.Services.AddScoped<IPasswordHasher<Entities.User>, 
            PasswordHasher<Entities.User>>();


        builder.Services.AddScoped<ILocalUserService, LocalUserService>();

        builder.Services.AddDbContext<IdentityDbContext>(options =>
        {
            options.UseSqlite(builder.Configuration.GetConnectionString("MarvinIdentityDBConnectionString"));
        });

        builder.Services.AddIdentityServer(options =>
            {
                // https://docs.duendesoftware.com/identityserver/v6/fundamentals/resources/api_scopes#authorization-based-on-scopes
                options.EmitStaticAudienceClaim = true;
            })
            .AddProfileService<LocalUserProfileService>()
            .AddInMemoryIdentityResources(Config.IdentityResources)
            .AddInMemoryApiScopes(Config.ApiScopes)
            .AddInMemoryApiResources(Config.ApiResources)
            .AddInMemoryClients(Config.Clients);


        return builder.Build();
    }
    
    public static WebApplication ConfigurePipeline(this WebApplication app)
    { 
        app.UseSerilogRequestLogging();
    
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        // uncomment if you want to add a UI
        app.UseStaticFiles();
        app.UseRouting();
            
        app.UseIdentityServer();

        // uncomment if you want to add a UI
        app.UseAuthorization();
        app.MapRazorPages().RequireAuthorization();

        return app;
    }
}
