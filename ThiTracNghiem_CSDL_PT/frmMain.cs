using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThiTracNghiem_CSDL_PT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {

                frmDangNhap f = new frmDangNhap();
                //MessageBox.Show("AAAAAA");
                f.MdiParent = this;
                f.Show();
                //MessageBox.Show("AAAAAA");
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "CẢNH BÁO",
                MessageBoxButtons.OKCancel);
            if(dialogResult==DialogResult.OK)
            {
                Program.username = "";
                Program.mlogin = "";
                Program.password = "";

                Close();
                Program.frmChinh.Close();
            }

        }
        private void HienThiMenu()
        {
            MAGV.Text = "Mã GV :" + Program.username;
            HOTEN.Text = "Họ tên :" + Program.mHoten;
            NHOM.Text = "Nhóm :" + Program.mGroup;
            // Phân quyền
            rbBaoCao.Visible=rbDanhMuc.Visible=rbNghiepVu.Visible=true;
        }
        private void MAGV_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
