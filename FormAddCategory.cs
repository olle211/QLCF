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
    public partial class FormAddCategory : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

        public FormAddCategory(string type)
        {
            InitializeComponent();
            string typeForm = type;
            if (typeForm == "new")
            {
                this.Text = "Thêm mới loại đồ uống";
            }
            else if (typeForm == "edit")
            {
                this.Text = "Sửa loại đồ uống";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!checkCategoryExist())
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
                Close();
            }
        }

        public bool checkCategoryExist()
        {
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("checkCategoryExist", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter sdt = command.Parameters.Add("categoryNm", SqlDbType.VarChar, 10);
            sdt.Value = txtHoten.Text.Trim();

            connection.Open();
            var dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (dataReader.HasRows)
            {
                MessageBox.Show("Loại đồ uống đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoten.Focus();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        public void saveData()
        {
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("addCategory", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter hoTen = command.Parameters.Add("sTenloaidouong", SqlDbType.NVarChar, 20);
            hoTen.Value = txtHoten.Text.Trim();

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Thêm mới thành công!");
            Close();
        }

        private void txtHoten_Validating(object sender, CancelEventArgs e)
        {
            string hoten = txtHoten.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoten))
            {
                e.Cancel = true;
                txtHoten.Focus();
                errorProvider1.SetError(txtHoten, "Trường Tên loại đồ uống không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtHoten, "");
            }
        }

    }
}
