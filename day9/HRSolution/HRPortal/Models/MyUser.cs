namespace HRPortal.Models;

public class MyUser{

    public int Id{get;set;}
    public string Password{get;set;}
    public int Roleid{get;set;}

    public MyUser(int id, string password, int roleid){
        this.Id = id;
        this.Password = password;
        this.Roleid = roleid;
    }

}