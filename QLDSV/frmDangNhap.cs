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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLDSVDataSet1.DIEM' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            tENCNComboBox.SelectedIndex = 1;
            tENCNComboBox.SelectedIndex = 0;

        }

        private void tENCNTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tENCNLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tENCNComboBox.SelectedValue != null)
            {
                Program.servername = tENCNComboBox.SelectedValue.ToString();
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                txtTenDangNhap.Focus();
                return;
            }
            Program.mlogin = txtTenDangNhap.Text;
            Program.password = txtMK.Text;
            if (Program.KetNoi() == 0) return;
            //MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);
            Program.mKhoa = tENCNComboBox.SelectedIndex;
            Program.bds_dspm = bdsDS;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.mKhoa = tENCNComboBox.SelectedIndex;
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh = new frmMain();
            this.Hide();
            Program.frmChinh.Show();
            //this.FormClosed += (o, w) => this.Show();
            Program.frmChinh.MaGV.Text = " Mã giảng viên : " + Program.username;
            Program.frmChinh.HoTen.Text = " Họ tên : " + Program.mHoten;
            Program.frmChinh.Nhom.Text = " Nhóm : " + Program.mGroup;
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
