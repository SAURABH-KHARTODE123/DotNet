using Graphics1;
namespace Paint;

static class Program
{
    [STAThread]
    static void Main()
    {
        Line l1 = new Line();
        l1.Color = "black";
        l1.Width = 1;
        l1.Draw();
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}