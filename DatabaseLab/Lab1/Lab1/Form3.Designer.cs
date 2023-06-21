namespace Lab1
{
    partial class Form3
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
            this.lbListClass = new System.Windows.Forms.Label();
            this.lbListStudents = new System.Windows.Forms.Label();
            this.listBoxClass = new System.Windows.Forms.ListBox();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListClass
            // 
            this.lbListClass.AutoSize = true;
            this.lbListClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListClass.Location = new System.Drawing.Point(124, 118);
            this.lbListClass.Name = "lbListClass";
            this.lbListClass.Size = new System.Drawing.Size(130, 20);
            this.lbListClass.TabIndex = 0;
            this.lbListClass.Text = "List Of Classes";
            // 
            // lbListStudents
            // 
            this.lbListStudents.AutoSize = true;
            this.lbListStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListStudents.Location = new System.Drawing.Point(512, 118);
            this.lbListStudents.Name = "lbListStudents";
            this.lbListStudents.Size = new System.Drawing.Size(140, 20);
            this.lbListStudents.TabIndex = 1;
            this.lbListStudents.Text = "List Of Students";
            // 
            // listBoxClass
            // 
            this.listBoxClass.BackColor = System.Drawing.Color.Turquoise;
            this.listBoxClass.FormattingEnabled = true;
            this.listBoxClass.Location = new System.Drawing.Point(28, 154);
            this.listBoxClass.Name = "listBoxClass";
            this.listBoxClass.Size = new System.Drawing.Size(336, 225);
            this.listBoxClass.TabIndex = 2;
            this.listBoxClass.SelectedIndexChanged += new System.EventHandler(this.listBoxClass_SelectedIndexChanged);
            // 
            // lvStudents
            // 
            this.lvStudents.BackColor = System.Drawing.Color.Turquoise;
            this.lvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentID,
            this.Name,
            this.ClassID});
            this.lvStudents.HideSelection = false;
            this.lvStudents.Location = new System.Drawing.Point(413, 154);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(346, 225);
            this.lvStudents.TabIndex = 3;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            // 
            // StudentID
            // 
            this.StudentID.Text = "Student ID";
            this.StudentID.Width = 86;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 146;
            // 
            // ClassID
            // 
            this.ClassID.Text = "Class ID";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(299, 401);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(193, 64);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Information Student";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvStudents);
            this.Controls.Add(this.listBoxClass);
            this.Controls.Add(this.lbListStudents);
            this.Controls.Add(this.lbListClass);
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbListClass;
        private System.Windows.Forms.Label lbListStudents;
        private System.Windows.Forms.ListBox listBoxClass;
        private System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.ColumnHeader StudentID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader ClassID;
        private System.Windows.Forms.Button btnEdit;
    }
}