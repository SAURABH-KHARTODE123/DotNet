using Graphics1;
using System.Drawing;
namespace Paint;

public partial class Form1 : Form
{
    Graphics1.Point StartPoint;
    Graphics1.Point EndPoint;
    public Form1()
    {
        InitializeComponent();

        Paint += new System.Windows.Forms.PaintEventHandler(onPaint);
    }

    public void onPaint(object sender, PaintEventArgs pe){

    }
}
