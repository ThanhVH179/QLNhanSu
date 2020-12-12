using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Data;
using DAL_QLNhanSu;
using DTO_QLNhanSu;

namespace BUS_QLNhanSu
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            return dalNhanVien.NhanVienDangNhap(nv);
        }
        public string encryption(string pw)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(pw));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
        public bool NhanVienQuenMatKhau(string email)
        {
            return dalNhanVien.QuenMatKhau(email);
        }
        public bool TaoMatKhau(string email, string matkhaumoi)
        {
            return dalNhanVien.TaoMatKhauMoi(email, matkhaumoi);
        }
        public DataTable VaiTroNV(string email)
        {
            return dalNhanVien.VaiTroNhanVien(email);
        }
        public bool UpdateMatKhau(string email, string matKhauCu, string matKhauMoi)
        {
            return dalNhanVien.UpdateMatKhau(email, matKhauCu, matKhauMoi);
        }
        public DataTable GetNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }
        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.insertNhanVien(nv);
        }
        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.updateNhanVien(nv);
        }
        public bool DeleteNhanVien(string manv)
        {
            return dalNhanVien.deleteNhanVien(manv);
        }
        public DataTable SearchNhanVien(string ten)
        {
            return dalNhanVien.searchNhanVien(ten);
        }

    }
    
}
