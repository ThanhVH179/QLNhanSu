using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhanSu
{
    public class DTO_NhanVien
    {
        public string maNV;
        public string hoTen;
        public string email;
        public DateTime ngaySinh;
        public string queQuan;
        public int gioiTinh;
        public string danToc;
        public string sDT;
        public int vaiTro;
        public string hinh;
        public string matKhau;
        public string maPB;
        public string chucVu;
        public string trinhDoHV;
        public string bacLuong;
        
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }
        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string DanToc
        {
            get { return danToc; }
            set { danToc = value; }
        }
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        public int VaiTro
        {
            get { return vaiTro; }
            set { vaiTro = value; }
        }
        public string Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string MaPB
        {
            get { return maPB; }
            set { maPB = value; }
        }
        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
        public string TrinhDoHV
        {
            get { return trinhDoHV; }
            set { trinhDoHV = value; }
        }
        public string BacLuong
        {
            get { return bacLuong; }
            set { bacLuong = value; }
        }

        public DTO_NhanVien(string manv, string hoten, string email, DateTime ngaysinh, string quequan, int gioitinh, string dantoc,
                            string sdt, int vaitro, string hinh, string matkhau, string maPB, string chucvu, string trinhdoHV, string bacluong)
        {
            this.maNV = manv;
            this.hoTen = hoten;
            this.email = email;
            this.ngaySinh = ngaysinh;
            this.queQuan = quequan;
            this.gioiTinh = gioitinh;
            this.danToc = dantoc;
            this.sDT = sdt;
            this.vaiTro = vaitro;
            this.hinh = hinh;
            this.matKhau = matkhau;
            this.maPB = maPB;
            this.chucVu = chucvu;
            this.trinhDoHV = trinhdoHV;
            this.bacLuong = bacluong;
        }
    }
}
