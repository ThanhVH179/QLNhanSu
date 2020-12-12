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
    public class BUS_HopDong
    {
        DAL_HopDong dalHopDong = new DAL_HopDong();
        public DataTable getHopDong()
        {
            return dalHopDong.getHopDong();
        }
        public bool insertHopDong(DTO_HopDong hopDong)
        {
            return dalHopDong.insertHopDong(hopDong);
        }
        public DataTable SearchHopDong(string maHD)
        {
            return dalHopDong.searchHopDong(maHD);
        }
    }
}
