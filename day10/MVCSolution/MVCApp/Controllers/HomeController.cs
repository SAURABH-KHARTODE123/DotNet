using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System.Collections.Generic;
// using System.Net;
// using System.Net.Http;
// using System.Web.Http;
using BLL;
using BOL;

namespace MVCApp.Controllers;

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

    public IActionResult Products()
    {
        CatalogManager mgr = new CatalogManager();
        List<Product> products = mgr.GetAllProducts();
        ViewData["products"] = products;
        return View();
    }

    // [HttpPost]
    public IActionResult Edit()
    {
        return View();
    }

    [HttpPost]
    [Route("Edit/{productid:int}")]
    public IActionResult Edit(int productId, string title, string description, int unitPrice, int categoryId, int unitInStock)
    {
        
        CatalogManager mgr = new CatalogManager();
        bool status = mgr.UpdateProductDetails(productId,title,description,unitPrice,categoryId,unitInStock);
        // Request.QueryString("id");
        Console.WriteLine(productId+" "+title);
        if(status){
            this.RedirectToAction("Products");
        }
        return View();
    }

    // [HttpPost]
    // public IActionResult Edit(int id)
    // {
    //     // CatalogManager mgr = new CatalogManager();
    //     // bool status = mgr.UpdateProductDetails(id);
    //     // if(status) {
    //     //     this.RedirectToAction("Products");
    //     // }
    //     return View();
    // }
    // [HttpPost]
    public IActionResult Insert()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Insert(string title, string description, int unitPrice, int categoryId, int unitInStock)
    {
        CatalogManager mgr = new CatalogManager();
        bool status = mgr.InsertProducts(title, description, unitPrice, categoryId, unitInStock);
        if(status){
            this.RedirectToAction("/Products");
        }
        return View();
    }
    public IActionResult Delete()
    {
        return View();
    }
}
