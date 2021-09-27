
namespace ThiTracNghiem_CSDL_PT
{
    partial class frmXemDSDK
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
            this.lbTHONGBAO = new System.Windows.Forms.Label();
            this.btnXEMDSDK = new System.Windows.Forms.Button();
            this.ngayKT = new System.Windows.Forms.DateTimePicker();
            this.ngayBD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbTHONGBAO
            // 
            this.lbTHONGBAO.AutoSize = true;
            this.lbTHONGBAO.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTHONGBAO.Location = new System.Drawing.Point(464, 426);
            this.lbTHONGBAO.Name = "lbTHONGBAO";
            this.lbTHONGBAO.Size = new System.Drawing.Size(150, 27);
            this.lbTHONGBAO.TabIndex = 23;
            this.lbTHONGBAO.Text = "THÔNG BÁO";
            // 
            // btnXEMDSDK
            // 
            this.btnXEMDSDK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXEMDSDK.Location = new System.Drawing.Point(426, 308);
            this.btnXEMDSDK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXEMDSDK.Name = "btnXEMDSDK";
            this.btnXEMDSDK.Size = new System.Drawing.Size(245, 76);
            this.btnXEMDSDK.TabIndex = 22;
            this.btnXEMDSDK.Text = "XEM DANH SÁCH ĐĂNG KÝ";
            this.btnXEMDSDK.UseVisualStyleBackColor = true;
            // 
            // ngayKT
            // 
            this.ngayKT.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayKT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayKT.Location = new System.Drawing.Point(759, 197);
            this.ngayKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngayKT.Name = "ngayKT";
            this.ngayKT.Size = new System.Drawing.Size(241, 34);
            this.ngayKT.TabIndex = 21;
            // 
            // ngayBD
            // 
            this.ngayBD.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayBD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayBD.Location = new System.Drawing.Point(67, 195);
            this.ngayBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngayBD.Name = "ngayBD";
            this.ngayBD.Size = new System.Drawing.Size(241, 34);
            this.ngayBD.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(776, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cơ sở";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(428, 101);
            this.cmbCoSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(241, 34);
            this.cmbCoSo.TabIndex = 16;
            // 
            // frmXemDSDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbTHONGBAO);
            this.Controls.Add(this.btnXEMDSDK);
            this.Controls.Add(this.ngayKT);
            this.Controls.Add(this.ngayBD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCoSo);
            this.Name = "frmXemDSDK";
            this.Text = "Xem Danh sách đăng ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTHONGBAO;
        private System.Windows.Forms.Button btnXEMDSDK;
        private System.Windows.Forms.DateTimePicker ngayKT;
        private System.Windows.Forms.DateTimePicker ngayBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCoSo;
    }
}