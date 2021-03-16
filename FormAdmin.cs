using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCF
{
    public partial class FormAdmin : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        String username, type;
        string empName, empPhone, empAddress, cateName, bevName, bevCateName;
        DateTime empDoB;
        Boolean empIsAdmin, empGender, empStatus;
        int empId, cateId, bevId, bevCateId, bevAmount;
        float bevPrice;

        public FormAdmin(string _username)
        {
            InitializeComponent();
            username = _username;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Xin chào " + username;
            ReloadForm();
        }
        public void ReloadForm()
        {
            //danh sách nhân viên
            var connection = new SqlConnection(connectionString);
            SqlCommand command1 = new SqlCommand("returnNV", connection);
            command1.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapterNV = new SqlDataAdapter(command1);
            DataTable dataTableNV = new DataTable();
            dataAdapterNV.Fill(dataTableNV);
            dataGridViewNV.DataSource = dataTableNV;

            //danh sách loại đồ uống
            SqlCommand command2 = new SqlCommand("returnCategory", connection);
            command2.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daCategory = new SqlDataAdapter(command2);
            DataTable dtCategory = new DataTable();
            daCategory.Fill(dtCategory);
            dataGridViewCategory.DataSource = dtCategory;

            //danh sách đồ uống
            SqlCommand command3 = new SqlCommand("returnBeverage", connection);
            command3.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daBeverage = new SqlDataAdapter(command3);
            DataTable dtBeverage = new DataTable();
            daBeverage.Fill(dtBeverage);
            dataGridViewBeverage.DataSource = dtBeverage;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            type = "new";
            FormAddEmployee FormAddEmployee = new FormAddEmployee(type, empId, empName, empPhone, empAddress, empStatus, empGender, empDoB, empIsAdmin);
            FormAddEmployee.ShowDialog();
            Show();
            ReloadForm();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tên nhân viên/Số điện thoại...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void btnDeleteBeverage_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection(connectionString);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa đồ uống này? Dữ liệu sẽ không thể khôi phục.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("deleteBeverage", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter categoryid = command.Parameters.Add("iMadouong", SqlDbType.Int);
                categoryid.Value = bevId;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadForm();
            }
        }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        type = "delete";
        if (empStatus == false)
        {
            deleteData();
        }
        else
        {
            MessageBox.Show("Không thể xóa nhân viên có trạng thái Đang làm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEditCategory_Click(object sender, EventArgs e)
    {
        type = "edit";
        FormAddCategory FormAddCategory = new FormAddCategory(type, cateId, cateName);
        FormAddCategory.ShowDialog();
        Show();
        ReloadForm();
    }

    private void btnDeleteCategory_Click(object sender, EventArgs e)
    {
        var connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand("checkContraintCateBeverage", connection);

        SqlParameter id = command.Parameters.Add("iMaloaidouong", SqlDbType.Int);
        id.Value = cateId;
        var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
        returnParameter.Direction = ParameterDirection.ReturnValue;
        command.CommandType = CommandType.StoredProcedure;

        connection.Open();
        command.ExecuteNonQuery();
        int result = Int32.Parse(returnParameter.Value.ToString());
        connection.Close();

        if (result == 1)
        {
            MessageBox.Show("Không thể xóa loại đồ uống đang tồn tại đồ uống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa loại đồ uống này? Dữ liệu sẽ không thể khôi phục.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand command2 = new SqlCommand("deleteCategory", connection);

                SqlParameter categoryid = command2.Parameters.Add("iMaloaidouong", SqlDbType.Int);
                categoryid.Value = cateId;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadForm();
            }
        }

    }

    private void btnEditBeverage_Click(object sender, EventArgs e)
    {
        type = "edit";
        FormAddBeverage FormAddBeverage = new FormAddBeverage(type, bevId, bevName, bevPrice, bevAmount, bevCateName, bevCateId);
        FormAddBeverage.ShowDialog();
        Show();
        ReloadForm();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        type = "edit";
        FormAddEmployee FormAddEmployee = new FormAddEmployee(type, empId, empName, empPhone, empAddress, empStatus, empGender, empDoB, empIsAdmin);
        FormAddEmployee.ShowDialog();
        Show();
        ReloadForm();
    }

    private void txtSearch_Leave(object sender, EventArgs e)
    {
        if (txtSearch.Text == "")
        {
            txtSearch.Text = "Tên nhân viên/Số điện thoại...";
            txtSearch.ForeColor = Color.Silver;
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        type = "new";
        FormAddCategory FormAddCategory = new FormAddCategory(type, cateId, cateName);
        FormAddCategory.ShowDialog();
        Show();
        ReloadForm();
    }

    private void button9_Click(object sender, EventArgs e)
    {
        type = "new";
        FormAddBeverage FormAddBeverage = new FormAddBeverage(type, bevId, bevName, bevPrice, bevAmount, bevCateName, bevCateId);
        FormAddBeverage.ShowDialog();
        Show();
        ReloadForm();
    }

    private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dataGridViewNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        {
            dataGridViewNV.CurrentRow.Selected = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;

            empId = Convert.ToInt32(dataGridViewNV.Rows[e.RowIndex].Cells["iMaNV"].FormattedValue);
            empName = (dataGridViewNV.Rows[e.RowIndex].Cells["sHoten"].FormattedValue.ToString());
            empAddress = (dataGridViewNV.Rows[e.RowIndex].Cells["sDiachi"].FormattedValue.ToString());
            empPhone = (dataGridViewNV.Rows[e.RowIndex].Cells["sSDT"].FormattedValue.ToString());
            empDoB = Convert.ToDateTime(dataGridViewNV.Rows[e.RowIndex].Cells["dNgaysinh"].FormattedValue.ToString());
            if (dataGridViewNV.SelectedRows[0].Cells["sGioitinh"].Value.Equals("Nam"))
            {
                empGender = true;

            }
            else if (dataGridViewNV.SelectedRows[0].Cells["sGioitinh"].Value.Equals("Nữ"))
            {
                empGender = false;
            }

            if (dataGridViewNV.SelectedRows[0].Cells["sTrangthai"].Value.Equals("Đang làm"))
            {
                empStatus = true;
            }
            else if (dataGridViewNV.SelectedRows[0].Cells["sTrangthai"].Value.Equals("Nghỉ việc"))
            {
                empStatus = false;
            }
            if (dataGridViewNV.SelectedRows[0].Cells["isAdmin"].Value.Equals(true))
            {
                empIsAdmin = true;
            }
            else
            {
                empIsAdmin = false;

            }
        }
    }

    private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dataGridViewCategory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        {
            dataGridViewCategory.CurrentRow.Selected = true;
            btnDeleteCategory.Enabled = true;
            btnEditCategory.Enabled = true;
            btnAddCategory.Enabled = false;

            cateId = Convert.ToInt32(dataGridViewCategory.Rows[e.RowIndex].Cells["iMaloaidouong"].FormattedValue);
            cateName = (dataGridViewCategory.Rows[e.RowIndex].Cells["sTenloaidouong"].FormattedValue.ToString());
        }
    }
    private void dataGridViewBeverage_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dataGridViewBeverage.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        {
            dataGridViewBeverage.CurrentRow.Selected = true;
            btnDeleteBeverage.Enabled = true;
            btnEditBeverage.Enabled = true;
            btnAddBeverage.Enabled = false;

            bevId = Convert.ToInt32(dataGridViewBeverage.Rows[e.RowIndex].Cells["iMadouong"].FormattedValue);
            bevName = (dataGridViewBeverage.Rows[e.RowIndex].Cells["sTendouong"].FormattedValue.ToString());
            bevAmount = Convert.ToInt32(dataGridViewBeverage.Rows[e.RowIndex].Cells["iSoluong"].FormattedValue);
            bevPrice = float.Parse(dataGridViewBeverage.Rows[e.RowIndex].Cells["fDongia"].FormattedValue.ToString());
            bevCateName = (dataGridViewBeverage.Rows[e.RowIndex].Cells["Tenloaidouong"].FormattedValue.ToString());
            bevCateId = Convert.ToInt32(dataGridViewBeverage.Rows[e.RowIndex].Cells["maLoaidouong"].FormattedValue.ToString());
        }
    }

    public void deleteData()
    {
        DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này? Dữ liệu sẽ không thể khôi phục.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("deleteNV", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter id = command.Parameters.Add("iMaNV", SqlDbType.Int);
            id.Value = empId;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadForm();
        }
    }
}
}
