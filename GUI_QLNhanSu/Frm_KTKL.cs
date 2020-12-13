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
    public partial class FrmKTKL : Form
    {
        public FrmKTKL()
        {
            InitializeComponent();
        }
        public static string vaitro;
        BUS_KTKL busKTKL = new BUS_KTKL();
        BUS_NhanVien busnv = new BUS_NhanVien();
        void OpenTextbox()
        {
            txtMaKTKL.Enabled = true;
            txtMoTa.Enabled = true;
            cmbMaNV.Enabled = true;
            cmbLoai.Enabled = true;
            txtMaKTKL.Text = null;
            txtMoTa.Text = null;
            cmbLoai.Text = null;
            cmbMaNV.Text = null;
        }
        void CloseTextbox()
        {
            txtMaKTKL.Enabled = false;
            txtMoTa.Enabled = false;
            cmbMaNV.Enabled = false;
            cmbLoai.Enabled = false;
            txtMaKTKL.Text = null;
            txtMoTa.Text = null;
            cmbLoai.Text = null;
            cmbMaNV.Text = null;
            btLuu.Enabled = false;
            btSua.Enabled = false;
        }
        void LoadGridView_KTKL()
        {
            dgvKTKL.DataSource = busKTKL.GetKTKL();
            dgvKTKL.Columns[0].HeaderText = "Mã KTKL";
            dgvKTKL.Columns[1].HeaderText = "Mã NV";
            dgvKTKL.Columns[2].HeaderText = "Loại";
            dgvKTKL.Columns[3].HeaderText = "Mô tả";

        }
        private void FrmKTKL_Load(object sender, EventArgs e)
        {
            if (int.Parse(vaitro) == 1)
            {
                btThem.Visible = false;
                btLuu.Visible = false;
                btXoa.Visible = false;
                btSua.Visible = false;
            }
            cmbMaNV.DataSource = busnv.DanhSachMaNV();
            cmbMaNV.ValueMember = "manv";
            LoadGridView_KTKL();
            CloseTextbox();
            txtTimkiem.Text = "Mời nhập mã nv...";
            txtTimkiem.BackColor = Color.LightGray;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            OpenTextbox();
            btLuu.Enabled = true;
            btSua.Enabled = false;
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKTKL.Text != "" && txtMoTa.Text != "" && cmbLoai.Text != "" && cmbMaNV.Text != "")
            {
                DTO_KhenThuongKyLuat ktkl = new DTO_KhenThuongKyLuat(txtMaKTKL.Text, txtMoTa.Text, cmbMaNV.Text, cmbLoai.SelectedIndex);
                if (busKTKL.insertKTKL(ktkl))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadGridView_KTKL();
                    CloseTextbox();
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
            if (txtMaKTKL.Text != "" && txtMoTa.Text != "" && cmbLoai.Text != "" && cmbMaNV.Text != "")
            {
                DTO_KhenThuongKyLuat ktkl = new DTO_KhenThuongKyLuat(txtMaKTKL.Text, txtMoTa.Text, cmbMaNV.Text, cmbLoai.SelectedIndex);
                if (MessageBox.Show("Bạn có chắc muốn sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busKTKL.updateKTKL(ktkl))
                    {
                        MessageBox.Show("Sửa thành công");
                        LoadGridView_KTKL();
                        CloseTextbox();
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
        private void dgvKTKL_Click(object sender, EventArgs e)
        {
            txtMaKTKL.Enabled = false;
            txtMoTa.Enabled = true;
            cmbMaNV.Enabled = true;
            cmbLoai.Enabled = true;
            btSua.Enabled = true;
            DataGridViewRow row = dgvKTKL.CurrentRow;
            txtMaKTKL.Text = row.Cells[0].Value.ToString();
            cmbMaNV.Text = row.Cells[1].Value.ToString();
            if (int.Parse(row.Cells[2].Value.ToString()) == 0)
            {
                cmbLoai.SelectedIndex = 0;
            }
            else
            {
                cmbLoai.SelectedIndex = 1;
            }            
            txtMoTa.Text = row.Cells[3].Value.ToString();
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvKTKL.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busKTKL.deleteKTKL(txtMaKTKL.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridView_KTKL();
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
                MessageBox.Show("Hãy chọn mã ktkl muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = null;
            txtTimkiem.BackColor = Color.White;
        }
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string maNV = txtTimkiem.Text;
            DataTable ds = busKTKL.SearchKTKL(maNV);
            if (ds.Rows.Count > 0)
            {
                dgvKTKL.DataSource = ds;
                dgvKTKL.Columns[0].HeaderText = "Mã KTKL";
                dgvKTKL.Columns[1].HeaderText = "Mã NV";
                dgvKTKL.Columns[2].HeaderText = "Loại";
                dgvKTKL.Columns[3].HeaderText = "Mô tả";
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimkiem.Text = "Mời nhập mã nv ...";
            txtTimkiem.BackColor = Color.LightGray;
        }

        private void btDS_Click(object sender, EventArgs e)
        {
            LoadGridView_KTKL();
            CloseTextbox();
        }
    }
}
