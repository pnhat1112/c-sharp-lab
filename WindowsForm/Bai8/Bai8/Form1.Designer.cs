namespace Bai8
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbNode = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.btnNodeGoc = new System.Windows.Forms.Button();
            this.btnNodeCon = new System.Windows.Forms.Button();
            this.btnDelAllNode = new System.Windows.Forms.Button();
            this.btnDelNode = new System.Windows.Forms.Button();
            this.btnCountNode = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(36, 63);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(88, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Tree View";
            // 
            // lbNode
            // 
            this.lbNode.AutoSize = true;
            this.lbNode.Location = new System.Drawing.Point(424, 112);
            this.lbNode.Name = "lbNode";
            this.lbNode.Size = new System.Drawing.Size(76, 13);
            this.lbNode.TabIndex = 1;
            this.lbNode.Text = "Tiêu đề Node:";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.Location = new System.Drawing.Point(40, 97);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(340, 341);
            this.treeView1.TabIndex = 2;
            // 
            // txtNode
            // 
            this.txtNode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNode.Location = new System.Drawing.Point(507, 104);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(266, 20);
            this.txtNode.TabIndex = 3;
            // 
            // btnNodeGoc
            // 
            this.btnNodeGoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNodeGoc.Location = new System.Drawing.Point(427, 155);
            this.btnNodeGoc.Name = "btnNodeGoc";
            this.btnNodeGoc.Size = new System.Drawing.Size(346, 30);
            this.btnNodeGoc.TabIndex = 4;
            this.btnNodeGoc.Text = "Thêm Node Gốc";
            this.btnNodeGoc.UseVisualStyleBackColor = false;
            this.btnNodeGoc.Click += new System.EventHandler(this.btnNodeGoc_Click);
            // 
            // btnNodeCon
            // 
            this.btnNodeCon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnNodeCon.Location = new System.Drawing.Point(427, 201);
            this.btnNodeCon.Name = "btnNodeCon";
            this.btnNodeCon.Size = new System.Drawing.Size(346, 30);
            this.btnNodeCon.TabIndex = 5;
            this.btnNodeCon.Text = "Thêm Node Con";
            this.btnNodeCon.UseVisualStyleBackColor = false;
            this.btnNodeCon.Click += new System.EventHandler(this.btnNodeCon_Click);
            // 
            // btnDelAllNode
            // 
            this.btnDelAllNode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelAllNode.Location = new System.Drawing.Point(427, 249);
            this.btnDelAllNode.Name = "btnDelAllNode";
            this.btnDelAllNode.Size = new System.Drawing.Size(346, 30);
            this.btnDelAllNode.TabIndex = 6;
            this.btnDelAllNode.Text = "Xóa tất cả Node";
            this.btnDelAllNode.UseVisualStyleBackColor = false;
            this.btnDelAllNode.Click += new System.EventHandler(this.btnDelAllNode_Click);
            // 
            // btnDelNode
            // 
            this.btnDelNode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelNode.Location = new System.Drawing.Point(427, 296);
            this.btnDelNode.Name = "btnDelNode";
            this.btnDelNode.Size = new System.Drawing.Size(346, 30);
            this.btnDelNode.TabIndex = 7;
            this.btnDelNode.Text = "Xóa Node đang chọn";
            this.btnDelNode.UseVisualStyleBackColor = false;
            this.btnDelNode.Click += new System.EventHandler(this.btnDelNode_Click);
            // 
            // btnCountNode
            // 
            this.btnCountNode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCountNode.Location = new System.Drawing.Point(427, 344);
            this.btnCountNode.Name = "btnCountNode";
            this.btnCountNode.Size = new System.Drawing.Size(346, 30);
            this.btnCountNode.TabIndex = 8;
            this.btnCountNode.Text = "Đếm tổng Node Tree";
            this.btnCountNode.UseVisualStyleBackColor = false;
            this.btnCountNode.Click += new System.EventHandler(this.btnCountNode_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnZoomIn.Location = new System.Drawing.Point(427, 393);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(86, 30);
            this.btnZoomIn.TabIndex = 9;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnZoomOut.Location = new System.Drawing.Point(687, 393);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(86, 30);
            this.btnZoomOut.TabIndex = 10;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnCountNode);
            this.Controls.Add(this.btnDelNode);
            this.Controls.Add(this.btnDelAllNode);
            this.Controls.Add(this.btnNodeCon);
            this.Controls.Add(this.btnNodeGoc);
            this.Controls.Add(this.txtNode);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lbNode);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbNode;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.Button btnNodeGoc;
        private System.Windows.Forms.Button btnNodeCon;
        private System.Windows.Forms.Button btnDelAllNode;
        private System.Windows.Forms.Button btnDelNode;
        private System.Windows.Forms.Button btnCountNode;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
    }
}

