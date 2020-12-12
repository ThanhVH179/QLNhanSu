using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhanSu
{
    public class DTO_SuCo
    {
        public string maSC;
        public string maNV;
        public string tenSC;
        public string thietHai;
        public int loaiSC;
        
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string MaSC
        {
            get { return maSC; }
            set { maSC = value; }
        }
        public string TenSC
        {
            get { return tenSC; }
            set { tenSC = value; }
        }
        public string ThietHai
        {
            get { return thietHai; }
            set { thietHai = value; }
        }
        public int LoaiSC
        {
            get { return loaiSC; }
            set { loaiSC = value; }
        }

        public DTO_SuCo(string masc, string manv, string tensc, int loaisc , string thiethai)
        {
            this.maNV = manv;
            this.maSC = masc;
            this.tenSC = tensc;
            this.thietHai = thiethai;
            this.loaiSC = loaisc;
        }
    }
}
