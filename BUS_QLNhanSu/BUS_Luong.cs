using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL_QLNhanSu;
using DTO_QLNhanSu;

namespace BUS_QLNhanSu
{
    public class BUS_Luong
    {
        DAL_Luong dalLuong = new DAL_Luong();
        public DataTable GetLuong()
        {
            return dalLuong.getLuong();
        }
        public bool insertLuong(DTO_Luong luong)
        {
            return dalLuong.insertLuong(luong);
        }
        public bool updateLuong(DTO_Luong luong)
        {
            return dalLuong.updateLuong(luong);
        }
        public bool deleteluong(string bacLuong)
        {
            return dalLuong.deleteLuong(bacLuong);
        }
        public DataTable SearchLuong(string bacLuong)
        {
            return dalLuong.searchLuong(bacLuong);
        }
        
    }
}
