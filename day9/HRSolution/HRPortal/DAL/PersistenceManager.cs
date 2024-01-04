using HRPortal.Models;
using System.Collections.Generic;
namespace DAL;

public static class PersistenceManager{

    public static List<MyUser> GetAllUsers(){
        List<MyUser> allUsers = new List<MyUser>();
        allUsers.Add(new MyUser(1,"ameyak",1));
        allUsers.Add(new MyUser(2,"askk",2));
        return allUsers;
    }

}