namespace Bai11
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
            this.components = new System.ComponentModel.Container();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(306, 113);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(188, 24);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Context Menu Strip";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(359, 176);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(82, 20);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "Thời gian";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(334, 211);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(138, 17);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Ngày Tháng Năm ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExitToolStripMenuItem,
            this.displayTimeToolStripMenuItem,
            this.displayDateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 70);
            // 
            // menuExitToolStripMenuItem
            // 
            this.menuExitToolStripMenuItem.Name = "menuExitToolStripMenuItem";
            this.menuExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menuExitToolStripMenuItem.Text = "Menu Exit";
            this.menuExitToolStripMenuItem.Click += new System.EventHandler(this.menuExitToolStripMenuItem_Click);
            // 
            // displayTimeToolStripMenuItem
            // 
            this.displayTimeToolStripMenuItem.Name = "displayTimeToolStripMenuItem";
            this.displayTimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayTimeToolStripMenuItem.Text = "Display Time";
            this.displayTimeToolStripMenuItem.Click += new System.EventHandler(this.displayTimeToolStripMenuItem_Click);
            // 
            // displayDateToolStripMenuItem
            // 
            this.displayDateToolStripMenuItem.Name = "displayDateToolStripMenuItem";
            this.displayDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayDateToolStripMenuItem.Text = "Display Date";
            this.displayDateToolStripMenuItem.Click += new System.EventHandler(this.displayDateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDateToolStripMenuItem;
    }
}

