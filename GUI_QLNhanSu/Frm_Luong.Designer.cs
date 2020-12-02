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
            this.txtHesoluong = new System.Windows.Forms.TextBox();
            this.txtHesophucap = new System.Windows.Forms.TextBox();
            this.txtLuongcoban = new System.Windows.Forms.TextBox();
            this.txtBacluong = new System.Windows.Forms.TextBox();
            this.lblHesophucap = new System.Windows.Forms.Label();
            this.lblHesoluong = new System.Windows.Forms.Label();
            this.lblLuongcoban = new System.Windows.Forms.Label();
            this.lblBacluong = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
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
            this.imageList1.Images.SetKeyName(1, "edit.png");
            this.imageList1.Images.SetKeyName(2, "Actions-edit-delete-icon.png");
            this.imageList1.Images.SetKeyName(3, "find.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHesoluong);
            this.panel1.Controls.Add(this.txtHesophucap);
            this.panel1.Controls.Add(this.txtLuongcoban);
            this.panel1.Controls.Add(this.txtBacluong);
            this.panel1.Controls.Add(this.lblHesophucap);
            this.panel1.Controls.Add(this.lblHesoluong);
            this.panel1.Controls.Add(this.lblLuongcoban);
            this.panel1.Controls.Add(this.lblBacluong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 158);
            this.panel1.TabIndex = 30;
            // 
            // txtHesoluong
            // 
            this.txtHesoluong.Location = new System.Drawing.Point(691, 45);
            this.txtHesoluong.Name = "txtHesoluong";
            this.txtHesoluong.Size = new System.Drawing.Size(216, 22);
            this.txtHesoluong.TabIndex = 15;
            // 
            // txtHesophucap
            // 
            this.txtHesophucap.Location = new System.Drawing.Point(691, 91);
            this.txtHesophucap.Name = "txtHesophucap";
            this.txtHesophucap.Size = new System.Drawing.Size(216, 22);
            this.txtHesophucap.TabIndex = 14;
            // 
            // txtLuongcoban
            // 
            this.txtLuongcoban.Location = new System.Drawing.Point(312, 92);
            this.txtLuongcoban.Name = "txtLuongcoban";
            this.txtLuongcoban.Size = new System.Drawing.Size(216, 22);
            this.txtLuongcoban.TabIndex = 13;
            // 
            // txtBacluong
            // 
            this.txtBacluong.Location = new System.Drawing.Point(312, 45);
            this.txtBacluong.Name = "txtBacluong";
            this.txtBacluong.Size = new System.Drawing.Size(216, 22);
            this.txtBacluong.TabIndex = 12;
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
            this.panel2.Size = new System.Drawing.Size(1182, 339);
            this.panel2.TabIndex = 31;
            // 
            // dgvLuong
            // 
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuong.Location = new System.Drawing.Point(0, 0);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 24;
            this.dgvLuong.Size = new System.Drawing.Size(1182, 339);
            this.dgvLuong.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.btSua);
            this.panel3.Controls.Add(this.btTimKiem);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Controls.Add(this.txtTimkiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 100);
            this.panel3.TabIndex = 32;
            // 
            // btXoa
            // 
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.ImageIndex = 2;
            this.btXoa.ImageList = this.imageList1;
            this.btXoa.Location = new System.Drawing.Point(884, 36);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 40);
            this.btXoa.TabIndex = 34;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.ImageIndex = 1;
            this.btSua.ImageList = this.imageList1;
            this.btSua.Location = new System.Drawing.Point(768, 36);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 40);
            this.btSua.TabIndex = 33;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btTimKiem
            // 
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.ImageIndex = 3;
            this.btTimKiem.ImageList = this.imageList1;
            this.btTimKiem.Location = new System.Drawing.Point(199, 36);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(120, 40);
            this.btTimKiem.TabIndex = 31;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.ImageIndex = 0;
            this.btThem.ImageList = this.imageList1;
            this.btThem.Location = new System.Drawing.Point(645, 36);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 40);
            this.btThem.TabIndex = 32;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(334, 45);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(250, 22);
            this.txtTimkiem.TabIndex = 30;
            // 
            // FrmLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lương";
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
        private System.Windows.Forms.TextBox txtHesoluong;
        private System.Windows.Forms.TextBox txtHesophucap;
        private System.Windows.Forms.TextBox txtLuongcoban;
        private System.Windows.Forms.TextBox txtBacluong;
        private System.Windows.Forms.Label lblHesophucap;
        private System.Windows.Forms.Label lblHesoluong;
        private System.Windows.Forms.Label lblLuongcoban;
        private System.Windows.Forms.Label lblBacluong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtTimkiem;
    }
}