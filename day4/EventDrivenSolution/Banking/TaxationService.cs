namespace Taxation;

public static class TaxationService
{
    public static void PayIncomeTax(float amount){
        Console.WriteLine("Income Tax: " + amount + " is deducted from account");
    }

    public static void PaySalesTax(float amount){
        Console.WriteLine("Sales Tax: " + amount + " is deducted from account");
    }

}