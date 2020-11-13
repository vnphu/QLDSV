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
    public partial class frmDangKyTaiKhoan : Form
    {
        public frmDangKyTaiKhoan()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmDangKyTaiKhoan_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.sP_DSChuaCoTKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSChuaCoTKTableAdapter.Fill(this.dS.SP_DSChuaCoTK);

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;
           
            cmbRoles.Items.Clear();
            cmbRoles.Items.Add("PGV");
            cmbRoles.Items.Add("Khoa");
            cmbRoles.Items.Add("User");
            cmbRoles.Items.Add("PKeToan");
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
                cmbRoles.Items.RemoveAt(3);
                cmbRoles.SelectedIndex = 0;
                cmbRoles.Enabled = true;
            }
           
            if (Program.mGroup != "PGV")
            {
                cmbKhoa.Enabled = false;
            }
            if (Program.mGroup == "Khoa")
            {
                cmbRoles.SelectedIndex = 1;
                //cmbRoles.Items.RemoveAt(3);
                //cmbRoles.Items.RemoveAt(0);
                cmbRoles.Enabled = false;
            }
            if (Program.mGroup == "PKeToan")
            {
                cmbRoles.SelectedIndex = 2;
                cmbRoles.Enabled = false;
            }

        }

        private void tENKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (Program.mGroup == "PGV" && cmbKhoa.SelectedIndex != Program.mKhoa)
            {
                cmbKhoa.SelectedIndex = Program.mKhoa;
            }
            this.Close();

        }

        private void tENLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Tên đăng nhập or mật khẩu bị trống", "", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection con = new SqlConnection(Program.connstr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TaoTaiKhoan"))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@LGNAME", SqlDbType.VarChar, 50).Value = txtTenDangNhap.Text;
                    cmd.Parameters.Add("@PASS", SqlDbType.VarChar, 50).Value = txtMatKhau.Text;
                    cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar, 50).Value = cmbMaGV.SelectedValue.ToString();
                    cmd.Parameters.Add("@ROLE", SqlDbType.VarChar, 50).Value = cmbRoles.Text;
                    if (MessageBox.Show("Tên đăng nhập : " + txtTenDangNhap.Text + " Mật khẩu: " + txtMatKhau.Text + " Mã GV: " + cmbMaGV.SelectedValue.ToString() + " Nhóm: " + cmbRoles.Text,
                        "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        SqlParameter prmt = new SqlParameter();
                        prmt = cmd.Parameters.Add("RETURN_VALUE", SqlDbType.Int);
                        prmt.Direction = ParameterDirection.ReturnValue;
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show(" Tạo tài khoản mới thành công !", "", MessageBoxButtons.OK);
                            txtTenDangNhap.Text = "";
                            txtMatKhau.Text = "";
                        }
                        catch (Exception ex)
                        {
                            int check = (int)cmd.Parameters["return_value"].Value;
                            if (check == 1)
                            {
                                MessageBox.Show("Tên đăng nhập đã tồn tại\n\n " + ex.Message);
                            }
                            if (check == 2)
                            {
                                MessageBox.Show("Mã giảng viên đã tồn tại\n\n " + ex.Message);
                            }
                            con.Close();
                        }
                    }
                    con.Close();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;

                Program.servername = cmbKhoa.SelectedValue.ToString();
                if(Program.mGroup == "PGV" && cmbKhoa.SelectedIndex == 2)
                {
                    MessageBox.Show("Bạn không có quyền truy cập", "", MessageBoxButtons.OK);
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
                    this.sP_DSChuaCoTKTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_DSChuaCoTKTableAdapter.Fill(this.dS.SP_DSChuaCoTK);
                    if (Program.mGroup == "PGV")
                    {
                        cmbKhoa.Enabled = true;
                        try
                        {
                            cmbRoles.Items.Clear();
                            cmbRoles.Items.Add("PGV");
                            cmbRoles.Items.Add("Khoa");
                            cmbRoles.Items.Add("User");
                            cmbRoles.Items.Add("PKeToan");

                            cmbRoles.Enabled = true;
                            cmbRoles.Items.RemoveAt(3);
                            cmbRoles.SelectedIndex = 0;
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    if (Program.mGroup == "PGV" && cmbKhoa.SelectedIndex.ToString() == "2")
                    {
                        cmbKhoa.Enabled = true;
                        try
                        {
                            cmbRoles.Items.Clear();
                            cmbRoles.Items.Add("PGV");
                            cmbRoles.Items.Add("Khoa");
                            cmbRoles.Items.Add("User");
                            cmbRoles.Items.Add("PKeToan");
                            cmbRoles.SelectedIndex = 3;
                            cmbRoles.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
