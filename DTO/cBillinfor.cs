using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DTO
{
    public class cBillinfor
    {
        public cBillinfor() { }
        public cBillinfor(int iSoHD, int iMaSP, int iSoluong, float fDongia) 
        {
            this.iSoHD = iSoHD;
            this.iMaSP = iMaSP;
            this.iSoluong = iSoluong;
            this.fDongia = fDongia;
        }
        public cBillinfor(DataRow row)
        {
            this.iSoHD =(int)row["iSoHD"];
            this.iMaSP = (int)row["iMaSP"];
            this.iSoluong = (int)row["iSoluong"];
            this.fDongia = (float)Convert.ToDouble(row["fDongia"].ToString());
        }
        
        private int iSoHD;
        private int iMaSP;
        private int iSoluong;
        private float fDongia;
        public int ISoHD { get => iSoHD; set => iSoHD = value; }
        public int IMaSP { get => iMaSP; set => iMaSP = value; }
        public int ISoluong { get => iSoluong; set => iSoluong = value; }
        public float FDongia { get => fDongia; set => fDongia = value; }




        public float TongTien()
        {
            return this.ISoluong * this.FDongia;
        }

    }
}
