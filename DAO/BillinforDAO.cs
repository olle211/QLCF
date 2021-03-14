using QLCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DAO
{
    class BillinforDAO
    {
        private static BillinforDAO instance;

        internal static BillinforDAO Instance 
        {   get { if (instance == null) instance = new BillinforDAO();return instance; } 
            private set => instance = value; }
        private BillinforDAO() { }

        public List<cBillinfor> listBillInfor() //tra ve 1 list billinfor tu bang CT_HoaDon
        {
            List<cBillinfor> list = new List<cBillinfor>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery("Select * From tblCT_HoaDon");
            foreach(DataRow item in data.Rows)
            {
                cBillinfor bill = new cBillinfor(item);
                list.Add(bill);
            }

            return list;
        }


        public void AddBillInfor(List<cBillinfor> listBillif) //thêm trường dữ liệu cho CT_HoaDon
        {
            string query = "EXECUTE addBillinfor @iSoHD , @iMaSP , @iSoluong , @fDongia";
            foreach (cBillinfor item in listBillif)
            {
                int i = DataProvider.Instance.ExcuteNonQuery(query, new object[] 
                {item.ISoHD, item.IMaSP, item.ISoluong,item.FDongia });
            }
        }
    }
}
