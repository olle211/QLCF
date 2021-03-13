
namespace QLCF
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.iMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridViewBeverage = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenloaidouong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMaloaidouong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeverage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWelcome.Location = new System.Drawing.Point(364, 8);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(98, 13);
            this.lblWelcome.TabIndex = 21;
            this.lblWelcome.Text = "Xin chào username";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 478);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.btnReport);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.dataGridViewNV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(436, 398);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 40);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(317, 398);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 40);
            this.btnEdit.TabIndex = 60;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearch.Location = new System.Drawing.Point(247, 349);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(272, 20);
            this.txtSearch.TabIndex = 45;
            this.txtSearch.Text = "Tên nhân viên/Số điện thoại...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(542, 339);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(542, 398);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(97, 40);
            this.btnReport.TabIndex = 42;
            this.btnReport.Text = "In danh sách";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(178, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 40);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.AllowUserToAddRows = false;
            this.dataGridViewNV.AllowUserToDeleteRows = false;
            this.dataGridViewNV.AllowUserToOrderColumns = true;
            this.dataGridViewNV.AllowUserToResizeColumns = false;
            this.dataGridViewNV.AllowUserToResizeRows = false;
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMaNV,
            this.sHoten,
            this.sGioitinh,
            this.sSDT,
            this.sDiachi,
            this.dNgaysinh,
            this.sTrangthai,
            this.isAdmin});
            this.dataGridViewNV.Location = new System.Drawing.Point(-4, 0);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.ReadOnly = true;
            this.dataGridViewNV.Size = new System.Drawing.Size(844, 330);
            this.dataGridViewNV.TabIndex = 8;
            this.dataGridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellClick);
            // 
            // iMaNV
            // 
            this.iMaNV.DataPropertyName = "iMaNV";
            this.iMaNV.HeaderText = "Mã nhân viên";
            this.iMaNV.Name = "iMaNV";
            this.iMaNV.ReadOnly = true;
            this.iMaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // sHoten
            // 
            this.sHoten.DataPropertyName = "sHoten";
            this.sHoten.HeaderText = "Họ tên";
            this.sHoten.Name = "sHoten";
            this.sHoten.ReadOnly = true;
            // 
            // sGioitinh
            // 
            this.sGioitinh.DataPropertyName = "sGioitinh";
            this.sGioitinh.HeaderText = "Giới tính";
            this.sGioitinh.Name = "sGioitinh";
            this.sGioitinh.ReadOnly = true;
            // 
            // sSDT
            // 
            this.sSDT.DataPropertyName = "sSDT";
            this.sSDT.HeaderText = "Số điện thoại";
            this.sSDT.Name = "sSDT";
            this.sSDT.ReadOnly = true;
            // 
            // sDiachi
            // 
            this.sDiachi.DataPropertyName = "sDiachi";
            this.sDiachi.HeaderText = "Địa chỉ";
            this.sDiachi.Name = "sDiachi";
            this.sDiachi.ReadOnly = true;
            // 
            // dNgaysinh
            // 
            this.dNgaysinh.DataPropertyName = "dNgaysinh";
            this.dNgaysinh.HeaderText = "Ngày sinh";
            this.dNgaysinh.Name = "dNgaysinh";
            this.dNgaysinh.ReadOnly = true;
            // 
            // sTrangthai
            // 
            this.sTrangthai.DataPropertyName = "sTrangthai";
            this.sTrangthai.HeaderText = "Trạng thái";
            this.sTrangthai.Name = "sTrangthai";
            this.sTrangthai.ReadOnly = true;
            this.sTrangthai.Width = 80;
            // 
            // isAdmin
            // 
            this.isAdmin.DataPropertyName = "isAdmin";
            this.isAdmin.HeaderText = "Quyền quản trị";
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.ReadOnly = true;
            this.isAdmin.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEditCategory);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnDeleteCategory);
            this.tabPage2.Controls.Add(this.btnAddCategory);
            this.tabPage2.Controls.Add(this.dataGridViewCategory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại đồ uống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(249, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 57;
            this.textBox1.Text = "Tên nhân viên/Số điện thoại...";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(544, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 56;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(531, 398);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(53, 40);
            this.btnDeleteCategory.TabIndex = 55;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(249, 398);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(80, 40);
            this.btnAddCategory.TabIndex = 54;
            this.btnAddCategory.Text = "Thêm mới";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.AllowUserToAddRows = false;
            this.dataGridViewCategory.AllowUserToDeleteRows = false;
            this.dataGridViewCategory.AllowUserToOrderColumns = true;
            this.dataGridViewCategory.AllowUserToResizeColumns = false;
            this.dataGridViewCategory.AllowUserToResizeRows = false;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewCategory.Location = new System.Drawing.Point(-2, 0);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.ReadOnly = true;
            this.dataGridViewCategory.Size = new System.Drawing.Size(842, 337);
            this.dataGridViewCategory.TabIndex = 53;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iMaloaidouong";
            this.dataGridViewTextBoxColumn1.DividerWidth = 1;
            this.dataGridViewTextBoxColumn1.FillWeight = 193.1972F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã loại đồ uống";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sTenloaidouong";
            this.dataGridViewTextBoxColumn2.DividerWidth = 1;
            this.dataGridViewTextBoxColumn2.FillWeight = 6.802719F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên loại đồ uống";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.dataGridViewBeverage);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(840, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Đồ uống";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(405, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 40);
            this.button6.TabIndex = 65;
            this.button6.Text = "Sửa";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(249, 363);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 20);
            this.textBox2.TabIndex = 64;
            this.textBox2.Text = "Tên nhân viên/Số điện thoại...";
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(544, 353);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 63;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(531, 405);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 40);
            this.button8.TabIndex = 62;
            this.button8.Text = "Xóa";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(249, 405);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 40);
            this.button9.TabIndex = 61;
            this.button9.Text = "Thêm mới";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridViewBeverage
            // 
            this.dataGridViewBeverage.AllowUserToAddRows = false;
            this.dataGridViewBeverage.AllowUserToDeleteRows = false;
            this.dataGridViewBeverage.AllowUserToOrderColumns = true;
            this.dataGridViewBeverage.AllowUserToResizeColumns = false;
            this.dataGridViewBeverage.AllowUserToResizeRows = false;
            this.dataGridViewBeverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeverage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.iSoluong,
            this.fDongia,
            this.sTenloaidouong,
            this.iMaloaidouong});
            this.dataGridViewBeverage.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBeverage.Name = "dataGridViewBeverage";
            this.dataGridViewBeverage.ReadOnly = true;
            this.dataGridViewBeverage.Size = new System.Drawing.Size(840, 337);
            this.dataGridViewBeverage.TabIndex = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "iMadouong";
            this.dataGridViewTextBoxColumn3.FillWeight = 161.0096F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã đồ uống";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sTendouong";
            this.dataGridViewTextBoxColumn4.FillWeight = 7.187927F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên đồ uống";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // iSoluong
            // 
            this.iSoluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iSoluong.DataPropertyName = "iSoluong";
            this.iSoluong.FillWeight = 7.187927F;
            this.iSoluong.HeaderText = "Số lượng";
            this.iSoluong.Name = "iSoluong";
            this.iSoluong.ReadOnly = true;
            // 
            // fDongia
            // 
            this.fDongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fDongia.DataPropertyName = "fDongia";
            this.fDongia.FillWeight = 7.187927F;
            this.fDongia.HeaderText = "Đơn giá";
            this.fDongia.Name = "fDongia";
            this.fDongia.ReadOnly = true;
            // 
            // sTenloaidouong
            // 
            this.sTenloaidouong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTenloaidouong.DataPropertyName = "sTenloaidouong";
            this.sTenloaidouong.FillWeight = 7.187927F;
            this.sTenloaidouong.HeaderText = "Loại đồ uống";
            this.sTenloaidouong.Name = "sTenloaidouong";
            this.sTenloaidouong.ReadOnly = true;
            // 
            // iMaloaidouong
            // 
            this.iMaloaidouong.DataPropertyName = "iMaloaidouong";
            this.iMaloaidouong.HeaderText = "Column2";
            this.iMaloaidouong.Name = "iMaloaidouong";
            this.iMaloaidouong.ReadOnly = true;
            this.iMaloaidouong.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(840, 452);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bàn";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(840, 452);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Thống kê doanh thu";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCategory.Image")));
            this.btnEditCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCategory.Location = new System.Drawing.Point(405, 398);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(53, 40);
            this.btnEditCategory.TabIndex = 59;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 496);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin";
            this.Text = "Danh mục quản trị hệ thống";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeverage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridViewBeverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenloaidouong;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaloaidouong;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditCategory;
    }
}