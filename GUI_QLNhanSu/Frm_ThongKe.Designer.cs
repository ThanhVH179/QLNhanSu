namespace GUI_QLNhanSu
{
    partial class FrmThongKe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khenThưởngKỷLuậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btGiamDan = new System.Windows.Forms.Button();
            this.btTangDan = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngToolStripMenuItem,
            this.khenThưởngKỷLuậtToolStripMenuItem,
            this.chấmCôngToolStripMenuItem,
            this.lươngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.phòngToolStripMenuItem.Text = "Phòng";
            // 
            // khenThưởngKỷLuậtToolStripMenuItem
            // 
            this.khenThưởngKỷLuậtToolStripMenuItem.Name = "khenThưởngKỷLuậtToolStripMenuItem";
            this.khenThưởngKỷLuậtToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.khenThưởngKỷLuậtToolStripMenuItem.Text = "Khen thưởng & Kỷ luật";
            // 
            // chấmCôngToolStripMenuItem
            // 
            this.chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            this.chấmCôngToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.chấmCôngToolStripMenuItem.Text = "Chấm công";
            // 
            // lươngToolStripMenuItem
            // 
            this.lươngToolStripMenuItem.Name = "lươngToolStripMenuItem";
            this.lươngToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.lươngToolStripMenuItem.Text = "Lương";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btTim);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 116);
            this.panel1.TabIndex = 7;
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTim.ImageIndex = 0;
            this.btTim.ImageList = this.imageList1;
            this.btTim.Location = new System.Drawing.Point(733, 35);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(130, 45);
            this.btTim.TabIndex = 9;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(882, 48);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(261, 22);
            this.txtTimKiem.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn phòng";
            // 
            // cmbPhong
            // 
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Location = new System.Drawing.Point(257, 46);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(237, 24);
            this.cmbPhong.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 351);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1382, 351);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btGiamDan);
            this.panel3.Controls.Add(this.btTangDan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1382, 100);
            this.panel3.TabIndex = 9;
            // 
            // btGiamDan
            // 
            this.btGiamDan.Location = new System.Drawing.Point(699, 27);
            this.btGiamDan.Name = "btGiamDan";
            this.btGiamDan.Size = new System.Drawing.Size(120, 40);
            this.btGiamDan.TabIndex = 7;
            this.btGiamDan.Text = "Giảm dần";
            this.btGiamDan.UseVisualStyleBackColor = true;
            // 
            // btTangDan
            // 
            this.btTangDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTangDan.Location = new System.Drawing.Point(552, 27);
            this.btTangDan.Name = "btTangDan";
            this.btTangDan.Size = new System.Drawing.Size(120, 40);
            this.btTangDan.TabIndex = 8;
            this.btTangDan.Text = "Tăng dần";
            this.btTangDan.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "find.png");
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmThongKe";
            this.Text = "Thống kê";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khenThưởngKỷLuậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btGiamDan;
        private System.Windows.Forms.Button btTangDan;
        private System.Windows.Forms.ImageList imageList1;
    }
}