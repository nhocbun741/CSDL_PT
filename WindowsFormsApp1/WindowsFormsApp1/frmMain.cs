using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WindowsFormsApp1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            this.USERNAME.Text = "Tên đăng nhập: " + Program.username;
            //this.HOTEN.Text = "Họ tên: " + Program.mhoten;
            this.NHOM.Text = "Nhóm quyền: " + Program.mgroup;

            if (Program.mgroup == "Giangvien")
            {
                this.barButtonItem6.Enabled = true;
                this.btnDangNhap.Enabled = false;
                this.barButtonItem1.Enabled = false;
                this.barButtonItem3.Enabled = false;
                this.barButtonItem4.Enabled = false;
                this.barButtonItem5.Enabled = false;
                this.barButtonItem7.Enabled = false;
                this.barButtonItem8.Enabled = false;

            }
            else if (Program.mgroup == "Sinhvien")
            {
                this.barButtonItem6.Enabled = false;
                this.btnDangNhap.Enabled = false;
                this.barButtonItem1.Enabled = false;
                this.barButtonItem3.Enabled = false;
                this.barButtonItem4.Enabled = false;
                this.barButtonItem5.Enabled = false;
                this.barButtonItem7.Enabled = false;
                this.barButtonItem8.Enabled = false;
            }
            else if (Program.mgroup == "Truong" || Program.mgroup == "Coso1" || Program.mgroup == "Coso2")
            {
                this.barButtonItem6.Enabled = true;
                this.btnDangNhap.Enabled = true;
                this.barButtonItem1.Enabled = true;
                this.barButtonItem3.Enabled = true;
                this.barButtonItem4.Enabled = true;
                this.barButtonItem5.Enabled = true;
                this.barButtonItem7.Enabled = true;
                this.barButtonItem8.Enabled = true;
            }
        }

        private Form KiemTraTonTai(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }


        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmKhoa));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKhoa f = new frmKhoa();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmLop));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmMonHoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmGiaoVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmGiaoVien f = new frmGiaoVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmSinhVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmGiaoVienDangKi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmGiaoVienDangKi f = new frmGiaoVienDangKi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmBoDe));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmBoDe f = new frmBoDe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmBangDiem));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmBangDiem f = new frmBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}