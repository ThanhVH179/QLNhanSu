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
    public partial class FrmLuong : Form
    {
        public FrmLuong()
        {
            InitializeComponent();
        }
        BUS_Luong busLuong = new BUS_Luong();
        void OpenTextbox()
        {
            txtBacLuong.Enabled = true;
            txtHeSoLuong.Enabled = true;
            txtHeSoPhuCap.Enabled = true;
            txtLuongCoBan.Enabled = true;
            txtBacLuong.Text = null;
            txtHeSoLuong.Text = null;
            txtHeSoPhuCap.Text = null;
            txtLuongCoBan.Text = null;
        }
        void CloseTextbox()
        {
            txtBacLuong.Enabled = false;
            txtHeSoLuong.Enabled = false;
            txtHeSoPhuCap.Enabled = false;
            txtLuongCoBan.Enabled = false;
            txtBacLuong.Text = null;
            txtHeSoLuong.Text = null;
            txtHeSoPhuCap.Text = null;
            txtLuongCoBan.Text = null;
            btSua.Enabled = false;
            btLuu.Enabled = false;
        }
        void LoadGridView_Luong()
        {
            dgvLuong.DataSource = busLuong.GetLuong();
            dgvLuong.Columns[0].HeaderText = "Bậc lương";
            dgvLuong.Columns[1].HeaderText = "Lương cơ bản";
            dgvLuong.Columns[2].HeaderText = "Hệ số lương";
            dgvLuong.Columns[3].HeaderText = "Hệ số phụ cấp";

        }
        private void FrmLuong_Load(object sender, EventArgs e)
        {
            LoadGridView_Luong();
            CloseTextbox();
            txtTimkiem.Text = "Mời nhập bậc lương...";
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
            if (txtBacLuong.Text != "" && txtLuongCoBan.Text != "" && txtHeSoLuong.Text != "" && txtHeSoPhuCap.Text != "")
            {
                double l, hsluong, hspc;
                bool isLuong = double.TryParse(txtLuongCoBan.Text, out l);
                bool ishsluong = double.TryParse(txtHeSoLuong.Text, out hsluong);
                bool ishspc = double.TryParse(txtHeSoPhuCap.Text, out hspc);
                if (!isLuong || double.Parse(txtLuongCoBan.Text) < 0)
                {
                    MessageBox.Show("Mời kiểm tra lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLuongCoBan.Focus();
                }
                else if (!ishsluong || double.Parse(txtHeSoLuong.Text) < 0)
                {
                    MessageBox.Show("Mời kiểm tra hệ số lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHeSoLuong.Focus();
                }
                else if (!ishspc || double.Parse(txtHeSoPhuCap.Text) < 0)
                {
                    MessageBox.Show("Mời kiểm tra hệ số phụ cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHeSoPhuCap.Focus();
                }
                else
                {
                    DTO_Luong luong = new DTO_Luong(txtBacLuong.Text, double.Parse(txtLuongCoBan.Text), double.Parse(txtHeSoLuong.Text), double.Parse(txtHeSoPhuCap.Text)); ;
                    if (busLuong.insertLuong(luong))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridView_Luong();
                        CloseTextbox();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }             
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvLuong_Click(object sender, EventArgs e)
        {
            btSua.Enabled = true;
            btLuu.Enabled = false;
            txtBacLuong.Enabled = false;
            txtHeSoLuong.Enabled = true;
            txtHeSoPhuCap.Enabled = true;
            txtLuongCoBan.Enabled = true;
            DataGridViewRow row = dgvLuong.CurrentRow;
            txtBacLuong.Text = row.Cells[0].Value.ToString();
            txtLuongCoBan.Text = row.Cells[1].Value.ToString();
            txtHeSoLuong.Text = row.Cells[2].Value.ToString();
            txtHeSoPhuCap.Text = row.Cells[3].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvLuong.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busLuong.deleteluong(txtBacLuong.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridView_Luong();
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
                MessageBox.Show("Hãy chọn bậc lương muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtBacLuong.Text != "" && txtLuongCoBan.Text != "" && txtHeSoLuong.Text != "" && txtHeSoPhuCap.Text != "")
            {
                double l, hsluong, hspc;
                bool isLuong = double.TryParse(txtLuongCoBan.Text, out l);
                bool ishsluong = double.TryParse(txtHeSoLuong.Text, out hsluong);
                bool ishspc = double.TryParse(txtHeSoPhuCap.Text, out hspc);
                if (!isLuong || double.Parse(txtLuongCoBan.Text) < 0)
                {
                    MessageBox.Show("Mời kiểm tra lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLuongCoBan.Focus();
                }
                else if (!ishsluong || double.Parse(txtHeSoLuong.Text) < 0)
                {
                    MessageBox.Show("Mời kiểm tra hệ số lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHeSoLuong.Focus();
                }
                else if (!ishspc || double.Parse(txtHeSoPhuCap.Text) < 0)
                {
                    MessageBox.Show("Mời kiểm tra hệ số phụ cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHeSoPhuCap.Focus();
                }
                else
                {
                    DTO_Luong luong = new DTO_Luong(txtBacLuong.Text, double.Parse(txtLuongCoBan.Text), double.Parse(txtHeSoLuong.Text), double.Parse(txtHeSoPhuCap.Text)); ;
                    if (MessageBox.Show("Bạn có chắc muốn sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (busLuong.updateLuong(luong))
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGridView_Luong();
                            CloseTextbox();
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
            string bacLuong = txtTimkiem.Text;
            DataTable ds = busLuong.SearchLuong(bacLuong);
            if (ds.Rows.Count > 0)
            {
                dgvLuong.DataSource = ds;
                dgvLuong.Columns[0].HeaderText = "Bậc lương";
                dgvLuong.Columns[1].HeaderText = "Lương cơ bản";
                dgvLuong.Columns[2].HeaderText = "Hệ số lương";
                dgvLuong.Columns[3].HeaderText = "Hệ số phụ cấp";
            }
            else
            {
                MessageBox.Show("Không tìm thấy bậc lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimkiem.Text = "Mời nhập bậc lương ...";
            txtTimkiem.BackColor = Color.LightGray;
        }

        private void btDS_Click(object sender, EventArgs e)
        {
            LoadGridView_Luong();
            CloseTextbox();
        }
    }
}
