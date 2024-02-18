using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class VehicleRemover
    {
        private string ConStr;
        public VehicleRemover() 
        {
            ConStr = "Server=localhost;Database=Garage;User=root;Password='';";
        }
        public bool RemoveVehicle(string plate)
        {
            bool removed = false;
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
                        bool spotFreed = RemoveCarSpotInTable(connection, tableName, plate);
                        if (spotFreed)
                        {
                            // If the spot is successfully freed, break the loop
                            removed = true;
                            break;
                        }
                    }
                }

            }
            return removed;
        }

        private bool RemoveCarSpotInTable(MySqlConnection connection, string tableName, string plate)
        {
            // Query to update the IsOccupied status and plateNr in the table
            string query = $"UPDATE {tableName} SET IsOccupied = 0, plateNr = NULL WHERE plateNr = @PlateNr;";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PlateNr", plate);
                int rowsAffected = command.ExecuteNonQuery();

                // If at least one row is affected, it means a spot was freed
                return rowsAffected > 0;
            }
        }
    }
}
