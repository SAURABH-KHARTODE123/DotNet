using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using BOL;
using BLL;


using Portal.Models;

namespace Portal.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    // Get All products from BLL
    // bind all products to ViewData
    // send viewData to View
    public IActionResult Index()
    {
        CatalogManager manager=new CatalogManager();
        List<Product1> allProducts=manager.GetAllProducts();
        this.ViewData["products"]=allProducts;
        return View();
    }

    public IActionResult Details( int id)
    {
      CatalogManager manager=new CatalogManager();
      Product1 product=manager.GetProduct(id);
      this.ViewData["product"]=product;
      return View();
    }

    public IActionResult Insert(){
        return View();
    }

    public IActionResult Delete(int id){
        //return View();
        return RedirectToAction("Index");
    }
 
}
