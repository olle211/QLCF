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
        int categoryId, bevid;
        string categoryName;
        class Category
        {
            public int idCategory { get; set; }

            public string nameCategory { get; set; }
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
        public FormAddBeverage(string type, int bevId, string bevName, float bevPrice, int bevAmount, string bevCateName, int bevCateId)
        {
            InitializeComponent();
            bevid = bevId;
            categoryId = bevCateId;
            string typeForm = type;
            if (typeForm == "new")
            {
                this.Text = "Thêm mới đồ uống";
                btnAdd.Visible = true;
                btnEdit.Visible = false;
            }
            else if (typeForm == "edit")
            {
                this.Text = "Sửa đồ uống";
                txtHoten.Text = bevId.ToString();
                txtName.Text = bevName;
                txtPrice.Text = bevPrice.ToString();
                txtAmount.Text = bevAmount.ToString();
                comboBoxCategory.Text = bevCateName;
                btnAdd.Visible = false;
                btnEdit.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!checkBeverageExist())
                {
                    saveData();
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                saveChange();
            }
        }
        public void saveChange()
        {
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("editBeverage", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter id = command.Parameters.Add("iMadouong", SqlDbType.Int);
            id.Value = bevid;
            SqlParameter hoTen = command.Parameters.Add("sTendouong", SqlDbType.NVarChar, 20);
            hoTen.Value = txtName.Text.Trim();
            SqlParameter donGia = command.Parameters.Add("fDongia", SqlDbType.Float);
            donGia.Value = txtPrice.Text.Trim();
            SqlParameter soLg = command.Parameters.Add("iSoluong", SqlDbType.Int);
            soLg.Value = txtAmount.Text.Trim();
            SqlParameter category = command.Parameters.Add("iMaloaidouong", SqlDbType.Int);
            category.Value = categoryId;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
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
                MessageBox.Show("Đồ uống đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            hoTen.Value = txtName.Text.Trim();
            SqlParameter price = command.Parameters.Add("fDongia", SqlDbType.Real);
            price.Value = txtPrice.Text.Trim();
            SqlParameter amount = command.Parameters.Add("iSoluong", SqlDbType.Int);
            amount.Value = txtAmount.Text.Trim();
            SqlParameter category = command.Parameters.Add("iMaloaidouong", SqlDbType.Int);
            category.Value = categoryId;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (comboBoxCategory.SelectedIndex == -1)
            {
                Category selectedItem = comboBoxCategory.SelectedItem as Category;
                if (selectedItem == null)
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
    }
}
