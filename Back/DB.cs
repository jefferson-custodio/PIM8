
using MySql.Data.MySqlClient;
using System.Data;

namespace DataBase
{
    public class DB
    {
        private static string ConnString = "Server=localhost;Database=PIM8;Uid=root;Pwd=Banco1020";
        // private MySqlConnection conn;

        public void runQuery(string query){
            var connection = new MySqlConnection(ConnString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            finally
            {
                // Console.WriteLine(connection.State);
                connection.Close();            
            }
        }

        public IDataReader runSelectQuery(string query){
            var connection = new MySqlConnection(ConnString);
            
            try
            {
                var command = connection.CreateCommand();
                MySqlDataReader reader; 
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection)){
                      reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load( reader );
                    return dt.CreateDataReader();
                }
                
                // return reader;
            }
            finally
            {
                // Console.WriteLine(connection.State);
                connection.Close();            
            }
        }

    }
}