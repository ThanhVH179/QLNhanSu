namespace GUI_QLNhanSu
{
    partial class FrmDoiMK
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
            this.lblMKCu = new System.Windows.Forms.Label();
            this.lblMKMoi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDoiMK = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMKCu
            // 
            this.lblMKCu.AutoSize = true;
            this.lblMKCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKCu.Location = new System.Drawing.Point(12, 71);
            this.lblMKCu.Name = "lblMKCu";
            this.lblMKCu.Size = new System.Drawing.Size(89, 18);
            this.lblMKCu.TabIndex = 0;
            this.lblMKCu.Text = "Mật khẩu cũ";
            // 
            // lblMKMoi
            // 
            this.lblMKMoi.AutoSize = true;
            this.lblMKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKMoi.Location = new System.Drawing.Point(12, 119);
            this.lblMKMoi.Name = "lblMKMoi";
            this.lblMKMoi.Size = new System.Drawing.Size(98, 18);
            this.lblMKMoi.TabIndex = 0;
            this.lblMKMoi.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // btDoiMK
            // 
            this.btDoiMK.Location = new System.Drawing.Point(58, 251);
            this.btDoiMK.Name = "btDoiMK";
            this.btDoiMK.Size = new System.Drawing.Size(120, 30);
            this.btDoiMK.TabIndex = 1;
            this.btDoiMK.Text = "Đổi mật khẩu";
            this.btDoiMK.UseVisualStyleBackColor = true;
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(200, 251);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(120, 30);
            this.btHuy.TabIndex = 1;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(162, 71);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(180, 22);
            this.txtMKCu.TabIndex = 2;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(162, 115);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(180, 22);
            this.txtMKMoi.TabIndex = 2;
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Location = new System.Drawing.Point(162, 166);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(180, 22);
            this.txtNhapLaiMK.TabIndex = 2;
            // 
            // FrmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 353);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btDoiMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMKMoi);
            this.Controls.Add(this.lblMKCu);
            this.Name = "FrmDoiMK";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMKCu;
        private System.Windows.Forms.Label lblMKMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDoiMK;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
    }
}