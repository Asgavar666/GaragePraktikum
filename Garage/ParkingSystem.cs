using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    
    public class ParkingSystem
    {
      private string ConStr;

        public ParkingSystem()
        {
            ConStr = "Server=localhost;Database=Garage;User=root;Password='';";
        }

            

       

        public void ParkVehicle(string TableName, int SpotID, string plateNr)
            {
                using(MySqlConnection connection = new MySqlConnection(ConStr))
                {
                    connection.Open();
                    string query = $"UPDATE {TableName}  SET plateNr = @plateNr, IsOccupied = 1 WHERE SpotID = @SpotID;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@plateNr", plateNr);
                        command.Parameters.AddWithValue("@SpotID", SpotID);
                        command.ExecuteNonQuery();
                    }
                }   
            }



            public (string TableName, int SpotID) FindFirstFreeCarSpot(string type)
            {
            using (MySqlConnection connection = new MySqlConnection(ConStr))
                {
                    connection.Open();

                    // Query to get all table names in the "Garage" database
                    string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'Garage';";

                    DataTable tables = new DataTable();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(tables);
                        }
                    }

                    foreach (DataRow row in tables.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();
                        if (tableName.EndsWith("_floor"))
                        {
                            int spotID = FindFreeCarSpotInTable(connection, tableName, type);
                            if (spotID != -1)
                            {
                                return (tableName, spotID);
                            }
                        }
                    }
                }

            // No free car spots found
            return (null, -1);
        }

        private int FindFreeCarSpotInTable(MySqlConnection connection, string tableName, string type )
        {
            int spotID = -1;

            // Query to find the first available car spot in the table
            string query = $"SELECT SpotID FROM {tableName} WHERE VehicleType = '{type}' AND (IsOccupied = 0 OR IsOccupied IS NULL) LIMIT 1;";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Retrieve the spot ID
                        spotID = reader.GetInt32(0);
                    }
                }
            }

            // No free car spots found in this table
            return spotID;
        }




    }

}

