using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhanSu
{
    public class DTO_KhenThuongKyLuat
    {
        public string maKTKL;
        public string moTa;
        public string maNV;
        public int loai;
    public DTO_KhenThuongKyLuat(string maktkl, string mota, string manv, int loai)
        {
            this.maKTKL = maktkl;
            this.maNV = manv;
            this.moTa = mota;
            this.loai = loai;
        }
        public string MaKTKL
        {
            get { return maKTKL; }
            set { maKTKL = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        public int Loai
        {
            get { return loai; }
            set { loai = value; }
        }
    }
}
