using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DTO
{
    public class cSanPham
    {

        private String sTenSP;
        private int iSoluong;
        private int iMaloaisp;
        private int iMaSP;
        private float fDongia;

        public cSanPham() { }
        public cSanPham(int imasp, string tensp, int maloaisp, int soluong, float dongia)
        {
            this.iMaSP = imasp;
            this.IMaloaisp = maloaisp;
            this.sTenSP = tensp;
            this.fDongia = dongia;
            this.iSoluong = soluong;
        }
        public cSanPham(DataRow row)
        {
            this.iMaSP = (int)row["iMaSP"];
            this.IMaloaisp = (int)row["iMaloaiSP"];
            this.sTenSP = row["sTenSP"].ToString();
            this.fDongia = (float)Convert.ToDouble(row["fDongia"].ToString());
            this.iSoluong = (int)row["iSoluong"];
        }

        public int IMaSP { get => iMaSP; set => iMaSP = value; }
        public int IMaloaisp { get => iMaloaisp; set => iMaloaisp = value; }
        public int ISoluong { get => iSoluong; set => iSoluong = value; }
        public string STenSP { get => sTenSP; set => sTenSP = value; }
        public float FDongia { get => fDongia; set => fDongia = value; }
    }
}
