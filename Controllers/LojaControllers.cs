using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class LojaController : Controller
    {
        private readonly AppDbContext _context;

        public LojaController(AppDbContext context)
        {
            _context = context;
        }

        // ✅ Ação para exibir todas as ligas
        public async Task<IActionResult> Ligas()
        {
            var ligas = await _context.Ligas.ToListAsync();
            Console.WriteLine($"✅ Ligas encontradas: {ligas.Count}");
            return View(ligas); // Renderiza Views/Loja/Ligas.cshtml
        }

        // ✅ Exibir clubes de uma liga
        public async Task<IActionResult> Clubes(int ligaId)
        {
            var clubes = await _context.Clubes
                .Include(c => c.Liga)
                .Where(c => c.LigaId == ligaId)
                .ToListAsync();

                var liga = await _context.Ligas.FindAsync(ligaId);
                ViewBag.LigaNome = liga?.Nome ?? "Liga";

            return View(clubes); // Renderiza Views/Loja/Clubes.cshtml
        }

        // ✅ Exibe produtos (camisetas) por clube
        public async Task<IActionResult> Produtos(int clubeId)
        {
            var produtos = await _context.Produtos
                .Include(p => p.Clube)
                .Where(p => p.ClubeId == clubeId)
                .ToListAsync();

            var clube = await _context.Clubes
                .Include(c => c.Liga)
                .FirstOrDefaultAsync(c => c.Id == clubeId);

            ViewBag.ClubeNome = clube?.Nome ?? "Clube";
            ViewBag.LigaNome = clube?.Liga?.Nome ?? "";

            return View("Produtos", produtos);
        }
    }
}
