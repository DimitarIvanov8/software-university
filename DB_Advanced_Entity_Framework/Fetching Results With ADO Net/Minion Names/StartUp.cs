using System;
using System.Data.SqlClient;

namespace Minion_Names
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=.;" +
                "Database=MinionsDB;Integrated Security=True";
            var connection = new SqlConnection(connectionString);

            int villainId = int.Parse(Console.ReadLine());

            connection.Open();
            using (connection)
            {
                string villainQuery = "SELECT [Name] FROM Villains WHERE Id = @villainId";
                var villainCommand = new SqlCommand(villainQuery, connection);
                villainCommand.Parameters.AddWithValue("@villainId", villainId);

                var reader = villainCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Villain: {reader[0]}");
                }
                reader.Close();

                string minionsQuery = "SELECT m.[Name], m.Age FROM Minions AS m " +
                    "JOIN MinionsVillains AS mv ON m.Id = mv.MinionId " +
                    "WHERE mv.VillainId = @villainId";
                var minionCommand = new SqlCommand(minionsQuery, connection);
                minionCommand.Parameters.AddWithValue("@villainId", villainId);
                reader = minionCommand.ExecuteReader();
                int counter = 1;
                while (reader.Read())
                {
                    Console.WriteLine($"{counter}. {reader[0]} {reader[1]}");
                    counter++;
                }
            }
        }
    }
}
