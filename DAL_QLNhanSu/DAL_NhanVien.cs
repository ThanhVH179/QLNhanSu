using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QLNhanSu;

namespace DAL_QLNhanSu
{
    public class DAL_NhanVien : DBConnect
    {
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DangNhap";
                cmd.Parameters.AddWithValue("email", nv.Email);
                cmd.Parameters.AddWithValue("matKhau", nv.MatKhau);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }
            return false;
        }
        public bool QuenMatKhau(string email)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_QuenMatKhau";
                cmd.Parameters.AddWithValue("email", email);
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    return true;
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
        public bool TaoMatKhauMoi(string email, string mkmoi)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TaoMatKhauMoi";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("matkhau", mkmoi);
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally { conn.Close(); }
            return false;
        }
        public DataTable VaiTroNhanVien(string email)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_LayVaiTroNV";
                cmd.Parameters.AddWithValue("email", email);
                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool UpdateMatKhau(string email, string matKhauCu, string matKhauMoi)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DoiMatKhau";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("@opwd", matKhauCu);
                cmd.Parameters.AddWithValue("@npwd", matKhauMoi);
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
        public DataTable getNhanVien()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachNV";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool insertNhanVien(DTO_NhanVien nv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertDataIntoNhanVien";
                cmd.Parameters.AddWithValue("manv", nv.maNV);
                cmd.Parameters.AddWithValue("hoten", nv.hoTen);
                cmd.Parameters.AddWithValue("ngaysinh", nv.ngaySinh);
                cmd.Parameters.AddWithValue("queQuan", nv.queQuan);
                cmd.Parameters.AddWithValue("gioitinh", nv.gioiTinh);
                cmd.Parameters.AddWithValue("dantoc", nv.danToc);
                cmd.Parameters.AddWithValue("chucvu", nv.chucVu);
                cmd.Parameters.AddWithValue("sdt", nv.sDT);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
            }
            finally { conn.Close(); }
            return false;
        }
        public bool updateNhanVien(DTO_NhanVien nv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateDataIntoNhanVien";
                cmd.Parameters.AddWithValue("manv", nv.maNV);
                cmd.Parameters.AddWithValue("hoten", nv.hoTen);
                cmd.Parameters.AddWithValue("ngaysinh", nv.ngaySinh);
                cmd.Parameters.AddWithValue("queQuan", nv.queQuan);
                cmd.Parameters.AddWithValue("gioitinh", nv.gioiTinh);
                cmd.Parameters.AddWithValue("dantoc", nv.danToc);
                cmd.Parameters.AddWithValue("chucvu", nv.chucVu);
                cmd.Parameters.AddWithValue("sdt", nv.sDT);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
            }
            finally { conn.Close(); }
            return false;
        }
        public bool deleteNhanVien(string hoten)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteDataNhanVien";
                cmd.Parameters.AddWithValue("hoTen", hoten);
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
        public DataTable searchNhanVien(string hoten)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TimNhanVien";
                cmd.Parameters.AddWithValue("hoten", hoten);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { conn.Close(); }
        }
    }
}
