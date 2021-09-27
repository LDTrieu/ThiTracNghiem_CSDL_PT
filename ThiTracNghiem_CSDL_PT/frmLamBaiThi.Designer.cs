
namespace ThiTracNghiem_CSDL_PT
{
    partial class frmLamBaiThi
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
            this.summarylistview = new System.Windows.Forms.ListView();
            this.question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownCAUHOI = new System.Windows.Forms.NumericUpDown();
            this.btnCAUSAU = new System.Windows.Forms.Button();
            this.btnCAUTRUOC = new System.Windows.Forms.Button();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.txtNOIDUNG = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTHONGBAO = new System.Windows.Forms.Label();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.lbNgayThi = new System.Windows.Forms.Label();
            this.lbTrinhDo = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCAUHOI)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // summarylistview
            // 
            this.summarylistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.question,
            this.answer});
            this.summarylistview.GridLines = true;
            this.summarylistview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.summarylistview.HideSelection = false;
            this.summarylistview.Location = new System.Drawing.Point(313, 0);
            this.summarylistview.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.summarylistview.MultiSelect = false;
            this.summarylistview.Name = "summarylistview";
            this.summarylistview.Size = new System.Drawing.Size(277, 717);
            this.summarylistview.TabIndex = 13;
            this.summarylistview.UseCompatibleStateImageBehavior = false;
            this.summarylistview.View = System.Windows.Forms.View.Details;
            // 
            // question
            // 
            this.question.Text = "Question";
            this.question.Width = 120;
            // 
            // answer
            // 
            this.answer.Text = "Answer";
            this.answer.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownCAUHOI);
            this.groupBox2.Controls.Add(this.btnCAUSAU);
            this.groupBox2.Controls.Add(this.btnCAUTRUOC);
            this.groupBox2.Controls.Add(this.rdD);
            this.groupBox2.Controls.Add(this.rdC);
            this.groupBox2.Controls.Add(this.rdB);
            this.groupBox2.Controls.Add(this.rdA);
            this.groupBox2.Controls.Add(this.txtNOIDUNG);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(600, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(897, 759);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Câu hỏi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "CHUYỂN ĐẾN CÂU";
            // 
            // numericUpDownCAUHOI
            // 
            this.numericUpDownCAUHOI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCAUHOI.Location = new System.Drawing.Point(512, 494);
            this.numericUpDownCAUHOI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownCAUHOI.Name = "numericUpDownCAUHOI";
            this.numericUpDownCAUHOI.Size = new System.Drawing.Size(161, 30);
            this.numericUpDownCAUHOI.TabIndex = 12;
            // 
            // btnCAUSAU
            // 
            this.btnCAUSAU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAUSAU.Location = new System.Drawing.Point(239, 482);
            this.btnCAUSAU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCAUSAU.Name = "btnCAUSAU";
            this.btnCAUSAU.Size = new System.Drawing.Size(153, 49);
            this.btnCAUSAU.TabIndex = 11;
            this.btnCAUSAU.Text = "CÂU SAU";
            this.btnCAUSAU.UseVisualStyleBackColor = true;
            // 
            // btnCAUTRUOC
            // 
            this.btnCAUTRUOC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAUTRUOC.Location = new System.Drawing.Point(32, 482);
            this.btnCAUTRUOC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCAUTRUOC.Name = "btnCAUTRUOC";
            this.btnCAUTRUOC.Size = new System.Drawing.Size(153, 49);
            this.btnCAUTRUOC.TabIndex = 10;
            this.btnCAUTRUOC.Text = "CÂU TRƯỚC";
            this.btnCAUTRUOC.UseVisualStyleBackColor = true;
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdD.Location = new System.Drawing.Point(8, 416);
            this.rdD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(50, 31);
            this.rdD.TabIndex = 8;
            this.rdD.TabStop = true;
            this.rdD.Text = "D";
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdC.Location = new System.Drawing.Point(8, 332);
            this.rdC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(49, 31);
            this.rdC.TabIndex = 7;
            this.rdC.TabStop = true;
            this.rdC.Text = "C";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdB.Location = new System.Drawing.Point(8, 247);
            this.rdB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(49, 31);
            this.rdB.TabIndex = 6;
            this.rdB.TabStop = true;
            this.rdB.Text = "B";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdA.Location = new System.Drawing.Point(8, 164);
            this.rdA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(50, 31);
            this.rdA.TabIndex = 5;
            this.rdA.TabStop = true;
            this.rdA.Text = "A";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // txtNOIDUNG
            // 
            this.txtNOIDUNG.Location = new System.Drawing.Point(8, 23);
            this.txtNOIDUNG.Margin = new System.Windows.Forms.Padding(4);
            this.txtNOIDUNG.Name = "txtNOIDUNG";
            this.txtNOIDUNG.Size = new System.Drawing.Size(745, 112);
            this.txtNOIDUNG.TabIndex = 0;
            this.txtNOIDUNG.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTHONGBAO);
            this.groupBox1.Controls.Add(this.btnNopBai);
            this.groupBox1.Controls.Add(this.lbThoiGian);
            this.groupBox1.Controls.Add(this.lbNgayThi);
            this.groupBox1.Controls.Add(this.lbTrinhDo);
            this.groupBox1.Controls.Add(this.lbLop);
            this.groupBox1.Controls.Add(this.lbMonHoc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(305, 759);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thi";
            // 
            // lbTHONGBAO
            // 
            this.lbTHONGBAO.AutoSize = true;
            this.lbTHONGBAO.Location = new System.Drawing.Point(16, 332);
            this.lbTHONGBAO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTHONGBAO.Name = "lbTHONGBAO";
            this.lbTHONGBAO.Size = new System.Drawing.Size(88, 17);
            this.lbTHONGBAO.TabIndex = 12;
            this.lbTHONGBAO.Text = "THONGBAO";
            // 
            // btnNopBai
            // 
            this.btnNopBai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.Location = new System.Drawing.Point(19, 398);
            this.btnNopBai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(153, 49);
            this.btnNopBai.TabIndex = 11;
            this.btnNopBai.Text = "NỘP BÀI";
            this.btnNopBai.UseVisualStyleBackColor = true;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.Location = new System.Drawing.Point(15, 278);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(106, 21);
            this.lbThoiGian.TabIndex = 8;
            this.lbThoiGian.Text = "THỜI GIAN";
            // 
            // lbNgayThi
            // 
            this.lbNgayThi.AutoSize = true;
            this.lbNgayThi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThi.Location = new System.Drawing.Point(15, 214);
            this.lbNgayThi.Name = "lbNgayThi";
            this.lbNgayThi.Size = new System.Drawing.Size(98, 21);
            this.lbNgayThi.TabIndex = 7;
            this.lbNgayThi.Text = "NGÀY THI";
            // 
            // lbTrinhDo
            // 
            this.lbTrinhDo.AutoSize = true;
            this.lbTrinhDo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrinhDo.Location = new System.Drawing.Point(15, 150);
            this.lbTrinhDo.Name = "lbTrinhDo";
            this.lbTrinhDo.Size = new System.Drawing.Size(100, 21);
            this.lbTrinhDo.TabIndex = 6;
            this.lbTrinhDo.Text = "TRÌNH ĐỘ";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(15, 95);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(46, 21);
            this.lbLop.TabIndex = 5;
            this.lbLop.Text = "LỚP";
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.AutoSize = true;
            this.lbMonHoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonHoc.Location = new System.Drawing.Point(15, 46);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(98, 21);
            this.lbMonHoc.TabIndex = 4;
            this.lbMonHoc.Text = "MÔN HỌC";
            // 
            // frmLamBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 759);
            this.Controls.Add(this.summarylistview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLamBaiThi";
            this.Text = "Làm Bài Thi";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCAUHOI)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView summarylistview;
        private System.Windows.Forms.ColumnHeader question;
        private System.Windows.Forms.ColumnHeader answer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCAUHOI;
        private System.Windows.Forms.Button btnCAUSAU;
        private System.Windows.Forms.Button btnCAUTRUOC;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.RichTextBox txtNOIDUNG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTHONGBAO;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Label lbNgayThi;
        private System.Windows.Forms.Label lbTrinhDo;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbMonHoc;
    }
}