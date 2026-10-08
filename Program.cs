// Import the application data context for database access.
using ForestersSiteCoreDemo.Data;
// Impport the ASP.NET Core hosting and application APIs.
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

// Import the ASP.NET Core hosting and application APIs.
var builder = WebApplication.CreateBuilder(args);

// Register MVC controllers and Razor views with dependency injection.
builder.Services.AddControllersWithViews();

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Register the application data context with dependency injection,
// reading the connection string from the configuration system.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Build the configured web application.
var app = builder.Build();

// Configure error handling and security middleware for non-development environments.
if (!app.Environment.IsDevelopment())
{
    // Route unhandled exceptions to the shared error page.
    app.UseExceptionHandler("/Home/Error");
    // Require browsers to use HTTPS for future requests.
    app.UseHsts();
}

// Redirect HTTP requests to HTTPS.
app.UseHttpsRedirection();

// Determine whether the incoming request is from a logged-in user.
app.UseAuthentication();

// Enable authorization middleware for routed requests.
app.UseAuthorization();

// Expose static files such as CSS, JavaScript, and images.
app.MapStaticAssets();

// Map requests to the default controller, action, and optional identifier.
app.MapControllerRoute(
    // Name the conventional MVC route.
    name: "default",
    // Use Home/Index when no route values are supplied.
    pattern: "{controller=Home}/{action=Index}/{id?}")
    // Apply static asset endpoint metadata to the route.
    .WithStaticAssets();

// Start listening for incoming HTTP requests.
app.Run();
