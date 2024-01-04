namespace BLL;
using BOL;
using DAL.Connected;


public class CatalogManager{
    public List<Product> GetAllProducts(){
        List<Product> products = DBManager.GetAllProducts();
        return products;
    }

    public bool InsertProducts( string title, string description, int unitPrice, int categoryId, int unitInStock)
    {
        return DBManager.InsertProducts(title, description, unitPrice, categoryId, unitInStock);
    }
    public bool UpdateProductDetails(int ProductId,string Title, string Description, int UnitPrice, int CategoryId, int UnitInStock){
        return DBManager.UpdateProductDetails(ProductId,Title,Description,UnitPrice,CategoryId,UnitInStock);
    }   
}