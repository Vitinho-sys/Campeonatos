using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LigasController : Controller
    {
        private readonly AppDbContext _context;

        public LigasController(AppDbContext context)
        {
            _context = context;
        }

        // Exibe todas as ligas
        public async Task<IActionResult> Index()
        {
            var ligas = await _context.Ligas.ToListAsync();
            return View(ligas);
        }

        // Exibe os clubes de uma liga
        public async Task<IActionResult> Clubes(int id)
        {
            var liga = await _context.Ligas
                .Include(l => l.Clubes)
                .FirstOrDefaultAsync(l => l.Id == id);

            if (liga == null)
                return NotFound();

            return View(liga);
        }
    }
}
