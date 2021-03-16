
namespace QLCF
{
    partial class fDoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblChuTK = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.txtMKmoi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chủ tài khoản:";
            // 
            // lblChuTK
            // 
            this.lblChuTK.AutoSize = true;
            this.lblChuTK.Location = new System.Drawing.Point(98, 34);
            this.lblChuTK.Name = "lblChuTK";
            this.lblChuTK.Size = new System.Drawing.Size(35, 13);
            this.lblChuTK.TabIndex = 1;
            this.lblChuTK.Text = "label2";
            this.lblChuTK.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MK cũ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MK mới:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhap lại MK mới:";
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Location = new System.Drawing.Point(112, 153);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacnhan.TabIndex = 5;
            this.btnXacnhan.Text = "Xong";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // txtMKcu
            // 
            this.txtMKcu.Location = new System.Drawing.Point(112, 51);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(166, 20);
            this.txtMKcu.TabIndex = 6;
            this.txtMKcu.UseSystemPasswordChar = true;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Location = new System.Drawing.Point(112, 80);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(166, 20);
            this.txtMKmoi.TabIndex = 7;
            this.txtMKmoi.UseSystemPasswordChar = true;
            // 
            // txtMKmoi2
            // 
            this.txtMKmoi2.Location = new System.Drawing.Point(112, 109);
            this.txtMKmoi2.Name = "txtMKmoi2";
            this.txtMKmoi2.Size = new System.Drawing.Size(166, 20);
            this.txtMKmoi2.TabIndex = 8;
            this.txtMKmoi2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "ĐỔI MẬT KHẨU";
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 188);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMKmoi2);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.txtMKcu);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblChuTK);
            this.Controls.Add(this.label1);
            this.Name = "fDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChuTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.TextBox txtMKmoi2;
        private System.Windows.Forms.Label label2;
    }
}