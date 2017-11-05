using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Print_All_Minion_Names
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=.;" +
                "Database=MinionsDB;Integrated Security=True";
            var connection = new SqlConnection(connectionString);

            connection.Open();
            using (connection)
            {
                try
                {
                    var command = new SqlCommand("SELECT Name FROM Minions", connection);
                    var reader = command.ExecuteReader();
                    var names = new List<string>();
                    using (reader)
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                names.Add(Convert.ToString(reader[0]));
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                    for (int i = 0; i < names.Count / 2; i++)
                    {
                        Console.WriteLine(names[i]);
                        Console.WriteLine(names[names.Count - 1 - i]);
                    }
                    if (names.Count % 2 != 0)
                    {
                        Console.WriteLine(names[names.Count / 2]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
