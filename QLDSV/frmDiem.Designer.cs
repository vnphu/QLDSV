namespace QLDSV
{
    partial class frmDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiem));
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label tENMHLabel1;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label dIEMLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.sp_GetValueDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBatDau = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetValueDiemTableAdapter = new QLDSV.DSTableAdapters.sp_GetValueDiemTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.bdsDiem = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMTableAdapter = new QLDSV.DSTableAdapters.DIEMTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.Khoa = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.cmbLanThi = new System.Windows.Forms.ComboBox();
            this.cmbTenMon = new System.Windows.Forms.ComboBox();
            this.sp_GetValueDiemGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mASVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIEMSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            tENMHLabel1 = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            dIEMLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetValueDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetValueDiemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 406);
            this.panel1.TabIndex = 0;
            // 
            // sp_GetValueDiemBindingSource
            // 
            this.sp_GetValueDiemBindingSource.DataMember = "sp_GetValueDiem";
            this.sp_GetValueDiemBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBatDau,
            this.btnGhi,
            this.btnTaiLai,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBatDau),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaiLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBatDau
            // 
            this.btnBatDau.Caption = "Bắt đầu";
            this.btnBatDau.Id = 0;
            this.btnBatDau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBatDau.ImageOptions.Image")));
            this.btnBatDau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBatDau.ImageOptions.LargeImage")));
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnBatDau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBatDau_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 1;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Caption = "Tải lại";
            this.btnTaiLai.Id = 2;
            this.btnTaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.Image")));
            this.btnTaiLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.LargeImage")));
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiLai_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1280, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1280, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 406);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1280, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 406);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // sp_GetValueDiemTableAdapter
            // 
            this.sp_GetValueDiemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDiem
            // 
            this.bdsDiem.DataMember = "DIEM";
            this.bdsDiem.DataSource = this.dS;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(tENMHLabel1);
            this.panel2.Controls.Add(this.cmbTenMon);
            this.panel2.Controls.Add(this.cmbLanThi);
            this.panel2.Controls.Add(this.cmbKhoa);
            this.panel2.Controls.Add(lANLabel);
            this.panel2.Controls.Add(this.txtMaMon);
            this.panel2.Controls.Add(this.Khoa);
            this.panel2.Controls.Add(tENMHLabel);
            this.panel2.Controls.Add(this.txtMaLop);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(tENLOPLabel);
            this.panel2.Controls.Add(this.cmbTenLop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1274, 129);
            this.panel2.TabIndex = 17;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.lOPBindingSource;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(319, 16);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(403, 21);
            this.cmbTenLop.TabIndex = 3;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.cmbTenLop_SelectedIndexChanged);
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(262, 52);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(53, 19);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Enabled = false;
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(319, 49);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(403, 26);
            this.txtMaLop.TabIndex = 42;
            this.txtMaLop.TextChanged += new System.EventHandler(this.txtMaLop_TextChanged);
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.Location = new System.Drawing.Point(728, 52);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(60, 19);
            tENMHLabel.TabIndex = 4;
            tENMHLabel.Text = "Mã môn";
            // 
            // Khoa
            // 
            this.Khoa.AutoSize = true;
            this.Khoa.Location = new System.Drawing.Point(12, 32);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(32, 13);
            this.Khoa.TabIndex = 0;
            this.Khoa.Text = "Khoa";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Enabled = false;
            this.txtMaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Location = new System.Drawing.Point(794, 49);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(259, 26);
            this.txtMaMon.TabIndex = 43;
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(1059, 40);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(39, 13);
            lANLabel.TabIndex = 6;
            lANLabel.Text = "Lần thi";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(61, 29);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(195, 21);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged_1);
            // 
            // cmbLanThi
            // 
            this.cmbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanThi.FormattingEnabled = true;
            this.cmbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLanThi.Location = new System.Drawing.Point(1115, 37);
            this.cmbLanThi.Name = "cmbLanThi";
            this.cmbLanThi.Size = new System.Drawing.Size(121, 21);
            this.cmbLanThi.TabIndex = 44;
            this.cmbLanThi.SelectedIndexChanged += new System.EventHandler(this.cmbLanThi_SelectedIndexChanged);
            // 
            // cmbTenMon
            // 
            this.cmbTenMon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.cmbTenMon.DataSource = this.mONHOCBindingSource;
            this.cmbTenMon.DisplayMember = "TENMH";
            this.cmbTenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMon.FormattingEnabled = true;
            this.cmbTenMon.Location = new System.Drawing.Point(855, 23);
            this.cmbTenMon.Name = "cmbTenMon";
            this.cmbTenMon.Size = new System.Drawing.Size(121, 21);
            this.cmbTenMon.TabIndex = 45;
            this.cmbTenMon.ValueMember = "MAMH";
            this.cmbTenMon.SelectedIndexChanged += new System.EventHandler(this.tENMHComboBox_SelectedIndexChanged);
            // 
            // tENMHLabel1
            // 
            tENMHLabel1.AutoSize = true;
            tENMHLabel1.Location = new System.Drawing.Point(800, 26);
            tENMHLabel1.Name = "tENMHLabel1";
            tENMHLabel1.Size = new System.Drawing.Size(49, 13);
            tENMHLabel1.TabIndex = 44;
            tENMHLabel1.Text = "TENMH:";
            // 
            // sp_GetValueDiemGridControl
            // 
            this.sp_GetValueDiemGridControl.DataSource = this.sp_GetValueDiemBindingSource;
            this.sp_GetValueDiemGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sp_GetValueDiemGridControl.Location = new System.Drawing.Point(3, 145);
            this.sp_GetValueDiemGridControl.MainView = this.gridView1;
            this.sp_GetValueDiemGridControl.MenuManager = this.barManager1;
            this.sp_GetValueDiemGridControl.Name = "sp_GetValueDiemGridControl";
            this.sp_GetValueDiemGridControl.Size = new System.Drawing.Size(1274, 139);
            this.sp_GetValueDiemGridControl.TabIndex = 17;
            this.sp_GetValueDiemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            this.colDIEM});
            this.gridView1.GridControl = this.sp_GetValueDiemGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.sp_GetValueDiemGridControl);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1280, 406);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(mASVLabel);
            this.groupBox2.Controls.Add(this.mASVTextEdit);
            this.groupBox2.Controls.Add(hOTENLabel);
            this.groupBox2.Controls.Add(this.hOTENTextEdit);
            this.groupBox2.Controls.Add(dIEMLabel);
            this.groupBox2.Controls.Add(this.dIEMSpinEdit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1274, 119);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(381, 25);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(40, 13);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // mASVTextEdit
            // 
            this.mASVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sp_GetValueDiemBindingSource, "MASV", true));
            this.mASVTextEdit.Location = new System.Drawing.Point(435, 22);
            this.mASVTextEdit.MenuManager = this.barManager1;
            this.mASVTextEdit.Name = "mASVTextEdit";
            this.mASVTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mASVTextEdit.TabIndex = 1;
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(381, 51);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(48, 13);
            hOTENLabel.TabIndex = 2;
            hOTENLabel.Text = "HOTEN:";
            // 
            // hOTENTextEdit
            // 
            this.hOTENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sp_GetValueDiemBindingSource, "HOTEN", true));
            this.hOTENTextEdit.Location = new System.Drawing.Point(435, 48);
            this.hOTENTextEdit.MenuManager = this.barManager1;
            this.hOTENTextEdit.Name = "hOTENTextEdit";
            this.hOTENTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hOTENTextEdit.TabIndex = 3;
            // 
            // dIEMLabel
            // 
            dIEMLabel.AutoSize = true;
            dIEMLabel.Location = new System.Drawing.Point(381, 77);
            dIEMLabel.Name = "dIEMLabel";
            dIEMLabel.Size = new System.Drawing.Size(37, 13);
            dIEMLabel.TabIndex = 4;
            dIEMLabel.Text = "DIEM:";
            // 
            // dIEMSpinEdit
            // 
            this.dIEMSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sp_GetValueDiemBindingSource, "DIEM", true));
            this.dIEMSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dIEMSpinEdit.Location = new System.Drawing.Point(435, 74);
            this.dIEMSpinEdit.MenuManager = this.barManager1;
            this.dIEMSpinEdit.Name = "dIEMSpinEdit";
            this.dIEMSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dIEMSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.dIEMSpinEdit.TabIndex = 5;
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDiem";
            this.Text = "frmDiem";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetValueDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetValueDiemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnBatDau;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource sp_GetValueDiemBindingSource;
        private DS dS;
        private DSTableAdapters.sp_GetValueDiemTableAdapter sp_GetValueDiemTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsDiem;
        private DSTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit mASVTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTENTextEdit;
        private DevExpress.XtraEditors.SpinEdit dIEMSpinEdit;
        private DevExpress.XtraGrid.GridControl sp_GetValueDiemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbTenMon;
        private System.Windows.Forms.ComboBox cmbLanThi;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label Khoa;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTenLop;
    }
}