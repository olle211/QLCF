using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLCF
{
    public partial class FormAddEmployee : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        String hoten, diachi, gioitinh, status, sodienthoai, password, isAdmin;
        DateTime DoB;
        int isadmin;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!checkEmployeeExist())
                {
                    saveData();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy?", "Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                txtHoten.Text = "";
                txtAddress.Text = "";
                txtSDT.Text = "";
                txtPassword.Text = "123456";
                dtPickerDoB.Value = DateTime.Now;
                rbNam.Checked = false;
                rbNu.Checked = false;
                rbNotWorking.Checked = false;
                rbWorking.Checked = false;
                rbAdmin.Checked = false;
                rbNotAdmin.Checked = false;
                btnEdit.Enabled = false;
            }
        }


        public FormAddEmployee(string type, List<string> dataArray)
        {
            InitializeComponent();
            string typeForm = type;
            if(typeForm == "new")
            {
                this.Text = "Thêm mới nhân viên";
            }
            else if (typeForm == "edit")
            {
                this.Text = "Sửa nhân viên";
            }
            List<string> data = dataArray;
            /*foreach(string i in data)
            {
                txtHoten.Text = data[i].name;
            }*/
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "123456";
        }

        public void saveData()
        {
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("addNV", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter hoTen = command.Parameters.Add("sHoten", SqlDbType.NVarChar, 50);
            hoTen.Value = hoten;
            SqlParameter diaChi = command.Parameters.Add("sDiachi", SqlDbType.NVarChar, 50);
            diaChi.Value = diachi;
            SqlParameter sdt = command.Parameters.Add("sSDT", SqlDbType.VarChar, 10);
            sdt.Value = sodienthoai;
            SqlParameter matKhau = command.Parameters.Add("password", SqlDbType.VarChar, 20);
            matKhau.Value = "123456";
            SqlParameter Dob = command.Parameters.Add("dNgaysinh", SqlDbType.Date);
            Dob.Value = DoB;
            SqlParameter gender = command.Parameters.Add("sGioitinh", SqlDbType.NVarChar, 10);
            gender.Value = gioitinh;
            SqlParameter workingSTT = command.Parameters.Add("status", SqlDbType.NVarChar, 20);
            workingSTT.Value = status;
            SqlParameter isAdmin = command.Parameters.Add("isAdmin", SqlDbType.Bit);
            isAdmin.Value = isadmin;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Thêm mới nhân viên thành công!");
            Close();
        }

        public bool checkEmployeeExist()
        {
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("checkEmployeeExist", connection);
            command.CommandType = CommandType.StoredProcedure;
            sodienthoai = txtSDT.Text.Trim();

            SqlParameter sdt = command.Parameters.Add("sSDT", SqlDbType.VarChar, 10);
            sdt.Value = sodienthoai;

            connection.Open();
            var dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (dataReader.HasRows)
            {
                /*if (dataReader.Read())
                {
                    string SDT = dataReader.GetString(0);
                    if (sodienthoai == SDT)
                    {
                        MessageBox.Show("Đã tồn tại nhân viên có số điện thoại " + SDT + "!");
                    }
                }*/
                MessageBox.Show("Số điện thoại đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                isAdmin = ((RadioButton)sender).Text;
                if (isAdmin == "Có")
                {
                    isadmin = 1;
                }
            }

        }

        private void rbNotAdmin_CheckedChanged(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Checked)
            {
                isAdmin = ((RadioButton)sender).Text;
                if (isAdmin == "Có")
                {
                    isadmin = 0;
                }
            }
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                gioitinh = ((RadioButton)sender).Text;
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                gioitinh = ((RadioButton)sender).Text;
        }

        private void rbNotWorking_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                status = ((RadioButton)sender).Text;
        }

        private void rbWorking_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                status = ((RadioButton)sender).Text;
        }

        private void txtHoten_Validating(object sender, CancelEventArgs e)
        {
            hoten = txtHoten.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoten))
            {
                e.Cancel = true;
                txtHoten.Focus();
                errorHoten.SetError(txtHoten, "Trường Họ tên không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorHoten.SetError(txtHoten, "");
            }
        }
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            diachi = txtAddress.Text.Trim();
            if (string.IsNullOrWhiteSpace(diachi))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorAddress.SetError(txtAddress, "Trường Địa chỉ không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorAddress.SetError(txtAddress, "");
            }
        }
        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            sodienthoai = txtSDT.Text.Trim();
            if (string.IsNullOrWhiteSpace(sodienthoai))
            {
                e.Cancel = true;
                txtSDT.Focus();
                errorSDT.SetError(txtSDT, "Trường Số điện thoại không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorSDT.SetError(txtSDT, "");
            }
        }
        private void gbGender_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gioitinh))
            {
                e.Cancel = true;
                errorGender.SetError(gbGender, "Trường Giới tính bắt buộc chọn");
            }
            else
            {
                e.Cancel = false;
                errorGender.SetError(gbGender, "");
            }
        }
        private void gbStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(status))
            {
                e.Cancel = true;
                errorStatus.SetError(gbStatus, "Trường Trạng thái bắt buộc chọn");
            }
            else
            {
                e.Cancel = false;
                errorStatus.SetError(gbStatus, "");
            }
        }
        private void gbIsAdmin_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(isAdmin))
            {
                e.Cancel = true;
                errorIsAdmin.SetError(gbIsAdmin, "Trường Quyền quản trị bắt buộc chọn");
            }
            else
            {
                e.Cancel = false;
                errorIsAdmin.SetError(gbIsAdmin, "");
            }
        }

        private void dtPickerDoB_Validating(object sender, CancelEventArgs e)
        {
            DoB = dtPickerDoB.Value;

            var today = DateTime.Today;
            decimal age = today.Year - DoB.Year;
            if (age < 18)
            {
                e.Cancel = true;
                errorDoB.SetError(dtPickerDoB, "Số tuổi phải lớn hơn 18");
                dtPickerDoB.Focus();
            }
            else
            {
                e.Cancel = false;
                errorDoB.SetError(dtPickerDoB, "");
            }
        }
    }
}

