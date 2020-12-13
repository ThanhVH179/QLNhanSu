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
    public class DAL_ChamCong : DBConnect
    {
        public DataTable getChamCong()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachChamCong";
                DataTable dtLuong = new DataTable();
                dtLuong.Load(cmd.ExecuteReader());
                return dtLuong;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool insertChamCong(DTO_ChamCong chamcong)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertDataIntoChamCong";
                cmd.Parameters.AddWithValue("maCC", chamcong.maCC);
                cmd.Parameters.AddWithValue("maNV", chamcong.maNV);
                cmd.Parameters.AddWithValue("thoiGian", chamcong.thoiGian);
                cmd.Parameters.AddWithValue("chuThich", chamcong.chuThich);
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

        public bool deleteChamCong(string macc)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteFromChamCong";
                cmd.Parameters.AddWithValue("maCC", macc);
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

        public DataTable searchChamCong(string manv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TimKiemChamCong";
                cmd.Parameters.AddWithValue("maNV", manv);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable ngayNghiNhanVien(string manv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_NgayNghiNhanVien";
                cmd.Parameters.AddWithValue("maNV", manv);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable thongKeNgayNghi()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ThongKeSoNgayNghi";
                DataTable dtLuong = new DataTable();
                dtLuong.Load(cmd.ExecuteReader());
                return dtLuong;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
