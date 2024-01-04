using System;
using IOCWebApp.Models;
using System.Collections.Generic;

namespace IOCWebApp.Services;

public interface IProductService
{
    public List<Product> GetProducts();
    public Product GetProductById(int id);
    public bool Insert(Product product);
    public bool Update(Product product);
    public bool Delete(int id);

}