using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.EL;
using Accounts.BLL;
using Accounts.Common;
using MetroFramework.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Common;


namespace Accounts.UI
{
    public partial class frmProjectWiseDatedSales : MetroForm
    {
        #region Variables
        frmFindAccounts frmAccount;
        string AccountNo = string.Empty;
        ConnectionInfo oConnectionInfo = new ConnectionInfo();
        #endregion
        #region Form Methods And Events
        public frmProjectWiseDatedSales()
        {
            InitializeComponent();
        }
        #endregion
        #region Custom And Window Controls Events And Methods
        private void txtDeliveryPerson_ButtonClick(object sender, EventArgs e)
        {
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog();
        }
        private void txtDeliveryPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                e.Handled = true;
                frmAccount = new frmFindAccounts();
                frmAccount.SearchText = e.KeyChar.ToString();
                frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
                frmAccount.ShowDialog();
            }
            else
                e.Handled = false;
        }
        void frmAccount_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            AccountNo = oelAccount.AccountNo;
            txtDeliveryPerson.Text = oelAccount.AccountName;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new SalesHeadBLL();
            bool IsNetTran = false;
            if (ChkCredit.Checked)
            {
                IsNetTran = false;
            }
            else
            {
                IsNetTran = true;
            }
            List<VoucherDetailEL> list = manager.GetAllProjectWiseDatedSales(Operations.IdProject, Operations.BookNo, AccountNo, dtStart.Value, dtEnd.Value, IsNetTran);
            if (list.Count > 0)
            {
                cbxInvoices.DisplayMember = "VoucherNo";
                cbxInvoices.ValueMember = "IdVoucher";
                cbxInvoices.DataSource = list;
               
            }
        }
        private void cbxInvoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxInvoices.Text != string.Empty)
            PrintReport();
        }
        #endregion
        #region Page Methods
        private void PrintReport()
        {
            string strSchemaName = "Reports";
            ReportDocument RptDocument = new ReportDocument();
            string ReportName = Operations.ProjectInvoiceName + ".rpt";
            RptDocument.Load("..//..//Reports/"+ReportName+"");

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

                    if (def.ParameterFieldName == "@VoucherNo")
                    {
                        ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                        ParameterValues crCurrentValues = def.CurrentValues;


                        //string TayloringNumber = VoucherNo;

                        crParamDiscreteValue.Value = cbxInvoices.Text;
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
                    else if (def.ParameterFieldName == "@IsNetTransaction")
                    {
                        ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                        ParameterValues crCurrentValues = def.CurrentValues;

                        crParamDiscreteValue.Value = ChkCredit.Checked ? false : true;
                        crCurrentValues.Add(crParamDiscreteValue);
                        def.ApplyCurrentValues(crCurrentValues);
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
