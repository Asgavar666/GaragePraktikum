using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.IdentityModel.Tokens;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
namespace Garage
{
    public partial class GarageApp : Form
    {
        DataBase DB = new DataBase();
        LevelGeneration LvG = new LevelGeneration();
        ParkingSystem PkS = new ParkingSystem();
        level lv = new level();
        PlateNrFinder PnF = new PlateNrFinder();
        VehicleRemover VR = new VehicleRemover();

        public GarageApp()
        {
            InitializeComponent();

            ShowFloor();
            AdjustDataGridViewHeight(FloorList);
            BtnParken.Visible = false;

            
            PanelEntry.Visible = true;
            PanelOut.Visible = true;
            PanelEtagenManager.Visible = false;
            panelSearch.Visible = false;
        }
       

        private void ShowFloor()
        {

            DB.LoadDataIntoDataGridView(FloorList);

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

                    LvG.RemoveParkingSpotsTable(Floor);
                    LvG.CreateParkingSpotsTable(Floor);
                    LvG.GetNumParkingSpots(Floor);
                    LvG.populateWithParkingSpots(Floor);


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

            DB.UpdateData(floor, cars, motorbikes);

            LvG.RemoveParkingSpotsTable(floor);
            LvG.CreateParkingSpotsTable(floor);
            LvG.GetNumParkingSpots(floor);
            LvG.populateWithParkingSpots(floor);



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
                    //DB.removeSpots(Floor);
                    LvG.RemoveParkingSpotsTable(Floor);
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
            panelSearch.Visible = true;
            PanelEntry.Visible = false;
            PanelOut.Visible = false;

        }

        private void LbEinfahrt_Click(object sender, EventArgs e)
        {
            PanelEtagenManager.Visible = false;
            panelSearch.Visible = false;
            PanelEntry.Visible = true;
            PanelOut.Visible = true;
        }






        private void BtnParken_Click(object sender, EventArgs e)
        {
            string licencePlate = TbPlate.Text.ToString();
            string floor = TbFloorNr.Text.ToString();

            if (!licencePlate.IsNullOrEmpty() && (RbAuto.Checked || RbMotorrad.Checked))
            {

                string tableName = LbEtageFrei.Text;
                int SpotID = Convert.ToInt32(LbPlatzFrei.Text);
                PkS.ParkVehicle(tableName, SpotID, licencePlate);
                LbIn.Text = "Ihr Fahrzeug ist bei uns sicher eingeparkt.";


                BtnParken.Visible = false;



            }


        }

        private void BtnFindParking_Click(object sender, EventArgs e)
        {
            string licencePlate = TbPlate.Text.ToString();
            string type = "";
            if (!licencePlate.IsNullOrEmpty() && (RbAuto.Checked || RbMotorrad.Checked))
            {
                if (RbAuto.Checked)
                {
                    type = "Car";
                }
                else
                {
                    type = "Motorbike";
                }



                (string TableName, int SpotID) result = PkS.FindFirstFreeCarSpot(type);
                var (tableName, spotID) = result;
                LbEtageFrei.Text = tableName;
                LbPlatzFrei.Text = spotID.ToString();


                BtnParken.Visible = true;


            }

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void BtnFindVehicle_Click(object sender, EventArgs e)
        {
            string plateNr = TbPlateToFind.Text.ToString();
            DataTable plateNrInfo = PnF.SearchVehicleByPlateNumber(plateNr);
            dataGridView2.DataSource = plateNrInfo;
            AdjustDataGridViewHeight(dataGridView2);
        }

        private void TbPlateToFind_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void BtnDriveOut_Click(object sender, EventArgs e)
        {
            string plateNr = TbDriveOut.Text.ToString();
            bool removed = VR.RemoveVehicle(plateNr);
            if (removed)
            {
                LbOut.Text = "Vielen Dank für die Nutzung unseres Garages!";
            }

        }

        private void TbDriveOut_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

       

       

       

       

        

        

        
    }
}
