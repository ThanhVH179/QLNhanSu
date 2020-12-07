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
    public class BUS_PhongBan
    {
        DAL_PhongBan dalPhongBan = new DAL_PhongBan();
        public DataTable GetPhongBan()
        {
            return dalPhongBan.getPhongBan();
        }
        public bool insertPhongBan(DTO_PhongBan phongBan)
        {
            return dalPhongBan.insertPhongBan(phongBan);
        }
        public bool updatePhongBan(DTO_PhongBan phongBan)
        {
            return dalPhongBan.updatePhongBan(phongBan);
        }
        public bool deletePhongBan(string maPB)
        {
            return dalPhongBan.deletePhongBan(maPB);
        }
        public DataTable searchPhongBan(string tenPB)
        {
            return dalPhongBan.searchPhongBan(tenPB);
        }
        public DataTable danhsachPhongBan()
        {
            return dalPhongBan.danhsachPhongBan();
        }
    }
}