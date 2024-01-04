namespace Graphics1;
using Hardware;

public class Line: Shape, IPrinter
{
    public Point startPoint{get;set;}
    public Point endPoint{get;set;} 

    public Line(){
        this.startPoint = new Point(0,0);
        this.endPoint = new Point(0,0);
    }   

    public Line(string c, int w, Point s, Point e):base(c,w){
        this.startPoint = s;
        this.endPoint = e;
    }

    public override void Draw(){
        Console.WriteLine("Drawing Line ...");
    }

    public override string ToString(){
        return base.ToString()+"[startpoint="+this.startPoint+ ", endpoint="+this.endPoint + "]";
    }

    void IPrinter.Print(){
        Console.WriteLine("Printing Line...");
    }

}