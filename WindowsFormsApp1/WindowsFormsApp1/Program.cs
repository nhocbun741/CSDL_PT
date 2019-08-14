using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        public static SqlConnection conn = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand();
        public static String connectionString;
        public static string servername = "";
        public static string username = "";
        public static string mlogin = "";
        public static string password = "";

        public static string db = "THI_TN";
        public static string remotelogin = "HTKN";
        public static string remotepassword = "123456";
        public static string mloginDN = "";
        public static string passworDN = "";
        public static string mgroup = "";
        public static string mhoten = "";
        public static int coso = 0;

        public static BindingSource bds_dspm = new BindingSource();
        public static frmMain frmChinh;

        public static int KetNoi()
        {
            if(Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connectionString = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.db + ";User ID=" +
                    Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connectionString;
                Program.conn.Open();
                return 1;
            }
            catch ( Exception e)
            {
                MessageBox.Show("Lỗi kết nối csdl" + e.Message, "", MessageBoxButtons.OK);
                return 0;    
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd, String connectionString)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(new frmDangNhap());
        }
    }
}
