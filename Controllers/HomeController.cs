using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var ligas = await _context.Ligas.ToListAsync();

            Console.WriteLine($"✅ Ligas encontradas no banco: {ligas.Count}");
            return View(ligas);
        }
    }
}
