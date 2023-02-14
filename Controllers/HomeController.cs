using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OMDB.Models;

namespace OMDB.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult MovieSearch()
    {
        return View();
    }

    [HttpPost]

    public IActionResult MovieSearch(string Title)
    {
        return View(MovieDAL.GetMovie(Title));
    }
    public IActionResult MovieNight()
    {
        return View();
    }

    [HttpPost]
    public IActionResult MovieNight(string Title1, string Title2, string Title3)
    {
        List<MovieDB> result = new List<MovieDB>();
        result.Add(MovieDAL.GetMovie(Title1));
        result.Add(MovieDAL.GetMovie(Title2));
        result.Add(MovieDAL.GetMovie(Title3));
        return View(result);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

