using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
            {
                Form frm = this.CheckExists(typeof(frmLop));
                if (frm != null) frm.Activate();
                else
                {
                    frmLop f = new frmLop();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không sử dụng được chức năng này!", "", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //Form frmTaoLogin = this.CheckExists(typeof(frmTaoTaiKhoan));
            //if (frmTaoLogin != null)
            //{
            //    frmTaoLogin.Close();
            //}
            if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
            {
                Form frm = this.CheckExists(typeof(frmLop));
                if (frm != null) frm.Activate();
                else
                {
                    frmLop f = new frmLop();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không sử dụng được chức năng này!", "", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
            {
                Form frm = this.CheckExists(typeof(frmMonHoc));
                if (frm != null) frm.Activate();
                else
                {
                    frmMonHoc f = new frmMonHoc();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không sử dụng được chức năng này!", "", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKyTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKyTaiKhoan f = new frmDangKyTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
            {
                Form frm = this.CheckExists(typeof(frmSinhVien));
                if (frm != null) frm.Activate();
                else
                {
                    frmSinhVien f = new frmSinhVien();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không sử dụng được chức năng này!", "", MessageBoxButtons.OK);
            }
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
            {
                Form frm = this.CheckExists(typeof(frmDiem));
                if (frm != null) frm.Activate();
                else
                {
                    frmDiem f = new frmDiem();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không sử dụng được chức năng này!", "", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
            {
                Form frm = this.CheckExists(typeof(frmREPORTDSSV));
                if (frm != null) frm.Activate();
                else
                {
                    frmREPORTDSSV f = new frmREPORTDSSV();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không sử dụng được chức năng này!", "", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
            {
                Form frm = this.CheckExists(typeof(frmREPORTDSTHM));
                if (frm != null) frm.Activate();
                else
                {
                    frmREPORTDSTHM f = new frmREPORTDSTHM();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không sử dụng được chức năng này!", "", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
            {
                Form frm = this.CheckExists(typeof(frmREPORTBANGDIEM));
                if (frm != null) frm.Activate();
                else
                {
                    frmREPORTBANGDIEM f = new frmREPORTBANGDIEM();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không sử dụng được chức năng này!", "", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
            {
                Form frm = this.CheckExists(typeof(frmREPORTPHIEUDIEM));
                if (frm != null) frm.Activate();
                else
                {
                    frmREPORTPHIEUDIEM f = new frmREPORTPHIEUDIEM();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn không sử dụng được chức năng này!", "", MessageBoxButtons.OK);
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MaGV_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void HoTen_Click(object sender, EventArgs e)
        {

        }
    }
}
