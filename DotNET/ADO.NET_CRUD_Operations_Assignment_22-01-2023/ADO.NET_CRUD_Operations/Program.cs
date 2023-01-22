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
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                // Getting each row one by one
                while (reader.Read())
                {
                    // Print User Name here 
                    Console.WriteLine(reader.GetString(1));
                }
            }

            // INSERT Operation
            string insertUserQuery = "INSERT INTO [User] (ID,Name) VALUES (@ID, @Name)";
            SqlCommand insertCommand = new SqlCommand(insertUserQuery, connection);
            insertCommand.Parameters.AddWithValue("@ID", 3);
            insertCommand.Parameters.AddWithValue("@Name", "Yamna");

            int recordsAdded = insertCommand.ExecuteNonQuery();
            Console.WriteLine($"{recordsAdded} no of records added");

            // UPDATE Operation
            string updateUserQuery = "UPDATE [User] SET Name=@Name WHERE ID=@ID";
            SqlCommand updateCommand = new SqlCommand(updateUserQuery, connection);
            updateCommand.Parameters.AddWithValue("@Name", "SabaY");
            updateCommand.Parameters.AddWithValue("@ID", 1);

            int recordsUpdated = updateCommand.ExecuteNonQuery();
            Console.WriteLine($"{recordsUpdated} no of records updated");

            // DELETE Operations
            string deleteUserQuery = "DELETE * FROM [User] WHERE ID=@ID";
            SqlCommand deleteCommand = new SqlCommand(deleteUserQuery, connection);
            deleteCommand.Parameters.AddWithValue("@ID", 1);

            int recordsDeleted = updateCommand.ExecuteNonQuery();
            Console.WriteLine($"{recordsDeleted} no of records deleted");


            Console.WriteLine("\n\nTHE END");
        }
    }
}