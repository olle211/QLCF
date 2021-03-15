using QLCF.DAO;
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
    public partial class fDoiMatKhau : Form
    {
        cNhanVien nv;
        public fDoiMatKhau(cNhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            lblChuTK.Text = nv.SHoTen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void doiMK()
        {

            if(txtMKcu.Text==nv.SMatkhau)
            {
                if (txtMKmoi.Text == txtMKmoi2.Text)
                {
                    NhanVienDAO.Instance.updateMatKhau(nv.IMaNV, txtMKmoi.Text);
                    MessageBox.Show("Đã thay đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu phải giống nhau!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng mật khẩu cũ!");
            }    
            
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            doiMK();
        }
    }
}
