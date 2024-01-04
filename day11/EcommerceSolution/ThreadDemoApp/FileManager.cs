
namespace Utility;

using System.IO;

public class FileManager{
    // public static string data;
    public string ReadData(){
        string data = File.ReadAllText(@"C:\Users\IET\Desktop\dotnet\products.txt");
        return data;
    }

    public void WriteData(string data){
        // string data = " ";
        File.WriteAllText(@"C:\Users\IET\Desktop\dotnet\products.txt",data);
    }

}