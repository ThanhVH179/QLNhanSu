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
    public class DAL_PhongBan : DBConnect
    {
        public DataTable getPhongBan()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachPhong";
                DataTable dtPhongBan = new DataTable();
                dtPhongBan.Load(cmd.ExecuteReader());
                return dtPhongBan;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool insertPhongBan(DTO_PhongBan phongBan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertDataIntoPhongBan";
                cmd.Parameters.AddWithValue("maPB", phongBan.maPB);
                cmd.Parameters.AddWithValue("tenPB", phongBan.maPB);
                cmd.Parameters.AddWithValue("truongPhong", phongBan.truongPhong);

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
        public bool updatePhongBan(DTO_PhongBan phongBan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateDataIntoPhongBan";
                cmd.Parameters.AddWithValue("maPB", phongBan.maPB);
                cmd.Parameters.AddWithValue("tenPB", phongBan.tenPB);
                cmd.Parameters.AddWithValue("truongPhong", phongBan.truongPhong);

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
        public bool deletePhongBan(string maPB)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteFromPhongBan";
                cmd.Parameters.AddWithValue("maPB", maPB);
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
        public DataTable searchPhongBan(string tenPB)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TimPhong";
                cmd.Parameters.AddWithValue("tenPB", tenPB);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable danhsachPhongBan()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachPhong";
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