namespace Library;

public class Books{
    private string[] Titles;

    public Books(){
        Titles = new string[5];

        this.Titles[0] = "you can win";
        this.Titles[1] = "Ignited minds";
        this.Titles[2] = "Rich dad, poor dad";
        this.Titles[3] = "Let us C";
        this.Titles[4] = "Effective C++";
    }


    // indexer syntax
    public string this[int index]{
        get{return this.Titles[index];}
        set{Titles[index] = value;}
    }
}