using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class rpHoaDon : Form
    {
        public rpHoaDon()
        {
            InitializeComponent();
        }

        public void Loadrp(String reportfilter = null)
        {
            string report = @"C:\Users\duyph\source\repos\olle211\QLCF\crHoaDon.rpt";
            ReportDocument rpt = new ReportDocument();
            rpt.Load(report);

            TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
            tableLogOnInfo.ConnectionInfo.ServerName = "DESKTOP-GVL37U5";
            tableLogOnInfo.ConnectionInfo.DatabaseName = "QL_QuanCafe";
            tableLogOnInfo.ConnectionInfo.UserID = "sa";
            tableLogOnInfo.ConnectionInfo.Password = "11223344";
            foreach (Table t in rpt.Database.Tables)
            {
                t.ApplyLogOnInfo(tableLogOnInfo);
            }
            if (reportfilter != "" && reportfilter != null)
            {
                rpt.RecordSelectionFormula = reportfilter;
            }

            crvHoaDon.ReportSource = rpt;
            crvHoaDon.Refresh();
        }

        private void rpHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
