namespace Graphics1;

public abstract class Shape
{
    public string Color {get;set;}
    public int Width {get;set;}

    public Shape(){
        this.Color = "black";
        this.Width = 0;
        // this("black",0);
    }

    public Shape(string c, int w){
        this.Color = c;
        this.Width = w;
    }


    public abstract void Draw();
    public override string ToString(){
        return "[ Width= "+this.Width+ "Color= "+ this.Color+"]";
    }
}