// Import activity diagnostics for request correlation.
using System.Diagnostics;

// Import MVC controller and action result types.
using Microsoft.AspNetCore.Mvc;

// Import the application's database context.
using ForestersSiteCoreDemo.Data;

// Import the application's view models.
using ForestersSiteCoreDemo.Models;

// Group this controller in the application's namespace.
namespace ForestersSiteCoreDemo.Controllers;

// Handle requests for the application's home pages.
public class HomeController : Controller
{
    // Store the database context so controller actions can access SQL Server.
    private readonly ApplicationDbContext _context;

    // ASP.NET Core provides the ApplicationDbContext through dependency injection.
    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Page(string pageKey)
    {
        // Retrieve the content page from the database based on the provided pageKey.
        var page = _context.ContentPages.FirstOrDefault(p => p.PageKey == pageKey);
        if (page == null)
        {
            return NotFound(); // Return a 404 Not Found response if the page is not found.
        }

        // Render the view for the content page, passing the retrieved page as the model.
        // The view will use the properties of the ContentPage model to display the page content.
        // The view name is explicitly specified as "Index" to use the same view for all content pages.
        
        return View("Index", page);
    }   
    // Render the home page.
    public IActionResult Index()
    {
        // Retrieve the first content page from the database to display on the home page.
        // This assumes that the content page with Id = 1 is the home page content.
       var page = _context.ContentPages.FirstOrDefault(p => p.PageKey == "home" );
       if (page == null)
       {
          return NotFound(); // Return a 404 Not Found response if the page is not found.   
       }

        return View(page);
    }

    public IActionResult SeedHome()
    {
       var page = new ContentPage {
        Title = "Welcome to ForestersSiteCoreDemo",
        Heading = "Plan with confidence for <em>what comes next.</em>",
        HeroDescription = "Foresters Financial helps families build lasting financial security through thoughtful protection, savings, and investment solutions.",
        Body = "This is the home page of the ForestersSiteCoreDemo application.",
        ImageUrl = "",
        Published = true
       };

       _context.ContentPages.Add(page);
       _context.SaveChanges();

       return Content("Home page added to the database.");
    }

    // Render the privacy policy page.
    public IActionResult Privacy()
    {
        // Return the privacy view.
        return View();
    }

    // Prevent the error response from being cached by clients or proxies.
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    // Render the shared error page with a diagnostic request identifier.
    public IActionResult Error()
    {
        // Prefer the current activity ID and fall back to the HTTP trace identifier.
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}