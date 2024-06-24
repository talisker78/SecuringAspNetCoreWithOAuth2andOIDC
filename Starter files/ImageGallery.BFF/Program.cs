using Duende.Bff;
using Duende.Bff.Yarp;
using ImageGallery.API.Authorization;
using ImageGallery.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddJsonOptions(configure =>
    {
        configure.JsonSerializerOptions.PropertyNamingPolicy = null;
    });

JsonWebTokenHandler.DefaultInboundClaimTypeMap.Clear();

builder.Services.AddBff()
    .AddRemoteApis();


builder.Services.AddHttpClient("IDPClient", client =>
{
    client.BaseAddress = new Uri("https://localhost:5001");
});

const string bffCookieScheme = "BFFCookieScheme";
const string bffChallengeScheme = "BFFChallengeScheme";

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = bffCookieScheme;
        options.DefaultChallengeScheme = bffChallengeScheme;
    })
    .AddCookie(bffCookieScheme)
    .AddOpenIdConnect(bffChallengeScheme, options =>
    {
        options.SignInScheme = bffCookieScheme;
        options.Authority = "https://localhost:5001";
        options.ClientId = "imagegallerybff";
        options.ClientSecret = "anothersecret";
        options.ResponseType = "code";
        options.SaveTokens = true;
        options.GetClaimsFromUserInfoEndpoint = true;
        options.ClaimActions.Remove("aud");
        options.ClaimActions.DeleteClaim("sid");
        options.ClaimActions.DeleteClaim("idp");
        options.Scope.Add("roles");
        options.Scope.Add("imagegalleryapi.read");
        options.Scope.Add("imagegalleryapi.write");
        options.Scope.Add("country");
        options.Scope.Add("offline_access");
        options.ClaimActions.MapJsonKey("role", "role");
        options.ClaimActions.MapUniqueJsonKey("country", "country");
        options.TokenValidationParameters = new()
        {
            NameClaimType = "name",
            RoleClaimType = "role"
        };
    });

builder.Services.AddAuthorization(authorizationOptions =>
{
    authorizationOptions.AddPolicy("UserCanAddImage",
        AuthorizationPolicies.CanAddImage());

    authorizationOptions.AddPolicy("ClientApplicationCanWrite", policyBuilder =>
    {
        policyBuilder.RequireClaim("scope", "imagegalleryapi.write");
    });

    authorizationOptions.AddPolicy("MustOwnImage", policyBuilder =>
    {
        policyBuilder.RequireAuthenticatedUser();
        policyBuilder.AddRequirements(new MustOwnImageRequirement());
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRemoteBffApiEndpoint(
        "/bff/images", "https://localhost:7075/api/images")
    .RequireAccessToken(TokenType.User);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
