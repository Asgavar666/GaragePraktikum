using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Garage
{
    public class level
    {
        private string ConStr;
        public level() 
        {
            ConStr = "Server=localhost;Database=Garage;User=root;Password='';";
        }



        public string GetFloorWithSpots() 
        {
            
            string Query = "SELECT f.floor_Name \r\nFROM floors f \r\nJOIN {tableName} fs ON f.floor_ID = fs.floorID \r\nWHERE fs.taken = 0 \r\nORDER BY f.floor_ID\r\nLIMIT 1;\r\n";

            string floorName = null;
            using (MySqlConnection connection = new MySqlConnection(ConStr))
            {
                connection.Open();
                using(MySqlCommand cmd = new MySqlCommand(Query, connection))
                {
                   object result = cmd.ExecuteScalar();
                    if (result != null) // Check if result is not null
                    {
                        floorName = result.ToString(); // Convert the result to string
                    }
                    else
                    {
                        // If no floor with free spots is found, get the first floor name directly
                        string getFirstFloorQuery = "SELECT TOP 1 floor_Name FROM floors ORDER BY floor_ID;";
                        using (MySqlCommand cmdFirstFloor = new MySqlCommand(getFirstFloorQuery, connection))
                        {
                            object firstFloorResult = cmdFirstFloor.ExecuteScalar();
                            if (firstFloorResult != null)
                            {
                                floorName = firstFloorResult.ToString();
                            }
                        }
                    }
                }
            
            }
            return floorName;
        }
        public int GetFirstCarSpot(string floor) 
        {
            
            string Query = "SELECT s.spotID \r\nFROM a_floor s \r\nJOIN floors f ON s.floorID = (SELECT f.floor_ID FROM floors f WHERE f.floor_Name = 'A') \r\nWHERE s.IsOccupied = 0 AND s.VehicleType = 'car'  \r\nORDER BY s.spotID \r\nLIMIT 1;\r\n ";
            int parkingSpot = 0;
            using (MySqlConnection connection = new MySqlConnection(ConStr))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@floor", floor);
                    object result = cmd.ExecuteScalar();
                    if (result != null) // Check if result is not null
                    {
                        parkingSpot = Convert.ToInt32(result);
                    }
                    
                }

            }
            return parkingSpot;
        }

        public int GetLargeSpotsCount(string floor)
        {

            string Query = "select car_Spots from floors where floor_Name = @floor;";
            int numberLargeSpots = 0;
            using (MySqlConnection connection = new MySqlConnection(ConStr))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@floor", floor);


                     object result = cmd.ExecuteScalar();

                    numberLargeSpots = Convert.ToInt32(result);
                }

            }
            return numberLargeSpots;
        }

        public int GetSmallSpotsCount(string floor)
        {
            string Query = "select motorbike_Spots from floors where floor_Name = @floor;";
            int numberSmallSpots = 0;
            using (MySqlConnection connection = new MySqlConnection(ConStr))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@floor", floor);


                    object result = cmd.ExecuteScalar();

                    numberSmallSpots = Convert.ToInt32(result);
                }

            }
            return numberSmallSpots;
        }

        //public int GetParkedLargeCount()
        //{
        //    string Query = "select count(*) from Tb_fahrzeug where Car = 1";

        //    using (SqlConnection connection = new SqlConnection(ConStr))
        //    {
        //        connection.Open();
        //        using (SqlCommand cmd = new SqlCommand(Query, connection))
        //        {



        //            int numberLargeSpotsTaken = cmd.ExecuteNonQuery();

        //            return numberLargeSpotsTaken;
        //        }

        //    }
        //}
        //public int GetParkedSmallCount()
        //{
        //    string Query = "select count(*) from Tb_fahrzeug where Motorrad = 1";

        //    using (SqlConnection connection = new SqlConnection(ConStr))
        //    {
        //        connection.Open();
        //        using (SqlCommand cmd = new SqlCommand(Query, connection))
        //        {



        //            int numberLargeSpotsTaken = cmd.ExecuteNonQuery();

        //            return numberLargeSpotsTaken;
        //        }

        //    }
        //}

        public void ParkVehicle(int Car, int Motorbike, string licencePlate)
        {
            
            
                string Query = "INSERT INTO Tb_fahrzeug(Kennz, Car, Motorrad) VALUES (@Kennz, @Car, @Motorrad);";

                using (MySqlConnection connection = new MySqlConnection(ConStr))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Kennz", licencePlate);
                        cmd.Parameters.AddWithValue("@Car", Car);
                        cmd.Parameters.AddWithValue("@Motorrad", Motorbike);


                    cmd.ExecuteNonQuery(); 
                    }
                }
            
        }




    }
}
