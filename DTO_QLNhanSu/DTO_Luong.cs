using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhanSu
{
    public class DTO_Luong
    {
        public string bacLuong;
        public double luongCoBan;
        public double heSoLuong;
        public double heSoPhuCap;
        
        public string BacLuong
        {
            get { return bacLuong; }
            set { bacLuong = value; }
        }
        public double LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }
        public double HeSoPhuCap
        {
            get { return heSoPhuCap; }
            set { heSoPhuCap = value; }
        }
        public double HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }

        public DTO_Luong(string bacluong, double luongcoban, double hesophucap, double hesoluong)
        {
            this.bacLuong = bacluong;
            this.luongCoBan = luongcoban;
            this.heSoLuong = hesoluong;
            this.heSoPhuCap = hesophucap;
        }
    }
}
