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
            FrmChamCong fcc = new FrmChamCong();

            fcc.TopLevel = false;
            fcc.Dock = DockStyle.Fill;
            panel1.Controls.Add(fcc);
            fcc.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap fdn = new FrmDangNhap();
            fdn.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien fnv = new FrmNhanVien();
            fnv.TopLevel = false;
            fnv.Dock = DockStyle.Fill;
            panel1.Controls.Add(fnv);
           
            fnv.Show();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHopDong fhd = new FrmHopDong();
            fhd.TopLevel = false;
            fhd.Dock = DockStyle.Fill;
            panel1.Controls.Add(fhd);
            fhd.Show();
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
            //aaa
        }
    }
}
