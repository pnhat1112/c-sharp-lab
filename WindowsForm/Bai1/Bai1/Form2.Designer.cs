namespace Bai1
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
            this.lbForm2 = new System.Windows.Forms.Label();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.lbEnter = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbForm2
            // 
            this.lbForm2.AutoSize = true;
            this.lbForm2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForm2.Location = new System.Drawing.Point(330, 169);
            this.lbForm2.Name = "lbForm2";
            this.lbForm2.Size = new System.Drawing.Size(151, 24);
            this.lbForm2.TabIndex = 0;
            this.lbForm2.Text = "This is Form 2";
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(328, 225);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(153, 20);
            this.txtEnter.TabIndex = 1;
            // 
            // lbEnter
            // 
            this.lbEnter.AutoSize = true;
            this.lbEnter.Location = new System.Drawing.Point(287, 228);
            this.lbEnter.Name = "lbEnter";
            this.lbEnter.Size = new System.Drawing.Size(35, 13);
            this.lbEnter.TabIndex = 2;
            this.lbEnter.Text = "Enter:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(363, 269);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lbEnter);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.lbForm2);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbForm2;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Label lbEnter;
        private System.Windows.Forms.Button btnShow;
    }
}