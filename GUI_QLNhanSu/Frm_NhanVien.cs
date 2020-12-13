using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;
using BUS_QLNhanSu;
using DTO_QLNhanSu;

namespace GUI_QLNhanSu
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        string checkUrlImage;
        string fileName;
        string fileSavePath;
        string fileAddress;
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        BUS_Luong busLuong = new BUS_Luong();
        BUS_PhongBan busPhong = new BUS_PhongBan();
        public void SendMail(string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("thanhhoangvo179@gmail.com", "thanhhjhj113");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("thanhhoangvo179@gmail.com");
                msg.To.Add(email);
                msg.Subject = "Bạn đã tạo tài khoản thành công";
                msg.Body = "Chào anh/chị. Mật khẩu là : thanh123. Anh/Chị vui lòng đăng nhập vào phần mềm và đổi mật khẩu";
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(msg);
                MessageBox.Show("Một email đã được gửi tới bạn");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        void ComboBoxValues()
        {
            cmbBacLuong.DataSource = busLuong.DanhSachBacLuong();
            cmbBacLuong.DisplayMember = "BacLuong";
            cmbBacLuong.ValueMember = "BacLuong";
            cmbMaPB.DataSource = busPhong.danhsachPhongBan();
            cmbMaPB.DisplayMember = "maPB";
            cmbMaPB.ValueMember = "maPB";
        }
        void OpenTextbox()
        {
            txtMaNV.Enabled = true;
            txtTen.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtQueQuan.Enabled = true;
            cmbGT.Enabled = true;
            txtDanToc.Enabled = true;
            txtSDT.Enabled = true;
            cmbChucVu.Enabled = true;
            txtEmail.Enabled = true;
            cmbVaiTro.Enabled = true;
            txtTDHV.Enabled = true;
            pbHinh.Enabled = true;
            cmbBacLuong.Enabled = true;
            cmbMaPB.Enabled = true;
            txtEmail.Text = null;
            cmbVaiTro.Text = null;
            cmbBacLuong.Text = null;
            cmbMaPB.Text = null;
            txtTDHV.Text = null;
            txtMaNV.Text = null;
            txtTen.Text = null;
            txtQueQuan.Text = null;
            txtDanToc.Text = null;
            txtSDT.Text = null;
            txtHinh.Text = null;
            cmbChucVu.Text = null;
            cmbGT.Text = null;
            pbHinh.Image = null;
        }
        void CloseTextbox()
        {
            txtMaNV.Enabled = false;
            txtTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtQueQuan.Enabled = false;
            cmbGT.Enabled = false;
            txtDanToc.Enabled = false;
            txtSDT.Enabled = false;
            cmbChucVu.Enabled = false;
            txtEmail.Enabled = false;
            cmbVaiTro.Enabled = false;
            cmbBacLuong.Enabled = false;
            cmbMaPB.Enabled = false;
            txtTDHV.Enabled = false;
            pbHinh.Enabled = false;
            txtHinh.Enabled = false;
            txtEmail.Text = null;
            cmbVaiTro.Text = null;
            cmbChucVu.Text = null;
            cmbBacLuong.Text = null;
            cmbMaPB.Text = null;
            txtTDHV.Text = null;
            txtMaNV.Text = null;
            txtTen.Text = null;
            txtQueQuan.Text = null;
            txtDanToc.Text = null;
            txtSDT.Text = null;
            txtHinh.Text = null;
            cmbGT.Text = null;
            btLuu.Enabled = false;
            btSua.Enabled = false;
        }

        void LoadGridView_NV()
        {
            dgvNhanVien.DataSource = busNhanVien.GetNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "Mã NV";
            dgvNhanVien.Columns[1].HeaderText = "Tên";
            dgvNhanVien.Columns[2].HeaderText = "Email";
            dgvNhanVien.Columns[3].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[4].HeaderText = "Quê quán";
            dgvNhanVien.Columns[5].HeaderText = "Giới tính";
            dgvNhanVien.Columns[6].HeaderText = "Dân tộc";
            dgvNhanVien.Columns[7].HeaderText = "Số điện thoại";
            dgvNhanVien.Columns[8].HeaderText = "Mã phòng";
            dgvNhanVien.Columns[9].HeaderText = "Chức vụ";
            dgvNhanVien.Columns[10].HeaderText = "Vai trò";
            dgvNhanVien.Columns[11].HeaderText = "Học vấn";
            dgvNhanVien.Columns[12].HeaderText = "Bậc lương";
            dgvNhanVien.Columns[13].HeaderText = "Hình";
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Mời nhập tên nv ...";
            txtTimKiem.BackColor = Color.LightGray;
            LoadGridView_NV();
            ComboBoxValues();
            CloseTextbox();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            OpenTextbox();
            btLuu.Enabled = true;
            btSua.Enabled = false;
        }

        private void btHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap|*.bmp|JPEG Image|*.jpg|GIF|*.gif|All Files|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình minh họa";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                pbHinh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Images\\" + fileName;
                txtHinh.Text = "\\Images\\" + fileName;
            }
        }
        
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTen.Text != "" && txtQueQuan.Text != "" && cmbGT.Text != "" && txtDanToc.Text != "" && txtSDT.Text != "" && cmbChucVu.Text != "" && txtEmail.Text != "" && cmbVaiTro.Text != "" && cmbMaPB.Text != "" && cmbBacLuong.Text != "" && txtTDHV.Text != "" && txtHinh.Text != "")
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text, txtTen.Text, txtEmail.Text, dtpNgaySinh.Value, txtQueQuan.Text, cmbGT.SelectedIndex, txtDanToc.Text, txtSDT.Text, cmbVaiTro.SelectedIndex, txtHinh.Text, cmbMaPB.Text, cmbChucVu.Text, txtTDHV.Text, cmbBacLuong.Text);
                if (busNhanVien.InsertNhanVien(nv))
                {
                    MessageBox.Show("Thêm thành công");
                    File.Copy(fileAddress, fileSavePath, true);
                    LoadGridView_NV();
                    SendMail(nv.Email);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTen.Text != "" && txtQueQuan.Text != "" && cmbGT.Text != "" && txtDanToc.Text != "" && txtSDT.Text != "" && cmbChucVu.Text != "" && txtEmail.Text != "" && cmbVaiTro.Text != "" && cmbMaPB.Text != "" && cmbBacLuong.Text != "" && txtTDHV.Text != "" && txtHinh.Text != "")
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text, txtTen.Text, txtEmail.Text, dtpNgaySinh.Value, txtQueQuan.Text, cmbGT.SelectedIndex, txtDanToc.Text, txtSDT.Text, cmbVaiTro.SelectedIndex, txtHinh.Text, cmbMaPB.Text, cmbChucVu.Text, txtTDHV.Text, cmbBacLuong.Text) ;
                if (MessageBox.Show("Bạn có chắc muốn sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busNhanVien.UpdateNhanVien(nv))
                    {
                        if (txtHinh.Text != checkUrlImage)
                            File.Copy(fileAddress, fileSavePath, true);
                        MessageBox.Show("Sửa thành công");
                        LoadGridView_NV();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = false;
            btSua.Enabled = true;
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (dgvNhanVien.Rows.Count > 0)
            {
                txtMaNV.Enabled = false;
                txtTen.Enabled = true;
                dtpNgaySinh.Enabled = true;
                txtQueQuan.Enabled = true;
                cmbGT.Enabled = true;
                txtDanToc.Enabled = true;
                txtSDT.Enabled = true;
                cmbChucVu.Enabled = true;
                txtEmail.Enabled = true;
                cmbVaiTro.Enabled = true;
                cmbMaPB.Enabled = true;
                cmbBacLuong.Enabled = true;
                txtTDHV.Enabled = true;
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();                
                txtEmail.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.CurrentRow.Cells[3].Value.ToString());
                txtQueQuan.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();                
                if (int.Parse(dgvNhanVien.CurrentRow.Cells[5].Value.ToString()) == 0)
                {
                    cmbGT.SelectedIndex = 0;
                }
                else
                {
                    cmbGT.SelectedIndex = 1;
                }
                txtDanToc.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                txtSDT.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
                cmbMaPB.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
                cmbChucVu.Text = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
                if (int.Parse(dgvNhanVien.CurrentRow.Cells[10].Value.ToString()) == 0)
                {
                    cmbVaiTro.SelectedIndex = 0;
                }
                else
                {
                    cmbVaiTro.SelectedIndex = 1;
                }
                txtTDHV.Text = dgvNhanVien.CurrentRow.Cells[11].Value.ToString();
                cmbBacLuong.Text = dgvNhanVien.CurrentRow.Cells[12].Value.ToString();
                txtHinh.Text = dgvNhanVien.CurrentRow.Cells[13].Value.ToString();
                checkUrlImage = txtHinh.Text;
                pbHinh.Image = Image.FromFile(saveDirectory + dgvNhanVien.CurrentRow.Cells[13].Value.ToString());
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busNhanVien.DeleteNhanVien(txtMaNV.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridView_NV();
                        CloseTextbox();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string nv = txtTimKiem.Text;
            DataTable ds = busNhanVien.SearchNhanVien(nv);
            if (ds.Rows.Count > 0)
            {
                dgvNhanVien.DataSource = ds;
                dgvNhanVien.Columns[0].HeaderText = "Mã NV";
                dgvNhanVien.Columns[1].HeaderText = "Tên";
                dgvNhanVien.Columns[2].HeaderText = "Email";
                dgvNhanVien.Columns[3].HeaderText = "Ngày sinh";
                dgvNhanVien.Columns[4].HeaderText = "Quê quán";
                dgvNhanVien.Columns[5].HeaderText = "Giới tính";
                dgvNhanVien.Columns[6].HeaderText = "Dân tộc";
                dgvNhanVien.Columns[7].HeaderText = "Số điện thoại";
                dgvNhanVien.Columns[8].HeaderText = "Mã phòng";
                dgvNhanVien.Columns[9].HeaderText = "Chức vụ";
                dgvNhanVien.Columns[10].HeaderText = "Vai trò";
                dgvNhanVien.Columns[11].HeaderText = "Học vấn";
                dgvNhanVien.Columns[12].HeaderText = "Bậc lương";
                dgvNhanVien.Columns[13].HeaderText = "Hình";
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimKiem.Text = "Mời nhập tên nhân viên ...";
            txtTimKiem.BackColor = Color.LightGray;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = null;
            txtTimKiem.BackColor = Color.White;
        }

        private void btDS_Click(object sender, EventArgs e)
        {
            LoadGridView_NV();
            CloseTextbox();
        }
    }
}
