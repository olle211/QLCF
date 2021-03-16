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


        public fTaoHoaDon(string username, string maNV)
        {
            InitializeComponent();
            lblMaNV.Text = username;               //ten NV lap hoa don
            lblNVLapHD.Text = maNV;           //Ma NV lap hoa don
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
            //tạo bill mới với 
            if (listSPoder.Count>0)
            {
                cBill bill = new cBill();
                bill.IMaNV = Convert.ToInt32(Program.MaNVLogin);
                bill.IMaban = 3;
                bill.STrangthai = "Chưa pha chế";
                BillDAO.Instance.AddBill(bill);         //thêm bill vào database
                iSoHD = BillDAO.Instance.ManewBill();      //Dua ma hd moi dc tao thanh ma hoa don co gia tri lon nhat trong bang HoaDon
                List<cBillinfor> bif = new List<cBillinfor>();
                foreach(cSanPhamOder item in listSPoder)
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
    }
}
