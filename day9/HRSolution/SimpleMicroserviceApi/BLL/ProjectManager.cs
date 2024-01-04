using PMP.Models;
namespace PMP.BLL;
public class ProjectManager{
public static List<Activity> GetAll(){
    List<Activity> items=new List<Activity>();
    items.Add(new Activity(1,"Print",false));
    items.Add(new Activity(2, "Code", false));
    items.Add(new Activity(3, "Test", false));
    items.Add(new Activity(4, "Deploy",false));
    items.Add(new Activity(5, "Support",false));
    //Access list from DAL 
    return items;
}
}