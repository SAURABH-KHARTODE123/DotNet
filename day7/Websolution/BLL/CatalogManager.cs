namespace BLL;
using BOL;
using DAL.Connected;
public class CatalogManager
{
    public List<Product1> GetAllProducts(){
        List<Product1> allProducts = new List<Product1>();
        allProducts=DBManager.GetAllProducts();
        return allProducts;
    }

     public Product1 GetProduct(int  id){
      List<Product1> allProducts=GetAllProducts();
      /*var product=from  p in allProducts
                   where p.ProductId ==id
                    select p  ;     
    */
       Product1 foundProduct=allProducts.Find((product)=>product.ProductId ==id);
      return foundProduct ;
     }
}