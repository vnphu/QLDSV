using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }




        public void clearTextBox()
        {
            txtMaLop.Text = "";
            txtMaMon.Text = "";
            cmbLanThi.SelectedIndex = 0;
        }
        private void frmDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;

            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
            cmbLanThi.SelectedIndex = 0;
            cmbTenLop.SelectedIndex = 0;
            cmbTenMon.SelectedIndex = 0;
            txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            txtMaMon.Text = cmbTenMon.SelectedValue.ToString();
            btnGhi.Enabled = false;
           

        }

        private void cmbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return; // Hệ thống chưa chọn đã chạy => Kết thúc
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
                        clearTextBox();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.dS.LOP);
                        cmbTenLop.SelectedIndex = 0;
                        cmbTenMon.SelectedIndex = 0;
                        txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
                        txtMaMon.Text = cmbTenMon.SelectedValue.ToString();
                    }
                }
            }
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenLop.SelectedValue != null)
            {
                txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            }
        }

        private void cmbTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenMon.SelectedValue != null)
            {
                txtMaMon.Text = cmbTenMon.SelectedValue.ToString();
            }
        }

        private void tENMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenMon.SelectedValue != null)
            {
                txtMaMon.Text = cmbTenMon.SelectedValue.ToString();
            }
        }

        private void btnBatDau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbTenLop.Text == "" || cmbTenMon.Text == "" || cmbLanThi.SelectedIndex == -1)
            {
                MessageBox.Show("Mã lớp hoặc mã môn hoặc lần thi bị trống");
                return;
            }
            try
            {

                string strLenh = "SELECT COUNT(MASV) FROM DBO.SINHVIEN where MALOP ='" + txtMaLop.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int s = Program.myReader.GetInt32(0);
                if (s == 0)
                {
                    MessageBox.Show("Lớp chưa có sinh viên!", "", MessageBoxButtons.OK);
                    txtMaLop.Focus();
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();

                String a = cmbLanThi.SelectedItem.ToString();
                int i = int.Parse(a);
                if (i == 2)
                {
                    strLenh = "SELECT COUNT(MASV) FROM DIEM WHERE MASV IN(SELECT MASV FROM SINHVIEN WHERE MALOP ='" + txtMaLop.Text + "') AND LAN = 1 AND DIEM.MAMH = '" + cmbTenMon.SelectedValue.ToString() + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    s = Program.myReader.GetInt32(0);
                    if (s == 0)
                    {
                        MessageBox.Show("Nhập điểm lần 1 trước khi nhập lần 2!", "", MessageBoxButtons.OK);
                        txtMaLop.Focus();
                        Program.myReader.Close();
                        return;
                    }
                    Program.myReader.Close();
                }
                this.sp_GetValueDiemTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_GetValueDiemTableAdapter.Fill(this.dS.sp_GetValueDiem, cmbTenLop.SelectedValue.ToString(),
                cmbTenMon.SelectedValue.ToString(), new System.Nullable<short>(((short)(System.Convert.ChangeType(i, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            btnGhi.Enabled = true;
            btnBatDau.Enabled = false;
            panel2.Enabled = false;
            //btnBatDau.Enabled = panel1.Enabled = false;
            groupBox2.Enabled = true;
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '.' || c > '9')
                    return false;
            }

            return true;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sp_GetValueDiemBindingSource.MoveLast();
            sp_GetValueDiemBindingSource.MoveFirst();
            using (SqlConnection con = new SqlConnection(Program.connstr))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DIEM where masv='000'", con);
                da.InsertCommand = new SqlCommand("sp_InsertValueDiem", con);
                da.InsertCommand.CommandType = CommandType.StoredProcedure;

                da.InsertCommand.Parameters.Add("@MASV", SqlDbType.Char, 12, "masv");
                da.InsertCommand.Parameters.Add("@MAMH", SqlDbType.Char, 6, "mamh");
                da.InsertCommand.Parameters.Add("@LAN", SqlDbType.SmallInt, 1, "lan");
                da.InsertCommand.Parameters.Add("@DIEM", SqlDbType.Float, 8, "diem");

                DataSet ds = new DataSet();
                da.Fill(ds, "BANGDIEM");
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    //dataGridView1.EndEdit();
                    DataRow newRow = ds.Tables["BANGDIEM"].NewRow();
                    newRow["masv"] = gridView1.GetRowCellValue(i, "MASV").ToString();
                    newRow["mamh"] = txtMaMon.Text;
                    newRow["lan"] = cmbLanThi.SelectedItem;
                    if (IsDigitsOnly(gridView1.GetRowCellValue(i, "DIEM").ToString()) == false)
                    {
                        MessageBox.Show("Điểm chỉ từ 0 đến 10 và chỉ có số !! Vui lòng kiểm tra lại", "", MessageBoxButtons.OK);
                        return;
                    }
                    string a = gridView1.GetRowCellValue(i, "DIEM").ToString();
                    if (a == "")
                    {
                        newRow["diem"] = 0;
                    }
                    else
                    {
                        newRow["diem"] = gridView1.GetRowCellValue(i, "DIEM").ToString();
                    }
                    ds.Tables["BANGDIEM"].Rows.Add(newRow);
                }
                da.Update(ds, "BANGDIEM");
                con.Close();
            }
            try
            {
                this.sp_GetValueDiemTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_GetValueDiemTableAdapter.Fill(this.dS.sp_GetValueDiem, txtMaLop.Text, txtMaMon.Text, new System.Nullable<short>(((short)(System.Convert.ChangeType(cmbLanThi.SelectedItem, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            btnGhi.Enabled = false;
            btnBatDau.Enabled = cmbKhoa.Enabled = panel1.Enabled = true;
            panel2.Enabled = true;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
            panel1.Enabled = true;
            btnBatDau.Enabled = true;
            try
            {
                this.sp_GetValueDiemTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_GetValueDiemTableAdapter.Fill(this.dS.sp_GetValueDiem, txtMaLop.Text, txtMaMon.Text, new System.Nullable<short>(((short)(System.Convert.ChangeType(cmbLanThi.SelectedItem, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            btnGhi.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbKhoa.DataSource = null;
            this.Close();
        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
