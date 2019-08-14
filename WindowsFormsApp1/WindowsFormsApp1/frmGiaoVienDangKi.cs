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

namespace WindowsFormsApp1
{
    public partial class frmGiaoVienDangKi : DevExpress.XtraEditors.XtraForm
    {
        public frmGiaoVienDangKi()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        public void XuLyButton(bool b)
        {
            this.button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = barButtonItem1.Enabled = barButtonItem2.Enabled = barButtonItem3.Enabled = b;
            barButtonItem4.Enabled = barButtonItem5.Enabled = groupBox1.Enabled = !b;
        }

        private void frmGiaoVienDangKi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            XuLyButton(true);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.Validate();
            //this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            //this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS);
            if (Program.KetNoi() == 0) MessageBox.Show("abc");
            String strLenh = "dbo.SP_GIAOVIENDANGKI_UPDATE_CREATE";
            Program.cmd = Program.conn.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = strLenh;
            Program.cmd.Parameters.AddWithValue("@MAGV", mAGVTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@MALOP", mALOPTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@MAMH", mAMHTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@TRINHDO", tRINHDOTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@NGAYTHI", nGAYTHIDateEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@LAN", lANSpinEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@SOCAUTHI", sOCAUTHISpinEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@THOIGIAN", tHOIGIANSpinEdit.Text.Trim());
            Program.cmd.ExecuteNonQuery();
            Program.conn.Close();
            XuLyButton(true);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLyButton(false);
            mAGVTextEdit.Focus();
            this.gIAOVIEN_DANGKYBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.gIAOVIEN_DANGKYBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gIAOVIEN_DANGKYBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.gIAOVIEN_DANGKYBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.gIAOVIEN_DANGKYBindingSource.MoveLast();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIAOVIEN_DANGKYBindingSource.CancelEdit();
            XuLyButton(true);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xoá hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.gIAOVIEN_DANGKYBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dS);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLyButton(false);
            mAGVTextEdit.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.gIAOVIEN_DANGKYBindingSource.Filter = "MALOP LIKE '%" + this.textBox1.Text + "%'" + " OR MAGV LIKE '%" + this.textBox1.Text + "%'" + " OR MAMH LIKE '%" + this.textBox1.Text + "%'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS);
        }
    }
}