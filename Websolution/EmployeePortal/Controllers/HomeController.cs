using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeePortal.Models;
using EmployeePortal.BOL;
using BLL;

namespace EmployeePortal.Controllers;

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

    public IActionResult Employee()
    {
        List<Employee> employees = CatalogManager.GetEmployees();
        ViewData["employees"] = employees;
        // TempData["employees"] =
        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Insert(int id, string name, int salary, string gender)
    {
        bool status = CatalogManager.InsertEmployee(id, name, salary, gender);
        if (status)
        {
            return this.RedirectToAction("Employee");
        }
        return View();
    }

    [Route("Home/Edit/{id}")]
    public IActionResult Edit(int id)
    {
        // Console.WriteLine(id);
        List<Employee> employees = CatalogManager.GetEmployees();
        Employee e = employees.Find((emp) => emp.Id == id);
        return View(e);
    }
    [HttpPost]
    [Route("Home/Edit/{id}")]
    public IActionResult Edit(int id, string name, int salary, string gender)
    {
        // HttpRequest request = new HttpRequest();
        // Request.QueryString("id");
        // Console.WriteLine(id + " " + name);
        bool status = CatalogManager.EditEmployeeDetails(id, name, salary, gender);
        // Console.WriteLine(status);
        if (status)
        {
            return this.RedirectToAction("Employee");
        }
        return View();
    }

    // [HttpPost]
    // [Route("Home/Delete/{id}")]
    // public IActionResult Delete(int id)
    // {
    //     return View(id);
    // }

    // [HttpPost]
    [Route("Home/Delete/{id}")]
    public IActionResult Delete(int id)
    {
        // Console.WriteLine(id);
        bool status = CatalogManager.DeleteEmployee(id);
        if (status)
        {
            return this.RedirectToAction("Employee");
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
