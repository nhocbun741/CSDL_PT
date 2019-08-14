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
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmKhoa : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoa()
        {
            InitializeComponent();
           // this.tENKHTextEdit.Enabled = false;
            //this.mAKHTextEdit.Enabled = false;
            //this.mACSTextEdit.Enabled = false;
        }
        public void XuLyButton(bool b)
        {
            this.button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = b;
            btnLuu.Enabled = btnHuy.Enabled = groupBox1.Enabled = !b;
        }
        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connectionString;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            XuLyButton(true);
        }

        private void cmbCS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLyButton(false);
            mAKHTextEdit.Focus();
            this.kHOABindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.kHOABindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.kHOABindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.kHOABindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.kHOABindingSource.MoveLast();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.Validate();
            //this.kHOABindingSource.EndEdit();
            //this.kHOATableAdapter.Update(this.dS);

            if (Program.KetNoi() == 0) MessageBox.Show("abc") ;
            String strLenh = "dbo.SP_KHOA_UPDATE_6";
            Program.cmd = Program.conn.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = strLenh;
            Program.cmd.Parameters.AddWithValue("@MAKH", mAKHTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@TENKH", tENKHTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@MACS", mACSTextEdit.Text.Trim());
            Program.cmd.ExecuteNonQuery();
            Program.conn.Close();
            XuLyButton(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.kHOABindingSource.CancelEdit();
            XuLyButton(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xoá hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.kHOABindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dS);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLyButton(false);
            mAKHTextEdit.Focus();
        }

        private void kHOAGridControl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.kHOABindingSource.Filter = "MAKH LIKE '%" + this.textBox1.Text + "%'" + " OR TENKH LIKE '%" + this.textBox1.Text + "%'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) MessageBox.Show("abc");

            String strLenh1 = "dbo.SP_KTRAKHOA";
            Program.cmd = Program.conn.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = strLenh1;
            Program.cmd.Parameters.Add("@MAKH", SqlDbType.Char).Value = this.mAKHTextEdit.Text.ToString();
            Program.cmd.Parameters.Add("@Ret", SqlDbType.Char).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
            Program.cmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.cmd.Parameters["@Ret"].Value.ToString(); // sp sẽ trả về giá trị 
            if (Ret == "1")
            {
                MessageBox.Show("Khoa đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.kHOABindingSource.EndEdit();
                this.kHOATableAdapter.Update(this.dS);
            }
           
        }
    }
}