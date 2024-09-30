using Eticket.Data;
using Microsoft.AspNetCore.Mvc;

namespace Eticket.Controllers;

public class ProducerController : Controller
{
    private readonly AppDbContext _context;

    public ProducerController(AppDbContext context)
    {
        _context = context;
    }
    // GET
    public async Task<IActionResult> Page2()
    {
        var allproducers = await _context.Producers.ToListAsync();
        return View(allproducers);
    }
}