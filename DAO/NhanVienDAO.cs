using QLCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance 
        {
            get { if (instance == null) instance = new NhanVienDAO();return instance; } 

            private set => instance = value; 
        }


        public cNhanVien TTNhanVienLogin(int maNV)
        {
            cNhanVien nv = null;

            DataTable data = new DataTable();
            data = DataProvider.Instance.ExcuteQuery("EXEC dbo.layNVtheoma @iMaNV ="+maNV);
            foreach(DataRow row in data.Rows)
            {
                nv = new cNhanVien(row);
            }

            return nv;
        }
    }
}
