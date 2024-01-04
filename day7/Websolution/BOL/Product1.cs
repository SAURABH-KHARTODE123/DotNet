namespace BOL;

public class Product1
{
    private int id;
    private string title;
    private string picture;
    private string description;
    private int unitPrice;
    private int available;
    private int categoryId;
    private int unitInStock;


    public Product1(){
    }

    public Product1(int productId, string title){
        this.id = productId;
        this.title = title;
        
    }

    // public Product(int productId, string title, string brand, string category){
    //     this.id = productId;
    //     this.title = title;       
    //     this.category = category;
    // }

    //  public Product(int productId, string title, string brand,
    //                 string category, float unitPrice, int balance){
    //     this.id = productId;
    //     this.title = title;
    //     this.category = category;
    //     this.unitPrice = unitPrice;
    //     this.balance = balance;
    // }

    public Product1(int productId, string title, string picture, string description,
                    int unitPrice, 
                    int available, int CategoryId, int unitInStock){
        this.id = productId;
        this.title = title;   
        this.picture = picture;
        this.unitPrice = unitPrice;
        this.description = description;
        this.available = available;
        this.categoryId = categoryId;
        this.unitInStock = unitInStock;
    }

    //Properties of Product Entity

    public int ProductId{
        get { return id; }
        set { id = value; }
    }
    
    public string Title{
            get { return title; }
            set { title = value; }
    }

    public string Picture{
        get  {   return picture; }
        set  { picture = value; }
    }

    public int UnitPrice{
        get  { return unitPrice; }
        set  { unitPrice = value; }
    }

    public string Description{
        get { return description; }
        set { description = value; }
    }

    public int Available{
        get { return available;}
        set { available = value; }
    }

    public int CategoryId{
        get { return categoryId; }
        set { categoryId = value; }
    }

    public int UnitInStock {
        get{  return unitInStock;}
        set{ unitInStock = value; }
    }
}
