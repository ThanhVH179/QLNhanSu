namespace GUI_QLNhanSu
{
    partial class FrmChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChamCong));
            this.imageListButton = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dTPThoigian = new System.Windows.Forms.DateTimePicker();
            this.txtChuthich = new System.Windows.Forms.TextBox();
            this.txtMaCC = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblChuthich = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblMaCC = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListButton
            // 
            this.imageListButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButton.ImageStream")));
            this.imageListButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButton.Images.SetKeyName(0, "add-icon.png");
            this.imageListButton.Images.SetKeyName(1, "Save-icon.png");
            this.imageListButton.Images.SetKeyName(2, "edit.png");
            this.imageListButton.Images.SetKeyName(3, "Actions-edit-delete-icon.png");
            this.imageListButton.Images.SetKeyName(4, "find.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dTPThoigian);
            this.panel1.Controls.Add(this.txtChuthich);
            this.panel1.Controls.Add(this.txtMaCC);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.lblMaNV);
            this.panel1.Controls.Add(this.lblChuthich);
            this.panel1.Controls.Add(this.lblThoiGian);
            this.panel1.Controls.Add(this.lblMaCC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 167);
            this.panel1.TabIndex = 29;
            // 
            // dTPThoigian
            // 
            this.dTPThoigian.Location = new System.Drawing.Point(306, 107);
            this.dTPThoigian.Name = "dTPThoigian";
            this.dTPThoigian.Size = new System.Drawing.Size(220, 22);
            this.dTPThoigian.TabIndex = 25;
            // 
            // txtChuthich
            // 
            this.txtChuthich.Location = new System.Drawing.Point(679, 33);
            this.txtChuthich.Multiline = true;
            this.txtChuthich.Name = "txtChuthich";
            this.txtChuthich.Size = new System.Drawing.Size(240, 80);
            this.txtChuthich.TabIndex = 23;
            // 
            // txtMaCC
            // 
            this.txtMaCC.Location = new System.Drawing.Point(306, 31);
            this.txtMaCC.Name = "txtMaCC";
            this.txtMaCC.Size = new System.Drawing.Size(220, 22);
            this.txtMaCC.TabIndex = 22;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(306, 67);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(220, 22);
            this.txtMaNV.TabIndex = 21;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(202, 72);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(57, 18);
            this.lblMaNV.TabIndex = 20;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // lblChuthich
            // 
            this.lblChuthich.AutoSize = true;
            this.lblChuthich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuthich.Location = new System.Drawing.Point(575, 34);
            this.lblChuthich.Name = "lblChuthich";
            this.lblChuthich.Size = new System.Drawing.Size(74, 18);
            this.lblChuthich.TabIndex = 18;
            this.lblChuthich.Text = "Chú thích:";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(202, 112);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(76, 18);
            this.lblThoiGian.TabIndex = 17;
            this.lblThoiGian.Text = "Thời Gian:";
            // 
            // lblMaCC
            // 
            this.lblMaCC.AutoSize = true;
            this.lblMaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCC.Location = new System.Drawing.Point(202, 34);
            this.lblMaCC.Name = "lblMaCC";
            this.lblMaCC.Size = new System.Drawing.Size(59, 18);
            this.lblMaCC.TabIndex = 16;
            this.lblMaCC.Text = "Mã CC:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvChamCong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 349);
            this.panel2.TabIndex = 30;
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChamCong.Location = new System.Drawing.Point(0, 0);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(1382, 349);
            this.dgvChamCong.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.btLuu);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Controls.Add(this.btTimKiem);
            this.panel3.Controls.Add(this.txtTimkiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 517);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1382, 86);
            this.panel3.TabIndex = 31;
            // 
            // btXoa
            // 
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.ImageIndex = 3;
            this.btXoa.ImageList = this.imageListButton;
            this.btXoa.Location = new System.Drawing.Point(1030, 34);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 40);
            this.btXoa.TabIndex = 31;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.ImageIndex = 0;
            this.btThem.ImageList = this.imageListButton;
            this.btThem.Location = new System.Drawing.Point(752, 34);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 40);
            this.btThem.TabIndex = 33;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btTimKiem
            // 
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.ImageIndex = 4;
            this.btTimKiem.ImageList = this.imageListButton;
            this.btTimKiem.Location = new System.Drawing.Point(299, 34);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(120, 40);
            this.btTimKiem.TabIndex = 30;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(436, 43);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(250, 22);
            this.txtTimkiem.TabIndex = 29;
            // 
            // btLuu
            // 
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.ImageIndex = 1;
            this.btLuu.ImageList = this.imageListButton;
            this.btLuu.Location = new System.Drawing.Point(895, 34);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 40);
            this.btLuu.TabIndex = 33;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // FrmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dTPThoigian;
        private System.Windows.Forms.TextBox txtChuthich;
        private System.Windows.Forms.TextBox txtMaCC;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblChuthich;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblMaCC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Button btLuu;
    }
}