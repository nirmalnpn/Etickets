using Eticket.Data;
using Microsoft.AspNetCore.Mvc;

namespace Eticket.Controllers;

public class CinemaController : Controller
{
    private readonly AppDbContext _context;

    public CinemaController(AppDbContext context)
    {
        _context = context;
    }
    // GET
    public async Task<IActionResult> Index()
    {
        var allCinemas =await _context.Cinemas.ToListAsync();
        return View(allCinemas);
    }
}