using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;

public class HomeController : Controller
{
    private List<Liga> ObterLigas()
    {
        return new List<Liga>
        {
            new Liga { Id = 1, Nome = "Premier League", Clubes = new List<Clube>() },
            new Liga { Id = 2, Nome = "La Liga", Clubes = new List<Clube>() }
        };
    }

    public IActionResult Index()
    {
        var ligas = ObterLigas();
        return View(ligas); // <- É importante passar o Model para a View
    }
}
