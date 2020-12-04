using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhanSu
{
    public class DTO_ChamCong
    {
        public string maCC;
        public string maNV;
        public string chuThich;
        public DateTime thoiGian;
    
        public string MaCC
        {
            get { return maCC; }
            set { maCC = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string ChuThich
        {
            get { return chuThich; }
            set { chuThich = value; }
        }
        public DateTime ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }

        public DTO_ChamCong(string macc, string manv, string chuthich, DateTime thoigian)
        {
            this.maCC = macc;
            this.maNV = manv;
            this.chuThich = chuthich;
            this.thoiGian = thoigian;
        }
    }
}
