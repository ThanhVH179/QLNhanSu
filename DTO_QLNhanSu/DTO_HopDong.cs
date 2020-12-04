using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhanSu
{
    public class DTO_HopDong
    {
        public string maHD;
        public string loaiHD;
        public string maNV;
        public DateTime ngayKy;
        public DateTime ngayKetThuc;
    
        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        public string LoaiHD
        {
            get { return loaiHD; }
            set { loaiHD = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public DateTime NgayKy
        {
            get { return ngayKy; }
            set { ngayKy = value; }
        }
        public DateTime NgayKetThuc
        {
            get { return ngayKetThuc; }
            set { ngayKetThuc = value; }
        }

        public DTO_HopDong(string mahd, string loaihd, string manv, DateTime ngayky, DateTime ngayketthuc)
        {
            this.maHD = mahd;
            this.loaiHD = loaihd;
            this.maNV = manv;
            this.ngayKy = ngayky;
            this.ngayKetThuc = ngayketthuc;
        }
    }
}
