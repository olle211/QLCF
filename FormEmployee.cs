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
using QLCF.DTO;
using QLCF.DAO;

namespace QLCF
{
    public partial class FormEmployee : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        
        public FormEmployee()
        {
            InitializeComponent();
            //username = _username;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Xin chào " + Program.TenNVLogin+" có mã NV là: "+Program.MaNVLogin;
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            fTaoHoaDon f = new fTaoHoaDon();
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

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cNhanVien nv = new cNhanVien();
            nv = NhanVienDAO.Instance.TTNhanVienLogin(Convert.ToInt32(Program.MaNVLogin));
            NVLoginDetail f = new NVLoginDetail();
            f.loadNVLogin(nv);
            f.ShowDialog();
        }
    }
}
