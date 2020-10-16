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
    public partial class frmSinhVien : Form
    {
        int vitri = 0, i = 0;
        String maKhoa = "";
        bool kt;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false; // tắt ràng buộc khóa ngoại
            //this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN); //gọi danh sách lớp vào trong table
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'DS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);
            //DS.EnforceConstraints = true;
            maKhoa = ((DataRowView)bdsLop[0])["MAKH"].ToString();
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
                btnPhucHoi.Enabled = false;
                btnGhi.Enabled = false;
                btnTaiLai.Enabled = true;
                btnGhiSV.Enabled = true;
                btnTaiLaiSV.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;

            }
            if (Program.mGroup == "Khoa" || Program.mGroup == "PKeToan")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnHieuChinh.Enabled = false;
                btnGhi.Enabled = false;

                btnTaiLaiSV.Enabled = btnTaiLaiSV.Enabled = true;
                btnThemSV.Enabled = false;
                btnXoaSV.Enabled = false;
                btnGhiSV.Enabled = false;
            }
            groupBox1.Enabled = false;

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = bdsLop.Position;
            groupBox1.Enabled = true;
            cmbKhoa.Enabled = false;
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled = false;
            kt = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count != 0)
            {
                MessageBox.Show("Lớp đã có sinh viên không thể xóa \n", "",
                        MessageBoxButtons.OK);
                return;
            }
            String malop = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp " + ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString() + " ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    MessageBox.Show("Đã xóa lớp" + malop);
                    bdsLop.RemoveCurrent(); //xóa đi hàng hiện tại ra khỏi dataSet
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lớp đã có sinh viên không thể xóa \n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    return;
                }
            }

            if (bdsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void dbsDiem_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            if (btnThem.Enabled == false) bdsLop.Position = vitri;
            groupBox1.Enabled = false;
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return;
            }
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            try
            {
                string strLenh = "EXEC sp_KTraLop '" + txtMaLop.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int s = Program.myReader.GetInt32(0);
                if (s == 1)
                {
                    MessageBox.Show("Mã lớp đã bị trùng!", "", MessageBoxButtons.OK);
                    txtMaLop.Focus();
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("kiểm tra lớp bị lỗi!", "", MessageBoxButtons.OK);
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS.LOP);
                if (Program.mGroup == "PGV")
                {
                    cmbKhoa.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            lOPGridControl.Enabled = sINHVIENGridControl.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                this.dIEMTableAdapter.Fill(this.dS.DIEM);
                lOPGridControl.Enabled = sINHVIENGridControl.Enabled = true;
                if (Program.mGroup == "PGV")
                {
                    cmbKhoa.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbKhoa.DataSource = null;

            this.Close();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            vitri = bdsSV.Position;
            bdsSV.AddNew();
            i = 1;
            ((DataRowView)bdsSV[bdsSV.Position])["NGHIHOC"] = false;
            ((DataRowView)bdsSV[bdsSV.Position])["PHAI"] = false;
            btnThemSV.Enabled = btnXoaSV.Enabled = false;
            btnGhiSV.Enabled = btnTaiLaiSV.Enabled = true;
        }

        private void btnTaiLaiSV_Click(object sender, EventArgs e)
        {
            try
            {
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                // TODO: This line of code loads data into the 'DS.DIEM' table. You can move, or remove it, as needed.
                this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dIEMTableAdapter.Fill(this.dS.DIEM);
                i = 0;
                if (Program.mGroup == "PGV")
                {
                    btnThemSV.Enabled = btnXoaSV.Enabled = true;
                    btnGhiSV.Enabled = btnTaiLaiSV.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (bdsDIEM.Count != 0)
            {
                MessageBox.Show("Sinh viên không thể xóa do đã có điểm!", "", MessageBoxButtons.OK);
                return;
            }
            String masv = "";
            masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
            string strLenh = "EXEC sp_KTraHP '" + masv + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int s = Program.myReader.GetInt32(0);
            if (s == 1)
            {
                MessageBox.Show("Sinh viên không thể xóa do đã đóng học phí!", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Close();
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên " + masv + " ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
                    //bdsSV.Position = bdsSV.Find("MASV", masv);
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    MessageBox.Show("Đã xóa sinh viên" + masv);
                    i = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên \n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    //bdsSV.Position = bdsSV.Find("MASV", masv);
                    return;
                }
            }
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {
            String masv = "";
            masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
            String ho = "";
            ho = ((DataRowView)bdsSV[bdsSV.Position])["HO"].ToString();
            String ten = "";
            ten = ((DataRowView)bdsSV[bdsSV.Position])["TEN"].ToString();
            String malop = "";
            malop = ((DataRowView)bdsSV[bdsSV.Position])["MALOP"].ToString();

            if (masv.Equals(""))
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            if (malop.Equals(""))
            {
                MessageBox.Show("Mã lớp không được để trống!", "", MessageBoxButtons.OK);
                return;
            }

            string strLenh;
            int s;
            if (!malop.Equals(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp khác với lớp bạn đang trọn!", "", MessageBoxButtons.OK);
                return;
            }
            if (i == 1)
            {
                strLenh = "EXEC sp_KTraSV '" + masv + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                s = Program.myReader.GetInt32(0);
                if (s == 1)
                {
                    MessageBox.Show("Mã sinh viên đã bị trùng hoặc bạn phải để con trỏ chuột chọn tại vị trí thêm mới!", "", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }

            try
            {
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                //cmbKhoa.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            i = 0;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnTaiLaiSV.Enabled = true;
            btnGhiSV.Enabled = true;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                Program.servername = cmbKhoa.SelectedValue.ToString();
                if (Program.mGroup == "PGV" && cmbKhoa.SelectedIndex == 2)
                {
                    MessageBox.Show("Bạn không có quyền truy cập cái này", "", MessageBoxButtons.OK);
                    cmbKhoa.SelectedIndex = 1;
                    cmbKhoa.SelectedIndex = 0;
                    return;
                }
                if (cmbKhoa.SelectedIndex != Program.mKhoa)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                else
                {
                    if (Program.mGroup == "PGV" || Program.mGroup == "Khoa")
                    {
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.dS.LOP);
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            groupBox1.Enabled = true;
            bdsLop.AddNew();
            txtMaLop.Focus();
            txtMaKhoa.Text = gridView1.GetRowCellValue(0, "MAKH").ToString();
            txtMaKhoa.Enabled = lOPGridControl.Enabled = false;
            kt = false;
            cmbKhoa.Enabled = sINHVIENGridControl.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }
    }
}
