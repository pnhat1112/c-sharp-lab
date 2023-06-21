namespace Lab2
{
    partial class Form1
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
            this.dtgViewStudents = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.grBoxStudents = new System.Windows.Forms.GroupBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lbClassID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewStudents)).BeginInit();
            this.grBoxStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgViewStudents
            // 
            this.dtgViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewStudents.Location = new System.Drawing.Point(12, 60);
            this.dtgViewStudents.Name = "dtgViewStudents";
            this.dtgViewStudents.Size = new System.Drawing.Size(440, 281);
            this.dtgViewStudents.TabIndex = 0;
            this.dtgViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewStudents_CellContentClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(487, 318);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(605, 318);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(713, 318);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // grBoxStudents
            // 
            this.grBoxStudents.Controls.Add(this.txtClassID);
            this.grBoxStudents.Controls.Add(this.txtName);
            this.grBoxStudents.Controls.Add(this.txtStudentID);
            this.grBoxStudents.Controls.Add(this.lbClassID);
            this.grBoxStudents.Controls.Add(this.lbName);
            this.grBoxStudents.Controls.Add(this.lbStudentID);
            this.grBoxStudents.Location = new System.Drawing.Point(487, 60);
            this.grBoxStudents.Name = "grBoxStudents";
            this.grBoxStudents.Size = new System.Drawing.Size(301, 234);
            this.grBoxStudents.TabIndex = 5;
            this.grBoxStudents.TabStop = false;
            this.grBoxStudents.Text = "Student Information";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(101, 173);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(180, 20);
            this.txtClassID.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(101, 40);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(180, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // lbClassID
            // 
            this.lbClassID.AutoSize = true;
            this.lbClassID.Location = new System.Drawing.Point(17, 173);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(49, 13);
            this.lbClassID.TabIndex = 2;
            this.lbClassID.Text = "Class ID:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(17, 114);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Student Name:";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(17, 47);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(61, 13);
            this.lbStudentID.TabIndex = 0;
            this.lbStudentID.Text = "Student ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.grBoxStudents);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtgViewStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewStudents)).EndInit();
            this.grBoxStudents.ResumeLayout(false);
            this.grBoxStudents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgViewStudents;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox grBoxStudents;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.Label lbName;
    }
}

