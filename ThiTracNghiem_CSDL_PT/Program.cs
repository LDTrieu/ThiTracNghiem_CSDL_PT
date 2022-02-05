using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ThiTracNghiem_CSDL_PT
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand();
        public static String connstr;
        public static String connstr_publisher = "Data Source=DESKTOP-00R6U3E;Initial Catalog=THI_TN;User ID=sa;Password=123";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "THI_TN";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "12";
        public static String mLoginDN = ""; //Xem lai
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChiNhanh = 0;
        public static String Control = ""; // Xem lai

        // Thêm
        public static String svMaLop = "";
        public static String svTenLop = "";

        // liên kết dữ liệu từ bảng dữ liệu vào chương trình
        public static BindingSource bindingSource = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static frmMain frmChinh;
        public static frmSinhVien frmSinhVien;
        public static frmSinhVien frmLamBaiThi;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr= "Data Source="+Program.servername+ ";Initial Catalog="+
                    Program.database+ ";User ID="+
                    Program.mlogin+";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;

            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch(SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void changeConnection(String connectionstring)
        {
            if (Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            Program.conn.ConnectionString = connectionstring;
            Program.conn.Open();
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;

        }
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

            static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
