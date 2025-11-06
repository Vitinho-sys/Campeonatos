using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public class LojaController : Controller
    {
        private List<Liga> ObterLigas()
        {
            return new List<Liga>
            {
                new Liga
                {
                    Id = 1,
                    Nome = "Premier League",
                    Clubes = new List<Clube>
                    {
                        new Clube
                        {
                            Id = 1,
                            Nome = "Manchester United",
                            Produtos = new List<Produto>
                            {
                                new Produto { Id = 1, Nome="Camisa Oficial 2025", Descricao="Camisa oficial do Manchester United 2025", Preco=299.90M, ImagemUrl="manu2025.jpg" },
                                new Produto { Id = 2, Nome="Camisa Treino", Descricao="Camisa de treino oficial", Preco=199.90M, ImagemUrl="manutreino.jpg" }
                            }
                        },
                        new Clube
                        {
                            Id = 2,
                            Nome = "Liverpool",
                            Produtos = new List<Produto>
                            {
                                new Produto { Id = 3, Nome="Camisa Oficial 2025", Descricao="Camisa oficial do Liverpool 2025", Preco=289.90M, ImagemUrl="liverpool2025.jpg" }
                            }
                        }
                    }
                },
                new Liga { Id=2, Nome="La Liga", Clubes = new List<Clube>() }
            };
        }

        public IActionResult Ligas()
        {
            var ligas = ObterLigas();
            return View(ligas);
        }

        public IActionResult Clubes(int ligaId)
        {
            var liga = ObterLigas().Find(l => l.Id == ligaId);
            if(liga == null) return NotFound();
            return View(liga);
        }

        public IActionResult Produtos(int clubeId)
        {
            var clubes = new List<Clube>();
            foreach(var liga in ObterLigas())
                clubes.AddRange(liga.Clubes);  // garante que é List<Clube> do mesmo namespace

            var clube = clubes.Find(c => c.Id == clubeId);
            if(clube == null) return NotFound();
            return View(clube);
        }
    }
}
