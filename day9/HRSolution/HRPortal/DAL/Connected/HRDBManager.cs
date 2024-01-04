namespace DAL.Connected;
using MySql.Data.MySqlClient;

public static class HRDBManager{

    public static string connString = "server=localhost;port=3306;user=root;password=welcome;database=ecommerce";

    public static bool ValidateUser(int userid, string password){
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connString;
        string query = "select * from users";
        MySqlCommand cmd = new MySqlCommand(query,con);
        try{
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()){
                int id = int.Parse(reader["userid"].ToString());
                string pass = reader["password"].ToString();
                if(id == userid && pass == password) {
                    return true;
                }
            }    
            reader.Close();
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }

        return false;
    }

}