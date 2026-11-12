using AlvionStudios.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlvionStudios.Controllers;

public class PortfolioController : Controller
{
    private readonly ApplicationDbContext _context;

    public PortfolioController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var projects = await _context.Projects
            .AsNoTracking()
            .OrderBy(project => project.Id)
            .ToListAsync();

        return View(projects);
    }

    public async Task<IActionResult> Details(int id)
    {
        var project = await _context.Projects
            .AsNoTracking()
            .FirstOrDefaultAsync(project => project.Id == id);

        if (project == null)
        {
            return NotFound();
        }

        return View(project);
    }
}