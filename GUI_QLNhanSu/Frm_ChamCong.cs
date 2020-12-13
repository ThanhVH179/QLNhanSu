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
    public partial class FrmChamCong : Form
    {
        public FrmChamCong()
        {
            InitializeComponent();
        }
        Bus_ChamCong busChamCong = new Bus_ChamCong();
        BUS_NhanVien busnv = new BUS_NhanVien();
        void CloseTextbox()
        {
            dTPThoigian.Enabled = false;
            txtMaCC.Enabled = false;
            cmbMaNV.Enabled = false;
            txtChuthich.Enabled = false;
            txtMaCC.Text = null;
            cmbMaNV.Text = null;
            txtChuthich.Text = null;
            btLuu.Enabled = false;
        }
        void OpenTextbox()
        {
            dTPThoigian.Enabled = true;
            txtMaCC.Enabled = true;
            cmbMaNV.Enabled = true;
            txtChuthich.Enabled = true;
            txtMaCC.Text = null;
            cmbMaNV.Text = null;
            txtChuthich.Text = null;
        }
        void LoadGridView_ChamCong()
        {
            dgvChamCong.DataSource = busChamCong.GetChamCong();
            dgvChamCong.Columns[0].HeaderText = "Mã CC";
            dgvChamCong.Columns[1].HeaderText = "Mã NV";
            dgvChamCong.Columns[2].HeaderText = "Thời gian";
            dgvChamCong.Columns[3].HeaderText = "Chú thích";
        }

        private void FrmChamCong_Load(object sender, EventArgs e)
        {
            cmbMaNV.DataSource = busnv.DanhSachMaNV();
            cmbMaNV.ValueMember = "manv";
            LoadGridView_ChamCong();
            CloseTextbox();
            txtTimkiem.Text = "Mời nhập mã nv...";
            txtTimkiem.BackColor = Color.LightGray;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            OpenTextbox();
            btLuu.Enabled = true;
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = null;
            txtTimkiem.BackColor = Color.White;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtMaCC.Text != "" || cmbMaNV.Text != "" || txtChuthich.Text != "")
            {
                DTO_ChamCong chamcong = new DTO_ChamCong(txtMaCC.Text, cmbMaNV.Text, dTPThoigian.Value, txtChuthich.Text );
                if (busChamCong.InsertChamCong(chamcong))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridView_ChamCong();
                    CloseTextbox();
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busChamCong.DeleteChamCong(txtMaCC.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridView_ChamCong();
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
                MessageBox.Show("Hãy chọn dữ liệu muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string macc = txtTimkiem.Text;
            DataTable ds = busChamCong.SearchChamCong(macc);
            if (ds.Rows.Count > 0)
            {
                dgvChamCong.DataSource = ds;
                dgvChamCong.Columns[0].HeaderText = "Mã CC";
                dgvChamCong.Columns[1].HeaderText = "Mã NV";
                dgvChamCong.Columns[2].HeaderText = "Thời gian";
                dgvChamCong.Columns[3].HeaderText = "Chú thích";
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimkiem.Text = "Mời nhập mã nv ...";
            txtTimkiem.BackColor = Color.LightGray;
        }

        private void dgvChamCong_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = false;
            DataGridViewRow row = dgvChamCong.CurrentRow;
            txtMaCC.Text = row.Cells[0].Value.ToString();
            cmbMaNV.Text = row.Cells[1].Value.ToString();
            dTPThoigian.Text = row.Cells[2].Value.ToString();
            txtChuthich.Text = row.Cells[3].Value.ToString();
        }

        private void btDS_Click(object sender, EventArgs e)
        {
            LoadGridView_ChamCong();
            CloseTextbox();
        }
    }
}
