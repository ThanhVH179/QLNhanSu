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
    public partial class FrmPhongBan : Form
    {
        public FrmPhongBan()
        {
            InitializeComponent();
        }
        public static string vaitro;
        BUS_PhongBan busPhongBan = new BUS_PhongBan();
        void OpenTextbox()
        {
            txtMaPB.Enabled = true;
            txtTenPB.Enabled = true;
            txtTruongPhong.Enabled = true;
            txtMaPB.Text = null;
            txtTenPB.Text = null;
            txtTruongPhong.Text = null;
        }
        void CloseTextbox()
        {
            txtMaPB.Enabled = false;
            txtTenPB.Enabled = false;
            txtTruongPhong.Enabled = false;
            txtMaPB.Text = null;
            txtTenPB.Text = null;
            txtTruongPhong.Text = null;
            btLuu.Enabled = false;
            btSua.Enabled = false;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            OpenTextbox();
            btLuu.Enabled = true;
            btSua.Enabled = false;
        }
         
        void LoadGridView_Phong()
        {
            dgvPhongBan.DataSource = busPhongBan.GetPhongBan();
            dgvPhongBan.Columns[0].HeaderText = "Mã PB";
            dgvPhongBan.Columns[1].HeaderText = "Tên PB";
            dgvPhongBan.Columns[2].HeaderText = "Trưởng phòng";
        }
        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            if (int.Parse(vaitro) == 1)
            {
                btThem.Visible = false;
                btLuu.Visible = false;
                btXoa.Visible = false;
                btSua.Visible = false;
            }
            LoadGridView_Phong();
            CloseTextbox();
            txtTimkiem.Text = "Mời nhập ...";
            txtTimkiem.BackColor = Color.LightGray;
        }        

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text != "" && txtTenPB.Text != "" && txtTruongPhong.Text != "")
            {
                DTO_PhongBan phongBan = new DTO_PhongBan(txtMaPB.Text, txtTenPB.Text, txtTruongPhong.Text); ;
                if (busPhongBan.insertPhongBan(phongBan))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridView_Phong();
                    CloseTextbox();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhongBan.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busPhongBan.deletePhongBan(txtMaPB.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridView_Phong();
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
                MessageBox.Show("Hãy chọn phòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPhongBan_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = false;
            btSua.Enabled = true;
            txtMaPB.Enabled = false;
            txtTenPB.Enabled = true;
            txtTruongPhong.Enabled = true;
            DataGridViewRow row = dgvPhongBan.CurrentRow;
            txtMaPB.Text = row.Cells[0].Value.ToString();
            txtTenPB.Text = row.Cells[1].Value.ToString();
            txtTruongPhong.Text = row.Cells[2].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text != "" && txtTenPB.Text != "" && txtTruongPhong.Text != "")
            {
                DTO_PhongBan phongBan = new DTO_PhongBan(txtMaPB.Text, txtTenPB.Text, txtTruongPhong.Text); ;
                if (MessageBox.Show("Bạn có chắc muốn sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busPhongBan.updatePhongBan(phongBan))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridView_Phong();
                        CloseTextbox();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = null;
            txtTimkiem.BackColor = Color.White;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string tenPB = txtTimkiem.Text;
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
            txtTimkiem.Text = "Mời nhập tên phòng ...";
            txtTimkiem.BackColor = Color.LightGray;
        }

        private void btDS_Click(object sender, EventArgs e)
        {
            LoadGridView_Phong();
            CloseTextbox();
        }
    }
}
