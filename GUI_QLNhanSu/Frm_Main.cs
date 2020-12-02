using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNhanSu
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChamCong Fcc = new FrmChamCong();
            Fcc.TopLevel = false;
            Fcc.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fcc);
            Fcc.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap Fdn = new FrmDangNhap();
            Fdn.MdiParent = this;
            Fdn.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            FrmNhanVien Fnv = new FrmNhanVien();
            Fnv.TopLevel = false;
            Fnv.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fnv);
           
            Fnv.Show();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHopDong Fhd = new FrmHopDong();
            Fhd.TopLevel = false;
            Fhd.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fhd);
            Fhd.Show();
        }

        private void khenThưởngKỷLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKTKL Fktkl = new FrmKTKL();
            Fktkl.TopLevel = false;
            Fktkl.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fktkl);
            Fktkl.Show();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLuong Fluong = new FrmLuong();
            Fluong.TopLevel = false;
            Fluong.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fluong);
            Fluong.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongBan Fpb = new FrmPhongBan();
            Fpb.TopLevel = false;
            Fpb.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fpb);
            Fpb.Show();
        }

        private void sựCốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuCo Fsc = new FrmSuCo();
            Fsc.TopLevel = false;
            Fsc.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fsc);
            Fsc.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongKe Ftk = new FrmThongKe();
            Ftk.TopLevel = false;
            Ftk.Dock = DockStyle.Fill;
            panel1.Controls.Add(Ftk);
            Ftk.Show();
            //bbbb
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đồiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMK Fdmk = new FrmDoiMK();
            Fdmk.MdiParent = this;
            Fdmk.Show();
        }
    }
}
