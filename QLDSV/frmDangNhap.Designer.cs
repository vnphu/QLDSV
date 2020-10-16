namespace QLDSV
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tENCNLabel;
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.bdsDS = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tENCNComboBox = new System.Windows.Forms.ComboBox();
            tENCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(95, 107);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(47, 13);
            tENCNLabel.TabIndex = 14;
            tENCNLabel.Text = "TENCN:";
            tENCNLabel.Click += new System.EventHandler(this.tENCNLabel_Click);
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDS
            // 
            this.bdsDS.DataMember = "V_DS_PHANMANH";
            this.bdsDS.DataSource = this.qLDSVDataSet;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(408, 267);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 34);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(212, 267);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(114, 34);
            this.btnDangnhap.TabIndex = 13;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(203, 209);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(319, 20);
            this.txtMK.TabIndex = 12;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(203, 150);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(319, 20);
            this.txtTenDangNhap.TabIndex = 11;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên đăng nhập";
            // 
            // tENCNComboBox
            // 
            this.tENCNComboBox.DataSource = this.bdsDS;
            this.tENCNComboBox.DisplayMember = "TENCN";
            this.tENCNComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tENCNComboBox.FormattingEnabled = true;
            this.tENCNComboBox.Location = new System.Drawing.Point(203, 99);
            this.tENCNComboBox.Name = "tENCNComboBox";
            this.tENCNComboBox.Size = new System.Drawing.Size(319, 21);
            this.tENCNComboBox.TabIndex = 15;
            this.tENCNComboBox.ValueMember = "TENSERVER";
            this.tENCNComboBox.SelectedIndexChanged += new System.EventHandler(this.tENCNComboBox_SelectedIndexChanged);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 646);
            this.Controls.Add(tENCNLabel);
            this.Controls.Add(this.tENCNComboBox);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource bdsDS;
        private QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tENCNComboBox;
    }
}