using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DTO
{
    public class cNhanVien
    {
        private int iMaNV;
        private string sHoTen;
        private string sGioitinh;
        private int iSDT;
        private string sDiachi;
        private DateTime? dNgaySinh;
        private string sTrangthai;
        private Boolean isAdmin;
        private string sMatkhau;
        private int iMaCV;
        public int IMaNV { get => iMaNV; set => iMaNV = value; }
        public string SHoTen { get => sHoTen; set => sHoTen = value; }
        public int ISDT { get => iSDT; set => iSDT = value; }
        public string SGioitinh { get => sGioitinh; set => sGioitinh = value; }
        public string SDiachi { get => sDiachi; set => sDiachi = value; }
        public DateTime? DNgaySinh { get => dNgaySinh; set => dNgaySinh = value; }
        public string STrangthai { get => sTrangthai; set => sTrangthai = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public string SMatkhau { get => sMatkhau; set => sMatkhau = value; }
        public int IMaCV { get => iMaCV; set => iMaCV = value; }

        public cNhanVien() { }



        public cNhanVien(int maNV, string ten, string gioitinh, int sdt, string diachi
            , DateTime? ngaysinh, string trangthai, Boolean isAdmin, string matkhau, int maCV)
        {
            this.IMaNV = maNV;
            this.SHoTen = ten;
            this.SGioitinh = gioitinh;
            this.ISDT = sdt;
            this.SDiachi = diachi;
            this.DNgaySinh = ngaysinh;
            this.STrangthai = trangthai;
            this.IsAdmin = isAdmin;
            this.SMatkhau = matkhau;
            this.IMaCV = maCV;
        }

        public cNhanVien(DataRow row)
        {
            this.IMaNV = (int)row["iMaNV"];
            this.SHoTen = row["sHoten"].ToString();
            this.SGioitinh = row["sGioitinh"].ToString();
            this.ISDT = Convert.ToInt32(row["sSDT"]);
            this.SDiachi = row["sDiachi"].ToString();
            this.DNgaySinh = (DateTime?)row["dNgaysinh"];
            this.STrangthai = row["sTrangthai"].ToString();
            this.IsAdmin = (Boolean)row["isAdmin"];
            this.SMatkhau = row["sMatkhau"].ToString();
            this.IMaCV = (int)row["iMaCV"];
        }
    }
}
