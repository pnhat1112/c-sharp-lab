namespace Lab4
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
            this.lsViewStudent = new System.Windows.Forms.ListView();
            this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsViewStudent
            // 
            this.lsViewStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentID,
            this.StudentName,
            this.ClassID});
            this.lsViewStudent.GridLines = true;
            this.lsViewStudent.HideSelection = false;
            this.lsViewStudent.Location = new System.Drawing.Point(147, 111);
            this.lsViewStudent.Name = "lsViewStudent";
            this.lsViewStudent.Size = new System.Drawing.Size(527, 267);
            this.lsViewStudent.TabIndex = 0;
            this.lsViewStudent.UseCompatibleStateImageBehavior = false;
            this.lsViewStudent.View = System.Windows.Forms.View.Details;
            // 
            // StudentID
            // 
            this.StudentID.Text = "Student ID";
            this.StudentID.Width = 119;
            // 
            // StudentName
            // 
            this.StudentName.Text = "Student Name";
            this.StudentName.Width = 124;
            // 
            // ClassID
            // 
            this.ClassID.Text = "Class ID";
            this.ClassID.Width = 172;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(344, 63);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(140, 24);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Student Table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lsViewStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsViewStudent;
        private System.Windows.Forms.ColumnHeader StudentID;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader ClassID;
        private System.Windows.Forms.Label lbTitle;
    }
}

