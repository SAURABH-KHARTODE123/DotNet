namespace Order;

public class Product: IDisposable{
    public int Id{get;set;}
    public string Details {get;set;}

    public Product(){

        
    }


    public void Dispose(){

        Console.WriteLine("dispose is invoked");
        // Dispose(disposing:true);
        GC.SuppressFinalize(this);
    }    

    ~Product(){
        Console.WriteLine("destructor is invoked");
    }
}