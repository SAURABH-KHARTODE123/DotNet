namespace HRPortal.Models;

public class Employee{

    public int Id{get;set;}
    public string Title{get;set;}
    public string Description{get;set;}

    public Employee(int id, string title, string description){
        this.Id = id;
        this.Title = title;
        this.Description = description;
    }

}