namespace Lab1
{
    partial class Form4
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
            this.lsvStudents = new System.Windows.Forms.ListView();
            this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbStudent = new System.Windows.Forms.GroupBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lbClassID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.grbStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvStudents
            // 
            this.lsvStudents.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lsvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentID,
            this.Name,
            this.ClassID});
            this.lsvStudents.GridLines = true;
            this.lsvStudents.HideSelection = false;
            this.lsvStudents.Location = new System.Drawing.Point(13, 49);
            this.lsvStudents.Name = "lsvStudents";
            this.lsvStudents.Size = new System.Drawing.Size(443, 365);
            this.lsvStudents.TabIndex = 0;
            this.lsvStudents.UseCompatibleStateImageBehavior = false;
            this.lsvStudents.View = System.Windows.Forms.View.Details;
            this.lsvStudents.SelectedIndexChanged += new System.EventHandler(this.lsvStudents_SelectedIndexChanged);
            // 
            // StudentID
            // 
            this.StudentID.Text = "Student ID";
            this.StudentID.Width = 106;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 157;
            // 
            // ClassID
            // 
            this.ClassID.Text = "ClassID";
            this.ClassID.Width = 112;
            // 
            // grbStudent
            // 
            this.grbStudent.Controls.Add(this.txtClassID);
            this.grbStudent.Controls.Add(this.txtName);
            this.grbStudent.Controls.Add(this.txtStudentID);
            this.grbStudent.Controls.Add(this.lbClassID);
            this.grbStudent.Controls.Add(this.lbName);
            this.grbStudent.Controls.Add(this.lbStudentID);
            this.grbStudent.Location = new System.Drawing.Point(492, 53);
            this.grbStudent.Name = "grbStudent";
            this.grbStudent.Size = new System.Drawing.Size(272, 145);
            this.grbStudent.TabIndex = 1;
            this.grbStudent.TabStop = false;
            this.grbStudent.Text = "Student Information";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(93, 100);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(152, 20);
            this.txtClassID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(93, 25);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(152, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // lbClassID
            // 
            this.lbClassID.AutoSize = true;
            this.lbClassID.Location = new System.Drawing.Point(19, 103);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(46, 13);
            this.lbClassID.TabIndex = 2;
            this.lbClassID.Text = "Class ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(19, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(19, 33);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(58, 13);
            this.lbStudentID.TabIndex = 0;
            this.lbStudentID.Text = "Student ID";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(492, 247);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(81, 28);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(585, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 28);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(683, 247);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(81, 28);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.grbStudent);
            this.Controls.Add(this.lsvStudents);
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.grbStudent.ResumeLayout(false);
            this.grbStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvStudents;
        private System.Windows.Forms.ColumnHeader StudentID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader ClassID;
        private System.Windows.Forms.GroupBox grbStudent;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
    }
}