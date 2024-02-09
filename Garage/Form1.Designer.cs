namespace Garage
{
    partial class Form1
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            LbEinfahrt = new Label();
            LbEtagenManager = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            TbFloorNr = new TextBox();
            TbPlacesLargeNr = new TextBox();
            label11 = new Label();
            TbPlacesSmallNr = new TextBox();
            label12 = new Label();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            FloorList = new DataGridView();
            PanelEtagenManager = new Panel();
            PanelEntry = new Panel();
            label3 = new Label();
            label2 = new Label();
            BtnParken = new Button();
            TbPlate = new TextBox();
            label15 = new Label();
            RbMotorrad = new RadioButton();
            RbAuto = new RadioButton();
            label14 = new Label();
            label13 = new Label();
            label16 = new Label();
            LbEtageFrei = new Label();
            LbPlatzFrei = new Label();
            label19 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FloorList).BeginInit();
            PanelEtagenManager.SuspendLayout();
            PanelEntry.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(LbEinfahrt);
            panel1.Controls.Add(LbEtagenManager);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 1031);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Garage.Properties.Resources.fast_sport_car_silhouette_Graphics_6979291_1_580x387;
            pictureBox1.Location = new Point(3, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 865);
            label8.Name = "label8";
            label8.Padding = new Padding(5);
            label8.Size = new Size(74, 28);
            label8.TabIndex = 8;
            label8.Text = "Logout";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(97, 452);
            label7.Name = "label7";
            label7.Size = new Size(83, 18);
            label7.TabIndex = 7;
            label7.Text = "Company";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 413);
            label6.Name = "label6";
            label6.Size = new Size(69, 18);
            label6.TabIndex = 6;
            label6.Text = "Profiles";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 312);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 5;
            label5.Text = "Clears";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 370);
            label4.Name = "label4";
            label4.Size = new Size(76, 18);
            label4.TabIndex = 4;
            label4.Text = "Settings";
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
            LbEtagenManager.Location = new Point(73, 222);
            LbEtagenManager.Name = "LbEtagenManager";
            LbEtagenManager.Size = new Size(140, 18);
            LbEtagenManager.TabIndex = 2;
            LbEtagenManager.Text = "Etagen Manager";
            LbEtagenManager.Click += LbEtagenManager_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(216, 217, 218);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(284, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(2280, 79);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F);
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 59);
            label1.TabIndex = 2;
            label1.Text = "Garage";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 23);
            label9.Name = "label9";
            label9.Size = new Size(140, 18);
            label9.TabIndex = 2;
            label9.Text = "Etagen Manager";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(70, 84);
            label10.Name = "label10";
            label10.Size = new Size(61, 18);
            label10.TabIndex = 3;
            label10.Text = "Etage ";
            // 
            // TbFloorNr
            // 
            TbFloorNr.Location = new Point(70, 105);
            TbFloorNr.Name = "TbFloorNr";
            TbFloorNr.Size = new Size(117, 27);
            TbFloorNr.TabIndex = 4;
            // 
            // TbPlacesLargeNr
            // 
            TbPlacesLargeNr.Location = new Point(270, 105);
            TbPlacesLargeNr.Name = "TbPlacesLargeNr";
            TbPlacesLargeNr.Size = new Size(164, 27);
            TbPlacesLargeNr.TabIndex = 6;
            TbPlacesLargeNr.KeyPress += TbPlacesLargeNr_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(270, 84);
            label11.Name = "label11";
            label11.Size = new Size(164, 18);
            label11.TabIndex = 5;
            label11.Text = "Parkplätze groß No";
            // 
            // TbPlacesSmallNr
            // 
            TbPlacesSmallNr.Location = new Point(470, 105);
            TbPlacesSmallNr.Name = "TbPlacesSmallNr";
            TbPlacesSmallNr.Size = new Size(167, 27);
            TbPlacesSmallNr.TabIndex = 8;
            TbPlacesSmallNr.KeyPress += TbPlacesSmallNr_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(470, 84);
            label12.Name = "label12";
            label12.Size = new Size(167, 18);
            label12.TabIndex = 7;
            label12.Text = "Parkplätze klein No";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(70, 174);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(96, 30);
            BtnAdd.TabIndex = 9;
            BtnAdd.Text = "Einlegen";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(195, 174);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(96, 30);
            BtnEdit.TabIndex = 10;
            BtnEdit.Text = "Ändern";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(323, 174);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(96, 30);
            BtnDelete.TabIndex = 11;
            BtnDelete.Text = "Löschen";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // FloorList
            // 
            FloorList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FloorList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            FloorList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FloorList.Location = new Point(24, 219);
            FloorList.Name = "FloorList";
            FloorList.Size = new Size(595, 38);
            FloorList.TabIndex = 12;
            // 
            // PanelEtagenManager
            // 
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
            PanelEtagenManager.Location = new Point(290, 85);
            PanelEtagenManager.Name = "PanelEtagenManager";
            PanelEtagenManager.Size = new Size(1287, 808);
            PanelEtagenManager.TabIndex = 13;
            // 
            // PanelEntry
            // 
            PanelEntry.Controls.Add(LbPlatzFrei);
            PanelEntry.Controls.Add(label19);
            PanelEntry.Controls.Add(LbEtageFrei);
            PanelEntry.Controls.Add(label16);
            PanelEntry.Controls.Add(label3);
            PanelEntry.Controls.Add(label2);
            PanelEntry.Controls.Add(BtnParken);
            PanelEntry.Controls.Add(TbPlate);
            PanelEntry.Controls.Add(label15);
            PanelEntry.Controls.Add(RbMotorrad);
            PanelEntry.Controls.Add(RbAuto);
            PanelEntry.Controls.Add(label14);
            PanelEntry.Controls.Add(label13);
            PanelEntry.Location = new Point(287, 85);
            PanelEntry.Name = "PanelEntry";
            PanelEntry.Size = new Size(1287, 808);
            PanelEntry.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 123);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 76);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // BtnParken
            // 
            BtnParken.Location = new Point(97, 442);
            BtnParken.Name = "BtnParken";
            BtnParken.Size = new Size(75, 31);
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
            label13.Location = new Point(97, 23);
            label13.Name = "label13";
            label13.Size = new Size(72, 18);
            label13.TabIndex = 0;
            label13.Text = "Einfahrt";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(563, 285);
            label16.Name = "label16";
            label16.Size = new Size(153, 18);
            label16.TabIndex = 9;
            label16.Text = "Erste freie Etage:";
            // 
            // LbEtageFrei
            // 
            LbEtageFrei.AutoSize = true;
            LbEtageFrei.Location = new Point(731, 285);
            LbEtageFrei.Name = "LbEtageFrei";
            LbEtageFrei.Size = new Size(17, 18);
            LbEtageFrei.TabIndex = 10;
            LbEtageFrei.Text = "?";
            // 
            // LbPlatzFrei
            // 
            LbPlatzFrei.AutoSize = true;
            LbPlatzFrei.Location = new Point(731, 328);
            LbPlatzFrei.Name = "LbPlatzFrei";
            LbPlatzFrei.Size = new Size(17, 18);
            LbPlatzFrei.TabIndex = 12;
            LbPlatzFrei.Text = "?";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(563, 328);
            label19.Name = "label19";
            label19.Size = new Size(159, 18);
            label19.TabIndex = 11;
            label19.Text = "Erster freier platz:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2564, 1031);
            Controls.Add(PanelEntry);
            Controls.Add(PanelEtagenManager);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FloorList).EndInit();
            PanelEtagenManager.ResumeLayout(false);
            PanelEtagenManager.PerformLayout();
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
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
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
        private Label label3;
        private Label label2;
        private Label LbEtageFrei;
        private Label label16;
        private Label LbPlatzFrei;
        private Label label19;
    }
}
