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
    public class DAL_Luong : DBConnect
    {
        public DataTable getLuong()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachLuong";
                DataTable dtLuong = new DataTable();
                dtLuong.Load(cmd.ExecuteReader());
                return dtLuong;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool insertLuong(DTO_Luong luong)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertDataIntoLuong";
                cmd.Parameters.AddWithValue("bacLuong", luong.bacLuong);
                cmd.Parameters.AddWithValue("luongCB", luong.luongCoBan);
                cmd.Parameters.AddWithValue("heSoLuong", luong.heSoLuong);
                
                cmd.Parameters.AddWithValue("heSoPhuCap", luong.heSoPhuCap);

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
        public bool updateLuong(DTO_Luong luong)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateDataIntoLuong";
                cmd.Parameters.AddWithValue("bacLuong", luong.bacLuong);
                cmd.Parameters.AddWithValue("luongCB", luong.luongCoBan);
                cmd.Parameters.AddWithValue("heSoLuong", luong.heSoLuong);
                cmd.Parameters.AddWithValue("heSoPhuCap", luong.heSoPhuCap);
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
        public bool deleteLuong(string bacLuong)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteDataFromLuong";
                cmd.Parameters.AddWithValue("bacLuong", bacLuong);
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
        public DataTable searchLuong(string bacLuong)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TimLuong";
                cmd.Parameters.AddWithValue("bacLuong", bacLuong);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable danhsachLuong()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachLuong";
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
