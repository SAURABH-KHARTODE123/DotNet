namespace BOL;

public class Product
{
    // private int ProductId;
    // private string title;
    // private string imageURL;
    // private string category;
    // private string description;
    // private float unitPrice;
    // private int balance;
    // private string paymentTerm;
    // private string delivery;

    public int ProductId{
        get;
        set;
    }
    
    public string Title{
            get;
            set;
    }


    public string Category{
        get ;
        set ;
    }
        
    public string Description{
        get;
        set;
    }

    
    public string PaymentTerm{
        get;
        set;
    }

    public string Delivery {
        get;
        set;
    }

    public string ImageURL{
        get;
        set;
    }

    public float UnitPrice{
        get;
        set;
    }
    
    public int Balance{
        get;
        set;
        }

    public Product(){
    }

    public Product(int productId, string title){
        this.ProductId = productId;
        this.Title = title;
        
    }

    public Product(int productId, string title, string description){
        this.ProductId = productId;
    }

    public Product(int productId, string title, string brand, string category){
        this.ProductId = productId;
        this.Title = title;       
        this.Category = category;
    }

     public Product(int productId, string title, string brand,
                    string category, float unitPrice, int balance){
        this.ProductId = productId;
        this.Title = title;
        this.Category = category;
        this.UnitPrice = unitPrice;
        this.Balance = balance;
    }

    public Product(int productId, string title, string brand, string category,
                    float unitPrice, 
                    int balance, string description, string imageURL){
        this.ProductId = productId;
        this.Title = title;   
        this.Category = category;
        this.UnitPrice = unitPrice;
        this.Balance = balance;
        this.Description = description;
        this.ImageURL = imageURL;
    }

    //Properties of Product Entity

    
}
