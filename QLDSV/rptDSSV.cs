using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class rptDSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDSSV(String malop)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_DSSV_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DSSV_ReportTableAdapter.Fill(ds1.sp_DSSV_Report, malop);
        }

    }
}
