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
        List<string> dataArray;

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
            FormAddEmployee FormAddEmployee = new FormAddEmployee(type, dataArray);
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

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tên nhân viên/Số điện thoại...";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn đóng Danh mục Nhân viên?", "Xác nhận đóng", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            type = "new";
            FormAddCategory FormAddCategory = new FormAddCategory(type);
            FormAddCategory.ShowDialog();
            Show();
            ReloadForm();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            type = "new";
            FormAddBeverage FormAddBeverage = new FormAddBeverage(type);
            FormAddBeverage.ShowDialog();
            Show();
            ReloadForm();
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewNV.CurrentRow.Selected = true;
                //string type = "edit";
                dataArray = new List<string>(dataGridViewNV.SelectedRows.Count);

                for (int index = 0; index < dataGridViewNV.SelectedRows.Count; index++)
                {
                    var selectedRow = dataGridViewNV.SelectedRows[index];
                    var item = (string)selectedRow.DataBoundItem;

                    dataArray.Add(item);
                }

               /* data.Add(dataGridViewNV.Rows[e.RowIndex].Cells["sHoten"].FormattedValue.ToString());
                data.Add(dataGridViewNV.Rows[e.RowIndex].Cells["sGioitinh"].FormattedValue.ToString());
                data.Add(dataGridViewNV.Rows[e.RowIndex].Cells["sSDT"].FormattedValue.ToString());
                data.Add(dataGridViewNV.Rows[e.RowIndex].Cells["sDiachi"].FormattedValue.ToString());
                data.Add(dataGridViewNV.Rows[e.RowIndex].Cells["dNgaysinh"].FormattedValue.ToString());
                data.Add(dataGridViewNV.Rows[e.RowIndex].Cells["dNgaysinh"].FormattedValue.ToString());
                data.Add(dataGridViewNV.Rows[e.RowIndex].Cells["sTrangthai"].FormattedValue.ToString());
                data.Add(dataGridViewNV.Rows[e.RowIndex].Cells["isAdmin"].FormattedValue.ToString());*/

                FormAddEmployee FormAddEmployee = new FormAddEmployee(type, dataArray);
                FormAddEmployee.ShowDialog();
                Show();
            }
        }
    }
}
