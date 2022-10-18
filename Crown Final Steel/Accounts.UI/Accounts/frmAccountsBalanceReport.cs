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
    public partial class frmAccountsBalanceReport : Form
    {
        ConnectionInfo oConnectionInfo = new ConnectionInfo();
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
        public string AccountType
        {
            get;
            set;
        }
        public bool IsDateWiseBalanceReport
        {
            get;
            set;
        }
        public frmAccountsBalanceReport()
        {
            InitializeComponent();
        }

        private void frmAccountsBalanceReport_Load(object sender, EventArgs e)
        {
            PrintReport();
        }
        private void PrintReport()
        {
            string strSchemaName = "Reports";
            ReportDocument RptDocument = new ReportDocument();            
            if (AccountType == "Stock")
            {
                RptDocument.Load("..//..//Reports/rptStockAccountsBalances.rpt");
            }
            else
            {
                if (!IsDateWiseBalanceReport)
                {
                    RptDocument.Load("..//..//Financial Reports/rptAccountsBalances.rpt");
                }
                else
                {
                    RptDocument.Load("..//..//Financial Reports/rptAccountsBalancesWithDate.rpt");
                }
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
                    if (AccountType == "Stock")
                    {
                        if (def.ParameterFieldName == "@IdCompany")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;
                            crParamDiscreteValue.Value = "{" + Operations.IdCompany + "}";

                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                    }
                    else
                    {
                        if (!IsDateWiseBalanceReport)
                        {
                            if (def.ParameterFieldName == "@IdProject")
                            {
                                ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                                ParameterValues crCurrentValues = def.CurrentValues;
                                crParamDiscreteValue.Value = Operations.IdProject; //"{" + Operations.IdCompany + "}";

                                crCurrentValues.Add(crParamDiscreteValue);
                                def.ApplyCurrentValues(crCurrentValues);
                            }
                            else if (def.ParameterFieldName == "@BookNo")
                            {
                                ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                                ParameterValues crCurrentValues = def.CurrentValues;
                                crParamDiscreteValue.Value = Operations.BookNo; //"{" + Operations.IdCompany + "}";

                                crCurrentValues.Add(crParamDiscreteValue);
                                def.ApplyCurrentValues(crCurrentValues);
                            }
                            else if (def.ParameterFieldName == "@AccountType")
                            {
                                ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                                ParameterValues crCurrentValues = def.CurrentValues;
                                crParamDiscreteValue.Value = AccountType;


                                crCurrentValues.Add(crParamDiscreteValue);
                                def.ApplyCurrentValues(crCurrentValues);

                            }
                        }
                        else
                        {
                            if (def.ParameterFieldName == "@IdProject")
                            {
                                ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                                ParameterValues crCurrentValues = def.CurrentValues;
                                crParamDiscreteValue.Value = Operations.IdProject; //"{" + Operations.IdCompany + "}";

                                crCurrentValues.Add(crParamDiscreteValue);
                                def.ApplyCurrentValues(crCurrentValues);
                            }
                            else if (def.ParameterFieldName == "@BookNo")
                            {
                                ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                                ParameterValues crCurrentValues = def.CurrentValues;
                                crParamDiscreteValue.Value = Operations.BookNo; //"{" + Operations.IdCompany + "}";

                                crCurrentValues.Add(crParamDiscreteValue);
                                def.ApplyCurrentValues(crCurrentValues);
                            }
                            else if (def.ParameterFieldName == "@StartDate")
                            {
                                ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                                ParameterValues crCurrentValues = def.CurrentValues;


                                //string TayloringNumber = VoucherNo;

                                crParamDiscreteValue.Value = StartDate;
                                crCurrentValues.Add(crParamDiscreteValue);
                                def.ApplyCurrentValues(crCurrentValues);
                            }
                            else if (def.ParameterFieldName == "@EndDate")
                            {
                                ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                                ParameterValues crCurrentValues = def.CurrentValues;


                                //string TayloringNumber = VoucherNo;

                                crParamDiscreteValue.Value = EndDate;
                                crCurrentValues.Add(crParamDiscreteValue);
                                def.ApplyCurrentValues(crCurrentValues);
                            }
                            else if (def.ParameterFieldName == "@AccountType")
                            {
                                ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                                ParameterValues crCurrentValues = def.CurrentValues;
                                crParamDiscreteValue.Value = AccountType;


                                crCurrentValues.Add(crParamDiscreteValue);
                                def.ApplyCurrentValues(crCurrentValues);

                            }
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

            AccountsReport.ReportSource = RptDocument;
            //RptDocument.PrintToPrinter(1, false, 0, 0);
            //reportViewer1.repo = RptDocument;

            // crystalReportViewer1.ReportSource = RptDocument;
        }
    }
}
