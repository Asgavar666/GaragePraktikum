
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Garage
{
     class DataBase
    {
        
        private MySqlCommand Cmd;
        private DataTable dt;
        private MySqlDataAdapter Sda;
        private string ConStr;

        public DataBase()
        {
            ConStr = "Server=localhost;Database=Garage;User=root;Password='';";

            Cmd = new MySqlCommand();
            

        }
        //public DataTable GetData( string floor, int numberPlacesLarge, int numberPlacesSmall)
        //{
        //    string Query = "insert into Tb_etagen values(@Floor, @NumberPlacesLarge, @NumberPlacesSmall);";



        //    Cmd.Parameters.AddWithValue("@Floor", floor);
        //    Cmd.Parameters.AddWithValue("@NumberPlacesLarge", numberPlacesLarge);
        //    Cmd.Parameters.AddWithValue("@NumberPlacesSmall", numberPlacesSmall);
        //    dt = new DataTable();
        //    Sda = new SqlDataAdapter(Query,ConStr);
        //    Sda.Fill(dt);
        //    return dt;
        //}
        public void makeCarSpots(string floor, int quantity) 
        {
            string Query = "INSERT INTO floor_spots (carspot) VALUES (True);";

            using (MySqlConnection connection = new MySqlConnection(ConStr))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                {
                    for(int i = 0; i < quantity; i++)
                    {
                        cmd.ExecuteNonQuery();
                         
                    }
                    
                    
                }
            }
        }



        public void removeSpots(string floor) 
        {
            string Query = "delete from floor_spots where floorID = (select f.floor_ID from floors f where f.floor_Name = @floor );";

            using (MySqlConnection connection = new MySqlConnection(ConStr))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@Floor", floor);
                   

                    cmd.ExecuteNonQuery(); 
                }
            }
        }

        public void InsertData(string floor, int numberPlacesLarge, int numberPlacesSmall)
        {
            string Query = "INSERT INTO floors(floor_Name, car_Spots, motorbike_Spots) VALUES (@Floor, @NumberPlacesLarge, @NumberPlacesSmall);";

            using (MySqlConnection connection = new MySqlConnection(ConStr))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@Floor", floor);
                    cmd.Parameters.AddWithValue("@NumberPlacesLarge", numberPlacesLarge);
                    cmd.Parameters.AddWithValue("@NumberPlacesSmall", numberPlacesSmall);

                    cmd.ExecuteNonQuery(); 
                }
            }
        }

        public void UpdateData(string floor, string numberPlacesLarge, string numberPlacesSmall)
        {
            
            using (MySqlConnection connection = new MySqlConnection(ConStr))
            {
                connection.Open();
                if(!string.IsNullOrEmpty(floor) && !string.IsNullOrEmpty(numberPlacesLarge) && !string.IsNullOrEmpty(numberPlacesSmall))
                    {
                    int large = Convert.ToInt32(numberPlacesLarge);
                    int small = Convert.ToInt32(numberPlacesSmall);
                        string Query = "update floors set car_Spots = @large, motorbike_Spots = @small where floor_Name = @floor;";
                        using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                        {
                    
                            cmd.Parameters.AddWithValue("@large", large);
                            cmd.Parameters.AddWithValue("@small", small);
                            cmd.Parameters.AddWithValue("@floor", floor);
                            cmd.ExecuteNonQuery();
                        }    

                    }
                else if (!string.IsNullOrEmpty(floor) && !string.IsNullOrEmpty(numberPlacesLarge) && string.IsNullOrEmpty(numberPlacesSmall))
                {
                    string Query = "update floors set car_Spots = @large where floor_Name = @floor;";
                    using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                    {
                        int large = Convert.ToInt32(numberPlacesLarge);

                        cmd.Parameters.AddWithValue("@large", large);
                        cmd.Parameters.AddWithValue("@floor", floor);
                        cmd.ExecuteNonQuery();
                    }
                }
                else if(!string.IsNullOrEmpty(floor) && string.IsNullOrEmpty(numberPlacesLarge) && !string.IsNullOrEmpty(numberPlacesSmall))
                {
                    string Query = "update floors set motorbike_Spots = @small where floor_Name = @floor;";
                    using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                    {
                        int small = Convert.ToInt32(numberPlacesSmall);

                        cmd.Parameters.AddWithValue("@small", small);
                        cmd.Parameters.AddWithValue("@floor", floor);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Etage nicht geändert, fehlende Daten");
                }

                
            }
        }





        public void LoadDataIntoDataGridView(DataGridView dataGridView)
        {
            string connStr =  "Server=localhost;Database=Garage;User=root;Password='';";
            string query = "SELECT * FROM floors;";

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dataGridView.DataSource = table;
                    }
                }
            }
        }


        public void DeleteFloor(string floor) 
        {
            string query = "DELETE FROM floors WHERE floor_Name = @floor;";

            using (MySqlConnection connection = new MySqlConnection(ConStr))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@floor", floor);
                    

                    cmd.ExecuteNonQuery(); 
                }
            }

        }




        
    }
}
