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
    public partial class fPhaChe : Form
    {
        List<cBill> list;
        List<cSanPhamOder> listSPOder;
        int mabill = -1;

        public fPhaChe()
        {
            InitializeComponent();
            layDSHD();
        }

        void layDSHD()
        {
            List<cBill> listbill = BillDAO.Instance.listBill();
            list = new List<cBill>();
            foreach (cBill item in listbill)
            {
                if (item.STrangthai == "Chưa pha chế" || item.STrangthai == "chưa pha chế")
                {
                    list.Add(item);
                }
            }
            cbbHoaDonChoPC.DataSource = null;
            cbbHoaDonChoPC.DataSource = list;
            cbbHoaDonChoPC.DisplayMember = "ISoHD";

        }

        private void fPhaChe_Load(object sender, EventArgs e)
        {
            
        }

        private void cbbHoaDonChoPC_SelectedValueChanged(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                cBill bill = new cBill();
                bill = (cBill)cbbHoaDonChoPC.SelectedValue;
                if (bill != null)
                {
                    mabill = (int)bill.ISoHD;
                    ShowCT_HD(mabill);
                }
               
            }
        }



        void ShowCT_HD(int maHD)
        {
            foreach (cBill item in list)
            {
                if (maHD == item.ISoHD)
                {
                    lblMaHD.Text = maHD.ToString();
                    lblNgayLap.Text = item.DNgaylap.Value.ToString("yyyy-MM-dd");
                }
            }
            listSPOder = SanPhamOderDAO.Instance.listSPOder(maHD);
            lvDSSP.Items.Clear();
            foreach (cSanPhamOder sp in listSPOder)
            {
                ListViewItem lvitem = new ListViewItem(sp.IMaSP.ToString());
                lvitem.SubItems.Add(sp.STenSP.ToString());
                lvitem.SubItems.Add(sp.ISoluong.ToString());
                lvitem.SubItems.Add(sp.FDongia.ToString());
                lvDSSP.Items.Add(lvitem);
            }
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            
            String reportFilter = String.Format("{0} = {1}", "{tblCT_HoaDon.iSoHD}", mabill);
            rpHoaDon rp = new rpHoaDon();
            rp.Loadrp(reportFilter);
            rp.ShowDialog();
            BillDAO.Instance.xacnhanPhache(mabill);
            mabill = -1;
            lblMaHD.Text = "";
            lblNgayLap.Text = "";
            lvDSSP.Items.Clear();
            layDSHD();
            
            

        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            BillDAO.Instance.huyBill(mabill);
            mabill = -1;
            listSPOder = new List<cSanPhamOder>();
            lblMaHD.Text = "";
            lblNgayLap.Text = "";
            lvDSSP.Items.Clear();
            layDSHD();

        }
    }
}
