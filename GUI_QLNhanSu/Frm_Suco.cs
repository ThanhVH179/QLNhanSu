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
    public partial class FrmSuCo : Form
    {
        public FrmSuCo()
        {
            InitializeComponent();
        }
        BUS_SuCo busSuCo = new BUS_SuCo();
        BUS_NhanVien busnv = new BUS_NhanVien();

        void OpenText()
        {
            cmbMaNV.Enabled = true;
            txtMaSC.Enabled = true;
            txtTenSC.Enabled = true;
            txtThiethai.Enabled = true;
            cmbLoaiSC.Enabled = true;
            cmbMaNV.Text = null;
            txtMaSC.Text = null;
            txtTenSC.Text = null;
            txtThiethai.Text = null;
            cmbLoaiSC.Text = null;
        }
        void CloseText()
        {
            cmbMaNV.Enabled = false;
            txtMaSC.Enabled = false;
            txtTenSC.Enabled = false;
            txtThiethai.Enabled = false;
            cmbLoaiSC.Enabled = false;
            cmbMaNV.Text = null;
            txtMaSC.Text = null;
            txtTenSC.Text = null;
            txtThiethai.Text = null;
            cmbLoaiSC.Text = null;
        }
        void LoadGridView_SuCo()
        {
            dgvSuco.DataSource = busSuCo.GetSuCo();
            dgvSuco.Columns[0].HeaderText = "Mã sự cố";
            dgvSuco.Columns[1].HeaderText = "Mã NV";
            dgvSuco.Columns[2].HeaderText = "Tên sự cố";
            dgvSuco.Columns[3].HeaderText = "Loại sự cố";
            dgvSuco.Columns[4].HeaderText = "Thiệt hại";
        }

        private void FrmSuCo_Load(object sender, EventArgs e)
        {
            cmbMaNV.DataSource = busnv.DanhSachMaNV();
            cmbMaNV.ValueMember = "manv";
            LoadGridView_SuCo();
            CloseText();
            txtTimkiem.Text = "Mời nhập mã sự cố...";
            txtTimkiem.BackColor = Color.LightGray;
        }
       
        private void btThem_Click(object sender, EventArgs e)
        {
            OpenText();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (cmbMaNV.Text != "" && txtMaSC.Text != "" && txtTenSC.Text !="" && txtThiethai.Text != "" && cmbLoaiSC.Text != "")
            {
                DTO_SuCo sc = new DTO_SuCo(txtMaSC.Text, cmbMaNV.Text, txtTenSC.Text, cmbLoaiSC.SelectedIndex, txtThiethai.Text);

                if (busSuCo.insertSuCo(sc))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadGridView_SuCo();
                    CloseText();
                }
            }
            else
            {
                MessageBox.Show("Mời nhập đầy đủ");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cmbMaNV.Text != "" && txtMaSC.Text != "" && txtTenSC.Text != "" && txtThiethai.Text != "" && cmbLoaiSC.Text != "")
            {
                DTO_SuCo sc = new DTO_SuCo(txtMaSC.Text, cmbMaNV.Text, txtTenSC.Text, cmbLoaiSC.SelectedIndex, txtThiethai.Text);

                if (busSuCo.updateSuCo(sc))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadGridView_SuCo();
                    CloseText();
                }
            }
            else
            {
                MessageBox.Show("Mời nhập đầy đủ");
            }
        }

        private void dgvSuco_Click(object sender, EventArgs e)
        {
            txtMaSC.Enabled = false;
            cmbMaNV.Enabled = true;
            cmbLoaiSC.Enabled = true;
            txtTenSC.Enabled = true;
            txtThiethai.Enabled = true;
            txtMaSC.Text = dgvSuco.CurrentRow.Cells[0].Value.ToString();
            cmbMaNV.Text = dgvSuco.CurrentRow.Cells[1].Value.ToString();
            txtTenSC.Text = dgvSuco.CurrentRow.Cells[2].Value.ToString();
            if (int.Parse(dgvSuco.CurrentRow.Cells[3].Value.ToString()) == 0)
            {
                cmbLoaiSC.SelectedIndex = 0;
            }
            else
            {
                cmbLoaiSC.SelectedIndex = 1;
            }
            txtThiethai.Text = dgvSuco.CurrentRow.Cells[4].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvSuco.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busSuCo.deleteSuCo(txtMaSC.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridView_SuCo();
                        CloseText();
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

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = null;
            txtTimkiem.BackColor = Color.White;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string maSC = txtTimkiem.Text;
            DataTable ds = busSuCo.SearchSuCo(maSC);
            if (ds.Rows.Count > 0)
            {
                dgvSuco.DataSource = ds;
                dgvSuco.Columns[0].HeaderText = "Mã sự cố";
                dgvSuco.Columns[1].HeaderText = "Mã NV";
                dgvSuco.Columns[2].HeaderText = "Tên sự cố";
                dgvSuco.Columns[3].HeaderText = "Loại sự cố";
                dgvSuco.Columns[4].HeaderText = "Thiệt hại";
            }
            else
            {
                MessageBox.Show("Không tìm thấy sự cố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimkiem.Text = "Mời nhập mã sự cố ...";
            txtTimkiem.BackColor = Color.LightGray;
        }

        private void btDS_Click(object sender, EventArgs e)
        {
            LoadGridView_SuCo();
            CloseText();
        }
    }
}
