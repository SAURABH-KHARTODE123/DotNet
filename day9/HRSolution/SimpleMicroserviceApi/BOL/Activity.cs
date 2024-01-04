namespace PMP.Models;
public class Activity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }

    public Activity(int id,string name, bool isComplete){
        this.Id = id;
        this.Name = name;
        this.IsComplete = isComplete;
    }

}