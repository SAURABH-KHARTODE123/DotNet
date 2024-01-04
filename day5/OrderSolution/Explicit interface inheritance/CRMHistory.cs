namespace OrderProcessing;

public class CRMHistory: IOrderDetails,ICustomerDetails{

    public void ShowOrderDetails(){
        Console.WriteLine("showing order details");
    }

    
    public void ShowCustomerDetails(){
        Console.WriteLine("showing customer details");
    }

    // explicit interface inheritance
    void IOrderDetails.ShowDetails(){
        Console.WriteLine("details of order");
    }

    void ICustomerDetails.ShowDetails(){
        Console.WriteLine("details of customer");
    }

    public void ChangeProfile(){
        Console.WriteLine("changing profile..");
    }

}