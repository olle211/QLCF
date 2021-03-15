
namespace QLCF
{
    partial class fTaoHoaDon
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
            this.btnXong = new System.Windows.Forms.Button();
            this.numericSoluong = new System.Windows.Forms.NumericUpDown();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaNV1 = new System.Windows.Forms.Label();
            this.lblNVLapHD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMenu = new System.Windows.Forms.ComboBox();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSLcon = new System.Windows.Forms.Label();
            this.HD_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.numericSLXoa = new System.Windows.Forms.NumericUpDown();
            this.panelXoa = new System.Windows.Forms.Panel();
            this.lblTenSPxoa = new System.Windows.Forms.Label();
            this.lblMaSPxoa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCheckedIndex = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoluong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSLXoa)).BeginInit();
            this.panelXoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXong
            // 
            this.btnXong.Location = new System.Drawing.Point(344, 335);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(112, 23);
            this.btnXong.TabIndex = 2;
            this.btnXong.Text = "Chuyển pha chế";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // numericSoluong
            // 
            this.numericSoluong.Location = new System.Drawing.Point(289, 71);
            this.numericSoluong.Name = "numericSoluong";
            this.numericSoluong.Size = new System.Drawing.Size(48, 20);
            this.numericSoluong.TabIndex = 3;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Enabled = false;
            this.btnThemSP.Location = new System.Drawing.Point(344, 70);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(50, 23);
            this.btnThemSP.TabIndex = 4;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaNV);
            this.panel1.Controls.Add(this.lblMaNV1);
            this.panel1.Controls.Add(this.lblNVLapHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(71, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 32);
            this.panel1.TabIndex = 5;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(251, 4);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(0, 13);
            this.lblMaNV.TabIndex = 3;
            // 
            // lblMaNV1
            // 
            this.lblMaNV1.AutoSize = true;
            this.lblMaNV1.Location = new System.Drawing.Point(204, 4);
            this.lblMaNV1.Name = "lblMaNV1";
            this.lblMaNV1.Size = new System.Drawing.Size(46, 13);
            this.lblMaNV1.TabIndex = 2;
            this.lblMaNV1.Text = "Mã NV: ";
            // 
            // lblNVLapHD
            // 
            this.lblNVLapHD.AutoSize = true;
            this.lblNVLapHD.Location = new System.Drawing.Point(81, 4);
            this.lblNVLapHD.Name = "lblNVLapHD";
            this.lblNVLapHD.Size = new System.Drawing.Size(0, 13);
            this.lblNVLapHD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người lập HD: ";
            // 
            // cbbMenu
            // 
            this.cbbMenu.FormattingEnabled = true;
            this.cbbMenu.Location = new System.Drawing.Point(18, 71);
            this.cbbMenu.Name = "cbbMenu";
            this.cbbMenu.Size = new System.Drawing.Size(187, 21);
            this.cbbMenu.TabIndex = 6;
            this.cbbMenu.SelectedValueChanged += new System.EventHandler(this.cbbMenu_SelectedValueChanged);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(143, 26);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(90, 23);
            this.btnXoaSP.TabIndex = 7;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "SL còn: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSLcon
            // 
            this.lblSLcon.AutoSize = true;
            this.lblSLcon.Location = new System.Drawing.Point(258, 75);
            this.lblSLcon.Name = "lblSLcon";
            this.lblSLcon.Size = new System.Drawing.Size(0, 13);
            this.lblSLcon.TabIndex = 10;
            // 
            // HD_SoLuong
            // 
            this.HD_SoLuong.DataPropertyName = "iSoluong";
            this.HD_SoLuong.HeaderText = "SL";
            this.HD_SoLuong.Name = "HD_SoLuong";
            // 
            // HD_Gia
            // 
            this.HD_Gia.DataPropertyName = "fDongia";
            this.HD_Gia.HeaderText = "Giá";
            this.HD_Gia.Name = "HD_Gia";
            // 
            // HD_TenSP
            // 
            this.HD_TenSP.DataPropertyName = "sTenSP";
            this.HD_TenSP.HeaderText = "Tên sản phẩm";
            this.HD_TenSP.Name = "HD_TenSP";
            // 
            // HD_MaSP
            // 
            this.HD_MaSP.DataPropertyName = "iMaSP";
            this.HD_MaSP.HeaderText = "Mã SP";
            this.HD_MaSP.Name = "HD_MaSP";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HD_MaSP,
            this.HD_TenSP,
            this.HD_Gia,
            this.HD_SoLuong});
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 113);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(444, 216);
            this.dgvHoaDon.TabIndex = 1;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // numericSLXoa
            // 
            this.numericSLXoa.Location = new System.Drawing.Point(143, 3);
            this.numericSLXoa.Name = "numericSLXoa";
            this.numericSLXoa.Size = new System.Drawing.Size(90, 20);
            this.numericSLXoa.TabIndex = 11;
            this.numericSLXoa.ValueChanged += new System.EventHandler(this.numericSLXoa_ValueChanged);
            // 
            // panelXoa
            // 
            this.panelXoa.Controls.Add(this.lblTenSPxoa);
            this.panelXoa.Controls.Add(this.lblMaSPxoa);
            this.panelXoa.Controls.Add(this.label4);
            this.panelXoa.Controls.Add(this.label3);
            this.panelXoa.Controls.Add(this.numericSLXoa);
            this.panelXoa.Controls.Add(this.btnXoaSP);
            this.panelXoa.Location = new System.Drawing.Point(12, 335);
            this.panelXoa.Name = "panelXoa";
            this.panelXoa.Size = new System.Drawing.Size(240, 52);
            this.panelXoa.TabIndex = 12;
            this.panelXoa.Visible = false;
            // 
            // lblTenSPxoa
            // 
            this.lblTenSPxoa.AutoSize = true;
            this.lblTenSPxoa.Location = new System.Drawing.Point(44, 31);
            this.lblTenSPxoa.Name = "lblTenSPxoa";
            this.lblTenSPxoa.Size = new System.Drawing.Size(35, 13);
            this.lblTenSPxoa.TabIndex = 15;
            this.lblTenSPxoa.Text = "label6";
            // 
            // lblMaSPxoa
            // 
            this.lblMaSPxoa.AutoSize = true;
            this.lblMaSPxoa.Location = new System.Drawing.Point(44, 10);
            this.lblMaSPxoa.Name = "lblMaSPxoa";
            this.lblMaSPxoa.Size = new System.Drawing.Size(35, 13);
            this.lblMaSPxoa.TabIndex = 14;
            this.lblMaSPxoa.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên sp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã Sp:";
            // 
            // lblCheckedIndex
            // 
            this.lblCheckedIndex.AutoSize = true;
            this.lblCheckedIndex.Location = new System.Drawing.Point(289, 344);
            this.lblCheckedIndex.Name = "lblCheckedIndex";
            this.lblCheckedIndex.Size = new System.Drawing.Size(35, 13);
            this.lblCheckedIndex.TabIndex = 13;
            this.lblCheckedIndex.Text = "label5";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(344, 361);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(112, 23);
            this.btnThanhToan.TabIndex = 14;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // fTaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 389);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblCheckedIndex);
            this.Controls.Add(this.panelXoa);
            this.Controls.Add(this.lblSLcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.numericSoluong);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "fTaoHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTaoHoaDon";
            this.Load += new System.EventHandler(this.fTaoHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSoluong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSLXoa)).EndInit();
            this.panelXoa.ResumeLayout(false);
            this.panelXoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.NumericUpDown numericSoluong;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaNV1;
        private System.Windows.Forms.Label lblNVLapHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMenu;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSLcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD_MaSP;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.NumericUpDown numericSLXoa;
        private System.Windows.Forms.Panel panelXoa;
        private System.Windows.Forms.Label lblTenSPxoa;
        private System.Windows.Forms.Label lblMaSPxoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCheckedIndex;
        private System.Windows.Forms.Button btnThanhToan;
    }
}