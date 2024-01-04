namespace Graphics2;
using Hardware;

public class Line: Shape, IPrinter{
    public Point startPoint {get;set;}
    public Point endPoint {get;set;}

    public Line(){
        this.startPoint = new Point(0,0);
        this.endPoint = new Point(0,0);
    }
    
    public Line(int w, string c, Point s, Point e):base(w,c){
        this.startPoint = s;
        this.endPoint = e;
    }

    public void Print(){
        Type t = this.GetType();
        Console.WriteLine(t.Name);
        Console.WriteLine("start point" + this.startPoint + " color " + this.Color);
    }

    public override string ToString(){
        return base.ToString()+"Line from " + this.startPoint + " to " + this.endPoint;
    }

}