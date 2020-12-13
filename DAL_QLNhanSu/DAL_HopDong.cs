using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QLNhanSu;

namespace DAL_QLNhanSu
{
    public class DAL_HopDong : DBConnect
    {
        public DataTable getHopDong()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachHopDong";
                DataTable dtHopDong = new DataTable();
                dtHopDong.Load(cmd.ExecuteReader());
                return dtHopDong;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool insertHopDong(DTO_HopDong hopDong)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertDataIntoHopDong";
                cmd.Parameters.AddWithValue("maHD", hopDong.maHD);
                cmd.Parameters.AddWithValue("loaiHD", hopDong.loaiHD);
                cmd.Parameters.AddWithValue("ngayKi", hopDong.ngayKy);
                cmd.Parameters.AddWithValue("ngayKet", hopDong.ngayKetThuc);
                cmd.Parameters.AddWithValue("maNV", hopDong.maNV);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public DataTable searchHopDong(string maHD)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TimHopDong";
                cmd.Parameters.AddWithValue("maHD", maHD);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }
  
    }
}
