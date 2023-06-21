namespace Bai4
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
            this.lbTitle1 = new System.Windows.Forms.Label();
            this.pnListBox = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.lbTitle2 = new System.Windows.Forms.Label();
            this.lbChooseColor = new System.Windows.Forms.Label();
            this.lbChangeColor = new System.Windows.Forms.Label();
            this.cbBoxColor = new System.Windows.Forms.ComboBox();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.pnListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle1
            // 
            this.lbTitle1.AutoSize = true;
            this.lbTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle1.Location = new System.Drawing.Point(373, 33);
            this.lbTitle1.Name = "lbTitle1";
            this.lbTitle1.Size = new System.Drawing.Size(77, 24);
            this.lbTitle1.TabIndex = 0;
            this.lbTitle1.Text = "ListBox";
            // 
            // pnListBox
            // 
            this.pnListBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnListBox.Controls.Add(this.btnXoaAll);
            this.pnListBox.Controls.Add(this.btnXoaCuoi);
            this.pnListBox.Controls.Add(this.btnXoaDau);
            this.pnListBox.Controls.Add(this.btnXoaChon);
            this.pnListBox.Controls.Add(this.txtSum);
            this.pnListBox.Controls.Add(this.lbSum);
            this.pnListBox.Controls.Add(this.listBox1);
            this.pnListBox.Location = new System.Drawing.Point(307, 76);
            this.pnListBox.Name = "pnListBox";
            this.pnListBox.Size = new System.Drawing.Size(481, 329);
            this.pnListBox.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(27, 129);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(61, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Họ và Tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 155);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(76, 196);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(95, 32);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Nhập thông tin";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(454, 186);
            this.listBox1.TabIndex = 0;
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(20, 218);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(38, 13);
            this.lbSum.TabIndex = 5;
            this.lbSum.Text = "Tổng: ";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(64, 215);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(54, 20);
            this.txtSum.TabIndex = 5;
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(23, 241);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(143, 32);
            this.btnXoaChon.TabIndex = 5;
            this.btnXoaChon.Text = "Xóa thông tin đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnXoaDau
            // 
            this.btnXoaDau.Location = new System.Drawing.Point(182, 241);
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new System.Drawing.Size(124, 32);
            this.btnXoaDau.TabIndex = 6;
            this.btnXoaDau.Text = "Xóa thông tin đầu";
            this.btnXoaDau.UseVisualStyleBackColor = true;
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);
            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.Location = new System.Drawing.Point(325, 241);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(143, 32);
            this.btnXoaCuoi.TabIndex = 7;
            this.btnXoaCuoi.Text = "Xóa thông tin cuối";
            this.btnXoaCuoi.UseVisualStyleBackColor = true;
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(182, 282);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(124, 32);
            this.btnXoaAll.TabIndex = 8;
            this.btnXoaAll.Text = "Xóa tất cả";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // lbTitle2
            // 
            this.lbTitle2.AutoSize = true;
            this.lbTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle2.Location = new System.Drawing.Point(337, 453);
            this.lbTitle2.Name = "lbTitle2";
            this.lbTitle2.Size = new System.Drawing.Size(113, 24);
            this.lbTitle2.TabIndex = 5;
            this.lbTitle2.Text = "ComboBox";
            // 
            // lbChooseColor
            // 
            this.lbChooseColor.AutoSize = true;
            this.lbChooseColor.Location = new System.Drawing.Point(255, 548);
            this.lbChooseColor.Name = "lbChooseColor";
            this.lbChooseColor.Size = new System.Drawing.Size(59, 13);
            this.lbChooseColor.TabIndex = 6;
            this.lbChooseColor.Text = "Chọn Màu:";
            // 
            // lbChangeColor
            // 
            this.lbChangeColor.AutoSize = true;
            this.lbChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangeColor.Location = new System.Drawing.Point(285, 494);
            this.lbChangeColor.Name = "lbChangeColor";
            this.lbChangeColor.Size = new System.Drawing.Size(211, 24);
            this.lbChangeColor.TabIndex = 7;
            this.lbChangeColor.Text = "Welcome to my Lab 4";
            // 
            // cbBoxColor
            // 
            this.cbBoxColor.FormattingEnabled = true;
            this.cbBoxColor.Items.AddRange(new object[] {
            "Yellow",
            "Red",
            "Black",
            "Blue"});
            this.cbBoxColor.Location = new System.Drawing.Point(329, 540);
            this.cbBoxColor.Name = "cbBoxColor";
            this.cbBoxColor.Size = new System.Drawing.Size(121, 21);
            this.cbBoxColor.TabIndex = 8;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(341, 567);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(84, 32);
            this.btnChangeColor.TabIndex = 9;
            this.btnChangeColor.Text = "Đổi màu";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.cbBoxColor);
            this.Controls.Add(this.lbChangeColor);
            this.Controls.Add(this.lbChooseColor);
            this.Controls.Add(this.lbTitle2);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pnListBox);
            this.Controls.Add(this.lbTitle1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnListBox.ResumeLayout(false);
            this.pnListBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle1;
        private System.Windows.Forms.Panel pnListBox;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lbTitle2;
        private System.Windows.Forms.Label lbChooseColor;
        private System.Windows.Forms.Label lbChangeColor;
        private System.Windows.Forms.ComboBox cbBoxColor;
        private System.Windows.Forms.Button btnChangeColor;
    }
}

