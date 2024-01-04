using MySql.Data.MySqlClient;

Console.WriteLine("Welcome to database");

// define the connection
MySqlConnection connection = new MySqlConnection();
connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac49;password=welcome;database=dac49";

/*
Console.WriteLine("Enter the id of product to be deleted:");
int id = int.Parse(Console.ReadLine());



Console.WriteLine("Enter the id of product to be updated:");
int id = int.Parse(Console.ReadLine());
Console.WriteLine("Enter new unit price");
int unit_price = int.Parse(Console.ReadLine());

*/



string query = "select * from products1";
// string query = "insert into products1 values(1,'Marie Gold','Sugar-free biscuits', 30)";
// string query = "update products1 set unit_price = @unit_price where id=@id";
// string query = "delete from products1 where id = @id";
// string query = "select count(*) from products1";

MySqlCommand command = new MySqlCommand(query,connection);

/*
command.Parameters.AddWithValue("@unit_price",unit_price);
command.Parameters.AddWithValue("@id",id);
*/
try{
    connection.Open();
    MySqlDataReader reader = command.ExecuteReader();

    while(reader.Read()){ 
        int? pid = int.Parse(reader["id"].ToString());
        string? pname = reader["name"].ToString();
        string? title = reader["title"].ToString();
        Console.WriteLine(pid + ", "+ pname + ", "+title);
    }
    reader.Close(); 
    //command.ExecuteNonQuery();
    // int count = int.Parse(command.ExecuteScalar().ToString());
    // Console.WriteLine("count of products :"+count);


}catch(Exception e){
    Console.WriteLine(e.Message);
}finally{
    connection.Close();
}

