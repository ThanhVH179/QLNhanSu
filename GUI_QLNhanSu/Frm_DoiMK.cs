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
    public partial class FrmDoiMK : Form
    {
  
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        public FrmDoiMK(string mail)
        {
            InitializeComponent();
            txtTaiKhoan.Text = mail;
            txtTaiKhoan.Enabled = false;
        }

        public void SendMail(string email, string matkhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                NetworkCredential cred = new NetworkCredential("thanhhoangvo179@gmail.com", "thanhhjhj113");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("thanhhoangvo179@gmail.com");
                msg.To.Add(email);
                msg.Subject = "Bạn đã sử dụng tính năng đổi mật khẩu";
                msg.Body = "Chào anh/chị. Mật khẩu mới là : " + matkhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(msg);
                MessageBox.Show("Một email đổi mật khẩu đã được gửi tới bạn");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKCu.Focus();
                return;
            }
            else if (txtMKMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoi.Focus();
                return;
            }
            else if (txtNhapLaiMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập lại mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapLaiMK.Focus();
                return;
            }
            else if (txtNhapLaiMK.Text.Trim() != txtMKMoi.Text.Trim())
            {
                MessageBox.Show("Nhập lại chưa đúng. Mời nhập lại mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapLaiMK.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn đổi mật khẩu ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mkCu = busNhanVien.encryption(txtMKCu.Text);
                    string mkMoi = busNhanVien.encryption(txtMKMoi.Text);
                    if (busNhanVien.UpdateMatKhau(txtTaiKhoan.Text, mkCu, mkMoi))
                    {                        
                        SendMail(txtTaiKhoan.Text, txtMKMoi.Text);
                        MessageBox.Show("Đổi mật khẩu thành công. Bạn cần phải đăng nhập lại");
                        FrmMain.session = 0;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng. Đổi mật khẩu không thành công");
                        txtMKCu.Text = null;
                        txtMKMoi.Text = null;
                        txtNhapLaiMK.Text = null;
                    }
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
