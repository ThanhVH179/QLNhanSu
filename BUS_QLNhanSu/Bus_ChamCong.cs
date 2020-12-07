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
    public class Bus_ChamCong
    {
        DAL_ChamCong dalChamCong = new DAL_ChamCong();
        public DataTable GetChamCong()
        {
            return dalChamCong.getChamCong();
        }
        public bool InsertChamCong(DTO_ChamCong chamcong)
        {
            return dalChamCong.insertChamCong(chamcong);
        }
        public bool DeleteChamCong(string macc)
        {
            return dalChamCong.deleteChamCong(macc);
        }
        public DataTable SearchChamCong(string manv)
        {
            return dalChamCong.searchChamCong(manv);
        }
        public DataTable NgayNghiNV(string manv)
        {
            return dalChamCong.ngayNghiNhanVien(manv);
        }
        public DataTable ThongKeSoNgayNghi()
        {
            return dalChamCong.thongKeNgayNghi();
        }
    }
}
