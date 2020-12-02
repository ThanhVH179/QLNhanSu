using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QLNhanSu
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLNhanSu;Integrated Security=True");
    }
}
