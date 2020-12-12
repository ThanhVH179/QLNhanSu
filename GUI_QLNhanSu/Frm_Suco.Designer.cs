namespace GUI_QLNhanSu
{
    partial class FrmSuCo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuCo));
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.cmbLoaiSC = new System.Windows.Forms.ComboBox();
            this.txtTenSC = new System.Windows.Forms.TextBox();
            this.txtThiethai = new System.Windows.Forms.TextBox();
            this.txtMaSC = new System.Windows.Forms.TextBox();
            this.lblThiethai = new System.Windows.Forms.Label();
            this.lblLoaiSC = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTenSC = new System.Windows.Forms.Label();
            this.lblMaSC = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSuco = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btDS = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuco)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Location = new System.Drawing.Point(34, 382);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(0, 17);
            this.lblTimkiem.TabIndex = 5;
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
            this.panel1.Controls.Add(this.cmbMaNV);
            this.panel1.Controls.Add(this.cmbLoaiSC);
            this.panel1.Controls.Add(this.txtTenSC);
            this.panel1.Controls.Add(this.txtThiethai);
            this.panel1.Controls.Add(this.txtMaSC);
            this.panel1.Controls.Add(this.lblThiethai);
            this.panel1.Controls.Add(this.lblLoaiSC);
            this.panel1.Controls.Add(this.lblMaNV);
            this.panel1.Controls.Add(this.lblTenSC);
            this.panel1.Controls.Add(this.lblMaSC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 184);
            this.panel1.TabIndex = 32;
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Items.AddRange(new object[] {
            "Tai nạn lao động",
            "Hư hỏng vật chất"});
            this.cmbMaNV.Location = new System.Drawing.Point(451, 80);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(195, 24);
            this.cmbMaNV.TabIndex = 21;
            // 
            // cmbLoaiSC
            // 
            this.cmbLoaiSC.FormattingEnabled = true;
            this.cmbLoaiSC.Items.AddRange(new object[] {
            "Tai nạn lao động",
            "Hư hỏng vật chất"});
            this.cmbLoaiSC.Location = new System.Drawing.Point(815, 124);
            this.cmbLoaiSC.Name = "cmbLoaiSC";
            this.cmbLoaiSC.Size = new System.Drawing.Size(195, 24);
            this.cmbLoaiSC.TabIndex = 21;
            // 
            // txtTenSC
            // 
            this.txtTenSC.Location = new System.Drawing.Point(451, 130);
            this.txtTenSC.Name = "txtTenSC";
            this.txtTenSC.Size = new System.Drawing.Size(195, 22);
            this.txtTenSC.TabIndex = 19;
            // 
            // txtThiethai
            // 
            this.txtThiethai.Location = new System.Drawing.Point(815, 32);
            this.txtThiethai.Multiline = true;
            this.txtThiethai.Name = "txtThiethai";
            this.txtThiethai.Size = new System.Drawing.Size(195, 67);
            this.txtThiethai.TabIndex = 18;
            // 
            // txtMaSC
            // 
            this.txtMaSC.Location = new System.Drawing.Point(451, 32);
            this.txtMaSC.Name = "txtMaSC";
            this.txtMaSC.Size = new System.Drawing.Size(195, 22);
            this.txtMaSC.TabIndex = 17;
            // 
            // lblThiethai
            // 
            this.lblThiethai.AutoSize = true;
            this.lblThiethai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThiethai.Location = new System.Drawing.Point(709, 32);
            this.lblThiethai.Name = "lblThiethai";
            this.lblThiethai.Size = new System.Drawing.Size(70, 18);
            this.lblThiethai.TabIndex = 16;
            this.lblThiethai.Text = "Thiệt Hại:";
            // 
            // lblLoaiSC
            // 
            this.lblLoaiSC.AutoSize = true;
            this.lblLoaiSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSC.Location = new System.Drawing.Point(709, 130);
            this.lblLoaiSC.Name = "lblLoaiSC";
            this.lblLoaiSC.Size = new System.Drawing.Size(65, 18);
            this.lblLoaiSC.TabIndex = 15;
            this.lblLoaiSC.Text = "Loại SC:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(373, 81);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(57, 18);
            this.lblMaNV.TabIndex = 14;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // lblTenSC
            // 
            this.lblTenSC.AutoSize = true;
            this.lblTenSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSC.Location = new System.Drawing.Point(373, 134);
            this.lblTenSC.Name = "lblTenSC";
            this.lblTenSC.Size = new System.Drawing.Size(62, 18);
            this.lblTenSC.TabIndex = 13;
            this.lblTenSC.Text = "Tên SC:";
            // 
            // lblMaSC
            // 
            this.lblMaSC.AutoSize = true;
            this.lblMaSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSC.Location = new System.Drawing.Point(373, 32);
            this.lblMaSC.Name = "lblMaSC";
            this.lblMaSC.Size = new System.Drawing.Size(58, 18);
            this.lblMaSC.TabIndex = 12;
            this.lblMaSC.Text = "Mã SC:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSuco);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 319);
            this.panel2.TabIndex = 33;
            // 
            // dgvSuco
            // 
            this.dgvSuco.AllowUserToAddRows = false;
            this.dgvSuco.AllowUserToDeleteRows = false;
            this.dgvSuco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuco.Location = new System.Drawing.Point(0, 0);
            this.dgvSuco.Name = "dgvSuco";
            this.dgvSuco.RowHeadersVisible = false;
            this.dgvSuco.RowHeadersWidth = 51;
            this.dgvSuco.RowTemplate.Height = 24;
            this.dgvSuco.Size = new System.Drawing.Size(1382, 319);
            this.dgvSuco.TabIndex = 28;
            this.dgvSuco.Click += new System.EventHandler(this.dgvSuco_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btDS);
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.btSua);
            this.panel3.Controls.Add(this.btLuu);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Controls.Add(this.btTimKiem);
            this.panel3.Controls.Add(this.txtTimkiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 509);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1382, 94);
            this.panel3.TabIndex = 34;
            // 
            // btDS
            // 
            this.btDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDS.ImageIndex = 5;
            this.btDS.ImageList = this.imageList1;
            this.btDS.Location = new System.Drawing.Point(1084, 26);
            this.btDS.Name = "btDS";
            this.btDS.Size = new System.Drawing.Size(125, 40);
            this.btDS.TabIndex = 44;
            this.btDS.Text = "Danh sách";
            this.btDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDS.UseVisualStyleBackColor = true;
            this.btDS.Click += new System.EventHandler(this.btDS_Click);
            // 
            // btXoa
            // 
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.ImageIndex = 3;
            this.btXoa.ImageList = this.imageList1;
            this.btXoa.Location = new System.Drawing.Point(978, 26);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 40);
            this.btXoa.TabIndex = 44;
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
            this.btSua.Location = new System.Drawing.Point(872, 26);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 40);
            this.btSua.TabIndex = 43;
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
            this.btLuu.Location = new System.Drawing.Point(766, 26);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 40);
            this.btLuu.TabIndex = 43;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThem
            // 
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.ImageIndex = 0;
            this.btThem.ImageList = this.imageList1;
            this.btThem.Location = new System.Drawing.Point(660, 26);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 40);
            this.btThem.TabIndex = 42;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.ImageIndex = 4;
            this.btTimKiem.ImageList = this.imageList1;
            this.btTimKiem.Location = new System.Drawing.Point(222, 26);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(120, 40);
            this.btTimKiem.TabIndex = 41;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(348, 35);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(250, 22);
            this.txtTimkiem.TabIndex = 40;
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // FrmSuCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTimkiem);
            this.Name = "FrmSuCo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sự cố";
            this.Load += new System.EventHandler(this.FrmSuCo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuco)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbLoaiSC;
        private System.Windows.Forms.TextBox txtTenSC;
        private System.Windows.Forms.TextBox txtThiethai;
        private System.Windows.Forms.TextBox txtMaSC;
        private System.Windows.Forms.Label lblThiethai;
        private System.Windows.Forms.Label lblLoaiSC;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenSC;
        private System.Windows.Forms.Label lblMaSC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSuco;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.Button btDS;
    }
}