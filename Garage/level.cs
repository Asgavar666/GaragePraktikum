using Microsoft.Data.SqlClient;
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
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kbade\Documents\GarageBD.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public string GetFloorWithSpots() 
        {
            string Query = "SELECT TOP 1 f.floor_Name FROM floors f JOIN floor_spots fs ON f.floor_ID = fs.floorID WHERE fs.taken = 0 ORDER BY f.floor_ID;";

            string floorName = null;
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                using(SqlCommand cmd = new SqlCommand(Query, connection))
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
                        using (SqlCommand cmdFirstFloor = new SqlCommand(getFirstFloorQuery, connection))
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
            
            string Query = "select top 1 s.spot_ID from floor_spots s join floors f on s.floorID = (select f.floor_ID where f.floor_Name = @floor) where s.taken = 0 and s.carspot = 1  order by s.spot_ID; ";
            int parkingSpot = 0;
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, connection))
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
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, connection))
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
            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, connection))
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

                using (SqlConnection connection = new SqlConnection(ConStr))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, connection))
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
