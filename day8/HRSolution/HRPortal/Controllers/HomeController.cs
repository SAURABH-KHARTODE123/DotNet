using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;

namespace HRPortal.Controllers;

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

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(string CompanyName, string ContactName)
    {
        Console.WriteLine("Company Name: " + CompanyName + ", Contact Name: " + ContactName);
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string Username, string Password)
    {
        Console.WriteLine("Username: " + Username + ", Password: " + Password);
        if(Username == "ameyak" && Password=="ameyak"){
            return this.RedirectToAction("Welcome");
        }
        return View();
    }

    public IActionResult Welcome(){
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
