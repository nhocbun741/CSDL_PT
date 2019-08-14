using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHI_TNDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.tHI_TNDataSet.V_DS_PHANMANH);

        }

        private void tENCSComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tENCSComboBox.SelectedValue != null)
            Program.servername = tENCSComboBox.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo lỗi", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;
            Program.coso = tENCSComboBox.SelectedIndex;
            Program.bds_dspm = v_DS_PHANMANHBindingSource;
            Program.mloginDN = Program.mlogin;
            Program.passworDN = Program.password;
            SqlDataReader myReader;
            String strLenh = "";
            if(rdGiangvien.Checked == true)
            {
                strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);

            }
            else if (rdSinhvien.Checked == true)
            {
                strLenh = "exec SP_DANGNHAP_1 '" + Program.mlogin + "'";
                
            }
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();

            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Không có quyền truy cập dữ liệu \n.", "", MessageBoxButtons.OK);
                return;

            }
            //Program.mhoten = myReader.GetString(1);
            Program.mgroup = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();
            this.Hide(); // đóng form hiện tại
                         // mở form dexfrmMain
            frmMain frmMain = new frmMain();
            frmMain.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}