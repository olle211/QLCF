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
    public partial class fThanhToan : Form
    {
        

        List<cBill> list;
        List<cSanPhamOder> listSPOder;
        int mabill=-1;
        public fThanhToan()
        {
            InitializeComponent();
        }

        private void lblMaHD_Click(object sender, EventArgs e)
        {

        }

        private void fThanhToan_Load(object sender, EventArgs e)
        {
            layDSHD();
        }
        // lấy danh sách các hóa đơn chưa thanh toán và đã pha chế lên
        void layDSHD()
        {
            List<cBill> listbill = BillDAO.Instance.listBill();
            list = new List<cBill>();
            foreach(cBill item in listbill)
            {
                if(item.STrangthai!="Đã thanh toán" && item.STrangthai == "Đã pha chế")
                {
                    list.Add(item);
                }
            }
            cbbHoaDon.DataSource = null;
            cbbHoaDon.DataSource = list;
            cbbHoaDon.DisplayMember = "ISoHD";
            
        } 

        private void cbbHoaDon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (list.Count>0)
            {
                cBill bill = new cBill();
                bill = (cBill)cbbHoaDon.SelectedValue;
                mabill = (int)bill.ISoHD;
                ShowCT_HD(mabill);
            }
            
        }



        //show ra ma hd, ngay lap va ds san pham cua hd
        void ShowCT_HD(int maHD)
        {
            foreach(cBill item in list)
            {
                if(maHD== item.ISoHD)
                {
                    lblMaHD.Text = maHD.ToString();
                    lblNgayLap.Text = item.DNgaylap.Value.ToString("yyyy-MM-dd");
                }
            }
            listSPOder = SanPhamOderDAO.Instance.listSPOder(maHD);
            lvDSSP.Items.Clear();
            foreach(cSanPhamOder sp in listSPOder)
            {
                ListViewItem lvitem = new ListViewItem(sp.IMaSP.ToString());
                lvitem.SubItems.Add(sp.STenSP.ToString());
                lvitem.SubItems.Add(sp.ISoluong.ToString());
                lvitem.SubItems.Add(sp.FDongia.ToString());
                lvDSSP.Items.Add(lvitem);
            }
        }



        //Thanh toan bill khi đạt điều kiện là đã pha chế
        private void btnTTHD_Click(object sender, EventArgs e)
        {
            foreach(cBill bill in list)
            {
                if (bill.ISoHD == mabill)
                {
                    if(bill.STrangthai=="Đã pha chế")
                    {
                        BillDAO.Instance.ThanhToanHD(mabill);
                        MessageBox.Show("Đã thanh toán hóa đơn có mã: " + mabill);
                        this.Refresh();
                        return;
                    }
                }
            }
            //this.Refresh();
            MessageBox.Show("Chưa đạt điều kiện thanh toán!");    
        } 
    }
}
