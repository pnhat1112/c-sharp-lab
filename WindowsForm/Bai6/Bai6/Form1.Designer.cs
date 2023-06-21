namespace Bai6
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
            this.panelDate = new System.Windows.Forms.Panel();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbNgayThang = new System.Windows.Forms.Label();
            this.lbGio = new System.Windows.Forms.Label();
            this.panelDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDate.Controls.Add(this.lbGio);
            this.panelDate.Controls.Add(this.lbNgayThang);
            this.panelDate.Controls.Add(this.lbDateTime);
            this.panelDate.Location = new System.Drawing.Point(3, 13);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(793, 120);
            this.panelDate.TabIndex = 0;
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.Location = new System.Drawing.Point(96, 54);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(166, 20);
            this.lbDateTime.TabIndex = 0;
            this.lbDateTime.Text = "Ngày giờ hiện tại là:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(152, 263);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(113, 32);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Hiển thị ngày giờ";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(388, 263);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(287, 32);
            this.progressBar1.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbNgayThang
            // 
            this.lbNgayThang.AutoSize = true;
            this.lbNgayThang.Location = new System.Drawing.Point(382, 61);
            this.lbNgayThang.Name = "lbNgayThang";
            this.lbNgayThang.Size = new System.Drawing.Size(66, 13);
            this.lbNgayThang.TabIndex = 1;
            this.lbNgayThang.Text = "Ngày Tháng";
            // 
            // lbGio
            // 
            this.lbGio.AutoSize = true;
            this.lbGio.Location = new System.Drawing.Point(536, 59);
            this.lbGio.Name = "lbGio";
            this.lbGio.Size = new System.Drawing.Size(23, 13);
            this.lbGio.TabIndex = 2;
            this.lbGio.Text = "Giờ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.panelDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbGio;
        private System.Windows.Forms.Label lbNgayThang;
    }
}

