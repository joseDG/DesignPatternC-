using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DesignPatternsAsp.Models;
using DesignPatternsAsp.Configuration;
using Microsoft.Extensions.Options;

namespace DesignPatternsAsp.Controllers;

public class HomeController : Controller
{
    private readonly IOptions<MyConfig> _config;

    public HomeController(IOptions<MyConfig> config)
    {
        _config = config;
    }

    public IActionResult Index()
    {
        Log.GetInstance(_config.Value.PathLog).Save("Entro a index");

    }

    public IActionResult Privacy()
    {
        Log.GetInstance(_config.Value.PathLog).Save("Entero a privacy");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
