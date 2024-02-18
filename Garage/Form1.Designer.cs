namespace Garage
{
    partial class GarageApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            LbEinfahrt = new Label();
            LbEtagenManager = new Label();
            PanelEtagenManager = new Panel();
            TbPlacesLargeNr = new TextBox();
            FloorList = new DataGridView();
            label9 = new Label();
            BtnDelete = new Button();
            label10 = new Label();
            BtnEdit = new Button();
            TbFloorNr = new TextBox();
            BtnAdd = new Button();
            label11 = new Label();
            TbPlacesSmallNr = new TextBox();
            label12 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            PanelOut = new Panel();
            LbOut = new Label();
            BtnDriveOut = new Button();
            label3 = new Label();
            TbDriveOut = new TextBox();
            label2 = new Label();
            panelSearch = new Panel();
            dataGridView2 = new DataGridView();
            label20 = new Label();
            label18 = new Label();
            BtnFindVehicle = new Button();
            TbPlateToFind = new TextBox();
            label17 = new Label();
            PanelEntry = new Panel();
            LbIn = new Label();
            BtnFindParking = new Button();
            LbPlatzFrei = new Label();
            label19 = new Label();
            LbEtageFrei = new Label();
            label16 = new Label();
            BtnParken = new Button();
            TbPlate = new TextBox();
            label15 = new Label();
            RbMotorrad = new RadioButton();
            RbAuto = new RadioButton();
            label14 = new Label();
            label13 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelEtagenManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FloorList).BeginInit();
            panel2.SuspendLayout();
            PanelOut.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            PanelEntry.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LbEinfahrt);
            panel1.Controls.Add(LbEtagenManager);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 941);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fast_sport_car_silhouette_Graphics_6979291_1_580x387;
            pictureBox1.Location = new Point(0, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LbEinfahrt
            // 
            LbEinfahrt.AutoSize = true;
            LbEinfahrt.Location = new Point(73, 259);
            LbEinfahrt.Name = "LbEinfahrt";
            LbEinfahrt.Size = new Size(72, 18);
            LbEinfahrt.TabIndex = 3;
            LbEinfahrt.Text = "Einfahrt";
            LbEinfahrt.Click += LbEinfahrt_Click;
            // 
            // LbEtagenManager
            // 
            LbEtagenManager.AutoSize = true;
            LbEtagenManager.Location = new Point(40, 220);
            LbEtagenManager.Name = "LbEtagenManager";
            LbEtagenManager.Size = new Size(140, 18);
            LbEtagenManager.TabIndex = 2;
            LbEtagenManager.Text = "Etagen Manager";
            LbEtagenManager.Click += LbEtagenManager_Click;
            // 
            // PanelEtagenManager
            // 
            PanelEtagenManager.Anchor = AnchorStyles.None;
            PanelEtagenManager.Controls.Add(TbPlacesLargeNr);
            PanelEtagenManager.Controls.Add(FloorList);
            PanelEtagenManager.Controls.Add(label9);
            PanelEtagenManager.Controls.Add(BtnDelete);
            PanelEtagenManager.Controls.Add(label10);
            PanelEtagenManager.Controls.Add(BtnEdit);
            PanelEtagenManager.Controls.Add(TbFloorNr);
            PanelEtagenManager.Controls.Add(BtnAdd);
            PanelEtagenManager.Controls.Add(label11);
            PanelEtagenManager.Controls.Add(TbPlacesSmallNr);
            PanelEtagenManager.Controls.Add(label12);
            PanelEtagenManager.Location = new Point(215, 83);
            PanelEtagenManager.Name = "PanelEtagenManager";
            PanelEtagenManager.Size = new Size(835, 800);
            PanelEtagenManager.TabIndex = 14;
            // 
            // TbPlacesLargeNr
            // 
            TbPlacesLargeNr.Anchor = AnchorStyles.None;
            TbPlacesLargeNr.Location = new Point(331, 240);
            TbPlacesLargeNr.Name = "TbPlacesLargeNr";
            TbPlacesLargeNr.Size = new Size(164, 27);
            TbPlacesLargeNr.TabIndex = 6;
            TbPlacesLargeNr.KeyPress += TbPlacesLargeNr_KeyPress;
            // 
            // FloorList
            // 
            FloorList.Anchor = AnchorStyles.None;
            FloorList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FloorList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            FloorList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FloorList.Location = new Point(142, 395);
            FloorList.Name = "FloorList";
            FloorList.Size = new Size(595, 38);
            FloorList.TabIndex = 12;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 16F);
            label9.Location = new Point(331, 70);
            label9.Name = "label9";
            label9.Size = new Size(192, 26);
            label9.TabIndex = 2;
            label9.Text = "Etagen Manager";
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.None;
            BtnDelete.Location = new Point(530, 344);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(96, 30);
            BtnDelete.TabIndex = 11;
            BtnDelete.Text = "Löschen";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(131, 219);
            label10.Name = "label10";
            label10.Size = new Size(61, 18);
            label10.TabIndex = 3;
            label10.Text = "Etage ";
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.None;
            BtnEdit.Location = new Point(402, 344);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(96, 30);
            BtnEdit.TabIndex = 10;
            BtnEdit.Text = "Ändern";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // TbFloorNr
            // 
            TbFloorNr.Anchor = AnchorStyles.None;
            TbFloorNr.Location = new Point(131, 240);
            TbFloorNr.Name = "TbFloorNr";
            TbFloorNr.Size = new Size(117, 27);
            TbFloorNr.TabIndex = 4;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.None;
            BtnAdd.Location = new Point(277, 344);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(96, 30);
            BtnAdd.TabIndex = 9;
            BtnAdd.Text = "Einlegen";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(331, 219);
            label11.Name = "label11";
            label11.Size = new Size(164, 18);
            label11.TabIndex = 5;
            label11.Text = "Parkplätze groß No";
            // 
            // TbPlacesSmallNr
            // 
            TbPlacesSmallNr.Anchor = AnchorStyles.None;
            TbPlacesSmallNr.Location = new Point(531, 240);
            TbPlacesSmallNr.Name = "TbPlacesSmallNr";
            TbPlacesSmallNr.Size = new Size(167, 27);
            TbPlacesSmallNr.TabIndex = 8;
            TbPlacesSmallNr.KeyPress += TbPlacesSmallNr_KeyPress;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(531, 219);
            label12.Name = "label12";
            label12.Size = new Size(167, 18);
            label12.TabIndex = 7;
            label12.Text = "Parkplätze klein No";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(216, 217, 218);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(209, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1799, 83);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F);
            label1.Location = new Point(108, 8);
            label1.Name = "label1";
            label1.Size = new Size(198, 59);
            label1.TabIndex = 2;
            label1.Text = "Garage";
            // 
            // PanelOut
            // 
            PanelOut.Controls.Add(LbOut);
            PanelOut.Controls.Add(BtnDriveOut);
            PanelOut.Controls.Add(label3);
            PanelOut.Controls.Add(TbDriveOut);
            PanelOut.Controls.Add(label2);
            PanelOut.Location = new Point(1165, 83);
            PanelOut.Name = "PanelOut";
            PanelOut.Size = new Size(843, 858);
            PanelOut.TabIndex = 14;
            // 
            // LbOut
            // 
            LbOut.AutoSize = true;
            LbOut.Font = new Font("Verdana", 18F);
            LbOut.ForeColor = Color.Green;
            LbOut.Location = new Point(196, 210);
            LbOut.Name = "LbOut";
            LbOut.Size = new Size(0, 29);
            LbOut.TabIndex = 4;
            // 
            // BtnDriveOut
            // 
            BtnDriveOut.Location = new Point(378, 129);
            BtnDriveOut.Name = "BtnDriveOut";
            BtnDriveOut.Size = new Size(101, 32);
            BtnDriveOut.TabIndex = 3;
            BtnDriveOut.Text = "Ausfahren";
            BtnDriveOut.UseVisualStyleBackColor = true;
            BtnDriveOut.Click += BtnDriveOut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 92);
            label3.Name = "label3";
            label3.Size = new Size(216, 18);
            label3.TabIndex = 2;
            label3.Text = "Nummernschild eintippen";
            // 
            // TbDriveOut
            // 
            TbDriveOut.Location = new Point(378, 83);
            TbDriveOut.Name = "TbDriveOut";
            TbDriveOut.Size = new Size(100, 27);
            TbDriveOut.TabIndex = 1;
            TbDriveOut.KeyPress += TbDriveOut_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 29);
            label2.Name = "label2";
            label2.Size = new Size(77, 18);
            label2.TabIndex = 0;
            label2.Text = "Ausfahrt";
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(dataGridView2);
            panelSearch.Controls.Add(label20);
            panelSearch.Controls.Add(label18);
            panelSearch.Controls.Add(BtnFindVehicle);
            panelSearch.Controls.Add(TbPlateToFind);
            panelSearch.Controls.Add(label17);
            panelSearch.Location = new Point(1244, 83);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(764, 846);
            panelSearch.TabIndex = 14;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(117, 272);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(528, 31);
            dataGridView2.TabIndex = 7;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(117, 243);
            label20.Name = "label20";
            label20.Size = new Size(91, 18);
            label20.TabIndex = 14;
            label20.Text = "Ausgabe: ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(39, 76);
            label18.Name = "label18";
            label18.Size = new Size(260, 18);
            label18.TabIndex = 3;
            label18.Text = "Hier nummernschild eintippen:";
            // 
            // BtnFindVehicle
            // 
            BtnFindVehicle.Location = new Point(329, 127);
            BtnFindVehicle.Name = "BtnFindVehicle";
            BtnFindVehicle.Size = new Size(131, 37);
            BtnFindVehicle.TabIndex = 5;
            BtnFindVehicle.Text = "Suchen";
            BtnFindVehicle.UseVisualStyleBackColor = true;
            BtnFindVehicle.Click += BtnFindVehicle_Click;
            // 
            // TbPlateToFind
            // 
            TbPlateToFind.Location = new Point(329, 73);
            TbPlateToFind.Name = "TbPlateToFind";
            TbPlateToFind.Size = new Size(131, 27);
            TbPlateToFind.TabIndex = 1;
            TbPlateToFind.KeyPress += TbPlateToFind_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(230, 17);
            label17.Name = "label17";
            label17.Size = new Size(319, 18);
            label17.TabIndex = 0;
            label17.Text = "Fahrzeug nach Nummernschild suchen";
            // 
            // PanelEntry
            // 
            PanelEntry.Controls.Add(LbIn);
            PanelEntry.Controls.Add(BtnFindParking);
            PanelEntry.Controls.Add(LbPlatzFrei);
            PanelEntry.Controls.Add(label19);
            PanelEntry.Controls.Add(LbEtageFrei);
            PanelEntry.Controls.Add(label16);
            PanelEntry.Controls.Add(BtnParken);
            PanelEntry.Controls.Add(TbPlate);
            PanelEntry.Controls.Add(label15);
            PanelEntry.Controls.Add(RbMotorrad);
            PanelEntry.Controls.Add(RbAuto);
            PanelEntry.Controls.Add(label14);
            PanelEntry.Controls.Add(label13);
            PanelEntry.Location = new Point(221, 83);
            PanelEntry.Name = "PanelEntry";
            PanelEntry.Size = new Size(829, 858);
            PanelEntry.TabIndex = 14;
            // 
            // LbIn
            // 
            LbIn.AutoSize = true;
            LbIn.Font = new Font("Verdana", 18F);
            LbIn.ForeColor = Color.Green;
            LbIn.Location = new Point(82, 609);
            LbIn.Name = "LbIn";
            LbIn.Size = new Size(0, 29);
            LbIn.TabIndex = 16;
            // 
            // BtnFindParking
            // 
            BtnFindParking.Location = new Point(74, 430);
            BtnFindParking.Name = "BtnFindParking";
            BtnFindParking.Size = new Size(226, 49);
            BtnFindParking.TabIndex = 13;
            BtnFindParking.Text = "Parkplatz finden";
            BtnFindParking.UseVisualStyleBackColor = true;
            BtnFindParking.Click += BtnFindParking_Click;
            // 
            // LbPlatzFrei
            // 
            LbPlatzFrei.AutoSize = true;
            LbPlatzFrei.Location = new Point(564, 473);
            LbPlatzFrei.Name = "LbPlatzFrei";
            LbPlatzFrei.Size = new Size(17, 18);
            LbPlatzFrei.TabIndex = 12;
            LbPlatzFrei.Text = "?";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(396, 473);
            label19.Name = "label19";
            label19.Size = new Size(159, 18);
            label19.TabIndex = 15;
            label19.Text = "Erster freier platz:";
            // 
            // LbEtageFrei
            // 
            LbEtageFrei.AutoSize = true;
            LbEtageFrei.Location = new Point(564, 430);
            LbEtageFrei.Name = "LbEtageFrei";
            LbEtageFrei.Size = new Size(17, 18);
            LbEtageFrei.TabIndex = 10;
            LbEtageFrei.Text = "?";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(396, 430);
            label16.Name = "label16";
            label16.Size = new Size(153, 18);
            label16.TabIndex = 9;
            label16.Text = "Erste freie Etage:";
            // 
            // BtnParken
            // 
            BtnParken.Location = new Point(73, 531);
            BtnParken.Name = "BtnParken";
            BtnParken.Size = new Size(226, 50);
            BtnParken.TabIndex = 6;
            BtnParken.Text = "Parken";
            BtnParken.UseVisualStyleBackColor = true;
            BtnParken.Click += BtnParken_Click;
            // 
            // TbPlate
            // 
            TbPlate.Location = new Point(242, 350);
            TbPlate.Name = "TbPlate";
            TbPlate.Size = new Size(176, 27);
            TbPlate.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(82, 353);
            label15.Name = "label15";
            label15.Size = new Size(133, 18);
            label15.TabIndex = 4;
            label15.Text = "Nummernschild";
            // 
            // RbMotorrad
            // 
            RbMotorrad.AutoSize = true;
            RbMotorrad.Location = new Point(227, 296);
            RbMotorrad.Name = "RbMotorrad";
            RbMotorrad.Size = new Size(98, 22);
            RbMotorrad.TabIndex = 3;
            RbMotorrad.TabStop = true;
            RbMotorrad.Text = "Motorrad";
            RbMotorrad.UseVisualStyleBackColor = true;
            // 
            // RbAuto
            // 
            RbAuto.AutoSize = true;
            RbAuto.Location = new Point(107, 296);
            RbAuto.Name = "RbAuto";
            RbAuto.Size = new Size(64, 22);
            RbAuto.TabIndex = 2;
            RbAuto.TabStop = true;
            RbAuto.Text = "Auto";
            RbAuto.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(73, 219);
            label14.Name = "label14";
            label14.Size = new Size(175, 18);
            label14.TabIndex = 1;
            label14.Text = "Fahrzeug Auswählen";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(407, 23);
            label13.Name = "label13";
            label13.Size = new Size(72, 18);
            label13.TabIndex = 0;
            label13.Text = "Einfahrt";
            // 
            // GarageApp
            // 
            AcceptButton = BtnAdd;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(2008, 941);
            Controls.Add(PanelEntry);
            Controls.Add(PanelEtagenManager);
            Controls.Add(PanelOut);
            Controls.Add(panelSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "GarageApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelEtagenManager.ResumeLayout(false);
            PanelEtagenManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FloorList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PanelOut.ResumeLayout(false);
            PanelOut.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            PanelEntry.ResumeLayout(false);
            PanelEntry.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label LbEtagenManager;
        private Label label1;
        private Label LbEinfahrt;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label10;
        private TextBox TbFloorNr;
        private TextBox TbPlacesLargeNr;
        private Label label11;
        private TextBox TbPlacesSmallNr;
        private Label label12;
        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnDelete;
        private DataGridView FloorList;
        private Panel PanelEtagenManager;
        private Panel PanelEntry;
        private Label label13;
        private Label label15;
        private RadioButton RbMotorrad;
        private RadioButton RbAuto;
        private Label label14;
        private TextBox TbPlate;
        private Button BtnParken;
        private Label LbEtageFrei;
        private Label label16;
        private Label LbPlatzFrei;
        private Label label19;
        private Button BtnFindParking;
        private Panel panelSearch;
        private Label label18;
        private Button BtnFindVehicle;
        private TextBox TbPlateToFind;
        private Label label17;
        private Label label20;
        private Panel PanelOut;
        private Label label2;
        private Button BtnDriveOut;
        private DataGridView dataGridView2;
        private Label label3;
        private TextBox TbDriveOut;
        private Label LbOut;
        private Label LbIn;
    }
}
