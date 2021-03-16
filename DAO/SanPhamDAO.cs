using QLCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance 
        {   get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            private set => instance = value; 
        }
        private SanPhamDAO() { }

        public List<cSanPham> listSanPham()
        {
            List<cSanPham> list = new List<cSanPham>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery("Select * From tblDouong");
            foreach(DataRow item in data.Rows)
            {
                cSanPham sp = new cSanPham(item);
                list.Add(sp);
            }
            return list;
        }

        public void updateSLSP(List<cSanPhamOder> listoder)
        {
            List<cSanPham> listsp = listSanPham();
            foreach(cSanPham sp in listsp)
            {
                foreach (cSanPhamOder item in listoder)
                {
                    if (sp.IMaSP == item.IMaSP)
                    {
                        String query = "UPDATE dbo.tblSanpham SET iSoluong = " + (sp.ISoluong-item.ISoluong) + " WHERE iMaSP= " + item.IMaSP;
                        int i = DataProvider.Instance.ExcuteNonQuery(query);
                    }
                }
                    
            }

            


            
            
        }
    }
}
