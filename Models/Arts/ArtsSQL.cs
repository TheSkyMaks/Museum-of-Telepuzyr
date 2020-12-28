using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace web.Models.Arts
{
    public class ArtsSQL
    {
        public List<Art> imgData;
        public void StartArtsSQL()
        {
            try
            {
                var connectionString = "";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM MuseumDB.Arts", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            imgData = new List<Art>();
                            while (reader.Read())
                            {
                                imgData.Add(new Art { Id = reader.GetInt32(0), NameOfArt = reader.GetString(1), LinkOfArt = reader.GetString(2), DateCreationOfArt = reader.GetString(3) });
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
