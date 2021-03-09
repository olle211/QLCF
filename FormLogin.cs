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
        string name;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Yêu cầu nhập đủ thông tin đăng nhập");
            else
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
                        name = dataReader.GetString(1);
                        isAdmin = dataReader.GetBoolean(dataReader.GetOrdinal("isAdmin"));
                        if(isAdmin == true)
                        {
                            FormAdmin FormAdmin = new FormAdmin(name);
                            Hide();
                            FormAdmin.ShowDialog();
                            Show();
                        }
                        else
                        {
                            FormEmployee FormEmployee = new FormEmployee(name);
                            Hide();
                            FormEmployee.ShowDialog();
                            Show();
                        }
                    }
                }
                else
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                connection.Close();
            }
        }
    }
}
