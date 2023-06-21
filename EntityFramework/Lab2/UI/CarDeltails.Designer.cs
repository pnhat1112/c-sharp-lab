namespace UI
{
    partial class CarDeltails
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCarName = new System.Windows.Forms.Label();
            this.lbCarID = new System.Windows.Forms.Label();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbReleasedYear = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtReleasedYear = new System.Windows.Forms.TextBox();
            this.cboManufacturer = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(204, 56);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(125, 30);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Car Details";
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(47, 143);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(60, 15);
            this.lbCarName.TabIndex = 0;
            this.lbCarName.Text = "Car Name";
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(47, 108);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(39, 15);
            this.lbCarID.TabIndex = 1;
            this.lbCarID.Text = "Car ID";
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(47, 176);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(79, 15);
            this.lbManufacturer.TabIndex = 2;
            this.lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(47, 212);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 15);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price";
            // 
            // lbReleasedYear
            // 
            this.lbReleasedYear.AutoSize = true;
            this.lbReleasedYear.Location = new System.Drawing.Point(47, 247);
            this.lbReleasedYear.Name = "lbReleasedYear";
            this.lbReleasedYear.Size = new System.Drawing.Size(78, 15);
            this.lbReleasedYear.TabIndex = 4;
            this.lbReleasedYear.Text = "Released Year";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(156, 100);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(205, 23);
            this.txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(156, 135);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(205, 23);
            this.txtCarName.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(156, 204);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(205, 23);
            this.txtPrice.TabIndex = 7;
            // 
            // txtReleasedYear
            // 
            this.txtReleasedYear.Location = new System.Drawing.Point(156, 239);
            this.txtReleasedYear.Name = "txtReleasedYear";
            this.txtReleasedYear.Size = new System.Drawing.Size(205, 23);
            this.txtReleasedYear.TabIndex = 8;
            // 
            // cboManufacturer
            // 
            this.cboManufacturer.FormattingEnabled = true;
            this.cboManufacturer.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Ford",
            "Honda",
            "Kia",
            "Toyota"});
            this.cboManufacturer.Location = new System.Drawing.Point(156, 168);
            this.cboManufacturer.Name = "cboManufacturer";
            this.cboManufacturer.Size = new System.Drawing.Size(205, 23);
            this.cboManufacturer.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(156, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CarDeltails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(496, 419);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboManufacturer);
            this.Controls.Add(this.txtReleasedYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.lbReleasedYear);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.lbCarID);
            this.Controls.Add(this.lbCarName);
            this.Controls.Add(this.lbTitle);
            this.Name = "CarDeltails";
            this.Text = "CarDeltails";
            this.Load += new System.EventHandler(this.CarDeltails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private Label lbCarName;
        private Label lbCarID;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleasedYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtPrice;
        private TextBox txtReleasedYear;
        private ComboBox cboManufacturer;
        private Button btnSave;
        private Button btnCancel;
    }
}