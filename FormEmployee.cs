using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace QLCF
{
    public partial class FormEmployee : Form
    {
        string username, maNv;
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

        public FormEmployee(string _username, string _maNV)
        {
            InitializeComponent();
            username = _username;
            maNv = _maNV;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Xin chào " + username + " có mã NV là: " + maNv;
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            fTaoHoaDon f = new fTaoHoaDon(username, maNv);
            f.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            fThanhToan f = new fThanhToan();
            f.ShowDialog();
        }

        private void btnDSChoPhaChe_Click(object sender, EventArgs e)
        {
            fPhaChe f = new fPhaChe();
            f.ShowDialog();
        }
    }
}
