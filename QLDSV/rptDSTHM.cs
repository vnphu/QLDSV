using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class rptDSTHM : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDSTHM(String malop)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_DSTHM_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DSTHM_ReportTableAdapter.Fill(ds1.sp_DSTHM_Report, malop);
        }

    }
}
