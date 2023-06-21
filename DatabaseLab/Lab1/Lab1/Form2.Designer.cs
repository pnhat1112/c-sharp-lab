namespace Lab1
{
    partial class Form2
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
            this.lbEnterClassID = new System.Windows.Forms.Label();
            this.lbNumberStudents = new System.Windows.Forms.Label();
            this.txtEnterClassID = new System.Windows.Forms.TextBox();
            this.txtNumberStudents = new System.Windows.Forms.TextBox();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.lbClassID = new System.Windows.Forms.Label();
            this.lbClassName = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnViewListStudents = new System.Windows.Forms.Button();
            this.lsvStudents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViewAllTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEnterClassID
            // 
            this.lbEnterClassID.AutoSize = true;
            this.lbEnterClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterClassID.Location = new System.Drawing.Point(32, 64);
            this.lbEnterClassID.Name = "lbEnterClassID";
            this.lbEnterClassID.Size = new System.Drawing.Size(111, 17);
            this.lbEnterClassID.TabIndex = 0;
            this.lbEnterClassID.Text = "Enter ClassID:";
            // 
            // lbNumberStudents
            // 
            this.lbNumberStudents.AutoSize = true;
            this.lbNumberStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberStudents.Location = new System.Drawing.Point(32, 103);
            this.lbNumberStudents.Name = "lbNumberStudents";
            this.lbNumberStudents.Size = new System.Drawing.Size(162, 17);
            this.lbNumberStudents.TabIndex = 1;
            this.lbNumberStudents.Text = "Number of Students: ";
            // 
            // txtEnterClassID
            // 
            this.txtEnterClassID.Location = new System.Drawing.Point(203, 61);
            this.txtEnterClassID.Name = "txtEnterClassID";
            this.txtEnterClassID.Size = new System.Drawing.Size(240, 20);
            this.txtEnterClassID.TabIndex = 2;
            // 
            // txtNumberStudents
            // 
            this.txtNumberStudents.Location = new System.Drawing.Point(203, 103);
            this.txtNumberStudents.Name = "txtNumberStudents";
            this.txtNumberStudents.ReadOnly = true;
            this.txtNumberStudents.Size = new System.Drawing.Size(240, 20);
            this.txtNumberStudents.TabIndex = 3;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetail.Location = new System.Drawing.Point(111, 153);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(182, 37);
            this.btnViewDetail.TabIndex = 4;
            this.btnViewDetail.Text = "View in Detail";
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnCalculateNumberStudents_Click);
            // 
            // lbClassID
            // 
            this.lbClassID.AutoSize = true;
            this.lbClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassID.Location = new System.Drawing.Point(32, 250);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(72, 17);
            this.lbClassID.TabIndex = 5;
            this.lbClassID.Text = "Class ID:";
            // 
            // lbClassName
            // 
            this.lbClassName.AutoSize = true;
            this.lbClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassName.Location = new System.Drawing.Point(32, 285);
            this.lbClassName.Name = "lbClassName";
            this.lbClassName.Size = new System.Drawing.Size(98, 17);
            this.lbClassName.TabIndex = 6;
            this.lbClassName.Text = "Class Name:";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(32, 322);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(47, 17);
            this.lbYear.TabIndex = 7;
            this.lbYear.Text = "Year:";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(203, 249);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.ReadOnly = true;
            this.txtClassID.Size = new System.Drawing.Size(240, 20);
            this.txtClassID.TabIndex = 8;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(203, 284);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(240, 20);
            this.txtClassName.TabIndex = 9;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(203, 322);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(240, 20);
            this.txtYear.TabIndex = 10;
            // 
            // btnViewListStudents
            // 
            this.btnViewListStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewListStudents.Location = new System.Drawing.Point(603, 153);
            this.btnViewListStudents.Name = "btnViewListStudents";
            this.btnViewListStudents.Size = new System.Drawing.Size(225, 37);
            this.btnViewListStudents.TabIndex = 11;
            this.btnViewListStudents.Text = "View List Students";
            this.btnViewListStudents.UseVisualStyleBackColor = true;
            this.btnViewListStudents.Click += new System.EventHandler(this.btnViewListStudents_Click);
            // 
            // lsvStudents
            // 
            this.lsvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvStudents.GridLines = true;
            this.lsvStudents.HideSelection = false;
            this.lsvStudents.Location = new System.Drawing.Point(603, 249);
            this.lsvStudents.Name = "lsvStudents";
            this.lsvStudents.Size = new System.Drawing.Size(384, 203);
            this.lsvStudents.TabIndex = 12;
            this.lsvStudents.UseCompatibleStateImageBehavior = false;
            this.lsvStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Class ID";
            // 
            // btnViewAllTable
            // 
            this.btnViewAllTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllTable.Location = new System.Drawing.Point(68, 405);
            this.btnViewAllTable.Name = "btnViewAllTable";
            this.btnViewAllTable.Size = new System.Drawing.Size(225, 37);
            this.btnViewAllTable.TabIndex = 13;
            this.btnViewAllTable.Text = "View All Table";
            this.btnViewAllTable.UseVisualStyleBackColor = true;
            this.btnViewAllTable.Click += new System.EventHandler(this.btnViewAllTable_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1017, 492);
            this.Controls.Add(this.btnViewAllTable);
            this.Controls.Add(this.lsvStudents);
            this.Controls.Add(this.btnViewListStudents);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbClassName);
            this.Controls.Add(this.lbClassID);
            this.Controls.Add(this.btnViewDetail);
            this.Controls.Add(this.txtNumberStudents);
            this.Controls.Add(this.txtEnterClassID);
            this.Controls.Add(this.lbNumberStudents);
            this.Controls.Add(this.lbEnterClassID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnterClassID;
        private System.Windows.Forms.Label lbNumberStudents;
        private System.Windows.Forms.TextBox txtEnterClassID;
        private System.Windows.Forms.TextBox txtNumberStudents;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.Label lbClassName;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnViewListStudents;
        private System.Windows.Forms.ListView lsvStudents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnViewAllTable;
    }
}