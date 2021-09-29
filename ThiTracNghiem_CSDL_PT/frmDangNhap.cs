using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiem_CSDL_PT
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
        
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            //da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            MessageBox.Show("AAA");

        }
        private int KetNoiCSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                //MessageBox.Show("BBBB");
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối về ABC CSDL gốc.\n Bạn xem lại trên Server của Publisher và tên CSDL trong chuỗi kết nối. \n" + e.Message);
                return 0;
            }
        }

        private void cmbGiangVienTheoCS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdGiangVien_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.Show();
            lbMatKhau.Show();
            lbTaiKhoan.Text = "Tài khoản";
        }

        private void rdSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.Hide();
            lbMatKhau.Hide();
            lbTaiKhoan.Text = "Mã sinh viên";
        }

        private void lbTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Program.frmChinh.Close();
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCoSo.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}