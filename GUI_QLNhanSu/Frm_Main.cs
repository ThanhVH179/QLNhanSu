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
        public static string mail;
        public static int session = 0;
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void ResetValues()
        {
            if (session == 1)
            {
                DangNhapToolStripMenuItem.Enabled = false;
                DangXuatToolStripMenuItem.Enabled = true;
                DoiMatKhauToolStripMenuItem.Enabled = true;
                DanhMucToolStripMenuItem.Visible = true;
                thongTinNVMenuItem.Visible = true;
                thongTinNVMenuItem.Text = "Chào " + FrmMain.mail;
            }
            else
            {
                DangNhapToolStripMenuItem.Enabled = true;
                DangXuatToolStripMenuItem.Enabled = false;
                DoiMatKhauToolStripMenuItem.Enabled = false;
                DanhMucToolStripMenuItem.Visible = false;
                thongTinNVMenuItem.Visible = false;
            }
        }
        void FrmLogin_Closed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }

        void FrmDoiMK_Closed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
       
        private void DangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap Fdn = new FrmDangNhap();
            Fdn.MdiParent = this;
            Fdn.Show();
            Fdn.FormClosed += new FormClosedEventHandler(FrmLogin_Closed);
        }

        void FrmClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            panel1.Visible = false;
            panel1.Controls.Clear();
        }

        private void ChamCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            FrmChamCong Fcc = new FrmChamCong();
            Fcc.TopLevel = false;
            Fcc.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fcc);
            Fcc.Show();
            Fcc.FormClosed += new FormClosedEventHandler(FrmClosed);
        }
        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            FrmNhanVien Fnv = new FrmNhanVien();
            Fnv.TopLevel = false;
            Fnv.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fnv);
            Fnv.Show();
            Fnv.FormClosed += new FormClosedEventHandler(FrmClosed);
        }

        private void HopDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            FrmHopDong Fhd = new FrmHopDong();
            Fhd.TopLevel = false;
            Fhd.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fhd);
            Fhd.Show();
            Fhd.FormClosed += new FormClosedEventHandler(FrmClosed);
        }

        private void KTKLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            FrmKTKL Fktkl = new FrmKTKL();
            Fktkl.TopLevel = false;
            Fktkl.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fktkl);
            Fktkl.Show();
            Fktkl.FormClosed += new FormClosedEventHandler(FrmClosed);
        }

        private void LuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            FrmLuong Fluong = new FrmLuong();
            Fluong.TopLevel = false;
            Fluong.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fluong);
            Fluong.Show();
            Fluong.FormClosed += new FormClosedEventHandler(FrmClosed);
        }

        private void PhongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            FrmPhongBan Fpb = new FrmPhongBan();
            Fpb.TopLevel = false;
            Fpb.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fpb);
            Fpb.Show();
            Fpb.FormClosed += new FormClosedEventHandler(FrmClosed);
        }

        private void SuCoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            FrmSuCo Fsc = new FrmSuCo();
            Fsc.TopLevel = false;
            Fsc.Dock = DockStyle.Fill;
            panel1.Controls.Add(Fsc);
            Fsc.Show();
            Fsc.FormClosed += new FormClosedEventHandler(FrmClosed);
        }

        private void ThongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            FrmThongKe Ftk = new FrmThongKe();
            Ftk.TopLevel = false;
            Ftk.Dock = DockStyle.Fill;
            panel1.Controls.Add(Ftk);
            Ftk.Show();
            Ftk.FormClosed += new FormClosedEventHandler(FrmClosed);
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMK Fdmk = new FrmDoiMK(FrmMain.mail);
            Fdmk.MdiParent = this;
            Fdmk.Show();
            Fdmk.FormClosed += new FormClosedEventHandler(FrmDoiMK_Closed);
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session = 0;
            thongTinNVMenuItem.Text = null;
            ResetValues();
            panel1.Controls.Clear();
            panel1.Visible = false;
        }
    }
    } 
