
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
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSLcon = new System.Windows.Forms.Label();
            this.slSP = new System.Windows.Forms.Label();
            this.HD_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoluong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXong
            // 
            this.btnXong.Location = new System.Drawing.Point(344, 335);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(75, 23);
            this.btnXong.TabIndex = 2;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // numericSoluong
            // 
            this.numericSoluong.Location = new System.Drawing.Point(289, 70);
            this.numericSoluong.Name = "numericSoluong";
            this.numericSoluong.Size = new System.Drawing.Size(48, 20);
            this.numericSoluong.TabIndex = 3;
            // 
            // btnThemSP
            // 
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
            this.cbbMenu.Location = new System.Drawing.Point(43, 43);
            this.cbbMenu.Name = "cbbMenu";
            this.cbbMenu.Size = new System.Drawing.Size(240, 21);
            this.cbbMenu.TabIndex = 6;
            this.cbbMenu.SelectedValueChanged += new System.EventHandler(this.cbbMenu_SelectedValueChanged);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(89, 335);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSP.TabIndex = 7;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(43, 70);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(240, 20);
            this.tbGhiChu.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "SL còn: ";
            // 
            // lblSLcon
            // 
            this.lblSLcon.AutoSize = true;
            this.lblSLcon.Location = new System.Drawing.Point(332, 46);
            this.lblSLcon.Name = "lblSLcon";
            this.lblSLcon.Size = new System.Drawing.Size(0, 13);
            this.lblSLcon.TabIndex = 10;
            // 
            // slSP
            // 
            this.slSP.AutoSize = true;
            this.slSP.Location = new System.Drawing.Point(437, 24);
            this.slSP.Name = "slSP";
            this.slSP.Size = new System.Drawing.Size(25, 13);
            this.slSP.TabIndex = 11;
            this.slSP.Text = "slsp";
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
            this.dgvHoaDon.Size = new System.Drawing.Size(449, 216);
            this.dgvHoaDon.TabIndex = 1;
            // 
            // fTaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 389);
            this.Controls.Add(this.slSP);
            this.Controls.Add(this.lblSLcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGhiChu);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.cbbMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.numericSoluong);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "fTaoHoaDon";
            this.Text = "fTaoHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.numericSoluong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
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
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSLcon;
        private System.Windows.Forms.Label slSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD_MaSP;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}