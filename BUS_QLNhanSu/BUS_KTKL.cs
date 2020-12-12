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
    public class BUS_KTKL
    {
        DAL_KTKL dalKTKL = new DAL_KTKL();
        public DataTable GetKTKL()
        {
            return dalKTKL.getKTKL();
        }
        public bool insertKTKL(DTO_KhenThuongKyLuat ktkl)
        {
            return dalKTKL.insertKTKL(ktkl);
        }
        public bool updateKTKL(DTO_KhenThuongKyLuat ktkl)
        {
            return dalKTKL.updateKTKL(ktkl);
        }
        public bool deleteKTKL(string maKTKL)
        {
            return dalKTKL.deleteKTKL(maKTKL);
        }
        public DataTable SearchKTKL(string maNV)
        {
            return dalKTKL.searchKTKL(maNV);
        }
    
}
}
