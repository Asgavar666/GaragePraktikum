﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{
     class DataBase
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConStr;

        public DataBase()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kbade\Documents\GarageBD.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;

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
        

        public void InsertData(string floor, int numberPlacesLarge, int numberPlacesSmall)
        {
            string Query = "INSERT INTO floors(floor_Name, car_Spots, motorbike_Spots) VALUES (@Floor, @NumberPlacesLarge, @NumberPlacesSmall);";

            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@Floor", floor);
                    cmd.Parameters.AddWithValue("@NumberPlacesLarge", numberPlacesLarge);
                    cmd.Parameters.AddWithValue("@NumberPlacesSmall", numberPlacesSmall);

                    cmd.ExecuteNonQuery(); // Executes the INSERT statement
                }
            }
        }

        public void LoadDataIntoDataGridView(DataGridView dataGridView)
        {
            
            string query = "SELECT floor_Name, car_Spots, motorbike_Spots FROM floors";

            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, Con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        
                        BindingSource bindingSource = new BindingSource();
                        bindingSource.DataSource = table;

                        
                        dataGridView.DataSource = bindingSource;
                    }
                }
            }
        }
        public void DeleteFloor(string floor) 
        {
            string query = "DELETE FROM floors WHERE floor = @etage;";

            using (SqlConnection connection = new SqlConnection(ConStr))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@etage", floor);
                    

                    cmd.ExecuteNonQuery(); 
                }
            }

        }




        
    }
}