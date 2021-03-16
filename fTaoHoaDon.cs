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
    public partial class fTaoHoaDon : Form
    {
        List<cSanPhamOder> listSPoder;//danh sach san pham khach khang oder
        List<cSanPham> listSP; //danh sách sản phẩm sẵn có
        int iSoHD=-1;//ma HD moi dc tao


        public fTaoHoaDon()
        {
            InitializeComponent();
            lblMaNV.Text = Program.MaNVLogin;               //ten NV lap hoa don
            lblNVLapHD.Text =Program.TenNVLogin;           //Ma NV lap hoa don
            listSPoder = new List<cSanPhamOder>();          //Khoi tao ds sp kh oder
            getDSSanPham();
            

        }
        void LoadHD()
        {
            dgvHoaDon.DataSource = null;
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.DataSource = listSPoder;
        }
        

        void getDSSanPham()
        {

            listSP = SanPhamDAO.Instance.listSanPham();
            cbbMenu.DataSource = listSP;
            cbbMenu.DisplayMember = "sTenSP";
            
        }



        private void cbbMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            cSanPham a = new cSanPham();
            a = (cSanPham)cbbMenu.SelectedItem;
            if (a.ISoluong < 1)
            {
                btnThemSP.Enabled = false;
            }
            else
            {
                btnThemSP.Enabled = true;
            }
            numericSoluong.Maximum = a.ISoluong;
            numericSoluong.Minimum = 1;
            lblSLcon.Text = a.ISoluong.ToString();
            
        }
        //Thêm một danh sách sản phẩm oder cho khách hàng, có ktra đk: < SL còn lại, SL them >0
        private void btnThemSP_Click(object sender, EventArgs e) 
        {
            cSanPham a = new cSanPham();
            a = (cSanPham)cbbMenu.SelectedItem;     //lay ra sp da chon tren combobox
            int sl = (int)numericSoluong.Value;     //SL sp da nhap
            if (sl > 0)
            {
                foreach (cSanPhamOder item in listSPoder)
                {
                    if ((int)item.IMaSP == (int)a.IMaSP)
                    {

                        foreach(cSanPham sanpham in listSP)
                        {
                            if (sanpham.IMaSP == item.IMaSP)
                            {
                                int i= item.ISoluong + sl;
                                if (i <= sanpham.ISoluong)
                                {
                                    item.ISoluong = i;
                                    LoadHD();
                                    
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Số lượng vượt quá sl còn lại!");
                                    LoadHD();
                                    return;
                                }
                            }
                        }


                    }
                }
                cSanPhamOder sp = new cSanPhamOder((int)a.IMaSP, a.STenSP, sl, a.FDongia);
                listSPoder.Add(sp);
                LoadHD();
            }
            else
            {
                MessageBox.Show("Số lượng sản phẩm thêm phải lớn hơn 0!");
            }

        }
        
        private void btnXong_Click(object sender, EventArgs e)
        {

            TaoHD();
            

        }


        void TaoHD()
        {
            //tạo bill mới với 
            if (listSPoder.Count > 0)
            {
                cBill bill = new cBill();
                bill.IMaNV = Convert.ToInt32(Program.MaNVLogin);
                bill.IMaban = 3;
                bill.STrangthai = "Chưa pha chế";
                BillDAO.Instance.AddBill(bill);         //thêm bill vào database
                iSoHD = BillDAO.Instance.ManewBill();      //Dua ma hd moi dc tao thanh ma hoa don co gia tri lon nhat trong bang HoaDon
                List<cBillinfor> bif = new List<cBillinfor>();
                foreach (cSanPhamOder item in listSPoder)
                {
                    cBillinfor a = new cBillinfor();
                    a.ISoHD = iSoHD;
                    a.IMaSP = item.IMaSP;
                    a.ISoluong = item.ISoluong;
                    a.FDongia = item.FDongia;
                    bif.Add(a);

                }
                BillinforDAO.Instance.AddBillInfor(bif);// thêm ct_hd vào database
                SanPhamDAO.Instance.updateSLSP(listSPoder);// update lai so luong san pham con lai
                BillDAO.Instance.setTongTienHD(iSoHD); //set tong tien HD cho HD vua tao
                MessageBox.Show("Đã tạo thành công hóa đơn!");

                //reset lai ds san pham oder va cap nhat lai danh sach san pham con lai
                dgvHoaDon.DataSource = null;
                listSPoder = new List<cSanPhamOder>();
                getDSSanPham();

            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm, không tạo được hóa đơn!");
            }
        }



        int maSpXoa=-1;
        int slsp;

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i != -1)
            {
                maSpXoa = Convert.ToInt32(dgvHoaDon.Rows[i].Cells[0].Value.ToString());
                string tensp = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
                slsp = Convert.ToInt32(dgvHoaDon.Rows[i].Cells[3].Value.ToString());
                float dongia = (float)Convert.ToDouble(dgvHoaDon.Rows[i].Cells[2].Value.ToString());
                lblCheckedIndex.Text = i.ToString();
                lblMaSPxoa.Text = maSpXoa.ToString();
                lblTenSPxoa.Text = tensp;
                panelXoa.Visible = true;
                numericSLXoa.Maximum = slsp;
                numericSLXoa.Minimum = 1;
            }
            
            
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            cSanPhamOder spoder=new cSanPhamOder();
            if (maSpXoa != -1 && slsp>0)
            {
                
                foreach (cSanPhamOder sp in listSPoder)
                {
                    
                    if (sp.IMaSP == maSpXoa)
                    {
                        sp.ISoluong = sp.ISoluong - Convert.ToInt32(numericSLXoa.Value);
                        if (sp.ISoluong <= 0)
                        {
                            spoder = sp;
                        }

                    }
                }
 
            }
            listSPoder.Remove(spoder);
            getDSSanPham();
            LoadHD();

        }

        private void numericSLXoa_ValueChanged(object sender, EventArgs e)
        {
            if (numericSLXoa.Value > slsp || numericSLXoa.Value < 1)
            {
                btnXoaSP.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fTaoHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            TaoHD();
            BillDAO.Instance.ThanhToanHD(iSoHD);
            String reportFilter = String.Format("{0} = {1}", "{tblCT_HoaDon.iSoHD}", iSoHD);
            rpHoaDon rp = new rpHoaDon();
            rp.Loadrp(reportFilter);
            rp.ShowDialog();
        }
    }
}
