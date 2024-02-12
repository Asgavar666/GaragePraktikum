using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.IdentityModel.Tokens;
namespace Garage
{
    public partial class Form1 : Form
    {
        DataBase DB = new DataBase();
        level lv = new level();

        VehicleSize smallSpotSize = VehicleSize.Small;
        VehicleSize largeSpotSize = VehicleSize.Large;
        public Form1()
        {
            InitializeComponent();

            ShowFloor();
            AdjustDataGridViewHeight(FloorList);
        }
        //DB Con;

        private void ShowFloor()
        {

            DB.LoadDataIntoDataGridView(FloorList);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private int GetFreeSpots(int spotsTotal, int spotsTaken) 
        {
            return spotsTotal - spotsTaken;
        }
        

        private void BtnAdd_Click(object sender, EventArgs e)
        {


            if (TbFloorNr.Text.IsNullOrEmpty() || TbPlacesLargeNr.Text.IsNullOrEmpty() || TbPlacesSmallNr.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Füllen Sie bitte alle Datenfeldern aus");
            }
            else
            {
                try
                {
                    string Floor = TbFloorNr.Text.ToString();
                    int numberPlacesLarge = int.Parse(TbPlacesLargeNr.Text);
                    int numberPlacesSmall = int.Parse(TbPlacesSmallNr.Text);
                    DB.InsertData(Floor, numberPlacesLarge, numberPlacesSmall);
                   // DB.makeSpots();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            ShowFloor();
            AdjustDataGridViewHeight(FloorList);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string floor = TbFloorNr.Text.ToString();
            string cars = TbPlacesLargeNr.Text.ToString();
            string motorbikes = TbPlacesSmallNr.Text.ToString();

            DB.UpdateData(floor,cars,motorbikes);




            ShowFloor();
            AdjustDataGridViewHeight(FloorList);

        }
           
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TbFloorNr.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Bitte tippen Sie ein, welche Etage gelöscht werden soll");
            }
            else
            {
                try
                {
                    string Floor = TbFloorNr.Text.ToString();
                    DB.removeSpots(Floor);
                    DB.DeleteFloor(Floor);
                    ShowFloor();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            ShowFloor();
            AdjustDataGridViewHeight(FloorList);
        }
        //make DataBase table and FloorList to be the same height
        public void AdjustDataGridViewHeight(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;

            // Calculate the total height of the rows
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;

            // Additional space for row borders
            totalHeight += dgv.Rows.Count * 4; //   4 pixels per row border (top + bottom)

            // Set the DataGridView's client size to the calculated height
            dgv.ClientSize = new Size(dgv.ClientSize.Width, totalHeight);
        }


        private void TbPlacesLargeNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace) and digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbPlacesSmallNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like backspace) and digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LbEtagenManager_Click(object sender, EventArgs e)
        {
            PanelEtagenManager.Visible = true;
            PanelEntry.Visible = false;
        }

        private void LbEinfahrt_Click(object sender, EventArgs e)
        {
            PanelEtagenManager.Visible = false;
            PanelEntry.Visible = true;
        }

        




        private void BtnParken_Click(object sender, EventArgs e)
        {
            string licencePlate = TbPlate.Text.ToString();

             if (!licencePlate.IsNullOrEmpty())
            {
                if (RbAuto.Checked) 
                {
                    int Car = 1;
                    int Motorbike = 0;


                }
                else if (RbMotorrad.Checked) 
                {
                    int Car = 0;
                    int Motorbike = 1;
                }


                string floorWithSpots = lv.GetFloorWithSpots();
                int firstFreeSpot = lv.GetFirstCarSpot(floorWithSpots);
                LbEtageFrei.Text = floorWithSpots;
                LbPlatzFrei.Text = firstFreeSpot.ToString();

           

           
               

                
            }
            
            
        }
    }
}
