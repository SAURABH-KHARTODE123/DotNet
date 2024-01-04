namespace Graphics1;

public class Circle:Shape
{
    public Point Center{get;set;}
    public int Radius{get;set;}

    public Circle(){
        this.Center = new Point(0,0);
        this.Radius = 0;
    }

    public Circle(string c, int w, Point p, int r):base(c,w){
        this.Center = p;
        this.Radius = r;
    }

    public override void Draw(){
        Console.WriteLine("drawing circle...");
    }

    public override string ToString(){
        return base.ToString() + "[ Center="+this.Center+", radius= "+ this.Radius+"]";
    }
    
}