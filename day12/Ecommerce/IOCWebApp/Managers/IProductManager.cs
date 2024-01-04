namespace IOCWebApp.Repositories;
using IOCWebApp.Models;
using System.Collections.Generic;

public interface IProductManager
{

    public List<Product> GetAll();
    public Product GetById(int id);
    public bool Update(Product product);
    public bool Insert(Product product);
    public bool Delete(int id);
}