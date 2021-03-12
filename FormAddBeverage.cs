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
    public partial class FormAddBeverage : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        int categoryId;
        string categoryName;
        class Category
        {
            public int idCategory { get; set; }

            public string nameCategory { get; set; }
        }
        public FormAddBeverage(string type)
        {
            InitializeComponent();
            string typeForm = type;
            if (typeForm == "new")
            {
                this.Text = "Thêm mới đồ uống";
            }
            else if (typeForm == "edit")
            {
                this.Text = "Sửa đồ uống";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!checkBeverageExist())
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

        public bool checkBeverageExist()
        {
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("checkBeverageExist", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter sdt = command.Parameters.Add("beverageNm", SqlDbType.VarChar, 20);
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
            var command = new SqlCommand("addBeverage", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter hoTen = command.Parameters.Add("sTendouong", SqlDbType.NVarChar, 20);
            hoTen.Value = txtHoten.Text.Trim();
            SqlParameter price = command.Parameters.Add("fDongia", SqlDbType.Real);
            price.Value = txtPrice.Text.Trim();
            SqlParameter amount = command.Parameters.Add("iSoluong", SqlDbType.Int);
            amount.Value = txtAmount.Text.Trim();
            SqlParameter category = command.Parameters.Add("iMaloaidouong", SqlDbType.Int);
            category.Value = categoryId;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Thêm mới thành công!");
            Close();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex != -1)
            {
                Category selectedItem = comboBoxCategory.SelectedItem as Category;
                if (selectedItem != null)
                {
                    categoryName = selectedItem.nameCategory;
                    categoryId = selectedItem.idCategory;
                }
            }
        }

        private void txtHoten_Validating(object sender, CancelEventArgs e)
        {
            string hoten = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoten))
            {
                e.Cancel = true;
                txtName.Focus();
                errorName.SetError(txtName, "Trường Tên đồ uống không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorName.SetError(txtName, "");
            }
        }
        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            string hoten = txtPrice.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoten))
            {
                e.Cancel = true;
                txtPrice.Focus();
                errorPrice.SetError(txtPrice, "Trường Đơn giá không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorPrice.SetError(txtPrice, "");
            }
        }
        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            string hoten = txtAmount.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoten))
            {
                e.Cancel = true;
                txtAmount.Focus();
                errorAmount.SetError(txtAmount, "Trường Số lượng không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorAmount.SetError(txtAmount, "");
            }
        }
        private void txtCategory_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxCategory.SelectedIndex != -1)
            {
                Category selectedItem = comboBoxCategory.SelectedItem as Category;
                if(selectedItem == null)
                {
                    e.Cancel = true;
                    comboBoxCategory.Focus();
                    errorCategory.SetError(comboBoxCategory, "Trường Loại đồ uống bắt buộc chọn!");
                }
                else
                {
                    e.Cancel = false;
                    errorCategory.SetError(comboBoxCategory, "");
                }
            }
        }

        private void FormAddBeverage_Load(object sender, EventArgs e)
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("returnCategory", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader drCategory = command.ExecuteReader();
            if (drCategory.HasRows)
            {
                while (drCategory.Read())
                {
                    comboBoxCategory.Items.Add(new Category()
                    {
                        idCategory = drCategory.GetInt32(0),
                        nameCategory = drCategory.GetString(1)
                    });
                }
                comboBoxCategory.DisplayMember = "nameCategory";
                comboBoxCategory.ValueMember = "idCategory";
            }
            connection.Close();
        }
    }
}
