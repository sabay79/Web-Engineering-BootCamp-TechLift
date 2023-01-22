using System.Data.SqlClient;

namespace ADO.NET_CRUD_Operations
{
    internal class Program
    {
        static void Main()
        {
            // Setting connection string to access sql server database
            string connectionString = "Data Source=CRIBV-DNET42; Database=UserDB; Trusted_Connection=True; Integrated Security=SSPI;";

            // Creating command object to fetch users from user table
            using SqlConnection connection = new SqlConnection(connectionString);

            string command = "SELECT * FROM [User];";
            SqlCommand sqlCommand = new SqlCommand(command, connection);

            connection.Open();

            // Prepare reader to loop through the table
            using SqlDataReader reader = sqlCommand.ExecuteReader();

            // Getting each row one by one
            while (reader.Read())
            {
                // Print User Name here 
                Console.WriteLine(reader.GetString(1));
            }
            Console.WriteLine("THE END");
        }
    }
}