using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var produtos = await _context.Produtos
                .Include(p => p.Clube)
                .ToListAsync();
            return View(produtos);
        }

        public async Task<IActionResult> PorClube(int clubeId)
        {
            var produtos = await _context.Produtos
                 .Include(p => p.Clube)
                 .Where(p => p.ClubeId == clubeId)
                 .ToListAsync();

             return View("Index", produtos); // Reaproveita a mesma view Index.cshtml
        }
    }
}
