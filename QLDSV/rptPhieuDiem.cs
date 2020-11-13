using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class rptPhieuDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPhieuDiem(String masv)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_PhieuDiem_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_PhieuDiem_ReportTableAdapter.Fill(ds1.sp_PhieuDiem_Report, masv);
        }

    }
}
