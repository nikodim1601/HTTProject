using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HTTApp.Controllers;

public class HomeController : Controller
{
    private readonly HTTDbContext _dbContext;

    public HomeController(HTTDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _dbContext.Products.Include(product => product.Category).ToListAsync();
        
        return View(products);
    }
}