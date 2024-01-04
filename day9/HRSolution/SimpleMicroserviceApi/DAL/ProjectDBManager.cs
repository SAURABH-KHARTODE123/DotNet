using PMP.Models;
using MySql.Data.MySqlClient;
namespace PMP.DAL;
public class ProjectDBManager{

public static string connString = "server=localhost;port=3306;user=root;password=welcome;database=ecommerce";

public static List<Activity> GetAll(){
    List<Activity> items=new List<Activity>();
    
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString = connString;
    string query = "select * from activity";
    MySqlCommand cmd = new MySqlCommand(query,conn);
    try{
        conn.Open();
        MySqlDataReader reader = cmd.ExecuteReader();
        while(reader.Read()){
            int id = int.Parse(reader["id"].ToString());
            string? name = reader["name"].ToString();
            bool isComplete = bool.Parse(reader["isComplete"].ToString());
            Activity act = new Activity(id,name,isComplete);
            items.Add(act);
        }
        reader.Close();

    }catch(Exception e){
        Console.WriteLine(e.Message);
    }finally{
        conn.Close();
    }

    return items;
}
}