using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Garage
{
    public class LevelGeneration
    {
        private string ConStr;
        public LevelGeneration()
        {
            ConStr = "Server=localhost;Database=Garage;User=root;Password='';";
        }

        public void RemoveParkingSpotsTable(string floor)
        {
            string connectionString = ConStr;
            string tableName = $"{floor}_floor";
            string deleteIfExists = $"DROP TABLE IF EXISTS {tableName};";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand deleteIfExistsCommand = new MySqlCommand(deleteIfExists, connection))
                    {
                        deleteIfExistsCommand.ExecuteNonQuery();
                        

                    }
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Failed to remove table" + ex.Message);
                }
            }
        }


        public void CreateParkingSpotsTable(string floor)
        {
            string connectionString = ConStr;
            string tableName = $"{floor}_floor";
            string createTableSql = $@"CREATE TABLE {tableName}(SpotID int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
                  FloorID int(11) DEFAULT NULL,
                  plateNr VARCHAR(48),
                  VehicleType varchar(10) NOT NULL CHECK (`VehicleType` in ('Car','Motorbike')),
                  IsOccupied tinyint(1) DEFAULT NULL,
                  FOREIGN KEY (`FloorID`) REFERENCES `floors`(`floor_ID`)
                );";

 







            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand createTableCommand = new MySqlCommand(createTableSql, connection))
                    {
                        createTableCommand.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Table " + tableName + " Could not be created " + ex.Message);
                }
            }

        }


        public Tuple<int, int> GetNumParkingSpots(string floor)
        {
            string connectionString = ConStr;
            int carSpots = 0;
            int motorbikeSpots = 0;
            string getSpotCountsSql = @"SELECT car_Spots, motorbike_Spots FROM floors WHERE floor_Name =  @floor;"; // Assuming we are dealing with a single floor

            using( MySqlConnection connection = new MySqlConnection( connectionString))
            {
                try
                {
                    connection.Open();

                    using(MySqlCommand getSpotCountsCommand = new MySqlCommand(getSpotCountsSql, connection))
                    {
                        getSpotCountsCommand.Parameters.AddWithValue("@floor", floor);
                        using(MySqlDataReader reader = getSpotCountsCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                 carSpots = reader.GetInt32(0);
                                 motorbikeSpots = reader.GetInt32(1);
                            }

                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error getting Parking spots " + ex.Message);
                }
            }
            return new Tuple<int, int>(carSpots, motorbikeSpots);
        }

        public void populateWithParkingSpots(string floor)
        {
            string connectionString = ConStr;
            string tableName = $"{floor}_floor";
            string getFloorID = "select floor_ID from floors where floor_Name = @floor;";
            string insertCarParkingSpots = $"INSERT INTO {tableName} (FloorID, VehicleType) VALUES (@FloorID, 'Car');";
            string insertMotorbikeParkingSpots = $"INSERT INTO {tableName} (FloorID, VehicleType) VALUES (@FloorID, 'Motorbike');";
            int floorID = 0;
            Tuple<int, int> ParkingSpotCounts = GetNumParkingSpots(floor);

            //get floor ID
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand getfloorIDCommand = new MySqlCommand(getFloorID, connection))
                    {
                        getfloorIDCommand.Parameters.AddWithValue("@floor", floor);
                       object result = getfloorIDCommand.ExecuteScalar();
                        if(result != null)
                        {
                            floorID = Convert.ToInt32(result);
                        }

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("error getting floor ID  " + ex.Message);
                }
                //start creating parking spots for cars

                try
                {
                    //connection.Open();

                    using (MySqlCommand insertCarParkingSpotsCommand = new MySqlCommand(insertCarParkingSpots, connection))
                    {
                        //insertCarParkingSpotsCommand.Parameters.AddWithValue("@tableName", tableName);
                        insertCarParkingSpotsCommand.Parameters.AddWithValue("@FloorID", floorID);

                        for (int i = 0; i < ParkingSpotCounts.Item1; i++)
                        {

                            insertCarParkingSpotsCommand.ExecuteNonQuery();
                        }
                    }
                    using (MySqlCommand insertMotorbikeParkingSpotsCommand = new MySqlCommand(insertMotorbikeParkingSpots, connection))
                    {
                       // insertMotorbikeParkingSpotsCommand.Parameters.AddWithValue("@tableName", tableName);
                        insertMotorbikeParkingSpotsCommand.Parameters.AddWithValue("@FloorID", floorID);

                        for (int i = 0; i < ParkingSpotCounts.Item2; i++)
                        {

                            insertMotorbikeParkingSpotsCommand.ExecuteNonQuery();
                        }
                    }


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("error creating parking spots  " + ex.Message);
                }
            }



        }


       
    }   
}
