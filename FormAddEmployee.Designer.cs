
namespace QLCF
{
    partial class FormAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEmployee));
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbNotWorking = new System.Windows.Forms.RadioButton();
            this.rbWorking = new System.Windows.Forms.RadioButton();
            this.dtPickerDoB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbIsAdmin = new System.Windows.Forms.GroupBox();
            this.rbNotAdmin = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorHoten = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorIsAdmin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDoB = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbIsAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDoB)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbNam);
            this.gbGender.Controls.Add(this.rbNu);
            this.gbGender.Location = new System.Drawing.Point(12, 84);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(220, 23);
            this.gbGender.TabIndex = 46;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Giới tính:";
            this.gbGender.Validating += new System.ComponentModel.CancelEventHandler(this.gbGender_Validating);
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(88, 0);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 25;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(163, 0);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 26;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(353, 14);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(158, 20);
            this.txtSDT.TabIndex = 45;
            this.txtSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtSDT_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(83, 50);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(149, 20);
            this.txtAddress.TabIndex = 41;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(82, 15);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(150, 20);
            this.txtHoten.TabIndex = 39;
            this.txtHoten.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoten_Validating);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbNotWorking);
            this.gbStatus.Controls.Add(this.rbWorking);
            this.gbStatus.Location = new System.Drawing.Point(265, 81);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(246, 26);
            this.gbStatus.TabIndex = 47;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Trạng thái:";
            this.gbStatus.Validating += new System.ComponentModel.CancelEventHandler(this.gbStatus_Validating);
            // 
            // rbNotWorking
            // 
            this.rbNotWorking.AutoSize = true;
            this.rbNotWorking.Location = new System.Drawing.Point(163, 0);
            this.rbNotWorking.Name = "rbNotWorking";
            this.rbNotWorking.Size = new System.Drawing.Size(70, 17);
            this.rbNotWorking.TabIndex = 35;
            this.rbNotWorking.TabStop = true;
            this.rbNotWorking.Text = "Nghỉ việc";
            this.rbNotWorking.UseVisualStyleBackColor = true;
            this.rbNotWorking.CheckedChanged += new System.EventHandler(this.rbNotWorking_CheckedChanged);
            // 
            // rbWorking
            // 
            this.rbWorking.AutoSize = true;
            this.rbWorking.Location = new System.Drawing.Point(88, 0);
            this.rbWorking.Name = "rbWorking";
            this.rbWorking.Size = new System.Drawing.Size(70, 17);
            this.rbWorking.TabIndex = 34;
            this.rbWorking.TabStop = true;
            this.rbWorking.Text = "Đang làm";
            this.rbWorking.UseVisualStyleBackColor = true;
            this.rbWorking.CheckedChanged += new System.EventHandler(this.rbWorking_CheckedChanged);
            // 
            // dtPickerDoB
            // 
            this.dtPickerDoB.CustomFormat = "dd-MM-yyyy";
            this.dtPickerDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerDoB.Location = new System.Drawing.Point(353, 50);
            this.dtPickerDoB.Name = "dtPickerDoB";
            this.dtPickerDoB.Size = new System.Drawing.Size(158, 20);
            this.dtPickerDoB.TabIndex = 44;
            this.dtPickerDoB.Validating += new System.ComponentModel.CancelEventHandler(this.dtPickerDoB_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Địa chỉ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ngày sinh: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Họ tên: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Số điện thoại: ";
            // 
            // gbIsAdmin
            // 
            this.gbIsAdmin.Controls.Add(this.rbNotAdmin);
            this.gbIsAdmin.Controls.Add(this.rbAdmin);
            this.gbIsAdmin.Location = new System.Drawing.Point(265, 125);
            this.gbIsAdmin.Name = "gbIsAdmin";
            this.gbIsAdmin.Size = new System.Drawing.Size(246, 26);
            this.gbIsAdmin.TabIndex = 48;
            this.gbIsAdmin.TabStop = false;
            this.gbIsAdmin.Text = "Quyền quản trị:";
            this.gbIsAdmin.Validating += new System.ComponentModel.CancelEventHandler(this.gbIsAdmin_Validating);
            // 
            // rbNotAdmin
            // 
            this.rbNotAdmin.AutoSize = true;
            this.rbNotAdmin.Location = new System.Drawing.Point(163, 0);
            this.rbNotAdmin.Name = "rbNotAdmin";
            this.rbNotAdmin.Size = new System.Drawing.Size(56, 17);
            this.rbNotAdmin.TabIndex = 35;
            this.rbNotAdmin.TabStop = true;
            this.rbNotAdmin.Text = "Không";
            this.rbNotAdmin.UseVisualStyleBackColor = true;
            this.rbNotAdmin.CheckedChanged += new System.EventHandler(this.rbNotAdmin_CheckedChanged);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(88, 0);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(38, 17);
            this.rbAdmin.TabIndex = 34;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Có";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbAdmin_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(83, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(149, 20);
            this.txtPassword.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Mật khẩu:";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(163, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 40);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorHoten
            // 
            this.errorHoten.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // errorSDT
            // 
            this.errorSDT.ContainerControl = this;
            // 
            // errorGender
            // 
            this.errorGender.ContainerControl = this;
            // 
            // errorStatus
            // 
            this.errorStatus.ContainerControl = this;
            // 
            // errorIsAdmin
            // 
            this.errorIsAdmin.ContainerControl = this;
            // 
            // errorDoB
            // 
            this.errorDoB.ContainerControl = this;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(163, 164);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 40);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Lưu";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(265, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 40);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 216);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbIsAdmin);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.dtPickerDoB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "FormAddEmployee";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbIsAdmin.ResumeLayout(false);
            this.gbIsAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDoB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbNotWorking;
        private System.Windows.Forms.RadioButton rbWorking;
        private System.Windows.Forms.DateTimePicker dtPickerDoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbIsAdmin;
        private System.Windows.Forms.RadioButton rbNotAdmin;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorHoten;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.ErrorProvider errorSDT;
        private System.Windows.Forms.ErrorProvider errorGender;
        private System.Windows.Forms.ErrorProvider errorStatus;
        private System.Windows.Forms.ErrorProvider errorIsAdmin;
        private System.Windows.Forms.ErrorProvider errorDoB;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
    }
}