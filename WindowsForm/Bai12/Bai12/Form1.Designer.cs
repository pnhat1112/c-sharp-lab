namespace Bai12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.coppyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFormat = new System.Windows.Forms.ToolStripDropDownButton();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.toolStripEdit,
            this.toolStripFormat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coppyToolStripMenuItem,
            this.cutCtrlXToolStripMenuItem,
            this.pasteCtrlVToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.selectAllCtrlAToolStripMenuItem,
            this.undoCtrlZToolStripMenuItem});
            this.toolStripEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEdit.Image")));
            this.toolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(40, 22);
            this.toolStripEdit.Text = "Edit";
            // 
            // coppyToolStripMenuItem
            // 
            this.coppyToolStripMenuItem.Name = "coppyToolStripMenuItem";
            this.coppyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coppyToolStripMenuItem.Text = "Coppy  Ctrl + c";
            this.coppyToolStripMenuItem.Click += new System.EventHandler(this.coppyToolStripMenuItem_Click);
            // 
            // cutCtrlXToolStripMenuItem
            // 
            this.cutCtrlXToolStripMenuItem.Name = "cutCtrlXToolStripMenuItem";
            this.cutCtrlXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutCtrlXToolStripMenuItem.Text = "Cut   Ctrl + x";
            this.cutCtrlXToolStripMenuItem.Click += new System.EventHandler(this.cutCtrlXToolStripMenuItem_Click);
            // 
            // pasteCtrlVToolStripMenuItem
            // 
            this.pasteCtrlVToolStripMenuItem.Name = "pasteCtrlVToolStripMenuItem";
            this.pasteCtrlVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteCtrlVToolStripMenuItem.Text = "Paste   Ctrl + v";
            this.pasteCtrlVToolStripMenuItem.Click += new System.EventHandler(this.pasteCtrlVToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete   Del";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // selectAllCtrlAToolStripMenuItem
            // 
            this.selectAllCtrlAToolStripMenuItem.Name = "selectAllCtrlAToolStripMenuItem";
            this.selectAllCtrlAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllCtrlAToolStripMenuItem.Text = "SelectAll   Ctrl + A";
            this.selectAllCtrlAToolStripMenuItem.Click += new System.EventHandler(this.selectAllCtrlAToolStripMenuItem_Click);
            // 
            // undoCtrlZToolStripMenuItem
            // 
            this.undoCtrlZToolStripMenuItem.Name = "undoCtrlZToolStripMenuItem";
            this.undoCtrlZToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoCtrlZToolStripMenuItem.Text = "Undo   Ctrl + Z";
            this.undoCtrlZToolStripMenuItem.Click += new System.EventHandler(this.undoCtrlZToolStripMenuItem_Click);
            // 
            // toolStripFile
            // 
            this.toolStripFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFile.Image")));
            this.toolStripFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(38, 22);
            this.toolStripFile.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripFormat
            // 
            this.toolStripFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.wordWapToolStripMenuItem});
            this.toolStripFormat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFormat.Image")));
            this.toolStripFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFormat.Name = "toolStripFormat";
            this.toolStripFormat.Size = new System.Drawing.Size(58, 22);
            this.toolStripFormat.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // wordWapToolStripMenuItem
            // 
            this.wordWapToolStripMenuItem.Name = "wordWapToolStripMenuItem";
            this.wordWapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wordWapToolStripMenuItem.Text = "WordWrap";
            this.wordWapToolStripMenuItem.Click += new System.EventHandler(this.wordWapToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 423);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripEdit;
        private System.Windows.Forms.ToolStripMenuItem coppyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteCtrlVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllCtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoCtrlZToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFormat;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWapToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

