using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using DTO_QLNhanSu;
using BUS_QLNhanSu;

namespace GUI_QLNhanSu
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        public string vaiTro { get; set; }
        public string matKhau { get; set; }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.Email = txtTaiKhoan.Text;
            nv.MatKhau = busNhanVien.encryption(txtMatKhau.Text);
            if (busNhanVien.NhanVienDangNhap(nv))
            {
                FrmMain.mail = nv.Email;
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain.session = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Text = null;
                txtMatKhau.Text = null;
                txtTaiKhoan.Focus();
            }
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random rd = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rd.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }
        public int RandomNumber(int min, int max)
        {
            Random rd = new Random();
            return rd.Next(min, max);
        }

        public void SendMail(string email, string matkhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("thanhhoangvo179@gmail.com", "thanhhjhj113");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("thanhhoangvo179@gmail.com");
                msg.To.Add(email);
                msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                msg.Body = "Chào anh/chị. Mật khẩu mới là : " + matkhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(msg);
                MessageBox.Show("Một email khôi phục mật khẩu đã được gửi tới bạn");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "")
            {
                if (busNhanVien.NhanVienQuenMatKhau(txtTaiKhoan.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(1000, 9999));
                    builder.Append(RandomString(2, false));
                    string matkhaumoi = busNhanVien.encryption(builder.ToString());
                    busNhanVien.TaoMatKhau(txtTaiKhoan.Text, matkhaumoi);
                    SendMail(txtTaiKhoan.Text, builder.ToString());
                }
                else
                {
                    MessageBox.Show("Email không tồn tại, vui lòng kiểm tra lạo email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email để nhận thông tin khôi phục", "Thông báo");
                txtTaiKhoan.Focus();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
