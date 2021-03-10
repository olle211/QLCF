using QLCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        {   get { if (instance == null) instance = new BillDAO();return instance; } 
            private set => instance = value; }

        private BillDAO() { }

       public int ManewBill()
        {
            
            var NewMa = DataProvider.Instance.ExcuteNonScalar("SELECT MAX(iSoHD) FROM dbo.tblHoadon");
            return Convert.ToInt32(NewMa);
        }

        public List<cBill> listBill()           // trả về danh sách từ bảng tblHoaDon
        {
            List<cBill> list = new List<cBill>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery("Select * from tblHoaDon");
            foreach(DataRow item in data.Rows)
            {
                cBill bill = new cBill(item);
                list.Add(bill);
            }
            return list;
        }

        public void AddBill(cBill bill)
        {
            string query = "EXEC dbo.add_bill @iMaNV , @iMaBan , @sTrangthai";
            int i = DataProvider.Instance.ExcuteNonQuery(query,new object[] { bill.IMaNV,3,bill.STrangthai });
        }



        //Update hoa don có ma HD= maHD về trạng thái đã thanh toán và gán tổng tiền cho HD
        public void ThanhToanHD(int maHD)                    
        {                                           
            string query = "EXEC thanh_toan_HD @iSoHD , @sTrangthai";
            int i = DataProvider.Instance.ExcuteNonQuery(query, new object[] { maHD,"Đã thanh toán"});
        }

        public void xacnhanPhache(int maHD)
        {
            string query = "EXEC thanh_toan_HD @iSoHD , @sTrangthai";
            int i = DataProvider.Instance.ExcuteNonQuery(query, new object[] { maHD, "Đã pha chế" });
        }

        public void setTongTienHD(int maHD)
        {
            string query = "EXECUTE TongTienHD @iSoHD="+maHD;
            int i= DataProvider.Instance.ExcuteNonQuery(query);
            
        }

        public void huyBill (int maHD)
        {
            List<cBill> ls = new List<cBill>();
            ls = listBill();
            foreach(cBill item in ls)
            {
                if (item.ISoHD == maHD)
                {
                    if (item.STrangthai == "Chưa pha chế" || item.STrangthai == "chưa pha chế")
                    {
                        string query = "EXEC HuyBill @iSoHD= " + maHD;
                        string query1 = "EXEC HuyCT_Bill @iSoHD= " + maHD;
                        int i = DataProvider.Instance.ExcuteNonQuery(query1);
                        int j = DataProvider.Instance.ExcuteNonQuery(query);
                    }
                }
                
            }
            
        }
    }
}
