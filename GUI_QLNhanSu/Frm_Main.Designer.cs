namespace GUI_QLNhanSu
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.HeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhongBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HopDongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChamCongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuCoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KTKLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HuongDanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinNVMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThongToolStripMenuItem,
            this.DanhMucToolStripMenuItem,
            this.HuongDanToolStripMenuItem,
            this.thongTinNVMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // HeThongToolStripMenuItem
            // 
            this.HeThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangNhapToolStripMenuItem,
            this.DangXuatToolStripMenuItem,
            this.DoiMatKhauToolStripMenuItem,
            this.ThoatToolStripMenuItem});
            this.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem";
            this.HeThongToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.HeThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // DangNhapToolStripMenuItem
            // 
            this.DangNhapToolStripMenuItem.Name = "DangNhapToolStripMenuItem";
            this.DangNhapToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.DangNhapToolStripMenuItem.Text = "Đăng nhập ";
            this.DangNhapToolStripMenuItem.Click += new System.EventHandler(this.DangNhapToolStripMenuItem_Click);
            // 
            // DangXuatToolStripMenuItem
            // 
            this.DangXuatToolStripMenuItem.Enabled = false;
            this.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            this.DangXuatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.DangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.DangXuatToolStripMenuItem.Click += new System.EventHandler(this.DangXuatToolStripMenuItem_Click);
            // 
            // DoiMatKhauToolStripMenuItem
            // 
            this.DoiMatKhauToolStripMenuItem.Name = "DoiMatKhauToolStripMenuItem";
            this.DoiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.DoiMatKhauToolStripMenuItem.Text = "Đồi mật khẩu";
            this.DoiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.DoiMatKhauToolStripMenuItem_Click);
            // 
            // ThoatToolStripMenuItem
            // 
            this.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            this.ThoatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ThoatToolStripMenuItem.Text = "Thoát";
            this.ThoatToolStripMenuItem.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);
            // 
            // DanhMucToolStripMenuItem
            // 
            this.DanhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NhanVienToolStripMenuItem,
            this.PhongBanToolStripMenuItem,
            this.HopDongToolStripMenuItem,
            this.ChamCongToolStripMenuItem,
            this.LuongToolStripMenuItem,
            this.SuCoToolStripMenuItem,
            this.KTKLToolStripMenuItem,
            this.ThongKeToolStripMenuItem});
            this.DanhMucToolStripMenuItem.Name = "DanhMucToolStripMenuItem";
            this.DanhMucToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.DanhMucToolStripMenuItem.Text = "Danh mục";
            this.DanhMucToolStripMenuItem.Visible = false;
            // 
            // NhanVienToolStripMenuItem
            // 
            this.NhanVienToolStripMenuItem.Name = "NhanVienToolStripMenuItem";
            this.NhanVienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.NhanVienToolStripMenuItem.Text = "Nhân viên";
            this.NhanVienToolStripMenuItem.Click += new System.EventHandler(this.NhanVienToolStripMenuItem_Click);
            // 
            // PhongBanToolStripMenuItem
            // 
            this.PhongBanToolStripMenuItem.Name = "PhongBanToolStripMenuItem";
            this.PhongBanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.PhongBanToolStripMenuItem.Text = "Phòng ban";
            this.PhongBanToolStripMenuItem.Click += new System.EventHandler(this.PhongBanToolStripMenuItem_Click);
            // 
            // HopDongToolStripMenuItem
            // 
            this.HopDongToolStripMenuItem.Name = "HopDongToolStripMenuItem";
            this.HopDongToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.HopDongToolStripMenuItem.Text = "Hợp đồng";
            this.HopDongToolStripMenuItem.Click += new System.EventHandler(this.HopDongToolStripMenuItem_Click);
            // 
            // ChamCongToolStripMenuItem
            // 
            this.ChamCongToolStripMenuItem.Name = "ChamCongToolStripMenuItem";
            this.ChamCongToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ChamCongToolStripMenuItem.Text = "Chấm công";
            this.ChamCongToolStripMenuItem.Click += new System.EventHandler(this.ChamCongToolStripMenuItem_Click);
            // 
            // LuongToolStripMenuItem
            // 
            this.LuongToolStripMenuItem.Name = "LuongToolStripMenuItem";
            this.LuongToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.LuongToolStripMenuItem.Text = "Lương";
            this.LuongToolStripMenuItem.Click += new System.EventHandler(this.LuongToolStripMenuItem_Click);
            // 
            // SuCoToolStripMenuItem
            // 
            this.SuCoToolStripMenuItem.Name = "SuCoToolStripMenuItem";
            this.SuCoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SuCoToolStripMenuItem.Text = "Sự cố";
            this.SuCoToolStripMenuItem.Click += new System.EventHandler(this.SuCoToolStripMenuItem_Click);
            // 
            // KTKLToolStripMenuItem
            // 
            this.KTKLToolStripMenuItem.Name = "KTKLToolStripMenuItem";
            this.KTKLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.KTKLToolStripMenuItem.Text = "Khen thưởng kỷ luật";
            this.KTKLToolStripMenuItem.Click += new System.EventHandler(this.KTKLToolStripMenuItem_Click);
            // 
            // ThongKeToolStripMenuItem
            // 
            this.ThongKeToolStripMenuItem.Name = "ThongKeToolStripMenuItem";
            this.ThongKeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ThongKeToolStripMenuItem.Text = "Thống kê";
            this.ThongKeToolStripMenuItem.Click += new System.EventHandler(this.ThongKeToolStripMenuItem_Click);
            // 
            // HuongDanToolStripMenuItem
            // 
            this.HuongDanToolStripMenuItem.Name = "HuongDanToolStripMenuItem";
            this.HuongDanToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.HuongDanToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // thongTinNVMenuItem
            // 
            this.thongTinNVMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.thongTinNVMenuItem.Name = "thongTinNVMenuItem";
            this.thongTinNVMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.thongTinNVMenuItem.Size = new System.Drawing.Size(14, 24);
            this.thongTinNVMenuItem.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 675);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý nhân sự";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem HeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DanhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HuongDanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhongBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HopDongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChamCongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuCoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KTKLToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem ThongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinNVMenuItem;
    }
}