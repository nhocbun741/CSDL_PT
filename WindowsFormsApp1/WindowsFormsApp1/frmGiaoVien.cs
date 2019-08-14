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
    public partial class frmGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        public void XuLyButton(bool b)
        {

            this.button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = barButtonItem1.Enabled = barButtonItem2.Enabled = barButtonItem3.Enabled = b;
            barButtonItem4.Enabled = barButtonItem5.Enabled = groupBox1.Enabled = !b;
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.dS.GIAOVIEN.Clear();
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            XuLyButton(true);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.Validate();
            //this.gIAOVIENBindingSource.EndEdit();
            //this.gIAOVIENTableAdapter.Update(this.dS);
            if (Program.KetNoi() == 0) MessageBox.Show("abc");
            String strLenh = "dbo.SP_GIAOVIEN_UPDATE_CREATE";
            Program.cmd = Program.conn.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = strLenh;
            Program.cmd.Parameters.AddWithValue("@MAGV", mAGVTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@HO", hOCVITextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@TEN", tENTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@HOCVI", hOCVITextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@MAKH", mAKHTextEdit.Text.Trim());
            Program.cmd.ExecuteNonQuery();
            Program.conn.Close();
            XuLyButton(true);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLyButton(false);
            mAGVTextEdit.Focus();
            this.gIAOVIENBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.gIAOVIENBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gIAOVIENBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.gIAOVIENBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.gIAOVIENBindingSource.MoveLast();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIAOVIENBindingSource.CancelEdit();
            XuLyButton(true);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xoá hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.gIAOVIENBindingSource.RemoveCurrent();
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
            this.gIAOVIENBindingSource.Filter = "MAGV LIKE '%" + this.textBox1.Text + "%'" + " OR TEN LIKE '%" + this.textBox1.Text + "%'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) MessageBox.Show("abc");

            String strLenh1 = "dbo.SP_KTRAGV";
            Program.cmd = Program.conn.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = strLenh1;
            Program.cmd.Parameters.Add("@MAGV", SqlDbType.Char).Value = this.mAGVTextEdit.Text.ToString();
            Program.cmd.Parameters.Add("@Ret", SqlDbType.Char).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
            Program.cmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.cmd.Parameters["@Ret"].Value.ToString(); // sp sẽ trả về giá trị 
            if (Ret == "1")
            {
                MessageBox.Show("Giáo viên đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.gIAOVIENBindingSource.EndEdit();
                this.gIAOVIENTableAdapter.Update(this.dS);
            }
            
        }
    }
}