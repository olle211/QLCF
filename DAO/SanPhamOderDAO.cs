using QLCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DAO
{
    public class SanPhamOderDAO
    {
        private SanPhamOderDAO() { }
        private static SanPhamOderDAO instance;

        public static SanPhamOderDAO Instance 
        { 
            get { if (instance == null) instance = new SanPhamOderDAO(); return instance; }
            private set => instance = value; 
        }


        public List<cSanPhamOder> listSPOder(int maHD)
        {
            List<cSanPhamOder> list = new List<cSanPhamOder>();
            DataTable data = new DataTable();
            string query = "SELECT ct.iMaSP,sp.sTenSP,ct.iSoluong,ct.fDongia FROM dbo.tblCT_Hoadon AS ct, dbo.tblSanpham AS sp WHERE ct.iMaSP=sp.iMaSP AND ct.iSoHD=" + maHD;
            data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                cSanPhamOder sp = new cSanPhamOder(
                    (int)row["iMaSP"],row["sTenSP"].ToString(),(int)row["iSoluong"],(float)Convert.ToDouble(row["fDongia"]));
                list.Add(sp);
            }

            return list;
        }
    }
}
