
namespace ThiTracNghiem_CSDL_PT
{
    partial class frmTaoLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkbox_PASS = new System.Windows.Forms.CheckBox();
            this.btn_HUY = new System.Windows.Forms.Button();
            this.btn_TAO = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_NHOM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_GVTHEOCS = new System.Windows.Forms.ComboBox();
            this.txt_PASS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LOGIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkbox_PASS);
            this.groupBox1.Controls.Add(this.btn_HUY);
            this.groupBox1.Controls.Add(this.btn_TAO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_NHOM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_GVTHEOCS);
            this.groupBox1.Controls.Add(this.txt_PASS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_LOGIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox1.Size = new System.Drawing.Size(1029, 530);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // checkbox_PASS
            // 
            this.checkbox_PASS.AutoSize = true;
            this.checkbox_PASS.Location = new System.Drawing.Point(753, 267);
            this.checkbox_PASS.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox_PASS.Name = "checkbox_PASS";
            this.checkbox_PASS.Size = new System.Drawing.Size(143, 21);
            this.checkbox_PASS.TabIndex = 13;
            this.checkbox_PASS.Text = "Hiển thị Password";
            this.checkbox_PASS.UseVisualStyleBackColor = true;
            // 
            // btn_HUY
            // 
            this.btn_HUY.Location = new System.Drawing.Point(577, 443);
            this.btn_HUY.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HUY.Name = "btn_HUY";
            this.btn_HUY.Size = new System.Drawing.Size(137, 48);
            this.btn_HUY.TabIndex = 11;
            this.btn_HUY.Text = "Hủy tạo ";
            this.btn_HUY.UseVisualStyleBackColor = true;
            // 
            // btn_TAO
            // 
            this.btn_TAO.Location = new System.Drawing.Point(273, 443);
            this.btn_TAO.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TAO.Name = "btn_TAO";
            this.btn_TAO.Size = new System.Drawing.Size(141, 48);
            this.btn_TAO.TabIndex = 10;
            this.btn_TAO.Text = "Tạo login";
            this.btn_TAO.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhóm quyền:";
            // 
            // cmb_NHOM
            // 
            this.cmb_NHOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NHOM.FormattingEnabled = true;
            this.cmb_NHOM.Items.AddRange(new object[] {
            "CƠ SỞ",
            "GIẢNG VIÊN"});
            this.cmb_NHOM.Location = new System.Drawing.Point(289, 347);
            this.cmb_NHOM.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_NHOM.Name = "cmb_NHOM";
            this.cmb_NHOM.Size = new System.Drawing.Size(440, 24);
            this.cmb_NHOM.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giảng viên:";
            // 
            // cmb_GVTHEOCS
            // 
            this.cmb_GVTHEOCS.DisplayMember = "HOTEN";
            this.cmb_GVTHEOCS.FormattingEnabled = true;
            this.cmb_GVTHEOCS.Location = new System.Drawing.Point(289, 119);
            this.cmb_GVTHEOCS.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_GVTHEOCS.Name = "cmb_GVTHEOCS";
            this.cmb_GVTHEOCS.Size = new System.Drawing.Size(440, 24);
            this.cmb_GVTHEOCS.TabIndex = 6;
            this.cmb_GVTHEOCS.ValueMember = "MAGV";
            // 
            // txt_PASS
            // 
            this.txt_PASS.Location = new System.Drawing.Point(289, 265);
            this.txt_PASS.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PASS.Name = "txt_PASS";
            this.txt_PASS.Size = new System.Drawing.Size(440, 22);
            this.txt_PASS.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txt_LOGIN
            // 
            this.txt_LOGIN.Location = new System.Drawing.Point(289, 190);
            this.txt_LOGIN.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LOGIN.Name = "txt_LOGIN";
            this.txt_LOGIN.Size = new System.Drawing.Size(440, 22);
            this.txt_LOGIN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO LOGIN";
            // 
            // frmTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTaoLogin";
            this.Text = "Tạo Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkbox_PASS;
        private System.Windows.Forms.Button btn_HUY;
        private System.Windows.Forms.Button btn_TAO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_NHOM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_GVTHEOCS;
        private System.Windows.Forms.TextBox txt_PASS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LOGIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}