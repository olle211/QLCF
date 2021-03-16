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
    public partial class FormLogin : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        Boolean isAdmin;
        string name, username, password, maNV;

        public FormLogin()
        {
            InitializeComponent();
        }

        public void checkLogin()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("LoginCheck", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter thisUsername = command.Parameters.Add("username", SqlDbType.VarChar);
            thisUsername.Value = txtUsername.Text;
            SqlParameter thisPassword = command.Parameters.Add("password", SqlDbType.VarChar);
            thisPassword.Value = txtPassword.Text;
            connection.Open();
            var dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    isAdmin = dataReader.GetBoolean(dataReader.GetOrdinal("isAdmin"));
                    username = dataReader.GetString(dataReader.GetOrdinal("sSDT"));
                    password = dataReader.GetString(dataReader.GetOrdinal("sMatkhau"));
                    name = dataReader.GetString(dataReader.GetOrdinal("sHoten"));
                    maNV = dataReader.GetInt32(dataReader.GetOrdinal("iMaNV")).ToString();
                }
                if (username == txtUsername.Text && password != txtPassword.Text)
                {
                    MessageBox.Show("Sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (username == txtUsername.Text && password == txtPassword.Text)
                {
                    if (isAdmin == true)
                    {
                        FormAdmin FormAdmin = new FormAdmin(name);
                        Hide();
                        FormAdmin.ShowDialog();
                        Show();
                    }
                    else
                    {
                        FormEmployee FormEmployee = new FormEmployee(name, maNV);
                        Hide();
                        FormEmployee.ShowDialog();
                        Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection.Close();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                checkLogin();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                checkLogin();
        }

        private void linkForgotPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormResetPW FormResetPW = new FormResetPW();
            Hide();
            FormResetPW.ShowDialog();
            Show();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorUsername.SetError(txtUsername, "Trường Số điện thoại không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorUsername.SetError(txtUsername, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(password))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorPassword.SetError(txtPassword, "Trường Mật khẩu không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorPassword.SetError(txtPassword, "");
            }
        }
    }
}
