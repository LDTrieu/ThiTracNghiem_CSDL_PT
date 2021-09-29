
namespace ThiTracNghiem_CSDL_PT
{
    partial class frmDangNhap
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
            this.gbTaoLogin = new System.Windows.Forms.GroupBox();
            this.rdSinhVien = new System.Windows.Forms.RadioButton();
            this.rdGiangVien = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.lbCoSo = new System.Windows.Forms.Label();
            this.gbTaoLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTaoLogin
            // 
            this.gbTaoLogin.Controls.Add(this.rdSinhVien);
            this.gbTaoLogin.Controls.Add(this.rdGiangVien);
            this.gbTaoLogin.Controls.Add(this.btnThoat);
            this.gbTaoLogin.Controls.Add(this.btnDangNhap);
            this.gbTaoLogin.Controls.Add(this.txtMatKhau);
            this.gbTaoLogin.Controls.Add(this.txtTaiKhoan);
            this.gbTaoLogin.Controls.Add(this.lbMatKhau);
            this.gbTaoLogin.Controls.Add(this.lbTaiKhoan);
            this.gbTaoLogin.Controls.Add(this.cmbCoSo);
            this.gbTaoLogin.Controls.Add(this.lbCoSo);
            this.gbTaoLogin.Location = new System.Drawing.Point(14, 12);
            this.gbTaoLogin.Name = "gbTaoLogin";
            this.gbTaoLogin.Size = new System.Drawing.Size(937, 425);
            this.gbTaoLogin.TabIndex = 0;
            this.gbTaoLogin.TabStop = false;
            this.gbTaoLogin.Text = "Nhập thông tin";
            this.gbTaoLogin.Enter += new System.EventHandler(this.gbTaoLogin_Enter);
            // 
            // rdSinhVien
            // 
            this.rdSinhVien.AutoSize = true;
            this.rdSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSinhVien.Location = new System.Drawing.Point(521, 69);
            this.rdSinhVien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdSinhVien.Name = "rdSinhVien";
            this.rdSinhVien.Size = new System.Drawing.Size(106, 27);
            this.rdSinhVien.TabIndex = 19;
            this.rdSinhVien.TabStop = true;
            this.rdSinhVien.Text = "Sinh viên";
            this.rdSinhVien.UseVisualStyleBackColor = true;
            this.rdSinhVien.CheckedChanged += new System.EventHandler(this.rdSinhVien_CheckedChanged);
            // 
            // rdGiangVien
            // 
            this.rdGiangVien.AutoSize = true;
            this.rdGiangVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGiangVien.Location = new System.Drawing.Point(266, 69);
            this.rdGiangVien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdGiangVien.Name = "rdGiangVien";
            this.rdGiangVien.Size = new System.Drawing.Size(121, 27);
            this.rdGiangVien.TabIndex = 18;
            this.rdGiangVien.TabStop = true;
            this.rdGiangVien.Text = "Giảng viên";
            this.rdGiangVien.UseVisualStyleBackColor = true;
            this.rdGiangVien.CheckedChanged += new System.EventHandler(this.rdGiangVien_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(510, 319);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 37);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(295, 319);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(145, 37);
            this.btnDangNhap.TabIndex = 16;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(426, 247);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(259, 29);
            this.txtMatKhau.TabIndex = 15;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(426, 187);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(259, 29);
            this.txtTaiKhoan.TabIndex = 14;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(251, 251);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(90, 22);
            this.lbMatKhau.TabIndex = 13;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.Location = new System.Drawing.Point(251, 191);
            this.lbTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(94, 22);
            this.lbTaiKhoan.TabIndex = 12;
            this.lbTaiKhoan.Text = "Tài khoản";
            this.lbTaiKhoan.Click += new System.EventHandler(this.lbTaiKhoan_Click);
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(426, 127);
            this.cmbCoSo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(259, 30);
            this.cmbCoSo.TabIndex = 11;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // lbCoSo
            // 
            this.lbCoSo.AutoSize = true;
            this.lbCoSo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoSo.Location = new System.Drawing.Point(251, 130);
            this.lbCoSo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCoSo.Name = "lbCoSo";
            this.lbCoSo.Size = new System.Drawing.Size(59, 22);
            this.lbCoSo.TabIndex = 10;
            this.lbCoSo.Text = "Cơ sở";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 449);
            this.Controls.Add(this.gbTaoLogin);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.gbTaoLogin.ResumeLayout(false);
            this.gbTaoLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaoLogin;
        private System.Windows.Forms.RadioButton rdSinhVien;
        private System.Windows.Forms.RadioButton rdGiangVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label lbCoSo;
    }
}