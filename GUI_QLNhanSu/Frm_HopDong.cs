using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLNhanSu;
using BUS_QLNhanSu;

namespace GUI_QLNhanSu
{
    public partial class FrmHopDong : Form
    {
        public FrmHopDong()
        {
            InitializeComponent();
        }
        BUS_HopDong busHopDong = new BUS_HopDong();
        BUS_NhanVien busnv = new BUS_NhanVien();
        void OpenTextbox()
        {
            txtMaHD.Enabled = true;
            cmbLoaiHD.Enabled = true;
            cmbMaNV.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            dtpNgayKi.Enabled = true;
            txtMaHD.Text = null;
            cmbMaNV.Text = null;
            cmbLoaiHD.Text = null;
        }
        void CloseTextbox()
        {
            txtMaHD.Enabled = false;
            cmbLoaiHD.Enabled = false;
            cmbMaNV.Enabled = false;
            dtpNgayKetThuc.Enabled = false;
            dtpNgayKi.Enabled = false;
            txtMaHD.Text = null;
            cmbMaNV.Text = null;
            cmbLoaiHD.Text = null;
            btLuu.Enabled = false;
        }
        void LoadGridView_HopDong()
        {
            dgvHopDong.DataSource = busHopDong.getHopDong();
            dgvHopDong.Columns[0].HeaderText = "Mã HD";
            dgvHopDong.Columns[1].HeaderText = "Loại HD";
            dgvHopDong.Columns[2].HeaderText = "Ngày ký";
            dgvHopDong.Columns[3].HeaderText = "Ngày kết thúc";
            dgvHopDong.Columns[4].HeaderText = "Mã NV";            

        }
        private void FrmHopDong_Load(object sender, EventArgs e)
        {
            cmbMaNV.DataSource = busnv.DanhSachMaNV();
            cmbMaNV.ValueMember = "manv";
            LoadGridView_HopDong();
            CloseTextbox();
            txtTimkiem.Text = "Mời nhập mã hợp đồng...";
            txtTimkiem.BackColor = Color.LightGray;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            OpenTextbox();
            btLuu.Enabled = true;
        }
        private void dgvHopDong_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = false;
            DataGridViewRow row = dgvHopDong.CurrentRow;
            txtMaHD.Text = row.Cells[0].Value.ToString();
            if (int.Parse(row.Cells[1].Value.ToString()) == 0)
            {
                cmbLoaiHD.SelectedIndex = 0;
            }
            else
            {
                cmbLoaiHD.SelectedIndex = 1;
            }
            dtpNgayKi.Text = row.Cells[2].Value.ToString();
            dtpNgayKetThuc.Text = row.Cells[3].Value.ToString();
            cmbMaNV.Text = row.Cells[4].Value.ToString();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text != "" && cmbLoaiHD.Text != "" && cmbMaNV.Text != "")
            {
                DTO_HopDong hd = new DTO_HopDong(txtMaHD.Text, cmbLoaiHD.SelectedIndex, cmbMaNV.Text, dtpNgayKi.Value, dtpNgayKetThuc.Value);
                if (busHopDong.insertHopDong(hd))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadGridView_HopDong();
                    CloseTextbox();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập đầy đủ");
            }
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = null;
            txtTimkiem.BackColor = Color.White;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string mahd = txtTimkiem.Text;
            DataTable ds = busHopDong.SearchHopDong(mahd);
            if (ds.Rows.Count > 0)
            {
                dgvHopDong.DataSource = ds;
                dgvHopDong.Columns[0].HeaderText = "Mã HD";
                dgvHopDong.Columns[1].HeaderText = "Loại HD";
                dgvHopDong.Columns[2].HeaderText = "Ngày ký";
                dgvHopDong.Columns[3].HeaderText = "Ngày kết thúc";
                dgvHopDong.Columns[4].HeaderText = "Mã NV";
            }
            else
            {
                MessageBox.Show("Không tìm thấy hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimkiem.Text = "Mời nhập mã hợp đồng ...";
            txtTimkiem.BackColor = Color.LightGray;
        }

        private void btDS_Click(object sender, EventArgs e)
        {
            LoadGridView_HopDong();
            CloseTextbox();
        }

    }
}
