using QLCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class NVLoginDetail : Form
    {
        public NVLoginDetail()
        {
            InitializeComponent();
        }
        public void loadNVLogin(cNhanVien nv)
        {
            lblMaNV.Text = nv.IMaNV.ToString();
            lblTenNV.Text = nv.SHoTen.ToString();
            lblNgaySinh.Text = nv.DNgaySinh.Value.ToString("yyyy-MM-DD");
            lblGT.Text = nv.SGioitinh.ToString();
            lblSDT.Text = nv.ISDT.ToString();
        }
    }
}
