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
        //private SqlConnection conn_publisher = new SqlConnection();
        //string connectString= @"Data Source=DESKTOP-00R6U3E;Initial Catalog=THI_TN;Integrated Security=True";
        //SqlConnection conn_publisher = new SqlConnection(@"Data Source=DESKTOP-00R6U3E;Initial Catalog=THI_TN;Integrated Security=True");

        public frmDangNhap()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            DataTable dataTable = GetSubcriber();
            if (dataTable == null)
            {
                return;
            }
            cmbCoSo.DataSource = DBConnection.BsSubcribers.DataSource = dataTable;
            cmbCoSo.DisplayMember = "FullInfo";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedItem = -1;     
        }

        private void layDanhSachPhanManh(String cmd)
        {
            if (DBConnection.PublisherConnection.State == ConnectionState.Closed)
            {
                DBConnection.PublisherConnection.Open();
            }
            DataTable dataTable = new DataTable();
            // adapter dùng để đưa dữ liệu từ view sang database
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, DBConnection.PublisherConnection);
            dataAdapter.Fill(dataTable);

            DBConnection.PublisherConnection.Close();
            Program.bindingSource.DataSource = dataTable;

            cmbCoSo.DataSource = Program.bindingSource;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
        }

        private DataTable GetSubcriber()
        {
            if (!DBConnection.ConnectToPublisher())
            {
                MessageBox.Show("Kết nối đến CSDL thất bại. " + "" +
                    " Vui lòng xem lại tên server và tên CDL trong chuỗi kết nối");
                return null;
            }
            string query = "SELECT * FROM view_GetSubcribers";
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, DBConnection.PublisherConnection);
            dataAdapter.Fill(dataTable);
            DBConnection.PublisherConnection.Close();
            return dataTable;
        }
        
        
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "LDT";
            txtMatKhau.Text = "123456";
            if (KetNoi_CSDLGOC() == 0)
                return;
            // Lấy 2 cái đầu tiên của danh sách
            GetSubcriber
           
           
            //rdGiangVien.AutoCheck = true;
            if (KetNoi_CSDLGOC() == 0)
                return;
            LayDSPM("SELECT * FROM Get_Subscribes WHERE TENCS <> 'TRA CUU'");
            //cmbCoSo.SelectedIndex = 1;
            //cmbCoSo.SelectedIndex = 0;
            //MessageBox.Show("tttt");
            /*try
            {
                //Integrated Security=True--> Kết nối về site chủ không cần password và tài khoản
                // dùng để lấy danh sách cơ sở từ site chủ
                string chuoiketnoi = "Data Source=DESKTOP-00R6U3E;Initial Catalog=THI_TN;Integrated Security=True";
                Program.conn.ConnectionString = chuoiketnoi;
                Program.conn.Open();

                // Gọi view V_DS_COSO và trả về datable 
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_COSO");
                Program.bds_dspm.DataSource = dt;

                // Lấy kết quả đổ vào combobox
                cmbCoSo.DataSource = dt;
                cmbCoSo.DisplayMember = "TENCS";
                cmbCoSo.ValueMember = "TENSERVER";
                cmbCoSo.SelectedIndex = 1;
                cmbCoSo.SelectedIndex = 0;
                //txUsername.Focus();
            }
            catch (Exception a)
            {
                MessageBox.Show("Không thể kết nối tới database! " + a.Message, "", MessageBoxButtons.OK);
            }*/
        }

        
        private int KetNoi_CSDLGOC()
        {
            if (DBConnection.PublisherConnection != null && DBConnection.PublisherConnection.State == ConnectionState.Open)
            {
                DBConnection.PublisherConnection.Close();
            }
            try
            {
                DBConnection.PublisherConnection.ConnectionString = Program.connstr_publisher;
                DBConnection.PublisherConnection.Open();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " +
                    ex.Message, "", MessageBoxButtons.OK);
                return 0;
            }
            
        }
        private String getID(String username,string pass)
        {
            string id = "";

            return id;
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
            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và Mật khẩu không được trống", "", MessageBoxButtons.OK);
                return;
            }

            if (txtTaiKhoan.Text.Trim() == "" && rdSinhVien.Checked)
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "", MessageBoxButtons.OK);
                return;
            }
           
        }

        private void gbTaoLogin_Enter(object sender, EventArgs e)
        {
            //rdGiangVien.AutoCheck = true;
            //MessageBox.Show("check point rdGiangVien");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}