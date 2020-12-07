using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNhanSu;
using DTO_QLNhanSu;

namespace GUI_QLNhanSu
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }
        BUS_PhongBan busPhongBan = new BUS_PhongBan();
        BUS_Luong busLuong = new BUS_Luong();
        Bus_ChamCong busChamCong = new Bus_ChamCong();
        void LoadGridView_Phong()
        {
            dgvPhongBan.DataSource = busPhongBan.GetPhongBan();
            dgvPhongBan.Columns[0].HeaderText = "Mã PB";
            dgvPhongBan.Columns[1].HeaderText = "Tên PB";
            dgvPhongBan.Columns[2].HeaderText = "Trưởng phòng";
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            LoadGridView_Phong();
            LoadGridView_Luong();
            LoadGridView_ChamCong();
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTKPhong.Text = null;
            txtTKPhong.BackColor = Color.White;
        }

        private void btTKPhong_Click(object sender, EventArgs e)
        {
            string tenPB = txtTKPhong.Text;
            DataTable ds = busPhongBan.searchPhongBan(tenPB);
            if (ds.Rows.Count > 0)
            {
                dgvPhongBan.DataSource = ds;
                dgvPhongBan.Columns[0].HeaderText = "Mã PB";
                dgvPhongBan.Columns[1].HeaderText = "Tên PB";
                dgvPhongBan.Columns[2].HeaderText = "Trưởng Phòng";
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTKPhong.Text = "Mời nhập tên phòng ...";
            txtTKPhong.BackColor = Color.LightGray;
        }

        private void btDanhSach_Click(object sender, EventArgs e)
        {
            FrmThongKe_Load(sender, e);
        }

        void LoadGridView_Luong()
        {
            dgvLuong.DataSource = busLuong.GetLuong();
            dgvLuong.Columns[0].HeaderText = "Bậc lương";
            dgvLuong.Columns[1].HeaderText = "Lương cơ bản";
            dgvLuong.Columns[2].HeaderText = "Hệ số lương";
            dgvLuong.Columns[3].HeaderText = "Hệ số phụ cấp";
        }

        private void txtTKChamCong_Click(object sender, EventArgs e)
        {
            txtTKChamCong.Text = null;
            txtTKChamCong.BackColor = Color.White;
        }
        void LoadGridView_ChamCong()
        {
            dgvChamCong.DataSource = busChamCong.ThongKeSoNgayNghi();
            dgvChamCong.Columns[0].HeaderText = "Mã NV";
            dgvChamCong.Columns[1].HeaderText = "Số ngày nghỉ";
        }

        private void btTKChamCong_Click(object sender, EventArgs e)
        {
            string manv = txtTKChamCong.Text;
            DataTable ds = busChamCong.NgayNghiNV(manv);
            if (ds.Rows.Count > 0)
            {
                dgvChamCong.DataSource = ds;
                dgvChamCong.Columns[0].HeaderText = "Mã NV";
                dgvChamCong.Columns[1].HeaderText = "Số ngày nghỉ";
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTKChamCong.Text = "Mời nhập mã nv ...";
            txtTKChamCong.BackColor = Color.LightGray;
        }

        private void btDScc_Click(object sender, EventArgs e)
        {
            LoadGridView_ChamCong();
        }
    }
}
