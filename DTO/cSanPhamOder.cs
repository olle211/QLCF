using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DTO
{
    public class cSanPhamOder
    {
        private int iMaSP;
        private String sTenSP;
        private int iSoluong =0;
        private float fDongia;
        public cSanPhamOder() { }
        public cSanPhamOder(int iMaSP, String sTenSP, int iSoluong, float fDongia)
        {
            this.IMaSP = iMaSP;
            this.sTenSP = sTenSP;
            this.iSoluong = iSoluong;
            this.fDongia = fDongia;
        }
        public int IMaSP { get => iMaSP; set => iMaSP = value; }
        public String STenSP { get => sTenSP; set => sTenSP = value; }
        public int ISoluong { get => iSoluong; set => iSoluong = value; }
        public float FDongia { get => fDongia; set => fDongia = value; }
    }
}
