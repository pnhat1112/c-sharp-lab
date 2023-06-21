namespace UI
{
    partial class CarManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtReleasedYear = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.lbReleasedYear = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.lbCarID = new System.Windows.Forms.Label();
            this.lbCarName = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.dtGVListCar = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVListCar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReleasedYear
            // 
            this.txtReleasedYear.Location = new System.Drawing.Point(527, 84);
            this.txtReleasedYear.Name = "txtReleasedYear";
            this.txtReleasedYear.Size = new System.Drawing.Size(205, 23);
            this.txtReleasedYear.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(527, 49);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(205, 23);
            this.txtPrice.TabIndex = 17;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(159, 89);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(205, 23);
            this.txtCarName.TabIndex = 16;
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(159, 54);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(205, 23);
            this.txtCarID.TabIndex = 15;
            // 
            // lbReleasedYear
            // 
            this.lbReleasedYear.AutoSize = true;
            this.lbReleasedYear.Location = new System.Drawing.Point(418, 92);
            this.lbReleasedYear.Name = "lbReleasedYear";
            this.lbReleasedYear.Size = new System.Drawing.Size(78, 15);
            this.lbReleasedYear.TabIndex = 14;
            this.lbReleasedYear.Text = "Released Year";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(418, 57);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 15);
            this.lbPrice.TabIndex = 13;
            this.lbPrice.Text = "Price";
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(50, 130);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(79, 15);
            this.lbManufacturer.TabIndex = 12;
            this.lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(50, 62);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(39, 15);
            this.lbCarID.TabIndex = 11;
            this.lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(50, 97);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(60, 15);
            this.lbCarName.TabIndex = 10;
            this.lbCarName.Text = "Car Name";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(159, 130);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(205, 23);
            this.txtManufacturer.TabIndex = 19;
            // 
            // dtGVListCar
            // 
            this.dtGVListCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVListCar.Location = new System.Drawing.Point(50, 195);
            this.dtGVListCar.Name = "dtGVListCar";
            this.dtGVListCar.RowTemplate.Height = 25;
            this.dtGVListCar.Size = new System.Drawing.Size(685, 181);
            this.dtGVListCar.TabIndex = 20;
            this.dtGVListCar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVListCar_CellDoubleClick);
            this.dtGVListCar.DoubleClick += new System.EventHandler(this.dtGVListCar_DoubleClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(137, 163);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(366, 163);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(568, 163);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(366, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtGVListCar);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtReleasedYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.lbReleasedYear);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.lbCarID);
            this.Controls.Add(this.lbCarName);
            this.Name = "CarManagement";
            this.Text = "CarManagement";
            this.Load += new System.EventHandler(this.CarManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVListCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtReleasedYear;
        private TextBox txtPrice;
        private TextBox txtCarName;
        private TextBox txtCarID;
        private Label lbReleasedYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarID;
        private Label lbCarName;
        private TextBox txtManufacturer;
        private DataGridView dtGVListCar;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDel;
        private Button btnClose;
    }
}