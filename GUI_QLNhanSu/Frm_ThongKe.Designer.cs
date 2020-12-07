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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.tabLuong = new System.Windows.Forms.TabPage();
            this.tabChamCong = new System.Windows.Forms.TabPage();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.btTKPhong = new System.Windows.Forms.Button();
            this.txtTKPhong = new System.Windows.Forms.TextBox();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.btTKChamCong = new System.Windows.Forms.Button();
            this.txtTKChamCong = new System.Windows.Forms.TextBox();
            this.btDanhSach = new System.Windows.Forms.Button();
            this.btDSChamCong = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPhong.SuspendLayout();
            this.tabLuong.SuspendLayout();
            this.tabChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "find.png");
            this.imageList1.Images.SetKeyName(1, "Data-List-icon.png");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPhong);
            this.tabControl.Controls.Add(this.tabLuong);
            this.tabControl.Controls.Add(this.tabChamCong);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-1, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1386, 586);
            this.tabControl.TabIndex = 0;
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.btDanhSach);
            this.tabPhong.Controls.Add(this.txtTKPhong);
            this.tabPhong.Controls.Add(this.btTKPhong);
            this.tabPhong.Controls.Add(this.dgvPhongBan);
            this.tabPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPhong.Location = new System.Drawing.Point(4, 31);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(1378, 551);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Phòng";
            this.tabPhong.UseVisualStyleBackColor = true;
            // 
            // tabLuong
            // 
            this.tabLuong.Controls.Add(this.dgvLuong);
            this.tabLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLuong.Location = new System.Drawing.Point(4, 31);
            this.tabLuong.Name = "tabLuong";
            this.tabLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabLuong.Size = new System.Drawing.Size(1378, 551);
            this.tabLuong.TabIndex = 1;
            this.tabLuong.Text = "Lương";
            this.tabLuong.UseVisualStyleBackColor = true;
            // 
            // tabChamCong
            // 
            this.tabChamCong.Controls.Add(this.btDSChamCong);
            this.tabChamCong.Controls.Add(this.txtTKChamCong);
            this.tabChamCong.Controls.Add(this.btTKChamCong);
            this.tabChamCong.Controls.Add(this.dgvChamCong);
            this.tabChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabChamCong.Location = new System.Drawing.Point(4, 31);
            this.tabChamCong.Name = "tabChamCong";
            this.tabChamCong.Size = new System.Drawing.Size(1378, 551);
            this.tabChamCong.TabIndex = 2;
            this.tabChamCong.Text = "Chấm công";
            this.tabChamCong.UseVisualStyleBackColor = true;
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.AllowUserToDeleteRows = false;
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(6, 130);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.RowHeadersVisible = false;
            this.dgvPhongBan.RowHeadersWidth = 51;
            this.dgvPhongBan.RowTemplate.Height = 24;
            this.dgvPhongBan.Size = new System.Drawing.Size(1361, 415);
            this.dgvPhongBan.TabIndex = 0;
            // 
            // btTKPhong
            // 
            this.btTKPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTKPhong.ImageIndex = 0;
            this.btTKPhong.ImageList = this.imageList1;
            this.btTKPhong.Location = new System.Drawing.Point(319, 43);
            this.btTKPhong.Name = "btTKPhong";
            this.btTKPhong.Size = new System.Drawing.Size(150, 50);
            this.btTKPhong.TabIndex = 5;
            this.btTKPhong.Text = "Tìm kiếm";
            this.btTKPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTKPhong.UseVisualStyleBackColor = true;
            this.btTKPhong.Click += new System.EventHandler(this.btTKPhong_Click);
            // 
            // txtTKPhong
            // 
            this.txtTKPhong.BackColor = System.Drawing.Color.LightGray;
            this.txtTKPhong.Location = new System.Drawing.Point(498, 54);
            this.txtTKPhong.Name = "txtTKPhong";
            this.txtTKPhong.Size = new System.Drawing.Size(370, 28);
            this.txtTKPhong.TabIndex = 6;
            this.txtTKPhong.Text = "Mời nhập tên phòng ... ";
            this.txtTKPhong.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // dgvLuong
            // 
            this.dgvLuong.AllowUserToAddRows = false;
            this.dgvLuong.AllowUserToDeleteRows = false;
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Location = new System.Drawing.Point(11, 64);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.RowHeadersVisible = false;
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 24;
            this.dgvLuong.Size = new System.Drawing.Size(1361, 481);
            this.dgvLuong.TabIndex = 0;
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AllowUserToDeleteRows = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Location = new System.Drawing.Point(3, 129);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersVisible = false;
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(1372, 428);
            this.dgvChamCong.TabIndex = 0;
            // 
            // btTKChamCong
            // 
            this.btTKChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTKChamCong.ImageIndex = 0;
            this.btTKChamCong.ImageList = this.imageList1;
            this.btTKChamCong.Location = new System.Drawing.Point(230, 44);
            this.btTKChamCong.Name = "btTKChamCong";
            this.btTKChamCong.Size = new System.Drawing.Size(150, 50);
            this.btTKChamCong.TabIndex = 6;
            this.btTKChamCong.Text = "Tìm kiếm";
            this.btTKChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTKChamCong.UseVisualStyleBackColor = true;
            this.btTKChamCong.Click += new System.EventHandler(this.btTKChamCong_Click);
            // 
            // txtTKChamCong
            // 
            this.txtTKChamCong.BackColor = System.Drawing.Color.LightGray;
            this.txtTKChamCong.Location = new System.Drawing.Point(430, 55);
            this.txtTKChamCong.Name = "txtTKChamCong";
            this.txtTKChamCong.Size = new System.Drawing.Size(370, 28);
            this.txtTKChamCong.TabIndex = 7;
            this.txtTKChamCong.Text = "Mời nhập mã ... ";
            this.txtTKChamCong.Click += new System.EventHandler(this.txtTKChamCong_Click);
            // 
            // btDanhSach
            // 
            this.btDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDanhSach.ImageIndex = 1;
            this.btDanhSach.ImageList = this.imageList1;
            this.btDanhSach.Location = new System.Drawing.Point(1217, 43);
            this.btDanhSach.Name = "btDanhSach";
            this.btDanhSach.Size = new System.Drawing.Size(150, 50);
            this.btDanhSach.TabIndex = 7;
            this.btDanhSach.Text = "Danh sách";
            this.btDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDanhSach.UseVisualStyleBackColor = true;
            this.btDanhSach.Click += new System.EventHandler(this.btDanhSach_Click);
            // 
            // btDSChamCong
            // 
            this.btDSChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDSChamCong.ImageIndex = 1;
            this.btDSChamCong.ImageList = this.imageList1;
            this.btDSChamCong.Location = new System.Drawing.Point(1121, 44);
            this.btDSChamCong.Name = "btDSChamCong";
            this.btDSChamCong.Size = new System.Drawing.Size(150, 50);
            this.btDSChamCong.TabIndex = 8;
            this.btDSChamCong.Text = "Danh sách";
            this.btDSChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDSChamCong.UseVisualStyleBackColor = true;
            this.btDSChamCong.Click += new System.EventHandler(this.btDScc_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 603);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();
            this.tabLuong.ResumeLayout(false);
            this.tabChamCong.ResumeLayout(false);
            this.tabChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.TabPage tabLuong;
        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.Button btTKPhong;
        private System.Windows.Forms.TextBox txtTKPhong;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.TextBox txtTKChamCong;
        private System.Windows.Forms.Button btTKChamCong;
        private System.Windows.Forms.Button btDanhSach;
        private System.Windows.Forms.Button btDSChamCong;
    }
}