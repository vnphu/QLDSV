using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmMonHoc : Form
    {
        int vitri = 0;
        bool kt;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'DS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);
            //MessageBox.Show("" + bdsDiem.Count);
            if (Program.mGroup == "Khoa")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnHieuChinh.Enabled = false;
                btnGhi.Enabled = false;
            }
            btnPhucHoi.Enabled = false;
            btnGhi.Enabled = false;
            btnTaiLai.Enabled = false;

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn không được thiếu!", "", MessageBoxButtons.OK);
                txtMaMonHoc.Focus();
                return;
            }
            if (txtTenMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenMonHoc.Focus();
                return;
            }
            try
            {
                string strLenh = "EXEC sp_KTraMonHoc '" + txtMaMonHoc.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int s = Program.myReader.GetInt32(0);
                if (s == 1)
                {
                    MessageBox.Show("Mã môn đã bị trùng!", "", MessageBoxButtons.OK);
                    txtMaMonHoc.Focus();
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra mã môn bị lỗi!" + ex, "", MessageBoxButtons.OK);
            }
            try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.dS.MONHOC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học .\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = mONHOCGridControl.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            if (btnThem.Enabled == false) bdsMonHoc.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = mONHOCGridControl.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDiem.Count != 0)
            {
                MessageBox.Show("Môn học đã có người học.Không thể xóa", "",
                        MessageBoxButtons.OK);
                return;
            }
            String malop = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học " + ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString() + " ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", malop);
                    bdsMonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", malop);
                    return;
                }
            }

            if (bdsMonHoc.Count == 0) btnXoa.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            groupBox1.Enabled = true;
            kt = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = mONHOCGridControl.Enabled = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMonHoc.Position;
            groupBox1.Enabled = true;
            bdsMonHoc.AddNew();
            txtMaMonHoc.Focus();
            kt = mONHOCGridControl.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                this.dIEMTableAdapter.Fill(this.dS.DIEM);
                mONHOCGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
