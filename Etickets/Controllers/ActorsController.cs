using Eticket.Data;
using Microsoft.AspNetCore.Mvc;

namespace Eticket.Controllers;

public class ActorsController : Controller
{
    private readonly AppDbContext _context;

    public ActorsController(AppDbContext context)
    {
        _context = context;
    }
    // GET
    public IActionResult Page1()
    {
        var data = _context.Actors.ToList();
        return View(data);
    }
}
