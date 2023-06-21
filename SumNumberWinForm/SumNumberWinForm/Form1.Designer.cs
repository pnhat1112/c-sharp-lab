using System.Runtime.InteropServices;
using System;

namespace SumNumberWinForm
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
            this.lbNum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lbSum = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNum1
            // 
            this.lbNum1.AccessibleName = "lbNum1";
            this.lbNum1.AutoSize = true;
            this.lbNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum1.Location = new System.Drawing.Point(199, 177);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(86, 20);
            this.lbNum1.TabIndex = 0;
            this.lbNum1.Text = "Number 1";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(291, 171);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(185, 29);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(291, 209);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(185, 29);
            this.txtNum2.TabIndex = 3;
            // 
            // lbNum2
            // 
            this.lbNum2.AccessibleName = "lbNum2";
            this.lbNum2.AutoSize = true;
            this.lbNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum2.Location = new System.Drawing.Point(199, 215);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(86, 20);
            this.lbNum2.TabIndex = 2;
            this.lbNum2.Text = "Number 2";
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(291, 254);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(185, 29);
            this.txtSum.TabIndex = 5;
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSum.Location = new System.Drawing.Point(236, 260);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(49, 20);
            this.lbSum.TabIndex = 4;
            this.lbSum.Text = "Total";
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(343, 303);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(80, 30);
            this.btnSum.TabIndex = 6;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lbNum1);
            this.Name = "Form1";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Button btnSum;
    }
}

