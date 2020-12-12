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
    public class DAL_SuCo : DBConnect
    {
        public DataTable getSuCo()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachSuCo";
                DataTable dtSuCo = new DataTable();
                dtSuCo.Load(cmd.ExecuteReader());
                return dtSuCo;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool insertSuCo(DTO_SuCo suCo)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertDataIntoSuCo";
                cmd.Parameters.AddWithValue("maSC", suCo.maSC);
                cmd.Parameters.AddWithValue("maNV", suCo.maNV);
                cmd.Parameters.AddWithValue("tenSC", suCo.tenSC);
                cmd.Parameters.AddWithValue("loai", suCo.loaiSC);
                cmd.Parameters.AddWithValue("thietHai", suCo.thietHai);

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
        public bool updateSuCo(DTO_SuCo suCo)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateDataIntoSuCo";
                cmd.Parameters.AddWithValue("maSC", suCo.maSC);
                cmd.Parameters.AddWithValue("maNV", suCo.maNV);
                cmd.Parameters.AddWithValue("tenSC", suCo.tenSC);
                cmd.Parameters.AddWithValue("loai", suCo.loaiSC);
                cmd.Parameters.AddWithValue("thietHai", suCo.thietHai);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally { conn.Close(); }
            return false;
        }
        public bool deleteSuCo(string maSC)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteDataFromSuCo";
                cmd.Parameters.AddWithValue("maSC", maSC);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally { conn.Close(); }
            return false;
        }
        public DataTable searchSuCo(string maSC)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TimSuCo";
                cmd.Parameters.AddWithValue("maSC", maSC);
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

