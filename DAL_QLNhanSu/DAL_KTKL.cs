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
        public class DAL_KTKL : DBConnect
    {
        public DataTable getKTKL()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachKTKL";
                DataTable dtKTKL = new DataTable();
                dtKTKL.Load(cmd.ExecuteReader());
                return dtKTKL;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool insertKTKL(DTO_KhenThuongKyLuat ktkl)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertDataIntoKTKL";
                cmd.Parameters.AddWithValue("maKTKL", ktkl.maKTKL);
                cmd.Parameters.AddWithValue("loai", ktkl.loai);
                cmd.Parameters.AddWithValue("moTa", ktkl.moTa);
                cmd.Parameters.AddWithValue("maNV", ktkl.maNV);

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
        public bool updateKTKL(DTO_KhenThuongKyLuat ktkl)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateDataIntoKTKL";
                cmd.Parameters.AddWithValue("maKTKL", ktkl.maKTKL);
                cmd.Parameters.AddWithValue("loai", ktkl.loai);
                cmd.Parameters.AddWithValue("moTa", ktkl.moTa);
                cmd.Parameters.AddWithValue("maNV", ktkl.maNV);
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
        public bool deleteKTKL(string maKTKL)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteDataFromKTKL";
                cmd.Parameters.AddWithValue("maKTKL", maKTKL);
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
        public DataTable searchKTKL(string maNV)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TimKiemKTKL";
                cmd.Parameters.AddWithValue("maNV", maNV);
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

