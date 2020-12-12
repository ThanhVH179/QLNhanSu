namespace GUI_QLNhanSu
{
    partial class FrmLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLuong));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.txtHeSoPhuCap = new System.Windows.Forms.TextBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.txtBacLuong = new System.Windows.Forms.TextBox();
            this.lblHesophucap = new System.Windows.Forms.Label();
            this.lblHesoluong = new System.Windows.Forms.Label();
            this.lblLuongcoban = new System.Windows.Forms.Label();
            this.lblBacluong = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btDS = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Save-icon.png");
            this.imageList1.Images.SetKeyName(2, "edit.png");
            this.imageList1.Images.SetKeyName(3, "Actions-edit-delete-icon.png");
            this.imageList1.Images.SetKeyName(4, "find.png");
            this.imageList1.Images.SetKeyName(5, "Data-List-icon.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHeSoLuong);
            this.panel1.Controls.Add(this.txtHeSoPhuCap);
            this.panel1.Controls.Add(this.txtLuongCoBan);
            this.panel1.Controls.Add(this.txtBacLuong);
            this.panel1.Controls.Add(this.lblHesophucap);
            this.panel1.Controls.Add(this.lblHesoluong);
            this.panel1.Controls.Add(this.lblLuongcoban);
            this.panel1.Controls.Add(this.lblBacluong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 158);
            this.panel1.TabIndex = 30;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Enabled = false;
            this.txtHeSoLuong.Location = new System.Drawing.Point(691, 45);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(216, 22);
            this.txtHeSoLuong.TabIndex = 3;
            // 
            // txtHeSoPhuCap
            // 
            this.txtHeSoPhuCap.Enabled = false;
            this.txtHeSoPhuCap.Location = new System.Drawing.Point(691, 91);
            this.txtHeSoPhuCap.Name = "txtHeSoPhuCap";
            this.txtHeSoPhuCap.Size = new System.Drawing.Size(216, 22);
            this.txtHeSoPhuCap.TabIndex = 4;
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Enabled = false;
            this.txtLuongCoBan.Location = new System.Drawing.Point(312, 92);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(216, 22);
            this.txtLuongCoBan.TabIndex = 2;
            // 
            // txtBacLuong
            // 
            this.txtBacLuong.Enabled = false;
            this.txtBacLuong.Location = new System.Drawing.Point(312, 45);
            this.txtBacLuong.Name = "txtBacLuong";
            this.txtBacLuong.Size = new System.Drawing.Size(216, 22);
            this.txtBacLuong.TabIndex = 1;
            // 
            // lblHesophucap
            // 
            this.lblHesophucap.AutoSize = true;
            this.lblHesophucap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHesophucap.Location = new System.Drawing.Point(563, 95);
            this.lblHesophucap.Name = "lblHesophucap";
            this.lblHesophucap.Size = new System.Drawing.Size(108, 18);
            this.lblHesophucap.TabIndex = 11;
            this.lblHesophucap.Text = "Hệ số phụ cấp:";
            // 
            // lblHesoluong
            // 
            this.lblHesoluong.AutoSize = true;
            this.lblHesoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHesoluong.Location = new System.Drawing.Point(563, 46);
            this.lblHesoluong.Name = "lblHesoluong";
            this.lblHesoluong.Size = new System.Drawing.Size(92, 18);
            this.lblHesoluong.TabIndex = 10;
            this.lblHesoluong.Text = "Hệ số lương:";
            // 
            // lblLuongcoban
            // 
            this.lblLuongcoban.AutoSize = true;
            this.lblLuongcoban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuongcoban.Location = new System.Drawing.Point(184, 95);
            this.lblLuongcoban.Name = "lblLuongcoban";
            this.lblLuongcoban.Size = new System.Drawing.Size(102, 18);
            this.lblLuongcoban.TabIndex = 9;
            this.lblLuongcoban.Text = "Lương cơ bản:";
            // 
            // lblBacluong
            // 
            this.lblBacluong.AutoSize = true;
            this.lblBacluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacluong.Location = new System.Drawing.Point(184, 46);
            this.lblBacluong.Name = "lblBacluong";
            this.lblBacluong.Size = new System.Drawing.Size(78, 18);
            this.lblBacluong.TabIndex = 8;
            this.lblBacluong.Text = "Bậc lương:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLuong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 339);
            this.panel2.TabIndex = 31;
            // 
            // dgvLuong
            // 
            this.dgvLuong.AllowUserToAddRows = false;
            this.dgvLuong.AllowUserToDeleteRows = false;
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuong.Location = new System.Drawing.Point(0, 0);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.RowHeadersVisible = false;
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 24;
            this.dgvLuong.Size = new System.Drawing.Size(1301, 339);
            this.dgvLuong.TabIndex = 9;
            this.dgvLuong.Click += new System.EventHandler(this.dgvLuong_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btDS);
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.btSua);
            this.panel3.Controls.Add(this.btLuu);
            this.panel3.Controls.Add(this.btTimKiem);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Controls.Add(this.txtTimkiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1301, 100);
            this.panel3.TabIndex = 32;
            // 
            // btXoa
            // 
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.ImageIndex = 3;
            this.btXoa.ImageList = this.imageList1;
            this.btXoa.Location = new System.Drawing.Point(957, 36);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 40);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.ImageIndex = 2;
            this.btSua.ImageList = this.imageList1;
            this.btSua.Location = new System.Drawing.Point(831, 36);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 40);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.ImageIndex = 1;
            this.btLuu.ImageList = this.imageList1;
            this.btLuu.Location = new System.Drawing.Point(706, 36);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 40);
            this.btLuu.TabIndex = 8;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.ImageIndex = 4;
            this.btTimKiem.ImageList = this.imageList1;
            this.btTimKiem.Location = new System.Drawing.Point(133, 36);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(120, 40);
            this.btTimKiem.TabIndex = 5;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThem
            // 
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.ImageIndex = 0;
            this.btThem.ImageList = this.imageList1;
            this.btThem.Location = new System.Drawing.Point(579, 36);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 40);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.LightGray;
            this.txtTimkiem.Location = new System.Drawing.Point(268, 45);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(250, 22);
            this.txtTimkiem.TabIndex = 6;
            this.txtTimkiem.Text = "Mời nhập bậc lương...";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // btDS
            // 
            this.btDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDS.ImageIndex = 5;
            this.btDS.ImageList = this.imageList1;
            this.btDS.Location = new System.Drawing.Point(1083, 36);
            this.btDS.Name = "btDS";
            this.btDS.Size = new System.Drawing.Size(125, 40);
            this.btDS.TabIndex = 45;
            this.btDS.Text = "Danh sách";
            this.btDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDS.UseVisualStyleBackColor = true;
            // 
            // FrmLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lương";
            this.Load += new System.EventHandler(this.FrmLuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.TextBox txtHeSoPhuCap;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtBacLuong;
        private System.Windows.Forms.Label lblHesophucap;
        private System.Windows.Forms.Label lblHesoluong;
        private System.Windows.Forms.Label lblLuongcoban;
        private System.Windows.Forms.Label lblBacluong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btDS;
    }
}