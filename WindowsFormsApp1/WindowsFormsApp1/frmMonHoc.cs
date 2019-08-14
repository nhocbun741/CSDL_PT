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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        public void XuLyButton(bool b)
        {
            this.button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = barButtonItem1.Enabled = barButtonItem2.Enabled = barButtonItem3.Enabled = b;
            barButtonItem4.Enabled = barButtonItem5.Enabled = groupBox1.Enabled = !b;
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            XuLyButton(true);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.Validate();
            //this.mONHOCBindingSource.EndEdit();
            //this.mONHOCTableAdapter.Update(this.dS);
            if (Program.KetNoi() == 0) MessageBox.Show("abc");
            String strLenh = "dbo.SP_MONHOC_UPDATE_CREATE";
            Program.cmd = Program.conn.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = strLenh;
            Program.cmd.Parameters.AddWithValue("@MAMH", mAMHTextEdit.Text.Trim());
            Program.cmd.Parameters.AddWithValue("@TENMH", tENMHTextEdit.Text.Trim());
            Program.cmd.ExecuteNonQuery();
            Program.conn.Close();
            XuLyButton(true);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLyButton(false);
            mAMHTextEdit.Focus();
            this.mONHOCBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.MoveLast();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCBindingSource.CancelEdit();
            XuLyButton(true);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xoá hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.mONHOCBindingSource.RemoveCurrent();
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
            this.mONHOCBindingSource.Filter = "MAMH LIKE '%" + this.textBox1.Text + "%'" + " OR TENMH LIKE '%" + this.textBox1.Text + "%'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) MessageBox.Show("abc");

            String strLenh1 = "dbo.SP_KTRAMH";
            Program.cmd = Program.conn.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = strLenh1;
            Program.cmd.Parameters.Add("@MAMH", SqlDbType.Char).Value = this.mAMHTextEdit.Text.ToString();
            Program.cmd.Parameters.Add("@Ret", SqlDbType.Char).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
            Program.cmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.cmd.Parameters["@Ret"].Value.ToString(); // sp sẽ trả về giá trị 
            if (Ret == "1")
            {
                MessageBox.Show("Môn học đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.mONHOCBindingSource.EndEdit();
                this.mONHOCTableAdapter.Update(this.dS);
            }
           
        }
    }
}