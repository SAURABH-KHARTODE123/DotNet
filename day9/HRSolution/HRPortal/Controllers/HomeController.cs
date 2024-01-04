using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;
using DAL.Connected;

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

    public IActionResult Register(){
        return View();
    }

    [HttpPost]
    public IActionResult Register(string userName, string password){
        
        Console.WriteLine("User Name: "+ userName + ", Password: " + password);

        return View();
    }

    public IActionResult Login(){
        return View();
    }

    [HttpPost]
    public IActionResult Login(int userName, string password){
        
        Console.WriteLine("user id: "+ userName + ", password: " + password);
        bool status = HRDBManager.ValidateUser(userName,password);
        Console.WriteLine(status);
        if(status){
            return this.RedirectToAction("Welcome");
        }

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Welcome()
    {
        List<string> students = new List<string>();
        students.Add("Ameya");
        students.Add("Saurabh");

        ViewData["students"] = students;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
