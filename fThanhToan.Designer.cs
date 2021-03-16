
namespace QLCF
{
    partial class fThanhToan
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
            this.btnTTHD = new System.Windows.Forms.Button();
            this.lvDSSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbHoaDon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTTHD
            // 
            this.btnTTHD.Location = new System.Drawing.Point(89, 337);
            this.btnTTHD.Name = "btnTTHD";
            this.btnTTHD.Size = new System.Drawing.Size(75, 23);
            this.btnTTHD.TabIndex = 0;
            this.btnTTHD.Text = "Thanh toán";
            this.btnTTHD.UseVisualStyleBackColor = true;
            this.btnTTHD.Click += new System.EventHandler(this.btnTTHD_Click);
            // 
            // lvDSSP
            // 
            this.lvDSSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDSSP.HideSelection = false;
            this.lvDSSP.Location = new System.Drawing.Point(12, 126);
            this.lvDSSP.Name = "lvDSSP";
            this.lvDSSP.Size = new System.Drawing.Size(245, 205);
            this.lvDSSP.TabIndex = 1;
            this.lvDSSP.UseCompatibleStateImageBehavior = false;
            this.lvDSSP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sp";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên SP";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SL";
            this.columnHeader3.Width = 30;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn: ";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(74, 6);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(48, 13);
            this.lblMaHD.TabIndex = 3;
            this.lblMaHD.Text = "lblMaHD";
            this.lblMaHD.Click += new System.EventHandler(this.lblMaHD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày lập: ";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(74, 32);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(60, 13);
            this.lblNgayLap.TabIndex = 5;
            this.lblNgayLap.Text = "lblNgayLap";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNgayLap);
            this.panel1.Controls.Add(this.lblMaHD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 45);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Danh sách sản phẩm";
            // 
            // cbbHoaDon
            // 
            this.cbbHoaDon.FormattingEnabled = true;
            this.cbbHoaDon.Location = new System.Drawing.Point(78, 35);
            this.cbbHoaDon.Name = "cbbHoaDon";
            this.cbbHoaDon.Size = new System.Drawing.Size(121, 21);
            this.cbbHoaDon.TabIndex = 8;
            this.cbbHoaDon.SelectedValueChanged += new System.EventHandler(this.cbbHoaDon_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chọn HD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(42, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "THANH TOÁN HÓA ĐƠN";
            // 
            // fThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 367);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvDSSP);
            this.Controls.Add(this.btnTTHD);
            this.Name = "fThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThanhToan";
            this.Load += new System.EventHandler(this.fThanhToan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTTHD;
        private System.Windows.Forms.ListView lvDSSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}