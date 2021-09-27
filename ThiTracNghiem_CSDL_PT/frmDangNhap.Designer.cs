
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnTaoLogin = new System.Windows.Forms.Button();
            this.btnHuyTao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdNhomQuyen = new System.Windows.Forms.ComboBox();
            this.cmbGiangVienTheoCS = new System.Windows.Forms.ComboBox();
            this.checkbox_Pass = new System.Windows.Forms.CheckBox();
            this.gbTaoLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTaoLogin
            // 
            this.gbTaoLogin.Controls.Add(this.checkbox_Pass);
            this.gbTaoLogin.Controls.Add(this.cmbGiangVienTheoCS);
            this.gbTaoLogin.Controls.Add(this.cmdNhomQuyen);
            this.gbTaoLogin.Controls.Add(this.label3);
            this.gbTaoLogin.Controls.Add(this.label2);
            this.gbTaoLogin.Controls.Add(this.label1);
            this.gbTaoLogin.Controls.Add(this.btnHuyTao);
            this.gbTaoLogin.Controls.Add(this.btnTaoLogin);
            this.gbTaoLogin.Controls.Add(this.txtMatKhau);
            this.gbTaoLogin.Controls.Add(this.txtLoginName);
            this.gbTaoLogin.Controls.Add(this.lbMatKhau);
            this.gbTaoLogin.Controls.Add(this.lbLogin);
            this.gbTaoLogin.Location = new System.Drawing.Point(12, 12);
            this.gbTaoLogin.Name = "gbTaoLogin";
            this.gbTaoLogin.Size = new System.Drawing.Size(820, 425);
            this.gbTaoLogin.TabIndex = 0;
            this.gbTaoLogin.TabStop = false;
            this.gbTaoLogin.Text = "Nhập thông tin";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(131, 135);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(84, 17);
            this.lbLogin.TabIndex = 3;
            this.lbLogin.Text = "Login name:";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(134, 185);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(71, 17);
            this.lbMatKhau.TabIndex = 4;
            this.lbMatKhau.Text = "Password:";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(293, 135);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(244, 23);
            this.txtLoginName.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(293, 182);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(244, 23);
            this.txtMatKhau.TabIndex = 6;
            // 
            // btnTaoLogin
            // 
            this.btnTaoLogin.Location = new System.Drawing.Point(228, 328);
            this.btnTaoLogin.Name = "btnTaoLogin";
            this.btnTaoLogin.Size = new System.Drawing.Size(120, 33);
            this.btnTaoLogin.TabIndex = 7;
            this.btnTaoLogin.Text = "Tạo Login";
            this.btnTaoLogin.UseVisualStyleBackColor = true;
            // 
            // btnHuyTao
            // 
            this.btnHuyTao.Location = new System.Drawing.Point(389, 323);
            this.btnHuyTao.Name = "btnHuyTao";
            this.btnHuyTao.Size = new System.Drawing.Size(119, 38);
            this.btnHuyTao.TabIndex = 8;
            this.btnHuyTao.Text = "Hủy tạo";
            this.btnHuyTao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tạo Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Giảng viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nhóm quyền:";
            // 
            // cmdNhomQuyen
            // 
            this.cmdNhomQuyen.FormattingEnabled = true;
            this.cmdNhomQuyen.Location = new System.Drawing.Point(293, 267);
            this.cmdNhomQuyen.Name = "cmdNhomQuyen";
            this.cmdNhomQuyen.Size = new System.Drawing.Size(244, 24);
            this.cmdNhomQuyen.TabIndex = 12;
            // 
            // cmbGiangVienTheoCS
            // 
            this.cmbGiangVienTheoCS.FormattingEnabled = true;
            this.cmbGiangVienTheoCS.Location = new System.Drawing.Point(293, 79);
            this.cmbGiangVienTheoCS.Name = "cmbGiangVienTheoCS";
            this.cmbGiangVienTheoCS.Size = new System.Drawing.Size(244, 24);
            this.cmbGiangVienTheoCS.TabIndex = 13;
            // 
            // checkbox_Pass
            // 
            this.checkbox_Pass.AutoSize = true;
            this.checkbox_Pass.Location = new System.Drawing.Point(570, 185);
            this.checkbox_Pass.Name = "checkbox_Pass";
            this.checkbox_Pass.Size = new System.Drawing.Size(137, 21);
            this.checkbox_Pass.TabIndex = 14;
            this.checkbox_Pass.Text = "Hiển thị Password";
            this.checkbox_Pass.UseVisualStyleBackColor = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 449);
            this.Controls.Add(this.gbTaoLogin);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.gbTaoLogin.ResumeLayout(false);
            this.gbTaoLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaoLogin;
        private System.Windows.Forms.Button btnHuyTao;
        private System.Windows.Forms.Button btnTaoLogin;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.CheckBox checkbox_Pass;
        private System.Windows.Forms.ComboBox cmbGiangVienTheoCS;
        private System.Windows.Forms.ComboBox cmdNhomQuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}