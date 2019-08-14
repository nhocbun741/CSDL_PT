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
    public partial class frmBangDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmBangDiem()
        {
            InitializeComponent();
        }

        private void bANGDIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bANGDIEMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);

        }
    }
}