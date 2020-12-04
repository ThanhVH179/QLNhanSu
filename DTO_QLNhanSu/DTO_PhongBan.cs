using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhanSu
{
    public class DTO_PhongBan
    {
        public string maPB;
        public string tenPB;
        public string truongPhong;
    public DTO_PhongBan(string mapb, string tenpb, string truongphong)
        {
            this.maPB = mapb;
            this.tenPB = tenpb;
            this.truongPhong = truongphong;
        }
        public string MaPB
        {
            get { return maPB; }
            set { maPB = value; }
        }
        public string TenPB
        {
            get { return tenPB; }
            set { tenPB = value; }
        }
        public string TruongPhong
        {
            get { return truongPhong; }
            set { truongPhong = value; }
        }
    }


}
