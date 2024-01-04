namespace Hardware;

public class HPPrinter: IPrinter,IScanner
{

    public void Print(){
        Console.WriteLine("Printer is printing...");
    }

    public void Scan(){
        Console.WriteLine("Scanning ...");
    }
}