using System.Security.Claims;
using CRM;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthentication()
    .AddJwtBearer(options =>
    {
        options.Authority = "https://localhost:5001";
        options.TokenValidationParameters.ValidateAudience = false;
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("ApiScope", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireClaim("scope", "crm");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("identity", (ClaimsPrincipal user) => user.Claims.Select(c => new { c.Type, c.Value }))
    .RequireAuthorization(
        "ApiScope"
    );

// Route to catch a contact for identity system
app.MapGet("contacts/{identityId}", (int identityId) => DemoContacts.Contacts.FirstOrDefault(c => c.IdentityId == identityId))
.RequireAuthorization(
        "ApiScope"
    );

app.Run();

