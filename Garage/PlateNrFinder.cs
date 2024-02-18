using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{

    public class PlateNrFinder
    {
        private string ConStr;
        public PlateNrFinder()
        {
            ConStr = "Server=localhost;Database=Garage;User=root;Password='';";
        }

        


        public DataTable SearchVehicleByPlateNumber(string plateNr)
        {
            using (MySqlConnection connection = new MySqlConnection(ConStr))
            {
                connection.Open();

                // Query to get all table names in the "Garage" database
                string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'garage';";

                DataTable tables = new DataTable();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(tables);
                    }
                }

                DataTable result = new DataTable();
                foreach (DataRow row in tables.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    if (tableName.EndsWith("_floor"))
                    {
                        // Query to find the vehicle data by plate number in the table
                        query = $"SELECT * FROM {tableName} WHERE plateNr = @plateNr;";
                        using (MySqlCommand searchCommand = new MySqlCommand(query, connection))
                        {
                            searchCommand.Parameters.AddWithValue("@plateNr", plateNr);
                            using (MySqlDataAdapter searchAdapter = new MySqlDataAdapter(searchCommand))
                            {
                                DataTable searchResult = new DataTable();
                                searchAdapter.Fill(searchResult);
                                if (searchResult.Rows.Count > 0)
                                {
                                    // If found, add the table name as a column to the result and merge the results
                                    searchResult.Columns.Add("TableName", typeof(string));
                                    foreach (DataRow dataRow in searchResult.Rows)
                                    {
                                        dataRow["TableName"] = tableName;
                                    }
                                    if (result.Columns.Count == 0)
                                    {
                                        result = searchResult.Copy();
                                    }
                                    else
                                    {
                                        result.Merge(searchResult);
                                    }
                                }
                            }
                        }
                    }
                }

                return result;
            }
        }






    }
}
