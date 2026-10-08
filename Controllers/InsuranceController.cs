using ForestersSiteCoreDemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace ForestersSiteCoreDemo.Controllers;

public class InsuranceController : Controller
{
    // Render the insurance products page.
    private readonly ApplicationDbContext _context;

    public InsuranceController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        // Create a list of insurance products to display.
        var products = _context.InsuranceProducts.ToList();

        // Return the view associated with this action, passing the list of products.
        return View(products);
    }
}