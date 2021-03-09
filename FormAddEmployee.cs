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

namespace QLCF
{
    public partial class FormAddEmployee : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        String hoten, diachi, gioitinh, status, keyword, sodienthoai, password;
        DateTime DoB;
        int nvId;
        Boolean isAdmin;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            checkNV();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy?", "Hủy", MessageBoxButtons.YesNo);
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


        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "123456";
        }

        public void checkNV()
        {
            hoten = txtHoten.Text.Trim();
            diachi = txtAddress.Text.Trim();
            DoB = dtPickerDoB.Value;

            var today = DateTime.Today;
            decimal age = today.Year - DoB.Year;

            if (hoten == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                txtHoten.Focus();
            }
            if (sodienthoai == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                txtSDT.Focus();
            }
            else if (diachi == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.");
                txtAddress.Focus();
            }
            else if (age < 18)
            {
                MessageBox.Show("Số tuổi phải lớn hơn 18.");
                dtPickerDoB.Focus();
            }

            else if (gioitinh == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
            }

            else if (status == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái làm việc.");
            }
            else
            {
                saveData();
            }
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
            SqlParameter sdt = command.Parameters.Add("sDiachi", SqlDbType.NVarChar, 10);
            sdt.Value = sodienthoai;
            SqlParameter matKhau = command.Parameters.Add("sDiachi", SqlDbType.VarChar, 20);
            matKhau.Value = password;
            SqlParameter Dob = command.Parameters.Add("dNgaysinh", SqlDbType.Date);
            Dob.Value = DoB;
            SqlParameter gender = command.Parameters.Add("sGioitinh", SqlDbType.NVarChar, 10);
            gender.Value = gioitinh;
            SqlParameter workingSTT = command.Parameters.Add("status", SqlDbType.NVarChar, 20);
            workingSTT.Value = status;
            SqlParameter isAdmin = command.Parameters.Add("isAdmin", SqlDbType.Bit);
            isAdmin.Value = isAdmin;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Thêm thành công");
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                string temp;
                temp = ((RadioButton)sender).Text;
                if (temp == "Có")
                {
                    isAdmin = true;
                }
            }
                
        }

        private void rbNotAdmin_CheckedChanged(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Checked)
            {
                string temp;
                temp = ((RadioButton)sender).Text;
                if (temp == "Có")
                {
                    isAdmin = false;
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

    }
}
