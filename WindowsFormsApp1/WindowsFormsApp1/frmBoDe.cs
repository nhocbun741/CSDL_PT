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
    public partial class frmBoDe : DevExpress.XtraEditors.XtraForm
    {
        public frmBoDe()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        public void XuLyButton(bool b)
        {
            this.button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = barButtonItem1.Enabled = barButtonItem2.Enabled = barButtonItem3.Enabled = b;
            barButtonItem4.Enabled = barButtonItem5.Enabled = groupBox1.Enabled = !b;
        }

        private void frmBoDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connectionString;
            this.bODETableAdapter.Fill(this.dS.BODE);
            XuLyButton(true);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.bODEBindingSource.MoveLast();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.Validate();
            //this.bODEBindingSource.EndEdit();
            // this.bODETableAdapter.Update(this.dS);
            if (Program.KetNoi() == 0) MessageBox.Show("abc");
            String strLenh = "dbo.SP_BODE_UPDATE_CREATE";
            Program.cmd = Program.conn.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = strLenh;
            Program.cmd.Parameters.AddWithValue("@MAMH", mAMHTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@CAUHOI", cAUHOISpinEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@TRINHDO", tRINHDOTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@NOIDUNG", nOIDUNGTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@A", aTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@B", bTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@C", cTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@D", dTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@DAP_AN", dAP_ANTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@MAGV", mAGVTextEdit.Text.Trim());
            Program.cmd.ExecuteNonQuery();
            Program.conn.Close();
            XuLyButton(true);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLyButton(false);
            mAMHTextEdit.Focus();
            this.bODEBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bODEBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.bODEBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bODEBindingSource.MoveNext();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bODEBindingSource.CancelEdit();
            XuLyButton(true);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xoá hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.bODEBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dS);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLyButton(false);
            mAMHTextEdit.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.bODEBindingSource.Filter = "MAMH LIKE '%" + this.textBox1.Text + "%'" + " OR CAUHOI LIKE '%" + this.textBox1.Text + "%'" + " OR TRINHDO LIKE '%" + this.textBox1.Text + "%'" + " OR MAGV LIKE '%" + this.textBox1.Text + "%'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) MessageBox.Show("abc");

            String strLenh1 = "dbo.SP_KTRABODE";
            Program.cmd = Program.conn.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = strLenh1;
            Program.cmd.Parameters.Add("@CAUHOI", SqlDbType.Char).Value = this.cAUHOISpinEdit.Text.ToString();
            Program.cmd.Parameters.Add("@Ret", SqlDbType.Char).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
            Program.cmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.cmd.Parameters["@Ret"].Value.ToString(); // sp sẽ trả về giá trị 
            if (Ret == "1")
            {
                MessageBox.Show("Câu hỏi đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.bODEBindingSource.EndEdit();
                this.bODETableAdapter.Update(this.dS);
            }
           
        }
    }
}