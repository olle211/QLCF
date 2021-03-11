using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class FormResetPW : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        public FormResetPW()
        {
            InitializeComponent();
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                changePW();
            }
        }

        private void changePW()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand ChangePW = new SqlCommand("ChangePW", connection);
            ChangePW.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlUsername = ChangePW.Parameters.Add("@username", SqlDbType.VarChar, 10);
            sqlUsername.Value = textBox1.Text.Trim();
            SqlParameter newPW = ChangePW.Parameters.Add("@newPW", SqlDbType.VarChar, 10);
            newPW.Value = txtNewPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtNewPasswordConfirm.Text.Trim();
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.Open();
                ChangePW.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            string username = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorSDT.SetError(textBox1, "Trường Số điện thoại không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorSDT.SetError(textBox1, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = txtNewPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(password))
            {
                e.Cancel = true;
                txtNewPassword.Focus();
                errorPW.SetError(txtNewPassword, "Trường Mật khẩu không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorPW.SetError(txtNewPassword, "");
            }
        }

        private void txtConfirmPW_Validating(object sender, CancelEventArgs e)
        {
            string password = txtNewPasswordConfirm.Text.Trim();
            if (string.IsNullOrWhiteSpace(password))
            {
                e.Cancel = true;
                txtNewPasswordConfirm.Focus();
                errorConfirmPW.SetError(txtNewPasswordConfirm, "Trường Mật khẩu không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorConfirmPW.SetError(txtNewPasswordConfirm, "");
            }
        }
    }
}
