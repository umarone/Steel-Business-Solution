using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Common;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmLedgerreport : Form
    {
        #region Variables
        ConnectionInfo oConnectionInfo = new ConnectionInfo();
        public string AccountNo
        {
            get;
            set;
        }
        public string ReportType
        {
            get;
            set;
        }
        public DateTime StartDate 
        { 
            get; 
            set;
        }
        public DateTime EndDate
        {
            get;
            set;
        }
        #endregion
        #region Form Methods And Events
        public frmLedgerreport()
        {
            InitializeComponent();
        }
        private void frmLedgerreport_Load(object sender, EventArgs e)
        {
            PrintReport();
        }
        private void frmLedgerreport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void PrintReport()
        {
            string strSchemaName = "Reports";
            ReportDocument RptDocument = new ReportDocument();
            if (ReportType == "LederReport")
            {
                RptDocument.Load("..//..//Financial Reports/rptLedger.rpt");
            }
            else
            {
                RptDocument.Load("..//..//Financial Reports/rptDateWiseLedger.rpt");
            }
            TableLogOnInfo oTableLogOnInfo = new TableLogOnInfo();
            DbConnectionStringBuilder connectionBuilder = new DbConnectionStringBuilder();
            connectionBuilder.ConnectionString = DBHelper.DataConnection;
            oConnectionInfo.ServerName = connectionBuilder["Data Source"].ToString();
            oConnectionInfo.DatabaseName = connectionBuilder["initial catalog"].ToString();
            oConnectionInfo.UserID = connectionBuilder["user id"].ToString();
            oConnectionInfo.Password = connectionBuilder["password"].ToString();
            //oConnectionInfo.IntegratedSecurity = true;
            oConnectionInfo.Type = ConnectionInfoType.SQL;


            foreach (CrystalDecisions.CrystalReports.Engine.Table oTable in RptDocument.Database.Tables)
            {
                oTableLogOnInfo = oTable.LogOnInfo;
                oTableLogOnInfo.ConnectionInfo = oConnectionInfo;
                oTable.ApplyLogOnInfo(oTableLogOnInfo);
            }

            for (int i = 0; i <= RptDocument.Database.Tables.Count - 1; i++)
            {
                RptDocument.Database.Tables[i].Location = oConnectionInfo.DatabaseName + "." + strSchemaName + "." + RptDocument.Database.Tables[i].Location.Substring(RptDocument.Database.Tables[i].Location.LastIndexOf(".") + 1);
            }

            ParameterFieldDefinitions crParamFieldDefinitions = RptDocument.DataDefinition.ParameterFields;
            foreach (ParameterFieldDefinition def in crParamFieldDefinitions)
            {

                if (def.ReportName == "")
                {
                    if (ReportType == "LederReport")
                    {
                        if (def.ParameterFieldName == "@AccountNo")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = AccountNo;
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@IdProject")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = Operations.IdProject; //"{" + Operations.IdCompany + "}";
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@BookNo")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = Operations.BookNo; //"{" + Operations.IdCompany + "}";
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "ProjectName")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = Operations.ProjectName; //"{" + Operations.IdCompany + "}";
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                    }
                    else
                    {
                        if (def.ParameterFieldName == "@AccountNo")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = AccountNo;
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@IdCompany")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = "{" + Operations.IdCompany + "}";
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@IdProject")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = Operations.IdProject; //"{" + Operations.IdCompany + "}";
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@BookNo")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = Operations.BookNo; //"{" + Operations.IdCompany + "}";
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "ProjectName")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = Operations.ProjectName; //"{" + Operations.IdCompany + "}";
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@StartDate")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;

                            crParamDiscreteValue.Value = StartDate;
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@EndDate")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;

                            crParamDiscreteValue.Value = EndDate;
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                    }

                }
            }
            //PageMargins margins = RptDocument.PrintOptions.PageMargins;
            //margins.bottomMargin = 350;/
            //margins.leftMargin = 350;
            //margins.rightMargin = 350;
            //margins.topMargin = 350;   
            //RptDocument.PrintOptions.ApplyPageMargins(margins);

            ReportLedger.ReportSource = RptDocument;
            //RptDocument.PrintToPrinter(1, false, 0, 0);
            //reportViewer1.repo = RptDocument;

            // crystalReportViewer1.ReportSource = RptDocument;
        }
        #endregion
    }
}
