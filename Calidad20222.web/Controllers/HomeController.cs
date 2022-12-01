using System.Diagnostics;
using Calidad20222.web.Helper;
using Microsoft.AspNetCore.Mvc;
using Calidad20222.web.Models;
using Calidad20222.web.Services;

namespace Calidad20222.web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new List<Carta>());
    }
    
    [HttpPost]
    public IActionResult Generar()
    {
        List<Carta> cartas = new List<Carta>();
        cartas.Add(new Carta { Numero = int.Parse(Request.Form["Numero1"]), Palo = Request.Form["Palo1"] });
        cartas.Add(new Carta { Numero = int.Parse(Request.Form["Numero2"]), Palo = Request.Form["Palo2"] });
        cartas.Add(new Carta { Numero = int.Parse(Request.Form["Numero3"]), Palo = Request.Form["Palo3"] });
        cartas.Add(new Carta { Numero = int.Parse(Request.Form["Numero4"]), Palo = Request.Form["Palo4"] });
        cartas.Add(new Carta { Numero = int.Parse(Request.Form["Numero5"]), Palo = Request.Form["Palo5"] });
        foreach (Carta carta in cartas)
            Debug.WriteLine(carta.Numero);

        var service = new PokerService();
       
        ViewBag.Jugada = service.GetJugada(cartas);
        return View("Index", cartas);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}