using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.Common;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmPriceListReport : Form
    {
        ConnectionInfo oConnectionInfo = new ConnectionInfo();
        public frmPriceListReport()
        {
            InitializeComponent();
        }

        private void frmPriceListReport_Load(object sender, EventArgs e)
        {
            PrintReport();
        }
        private void PrintReport()
        {
            ReportDocument RptDocument = new ReportDocument();
            RptDocument.Load("..//..//Reports/rptPriceList.rpt");
            TableLogOnInfo oTableLogOnInfo = new TableLogOnInfo();
            DbConnectionStringBuilder connectionBuilder = new DbConnectionStringBuilder();
            connectionBuilder.ConnectionString = DBHelper.DataConnection;
            oConnectionInfo.ServerName = connectionBuilder["Data Source"].ToString();
            oConnectionInfo.DatabaseName = connectionBuilder["initial catalog"].ToString();
            // oConnectionInfo.UserID = connectionBuilder["user id"].ToString();
            //oConnectionInfo.Password = connectionBuilder["password"].ToString();
            oConnectionInfo.IntegratedSecurity = true;
            oConnectionInfo.Type = ConnectionInfoType.SQL;


            foreach (CrystalDecisions.CrystalReports.Engine.Table oTable in RptDocument.Database.Tables)
            {
                oTableLogOnInfo = oTable.LogOnInfo;
                oTableLogOnInfo.ConnectionInfo = oConnectionInfo;
                oTable.ApplyLogOnInfo(oTableLogOnInfo);
            }


            ParameterFieldDefinitions crParamFieldDefinitions = RptDocument.DataDefinition.ParameterFields;
            foreach (ParameterFieldDefinition def in crParamFieldDefinitions)
            {

                if (def.ReportName == "")
                {
                    if (def.ParameterFieldName == "@IdProject")
                    {
                        ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                        ParameterValues crCurrentValues = def.CurrentValues;


                        //string TayloringNumber = VoucherNo;

                        crParamDiscreteValue.Value = Operations.IdProject;
                        crCurrentValues.Add(crParamDiscreteValue);
                        def.ApplyCurrentValues(crCurrentValues);
                    }
                }
            }
            //        else if (def.ParameterFieldName == "@EndDate")
            //        {
            //            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
            //            ParameterValues crCurrentValues = def.CurrentValues;


            //            //string TayloringNumber = VoucherNo;

            //            crParamDiscreteValue.Value = EndDate;
            //            crCurrentValues.Add(crParamDiscreteValue);
            //            def.ApplyCurrentValues(crCurrentValues);
            //        }

            //    }
            //}
            //PageMargins margins = RptDocument.PrintOptions.PageMargins;
            //margins.bottomMargin = 350;/
            //margins.leftMargin = 350;
            //margins.rightMargin = 350;
            //margins.topMargin = 350;   
            //RptDocument.PrintOptions.ApplyPageMargins(margins);

            PriceListViewer.ReportSource = RptDocument;
            //RptDocument.PrintToPrinter(1, false, 0, 0);
            //reportViewer1.repo = RptDocument;

            // crystalReportViewer1.ReportSource = RptDocument;
        }
    }
}
