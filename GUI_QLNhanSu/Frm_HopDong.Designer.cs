namespace GUI_QLNhanSu
{
    partial class FrmHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHopDong));
            this.imageListBt = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoaiHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.cbbLoaiHD = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblNgayKy = new System.Windows.Forms.Label();
            this.txtNhanvien = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btThem = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListBt
            // 
            this.imageListBt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBt.ImageStream")));
            this.imageListBt.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBt.Images.SetKeyName(0, "add-icon.png");
            this.imageListBt.Images.SetKeyName(1, "edit.png");
            this.imageListBt.Images.SetKeyName(2, "Actions-edit-delete-icon.png");
            this.imageListBt.Images.SetKeyName(3, "find.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLoaiHD);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.lblMaHD);
            this.panel1.Controls.Add(this.cbbLoaiHD);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblNgayKetThuc);
            this.panel1.Controls.Add(this.lblNgayKy);
            this.panel1.Controls.Add(this.txtNhanvien);
            this.panel1.Controls.Add(this.lblMaNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 189);
            this.panel1.TabIndex = 28;
            // 
            // lblLoaiHD
            // 
            this.lblLoaiHD.AutoSize = true;
            this.lblLoaiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHD.Location = new System.Drawing.Point(163, 75);
            this.lblLoaiHD.Name = "lblLoaiHD";
            this.lblLoaiHD.Size = new System.Drawing.Size(66, 18);
            this.lblLoaiHD.TabIndex = 31;
            this.lblLoaiHD.Text = "Loại HD:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(256, 16);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(229, 22);
            this.txtMaHD.TabIndex = 30;
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(163, 16);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(59, 18);
            this.lblMaHD.TabIndex = 29;
            this.lblMaHD.Text = "Mã HD:";
            // 
            // cbbLoaiHD
            // 
            this.cbbLoaiHD.FormattingEnabled = true;
            this.cbbLoaiHD.Location = new System.Drawing.Point(256, 75);
            this.cbbLoaiHD.Name = "cbbLoaiHD";
            this.cbbLoaiHD.Size = new System.Drawing.Size(229, 24);
            this.cbbLoaiHD.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(640, 73);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(521, 75);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(102, 18);
            this.lblNgayKetThuc.TabIndex = 25;
            this.lblNgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // lblNgayKy
            // 
            this.lblNgayKy.AutoSize = true;
            this.lblNgayKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKy.Location = new System.Drawing.Point(163, 145);
            this.lblNgayKy.Name = "lblNgayKy";
            this.lblNgayKy.Size = new System.Drawing.Size(65, 18);
            this.lblNgayKy.TabIndex = 24;
            this.lblNgayKy.Text = "Ngày ký:";
            // 
            // txtNhanvien
            // 
            this.txtNhanvien.Location = new System.Drawing.Point(623, 16);
            this.txtNhanvien.Name = "txtNhanvien";
            this.txtNhanvien.Size = new System.Drawing.Size(229, 22);
            this.txtNhanvien.TabIndex = 23;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(541, 16);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(57, 18);
            this.lblMaNV.TabIndex = 22;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvHopDong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 336);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Controls.Add(this.btTimKiem);
            this.panel3.Controls.Add(this.txtTimkiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 525);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 107);
            this.panel3.TabIndex = 30;
            // 
            // btThem
            // 
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.ImageIndex = 0;
            this.btThem.ImageList = this.imageListBt;
            this.btThem.Location = new System.Drawing.Point(790, 35);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 40);
            this.btThem.TabIndex = 36;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btTimKiem
            // 
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.ImageIndex = 3;
            this.btTimKiem.ImageList = this.imageListBt;
            this.btTimKiem.Location = new System.Drawing.Point(337, 35);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(120, 40);
            this.btTimKiem.TabIndex = 35;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(474, 44);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(250, 22);
            this.txtTimkiem.TabIndex = 34;
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHopDong.Location = new System.Drawing.Point(0, 0);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.RowTemplate.Height = 24;
            this.dgvHopDong.Size = new System.Drawing.Size(982, 336);
            this.dgvHopDong.TabIndex = 25;
            // 
            // FrmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hợp đồng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListBt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoaiHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.ComboBox cbbLoaiHD;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblNgayKy;
        private System.Windows.Forms.TextBox txtNhanvien;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridView dgvHopDong;
    }
}