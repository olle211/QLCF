using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DTO
{
    public class cBill
    {
        public cBill() { }
        public cBill(DataRow row)
        {
            this.ISoHD = (int)row["iSoHD"];
            this.iMaNV = (int)row["iMaNV"];
            this.iMaban = (int)row["iMaban"];
            this.sTrangthai = row["sTrangthai"].ToString();
            this.dNgaylap = (DateTime?)row["dNgaylap"];
            this.fTongtien = (float)Convert.ToDouble(row["fTongtien".ToString()]);
            
        }
        public cBill(int? iSoHD, int iMaNV, String sTrangthai, DateTime? dNgaylap )
        {
            this.ISoHD = iSoHD;
            this.IMaNV = iMaNV;
            this.IMaban = iMaban;
            this.STrangthai = sTrangthai;
            this.DNgaylap = dNgaylap;
            
        }
        private float fTongtien;
        private DateTime? dNgaylap;
        private string sTrangthai;
        private int iMaban;
        private int iMaNV;
        private int? iSoHD;

        public int? ISoHD { get => iSoHD; set => iSoHD = value; }
        public int IMaNV { get => iMaNV; set => iMaNV = value; }
        public int IMaban { get => iMaban; set => iMaban = value; }
        public string STrangthai { get => sTrangthai; set => sTrangthai = value; }
        public DateTime? DNgaylap { get => dNgaylap; set => dNgaylap = value; }
        public float FTongtien { get => fTongtien; set => fTongtien = value; }
    }
}
