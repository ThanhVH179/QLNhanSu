namespace GUI_QLNhanSu
{
    partial class FrmDangNhap
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
            this.lbl_PMQLNS = new System.Windows.Forms.Label();
            this.lbl_TK = new System.Windows.Forms.Label();
            this.lbl_MK = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btQuenMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_PMQLNS
            // 
            this.lbl_PMQLNS.AutoSize = true;
            this.lbl_PMQLNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PMQLNS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_PMQLNS.Location = new System.Drawing.Point(77, 34);
            this.lbl_PMQLNS.Name = "lbl_PMQLNS";
            this.lbl_PMQLNS.Size = new System.Drawing.Size(273, 25);
            this.lbl_PMQLNS.TabIndex = 0;
            this.lbl_PMQLNS.Text = "Phần mềm quản lý nhân sự";
            // 
            // lbl_TK
            // 
            this.lbl_TK.AutoSize = true;
            this.lbl_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TK.Location = new System.Drawing.Point(45, 101);
            this.lbl_TK.Name = "lbl_TK";
            this.lbl_TK.Size = new System.Drawing.Size(77, 18);
            this.lbl_TK.TabIndex = 1;
            this.lbl_TK.Text = "Tài khoản:";
            // 
            // lbl_MK
            // 
            this.lbl_MK.AutoSize = true;
            this.lbl_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MK.Location = new System.Drawing.Point(45, 152);
            this.lbl_MK.Name = "lbl_MK";
            this.lbl_MK.Size = new System.Drawing.Size(73, 18);
            this.lbl_MK.TabIndex = 2;
            this.lbl_MK.Text = "Mật khẩu:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(128, 100);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(250, 22);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(128, 152);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(250, 22);
            this.txtMatKhau.TabIndex = 2;
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.btDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btDangNhap.Location = new System.Drawing.Point(69, 235);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(109, 40);
            this.btDangNhap.TabIndex = 3;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btQuenMatKhau
            // 
            this.btQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuenMatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btQuenMatKhau.Location = new System.Drawing.Point(219, 234);
            this.btQuenMatKhau.Name = "btQuenMatKhau";
            this.btQuenMatKhau.Size = new System.Drawing.Size(152, 40);
            this.btQuenMatKhau.TabIndex = 4;
            this.btQuenMatKhau.Text = "Quên mật khẩu";
            this.btQuenMatKhau.UseVisualStyleBackColor = true;
            // 
            // FrmDangNhap
            // 
            this.AcceptButton = this.btDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 353);
            this.Controls.Add(this.btQuenMatKhau);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lbl_MK);
            this.Controls.Add(this.lbl_TK);
            this.Controls.Add(this.lbl_PMQLNS);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PMQLNS;
        private System.Windows.Forms.Label lbl_TK;
        private System.Windows.Forms.Label lbl_MK;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btQuenMatKhau;
    }
}

