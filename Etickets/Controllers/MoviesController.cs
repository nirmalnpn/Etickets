using Eticket.Data;
using Microsoft.AspNetCore.Mvc;

namespace Eticket.Controllers;

public class MoviesController : Controller
{
    private readonly AppDbContext _context;

    public MoviesController(AppDbContext context)
    {
        _context = context;
    }
    // GET
    public async Task<IActionResult> Index()
    {
        var allMovies = await _context.Movies.ToListAsync();
        return View(allMovies);
    }
}