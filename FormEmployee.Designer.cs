
namespace QLCF
{
    partial class FormEmployee
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDSChoPhaChe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bán Hàng";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWelcome.Location = new System.Drawing.Point(112, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(98, 13);
            this.lblWelcome.TabIndex = 22;
            this.lblWelcome.Text = "Xin chào username";
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Location = new System.Drawing.Point(12, 92);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(97, 38);
            this.btnTaoHoaDon.TabIndex = 23;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(115, 92);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(97, 38);
            this.btnThanhToan.TabIndex = 24;
            this.btnThanhToan.Text = "Thanh toán HD";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDSChoPhaChe
            // 
            this.btnDSChoPhaChe.Location = new System.Drawing.Point(218, 92);
            this.btnDSChoPhaChe.Name = "btnDSChoPhaChe";
            this.btnDSChoPhaChe.Size = new System.Drawing.Size(97, 38);
            this.btnDSChoPhaChe.TabIndex = 25;
            this.btnDSChoPhaChe.Text = "DS chờ pha chế";
            this.btnDSChoPhaChe.UseVisualStyleBackColor = true;
            this.btnDSChoPhaChe.Click += new System.EventHandler(this.btnDSChoPhaChe_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 163);
            this.Controls.Add(this.btnDSChoPhaChe);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnTaoHoaDon);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label1);
            this.Name = "FormEmployee";
            this.Text = "Danh mục nhân viên";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDSChoPhaChe;
    }
}