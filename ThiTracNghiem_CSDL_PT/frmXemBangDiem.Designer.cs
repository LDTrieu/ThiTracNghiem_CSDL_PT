
namespace ThiTracNghiem_CSDL_PT
{
    partial class frmXemBangDiem
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.btnXemBangDiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLAN = new System.Windows.Forms.ComboBox();
            this.cmbMONTHI = new System.Windows.Forms.ComboBox();
            this.cmbLOP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.button1.Location = new System.Drawing.Point(578, 376);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 63);
            this.button1.TabIndex = 33;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "CƠ SỞ";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DisplayMember = "TENPM";
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(180, 209);
            this.cmbCoSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(197, 27);
            this.cmbCoSo.TabIndex = 31;
            this.cmbCoSo.ValueMember = "TENSERVER";
            // 
            // btnXemBangDiem
            // 
            this.btnXemBangDiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBangDiem.Location = new System.Drawing.Point(276, 376);
            this.btnXemBangDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemBangDiem.Name = "btnXemBangDiem";
            this.btnXemBangDiem.Size = new System.Drawing.Size(160, 63);
            this.btnXemBangDiem.TabIndex = 30;
            this.btnXemBangDiem.Text = "Xem bảng điểm";
            this.btnXemBangDiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "LẦN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "MÔN THI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "LỚP";
            // 
            // cmbLAN
            // 
            this.cmbLAN.DisplayMember = "LAN";
            this.cmbLAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLAN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLAN.FormattingEnabled = true;
            this.cmbLAN.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLAN.Location = new System.Drawing.Point(752, 297);
            this.cmbLAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLAN.Name = "cmbLAN";
            this.cmbLAN.Size = new System.Drawing.Size(137, 27);
            this.cmbLAN.TabIndex = 26;
            this.cmbLAN.ValueMember = "LAN";
            // 
            // cmbMONTHI
            // 
            this.cmbMONTHI.DisplayMember = "TENMH";
            this.cmbMONTHI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMONTHI.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMONTHI.FormattingEnabled = true;
            this.cmbMONTHI.Location = new System.Drawing.Point(464, 297);
            this.cmbMONTHI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMONTHI.Name = "cmbMONTHI";
            this.cmbMONTHI.Size = new System.Drawing.Size(212, 27);
            this.cmbMONTHI.TabIndex = 25;
            this.cmbMONTHI.ValueMember = "MAMH";
            // 
            // cmbLOP
            // 
            this.cmbLOP.DisplayMember = "TENLOP";
            this.cmbLOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLOP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLOP.FormattingEnabled = true;
            this.cmbLOP.Location = new System.Drawing.Point(180, 297);
            this.cmbLOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLOP.Name = "cmbLOP";
            this.cmbLOP.Size = new System.Drawing.Size(197, 27);
            this.cmbLOP.TabIndex = 24;
            this.cmbLOP.ValueMember = "MALOP";
            // 
            // femXemBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.btnXemBangDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLAN);
            this.Controls.Add(this.cmbMONTHI);
            this.Controls.Add(this.cmbLOP);
            this.Name = "femXemBangDiem";
            this.Text = "Xem Bảng Điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Button btnXemBangDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLAN;
        private System.Windows.Forms.ComboBox cmbMONTHI;
        private System.Windows.Forms.ComboBox cmbLOP;
    }
}