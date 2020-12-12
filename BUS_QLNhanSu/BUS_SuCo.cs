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
    public class BUS_SuCo
    {
        DAL_SuCo dalSuCo = new DAL_SuCo();
        public DataTable GetSuCo()
        {
            return dalSuCo.getSuCo();
        }
        public bool insertSuCo(DTO_SuCo suCo)
        {
            return dalSuCo.insertSuCo(suCo);
        }
        public bool updateSuCo(DTO_SuCo suCo)
        {
            return dalSuCo.updateSuCo(suCo);
        }
        public bool deleteSuCo(string maSC)
        {
            return dalSuCo.deleteSuCo(maSC);
        }
        public DataTable SearchSuCo(string maSC)
        {
            return dalSuCo.searchSuCo(maSC);
        }
    }
}
