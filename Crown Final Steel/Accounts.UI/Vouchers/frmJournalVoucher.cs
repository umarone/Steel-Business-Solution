using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.Common;
using Accounts.EL;
using Accounts.BLL;

using MetroFramework.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Common;

namespace Accounts.UI
{
    public partial class frmJournalVoucher : MetroForm
    {
        #region Variables
        frmPrintVouchers frmprintVouchers = null;
        frmFindAccounts frmAccount;
        frmFindVouchers frmfindVouchers;
        public decimal OldValue { get; set; }
        public Int64? IdVoucher;
        public Int64? CashTransactionId { get; set; }
        Int64 FirstVoucherNo,LastVoucherNo, FirstVoucherId, LastVoucherId, ResultantVoucher = 0;
        public string VoucherType { get; set; }
        TextBox txtDebit = new TextBox();
        TextBox txtCredit = new TextBox();
        ConnectionInfo oConnectionInfo = new ConnectionInfo();
        DateTime? VoucherDateTime = DateTime.Now;

        public decimal VoucherPreviousBillAmount = 0;
        bool IsEditedDateChanged = false;
        int DateStatus = 0;

        #endregion
        #region Form Events and Methods
        public frmJournalVoucher()
        {
            InitializeComponent();
        }
        private void frmJournalVoucher_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FillTotalVouchers();
            GetLastVoucherTransactionByType();
            FillData();
            CreateAndInitializeFooterRow();
            //DgvVoucher.Columns[6].Visible = false;
            CheckModulePermissions();
        }
        private void frmJournalVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (IdVoucher != null && IdVoucher > 0)
                {                    
                    ClearControl();
                    if (DgvVoucher.Rows.Count > 0)
                    {
                        DgvVoucher.Rows.Clear();
                    }
                    FillData();
                }
                else
                {
                    this.Close();
                }
            }
        }        
        #endregion
        #region Simple Custom Methods
        private void CheckModulePermissions()
        {
            List<UserModulesPermissionsEL> PermissionsList = UserPermissions.GetUserModulePermissionsByUserAndModuleId(Operations.UserID);
            if (PermissionsList != null && PermissionsList.Count > 0)
            {
                if (PermissionsList[0].Saving == true)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
                if (PermissionsList[0].Deleting == true)
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }
                if (PermissionsList[0].Posting == true)
                {
                    btnSave.Enabled = true;
                    chkPosted.Checked = true;
                    chkPosted.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = false;
                    chkPosted.Checked = false;
                    chkPosted.Enabled = true;
                }
            }
            //else
            //{
            //    btnSave.Enabled = false;
            //    btnDelete.Enabled = false;
            //    chkPosted.Checked = true;
            //    chkPosted.Enabled = true;
            //}

        }
        private void FillData()
        {
            var manager = new VoucherBLL();
            txtVoucherNumber.Text = manager.GetMaxVoucherNumber(VoucherType, Operations.IdProject, Operations.BookNo);
        }
        private void FillTotalVouchers()
        {
            var Manager = new VoucherBLL();
            lblTotalVouchers.Text = Manager.GetTotalTransactionalVouchersByType(Operations.IdProject, Operations.BookNo, VoucherType).ToString();
        }
        private void GetLastVoucherTransactionByType()
        {
            var Manager = new VoucherBLL();
            List<VouchersEL> listFirst = Manager.GetFirstVoucherTransactionByType(Operations.IdProject, Operations.BookNo, VoucherType);
            List<VouchersEL> listLast = Manager.GetLastVoucherTransactionByType(Operations.IdProject, Operations.BookNo, VoucherType);
            if (listFirst.Count > 0 && listLast.Count > 0)
            {
                FirstVoucherNo = listFirst[0].VoucherNo;
                FirstVoucherId = listFirst[0].IdVoucher.Value;
                LastVoucherId = listLast[0].IdVoucher.Value;
                LastVoucherNo = listLast[0].VoucherNo;
                ResultantVoucher = LastVoucherId - FirstVoucherId;
                lblLastVoucherNo.Text = LastVoucherId.ToString();
            }
        }
        private void CreateAndInitializeFooterRow()
        {
            txtDebit.Enabled = false;
            txtDebit.TextAlign = HorizontalAlignment.Left;
            txtDebit.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);

            int hostCellLocation = DgvVoucher.GetCellDisplayRectangle(7, -1, true).X;

            txtDebit.Width = DgvVoucher.Columns[7].Width; //+SystemInformation.VerticalScrollBarWidth;
            txtDebit.Location = new Point(hostCellLocation, DgvVoucher.Height - txtDebit.Height);

            DgvVoucher.Controls.Add(txtDebit);

            txtDebit.BringToFront();

            txtCredit.Enabled = false;
            txtCredit.TextAlign = HorizontalAlignment.Left;
            txtCredit.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);

            int hostCreditCellLocation = DgvVoucher.GetCellDisplayRectangle(8, -1, true).X;
            txtCredit.Width = DgvVoucher.Columns[8].Width; //+SystemInformation.VerticalScrollBarWidth;
            txtCredit.Location = new Point(hostCreditCellLocation, DgvVoucher.Height - txtCredit.Height);

            DgvVoucher.Controls.Add(txtCredit);

            txtCredit.BringToFront();
        }
        private bool ValidateRows()
        {
            bool Status = true;
            if (DgvVoucher.Rows.Count > 1)
            {
                for (int i = 0; i < DgvVoucher.Rows.Count - 1; i++)
                {
                    if (DgvVoucher.Rows[i].Cells["colAccountNo"].Value == null)
                    {
                        Status = false;
                    }
                    //else if (DgvVoucher.Rows[i].Cells["colDebit"].Value == null)
                    //{
                    //    return false;
                    //}
                    //else if (DgvVoucher.Rows[i].Cells["colCredit"].Value == null)
                    //{
                    //    return false;
                    //}
                }
            }
            else
            {
                Status = false;
            }
            return Status;
        }
        private bool ValidateControls()
        {
            return true;
        }
        private void ClearControl()
        {
            DgvVoucher.Rows.Clear();
            //txtVoucherNumber.Text = string.Empty;
            txtVoucherNumber.Enabled = true;
            VEditBox.Text = string.Empty;
            txtDescription.Text = string.Empty;
            IdVoucher = null;
            //txtAmount.Text = string.Empty;
            txtDebit.Text = string.Empty;
            txtCredit.Text = string.Empty;
            CashTransactionId = null;
            lblStatuMessage.Text = string.Empty;
            VDate.Value = DateTime.Now;
            VDate.Enabled = true;
            VEditedDateTime.Value = DateTime.Now;
            if (chkPosted.Checked)
            {
                chkPosted.Checked = false;
                chkPosted.Enabled = true;
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnSave.Enabled = true;
            }

            VoucherPreviousBillAmount = 0;
            IsEditedDateChanged = false;
            DateStatus = 1;
        }
        private bool ValidateBookPeriod()
        {
            bool Status = true;
            if (Operations.BookPeriod == "" || Operations.BookPeriod == "Open")
            {
                Status = true;
            }
            else
            {
                string[] Period = Operations.BookPeriod.Split('=');
                if (Period.Length == 2)
                {
                    int FirstMonth = Convert.ToInt32(Period[0].Split(',')[0]);
                    int FirstYear = Convert.ToInt32(Period[0].Split(',')[1]);

                    int SecondMonth = Convert.ToInt32(Period[1].Split(',')[0]);
                    int SecondYear = Convert.ToInt32(Period[1].Split(',')[1]);
                    if (VDate.Value.Year == FirstYear || VDate.Value.Year == SecondYear)
                    {
                        if (VDate.Value.Month < FirstMonth && VDate.Value.Year == FirstYear)
                        {
                            Status = false;
                        }
                        else if (VDate.Value.Month > SecondMonth && VDate.Value.Year == SecondYear)
                        {
                            Status = false;
                        }
                        else
                        {
                            Status = true;
                        }
                    }
                    else
                    {
                        Status = false;
                    }
                    //if (VDate.Value.Month == FirstMonth && VDate.Value.Year == FirstYear || (VDate.Value.Month == SecondMonth && VDate.Value.Year == SecondYear))
                    //{
                    //    Status = true;
                    //}
                }
                else
                {
                    Status = false;
                }
            }
            return Status;
        }
        #endregion
        #region Other Controls Methods And Events
        void frmAccount_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            DgvVoucher.RefreshEdit();
            List<TransactionsEL> listColBalance = new List<TransactionsEL>();
            var manager = new AccountsBLL();
            List<AccountsEL> list = manager.GetAccount(oelAccount.AccountNo, Operations.IdCompany, Operations.IdProject);
            if (list.Count > 0)
            {
                //for (int i = 0; i < DgvVoucher.Rows.Count - 1; i++)
                //{
                //    if (DgvVoucher.Rows[i].Cells["colAccountNo"].Value != null)
                //    {
                //        if (oelAccount.AccountNo == Validation.GetSafeString(DgvVoucher.Rows[i].Cells["colAccountNo"].Value))
                //        {
                //            lblStatuMessage.Text = "Account Already exists";
                //            return;
                //        }
                //    }
                //}
            }

            DgvVoucher.CurrentRow.Cells["colIdAccount"].Value = oelAccount.IdAccount;
            DgvVoucher.CurrentRow.Cells["colAccountNo"].Value = oelAccount.AccountNo;
            DgvVoucher.CurrentRow.Cells["colHeadType"].Value = oelAccount.AccountType;
            DgvVoucher.CurrentRow.Cells["colAccountName"].Value = oelAccount.AccountName;
            listColBalance = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, oelAccount.AccountNo);
            if (listColBalance.Count > 0)
            {
                DgvVoucher.CurrentRow.Cells["colClosingBalance"].Value = listColBalance[0].ClosingBalance;
            }
            else
            {
                DgvVoucher.CurrentRow.Cells["colClosingBalance"].Value = 0;
            }
            DgvVoucher.Focus();
            lblStatuMessage.Text = "";

        }
        void frmfindVouchers_ExecuteFindVouchersEvent(VouchersEL oelVoucher)
        {
            LastVoucherId = oelVoucher.IdVoucher.Value;
            LastVoucherNo = oelVoucher.VoucherNo;
            txtVoucherNumber.Text = oelVoucher.VoucherNo.ToString();
            txtVoucherNumber.Enabled = false;
            FillVoucher();
        }
        private void txtVoucherNumber_ButtonClick(object sender, EventArgs e)
        {
            frmfindVouchers = new frmFindVouchers();
            frmfindVouchers.VoucherType = VoucherType;
            frmfindVouchers.ExecuteFindVouchersEvent += new frmFindVouchers.VouchersDelegate(frmfindVouchers_ExecuteFindVouchersEvent);
            frmfindVouchers.ShowDialog(this);
        }
        private void txtVoucherNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    FillVoucherByNumber(Validation.GetSafeLong(txtVoucherNumber.Text));
                }
            }
            else
                e.Handled = true;
        }
        #endregion        
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<VoucherDetailEL> oelVoucherDetailCollection = new List<VoucherDetailEL>();
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SoftwareChecksEL oelSoftwareCheck = DataOperations.SoftwareChecks.ToList().Find(x => x.SoftwareCheckName == "FinancialVoucherPrint");
            string InvolvementMsg;
            if (ValidateRows())
            {
                if (ValidateControls())
                {
                    if (IsTransactionalAccountExceeding(out InvolvementMsg))
                    {
                        MessageBox.Show(InvolvementMsg);
                        return;
                    }
                    /// Add Voucher...
                    VouchersEL oelVoucher = new VouchersEL();
                    if (!IdVoucher.HasValue)
                    {
                        oelVoucher.IdVoucher = 0;
                    }
                    else
                    {
                        oelVoucher.IdVoucher = IdVoucher.Value;
                    }
                    oelVoucher.SheetNo = Validation.GetSafeLong(VEditBox.Text);
                    oelVoucher.BookNo = Operations.BookNo;
                    oelVoucher.SubAccountNo = "0";
                    oelVoucher.IdUser = Operations.UserID;
                    oelVoucher.EditedByUserId = Operations.UserID;
                    oelVoucher.PostedByUserId = Operations.UserID;
                    oelVoucher.IdProject = Operations.IdProject;
                    oelVoucher.Date = VDate.Value;
                    //if (VoucherDateTime.Value != VDate.Value)
                    //    oelVoucher.EditedDateTime = VDate.Value;
                    //else
                    //    oelVoucher.EditedDateTime = DateTime.Now;
                    //oelVoucher.PostedDateTime = DateTime.Now;
                    if (!IdVoucher.HasValue)
                    {
                        oelVoucher.EditedDateTime = null;
                    }
                    else
                    {
                        if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtDebit.Text) && VoucherDateTime == null)
                            oelVoucher.EditedDateTime = VDate.Value;
                        else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtDebit.Text) && IsEditedDateChanged)
                            oelVoucher.EditedDateTime = VEditedDateTime.Value;
                        else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtDebit.Text) && IsEditedDateChanged)
                            oelVoucher.EditedDateTime = VEditedDateTime.Value;
                        else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtDebit.Text) && !IsEditedDateChanged)
                            oelVoucher.EditedDateTime = VEditedDateTime.Value;
                        else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtDebit.Text) && !IsEditedDateChanged && VEditedDateTime.Value > DateTime.Now)
                            oelVoucher.EditedDateTime = VEditedDateTime.Value;
                        else
                            oelVoucher.EditedDateTime = DateTime.Now;
                    }
                    if (chkPosted.Checked)
                    {
                        oelVoucher.PostedDateTime = DateTime.Now;
                    }
                    else
                        oelVoucher.PostedDateTime = null;
                    oelVoucher.Description = txtDescription.Text;
                    oelVoucher.VoucherType = VoucherType;
                    oelVoucher.ChequeNo = "";
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(XmlConfiguration.ReadXmlTerminalsConfiguration()[0]);
                    oelVoucher.TotalAmount = Convert.ToDecimal(txtDebit.Text == "" ? "0" : txtDebit.Text);
                    if (chkPosted.Checked)
                    {
                        oelVoucher.Posted = true;
                    }
                    else
                    {
                        oelVoucher.Posted = false;
                    }
                    /// Add Detail Transactions Accounts ...
                    for (int j = 0; j < DgvVoucher.Rows.Count - 1; j++)
                    {
                        //PaymentDetailEL oelPaymentDetail = new PaymentDetailEL();
                        VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                        oelVoucherDetail.IdVoucher = oelVoucher.IdVoucher;
                        if (DgvVoucher.Rows[j].Cells["ColIdDetailVoucher"].Value != null)
                        {
                            oelVoucherDetail.IdVoucherDetail = Validation.GetSafeLong(DgvVoucher.Rows[j].Cells["ColIdDetailVoucher"].Value.ToString());
                            oelVoucherDetail.IsNew = false;
                        }
                        else
                        {
                            oelVoucherDetail.IdVoucherDetail = 0;
                            oelVoucherDetail.IsNew = true;
                        }
                        oelVoucherDetail.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                        if (DgvVoucher.Rows[j].Cells["colDescription"].Value == null)
                        {
                            oelVoucherDetail.Description = "N/A";
                        }
                        else
                        {
                            oelVoucherDetail.Description = DgvVoucher.Rows[j].Cells["colDescription"].Value.ToString();
                        }
                        oelVoucherDetail.Seq = j + 1;
                        oelVoucherDetail.Units = 0;
                        oelVoucherDetail.IdAccount = Validation.GetSafeLong(DgvVoucher.Rows[j].Cells["colIdAccount"].Value);
                        oelVoucherDetail.AccountNo = Validation.GetSafeString(DgvVoucher.Rows[j].Cells["colAccountNo"].Value);
                        oelVoucherDetail.ClosingBalance = Validation.GetSafeDecimal(DgvVoucher.Rows[j].Cells["colClosingBalance"].Value);
                        oelVoucherDetail.Debit = Validation.GetSafeDecimal(DgvVoucher.Rows[j].Cells["colDebit"].Value);
                        oelVoucherDetail.Credit = Validation.GetSafeDecimal(DgvVoucher.Rows[j].Cells["colCredit"].Value);
                        //oelVoucherDetail.CreatedDateTime = VDate.Value.AddSeconds(j);
                        //if (VoucherDateTime.Value != VDate.Value)
                        //    oelVoucherDetail.CreatedDateTime = VDate.Value.AddSeconds(j);
                        //else
                        //    oelVoucherDetail.CreatedDateTime = DateTime.Now.AddSeconds(j);
                        if (!IdVoucher.HasValue)
                        {
                            oelVoucherDetail.CreatedDateTime = VDate.Value;
                        }
                        else
                        {
                            if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtDebit.Text) && VoucherDateTime == null)
                                oelVoucherDetail.CreatedDateTime = VDate.Value.AddSeconds(j);
                            else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtDebit.Text) && IsEditedDateChanged)
                                oelVoucherDetail.CreatedDateTime = VEditedDateTime.Value.AddSeconds(j);
                            else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtDebit.Text) && IsEditedDateChanged)
                                oelVoucherDetail.CreatedDateTime = VEditedDateTime.Value.AddSeconds(j);
                            else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtDebit.Text) && !IsEditedDateChanged)
                                oelVoucherDetail.CreatedDateTime = VEditedDateTime.Value.AddSeconds(j);
                            else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtDebit.Text) && !IsEditedDateChanged && VEditedDateTime.Value > DateTime.Now)
                                oelVoucherDetail.CreatedDateTime = VEditedDateTime.Value.AddSeconds(j);
                            else
                                oelVoucherDetail.CreatedDateTime = DateTime.Now;
                        }
                        oelVoucherDetailCollection.Add(oelVoucherDetail);
                    }


                    if (txtDebit.Text == txtCredit.Text)
                    {
                        if (!IdVoucher.HasValue || IdVoucher == 0)
                        {
                            if (ValidateBookPeriod())
                            {
                                var Manager = new VoucherBLL();
                                infoResult = Manager.InsertVouchersHead(oelVoucher, oelVoucherDetailCollection);
                                if (infoResult.IsSuccess)
                                {
                                    if (chkPosted.Checked)
                                    {
                                        lblStatuMessage.Text = "Successfully Posted In Ledger...";
                                    }
                                    else
                                    {
                                        lblStatuMessage.Text = "Successfully Inserted In Ledger...";
                                    }
                                    if (oelSoftwareCheck != null && oelSoftwareCheck.IsMust.Value)
                                    {
                                        if (MessageBox.Show("Do You Want To Print ?", "Printing Voucher", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                        {
                                            PrintVoucher(infoResult.IntID);
                                        }
                                    }
                                    ClearControl();
                                    FillData();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Voucher In This Book Period :" + Operations.BookPeriod);
                            }
                        }
                        else
                        {
                            if (ValidateBookPeriod())
                            {
                                var Manager = new VoucherBLL();
                                infoResult = Manager.UpdateVouchersHead(oelVoucher, oelVoucherDetailCollection);

                                if (infoResult.IsSuccess)
                                {
                                    if (chkPosted.Checked)
                                    {
                                        lblStatuMessage.Text = "Successfully Updated Posted Ledger...";
                                    }
                                    else
                                    {
                                        lblStatuMessage.Text = "Successfully Updated In Ledger...";
                                    }
                                    ClearControl();
                                    FillData();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Voucher In This Book Period :" + Operations.BookPeriod);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debit & Credit Sides not equal");
                    }
                }

                else
                {
                    lblStatuMessage.Text = "Cash Account Missing...";
                }
            }
            else
            {
                lblStatuMessage.Text = "Incomplete Entry...";
                lblStatuMessage.ForeColor = Color.Red;
            }
        }
        private void PrintVoucher(Int64 IdPrintingVoucher)
        {
            string strSchemaName = "Reports";
            ReportDocument RptDocument = new ReportDocument();
            TableLogOnInfo oTableLogOnInfo = new TableLogOnInfo();
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RptDocument.Load("..//..//Financial Reports/rptPrintVouchers.rpt");
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
                        if (def.ParameterFieldName == "@IdVoucher")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = IdPrintingVoucher;
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@IdProject")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = Operations.IdProject;
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@BookNo")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = Operations.BookNo;
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }

                    }
                }
                RptDocument.PrintOptions.PaperOrientation = PaperOrientation.Portrait;
                RptDocument.PrintOptions.PaperSize = PaperSize.PaperA5;
                RptDocument.PrintToPrinter(printDialog1.PrinterSettings.Copies, printDialog1.PrinterSettings.Collate, printDialog1.PrinterSettings.FromPage, printDialog1.PrinterSettings.ToPage);
            }
            //ClearControl();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (VEditBox.Text != string.Empty)
            //{
            var manager = new VoucherBLL();
            if (IdVoucher.HasValue && IdVoucher > 0)
            {
                if (MessageBox.Show("Are You Sure To Delete ?", "Deleting Voucher", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (manager.DeleteFinancialVouchers(IdVoucher, VoucherType, Operations.IdProject))
                    {
                        ClearControl();
                        lblStatuMessage.Text = "Voucher Deleted Successfully";
                        MessageBox.Show("Voucher Deleted Successfully");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Voucher To Delete....");
            }
            //}
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DgvVoucher.EndEdit();
            DgvVoucher.CurrentCell = null;
            this.Close();
        }
        private void btnNewVoucher_Click(object sender, EventArgs e)
        {
            ClearControl();
            GetLastVoucherTransactionByType();
            FillData();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtVoucherNumber.Text != string.Empty)
            {
                Int64 VoucherNo = Validation.GetSafeLong(txtVoucherNumber.Text);
                VoucherNo++;
                txtVoucherNumber.Text = VoucherNo.ToString();
                FillVoucherByNumber(VoucherNo);
            }
            else
            {
                if (Validation.GetSafeLong(lblTotalVouchers.Text) > 1)
                {
                    if (LastVoucherNo < Validation.GetSafeLong(lblLastVoucherNo.Text))
                    {
                        LastVoucherNo++;
                        FillVoucher();
                    }
                    else
                    {
                        LastVoucherNo--;
                        MessageBox.Show("You are at Last Voucher Number, Now Move Previous", "Vocher Number");
                    }
                }
                else
                {
                    //LastVoucherNo--;
                    MessageBox.Show("You are at Last Voucher Number, Now Move Previous", "Vocher Number");
                }
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (txtVoucherNumber.Text != string.Empty)
            {
                Int64 VoucherNo = Validation.GetSafeLong(txtVoucherNumber.Text);
                if (VoucherNo > 1)
                {
                    VoucherNo -= 1;
                    txtVoucherNumber.Text = VoucherNo.ToString();
                    FillVoucherByNumber(VoucherNo);
                }
                else
                {
                    MessageBox.Show("Can Not Go Back");
                }
            }
            else
            {
                if (LastVoucherNo >= FirstVoucherNo)
                {
                    FillVoucher();
                    //LastVoucherId -= 1;
                    if (LastVoucherNo > 0)
                        LastVoucherNo--;
                }
                else
                {
                    LastVoucherNo = FirstVoucherNo;
                    MessageBox.Show("You are at Least Position, Now Move Forward", "Vocher Number");
                }
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmprintVouchers = new frmPrintVouchers();
            frmprintVouchers.VoucherNo = IdVoucher.Value;
            frmprintVouchers.VType = VoucherType;
            frmprintVouchers.Show();
        }
        #endregion
        #region Win Controls Methods And Events
        private void VEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDescription.Focus();
            }
        }
        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DgvVoucher.Focus();
            }
        }
        #endregion
        #region Grid Events
        private void DgvVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (DgvVoucher.CurrentCellAddress.X == 2)
                {

                }
            }
        }
        private void DgvVoucher_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
        private void DgvVoucher_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvVoucher.Columns[e.ColumnIndex].Name == "colDebit")
            {

                for (int i = 0; i < DgvVoucher.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvVoucher.Rows[i].Cells["colDebit"].Value);
                }
                //txtAmount.Text = OldValue.ToString();
                txtDebit.Text = OldValue.ToString();
                OldValue = 0;

            }
            else if (DgvVoucher.Columns[e.ColumnIndex].Name == "colCredit")
            {
                for (int i = 0; i < DgvVoucher.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvVoucher.Rows[i].Cells["colCredit"].Value);
                }
                //txtAmount.Text = OldValue.ToString();
                txtCredit.Text = OldValue.ToString();
                OldValue = 0;
            }
        }
        private void DgvVoucher_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvVoucher.Columns[e.ColumnIndex].Name == "colDebit")
            {
                if (DgvVoucher.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    DgvVoucher.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
            else if (DgvVoucher.Columns[e.ColumnIndex].Name == "colCredit")
            {
                if (DgvVoucher.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    DgvVoucher.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
        }
        private void DgvVoucher_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgvVoucher.CurrentCellAddress.X == 4)
            {
                TextBox txtAccountName = e.Control as TextBox;
                if (txtAccountName != null)
                {
                    txtAccountName.KeyPress -= new KeyPressEventHandler(txtAccountName_KeyPress);
                    txtAccountName.KeyPress += new KeyPressEventHandler(txtAccountName_KeyPress);
                }
            }
        }
        void txtAccountName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DgvVoucher.CurrentCellAddress.X == 4)
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
                {
                    frmAccount = new frmFindAccounts();
                    frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
                    frmAccount.SearchText = e.KeyChar.ToString();
                    frmAccount.ShowDialog(this);
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
                else if (e.KeyChar == (char)Keys.Back)
                {

                }
                else
                    e.Handled = true;
            }
        }
        private void DgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 8)
            //{
            //    if (DgvVoucher.Rows[e.RowIndex].Cells["ColIdDetailVoucher"].Value == null)
            //    {
            //        DataGridViewRow oRow = DgvVoucher.Rows[e.RowIndex];
            //        DgvVoucher.Rows.Remove(oRow);
            //    }
            //}
        }
        
        #endregion
        #region Transactional Methods
        private bool IsTransactionalAccountExceeding(out string Message)
        {
            bool status = false;
            Message = string.Empty;
            List<TransactionsEL> list = new List<TransactionsEL>();
            for (int i = 0; i < DgvVoucher.Rows.Count - 1; i++)
            {
                list = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, Validation.GetSafeString(DgvVoucher.Rows[i].Cells["colAccountNo"].Value));
                if (Validation.GetSafeString(DgvVoucher.Rows[i].Cells["colHeadType"].Value) == "Cash Accounts")
                {
                    if (IdVoucher == null || IdVoucher <= 0)
                    {
                        if (Validation.GetSafeDecimal(DgvVoucher.Rows[i].Cells["colCredit"].Value) > list[0].ClosingBalance)
                        {
                            Message = "Cash Account Is Exceeding Credit Limit With Closing Balance...";
                            status = true;
                            break;
                        }
                    }
                }

                if (Validation.GetSafeString(DgvVoucher.Rows[i].Cells["colHeadType"].Value) == "Bank Accounts")
                {
                    if (IdVoucher == null || IdVoucher <= 0)
                    {
                        if (Validation.GetSafeDecimal(DgvVoucher.Rows[i].Cells["colCredit"].Value) == 0 || Validation.GetSafeDecimal(DgvVoucher.Rows[i].Cells["colCredit"].Value) > list[0].ClosingBalance)
                        {
                            Message = "Back Account Is Exceeding Credit Limit With Closing Balance...";
                            status = true;
                            break;
                        }
                    }
                }
            }
            return status;
        }

        private void VEditedDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (DateStatus == 0)
                IsEditedDateChanged = false;
            else
            {
                if (DateTime.Now.ToShortDateString() != VEditedDateTime.Value.ToShortDateString())
                    IsEditedDateChanged = true;
                else
                    IsEditedDateChanged = false;
            }
        }

        private void FillVoucher()
        {
            var Manager = new VoucherBLL();
            if (LastVoucherId == 0 || LastVoucherId == null)
            {
                LastVoucherId = Manager.GetTransactionalVoucherIdByVoucherNoForPaging(Operations.IdProject, Operations.BookNo, LastVoucherNo, VoucherType);
            }
            List<VoucherDetailEL> list = Manager.GetTransactionalVouchersByType(LastVoucherId, Operations.IdProject, Operations.BookNo, VoucherType);
            if (list.Count > 0)
            {
                VDate.Value = list[0].VDate.Value;
                DateStatus = 0;
                if (list[0].EditedDateTime != null)
                {
                    VoucherDateTime = list[0].EditedDateTime.Value;
                    VEditedDateTime.Value = list[0].EditedDateTime.Value;
                }
                else
                {
                    //VEditedDateTime.Value = VDate.Value;
                    VEditedDateTime.Value = DateTime.Now;
                    VoucherDateTime = null;
                }
                if (VoucherDateTime == null)
                {
                    VDate.Enabled = true;
                    VEditedDateTime.Enabled = false;
                }
                else
                {
                    VEditedDateTime.Enabled = true;
                    VDate.Enabled = false;
                }
                DateStatus = 1;
                IdVoucher = list[0].IdVoucher;
                txtDescription.Text = list[0].Description;
                txtVoucherNumber.Text = list[0].VoucherNo.ToString();
                VEditBox.Text = list[0].SheetNo.ToString();
                if (list[0].Posted.Value)
                {
                    if (Operations.IdRole != Validation.GetSafeLong(EnRoles.Administrator))
                    {
                        btnSave.Enabled = false;
                        btnDelete.Enabled = false;
                        chkPosted.Enabled = false;
                    }
                    chkPosted.Checked = list[0].Posted.Value;
                    lblStatuMessage.Text = "Posted Voucher ...";
                    lblStatuMessage.ForeColor = Color.Red;
                }
                else
                {
                    btnSave.Enabled = true;
                    btnDelete.Enabled = true;
                }

                FillTransactions(list);

            }
            else
            {
                MessageBox.Show("Voucher Number Not Found ...");
                ClearControl();
            }
            LastVoucherId = 0;
        }
        private void FillVoucherByNumber(Int64 VoucherNo)
        {
            var Manager = new VoucherBLL();
            List<VoucherDetailEL> list = Manager.GetTransactionalVouchersByTypeAndNumber(VoucherNo, Operations.IdProject, Operations.BookNo, VoucherType);
            if (list.Count > 0)
            {
                VDate.Value = list[0].VDate.Value;
                DateStatus = 0;
                if (list[0].EditedDateTime != null)
                {
                    VoucherDateTime = list[0].EditedDateTime.Value;
                    VEditedDateTime.Value = list[0].EditedDateTime.Value;
                }
                else
                {
                    //VEditedDateTime.Value = VDate.Value;
                    VEditedDateTime.Value = DateTime.Now;
                    VoucherDateTime = null;
                }
                if (VoucherDateTime == null)
                {
                    VDate.Enabled = true;
                    VEditedDateTime.Enabled = false;
                }
                else
                {
                    VEditedDateTime.Enabled = true;
                    VDate.Enabled = false;
                }
                DateStatus = 1;
                IdVoucher = list[0].IdVoucher;
                txtDescription.Text = list[0].Description;
                VEditBox.Text = list[0].SheetNo.ToString();
                txtVoucherNumber.Text = list[0].VoucherNo.ToString();
                HandleVoucher(list);
                FillTransactions(list);
            }
            else
            {
                MessageBox.Show("Voucher Number Not Found ...");
                ClearControl();
            }
        }
        private void HandleVoucher(List<VoucherDetailEL> list)
        {
            if (list[0].Posted.Value && list[0].IsDeleted == true)
            {
                //if (Operations.IdRole != Validation.GetSafeGuid(EnRoles.Administrator))
                {
                    btnSave.Enabled = false;
                    //btnDelete.Enabled = false;
                    chkPosted.Enabled = false;
                }
                lblVoucherStatus.Visible = true;
                lblVoucherStatus.Text = "Deleted Voucher";
                chkPosted.Checked = list[0].Posted.Value;
            }
            else if (!list[0].Posted.Value && !list[0].IsDeleted == true)
            {
                {
                    btnSave.Enabled = true;
                    btnDelete.Enabled = true;
                    chkPosted.Enabled = true;
                }
                lblVoucherStatus.Visible = false;
            }
            else if (list[0].Posted.Value && !list[0].IsDeleted == true)
            {
                btnSave.Enabled = false;
                //btnDelete.Enabled = false;
                chkPosted.Enabled = false;
            }
            else if (!list[0].Posted.Value && list[0].IsDeleted == true)
            {
                btnSave.Enabled = false;
                //btnDelete.Enabled = false;
                chkPosted.Enabled = false;
                lblVoucherStatus.Visible = true;
                lblVoucherStatus.Text = "Deleted Voucher";
            }
            else if (list[0].Posted.Value && list[0].IsDeleted == null)
            {
                btnSave.Enabled = false;
                //btnDelete.Enabled = false;
                chkPosted.Enabled = false;
                chkPosted.Checked = true;
                lblVoucherStatus.Visible = true;
                lblVoucherStatus.Text = "Posted Voucher";
            }
            else if (!list[0].Posted.Value && list[0].IsDeleted == null)
            {
                //btnSave.Enabled = false;
                //btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                chkPosted.Enabled = true;
                chkPosted.Checked = false;
                lblVoucherStatus.Visible = false;
                lblVoucherStatus.Text = "UnPosted Voucher";
            }
            else
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void FillTransactions(List<VoucherDetailEL> List)
        {
            if (DgvVoucher.Rows.Count > 0)
            {
                DgvVoucher.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {
                for (int i = 0; i < List.Count; i++)
                {
                    DgvVoucher.Rows.Add();
                    DgvVoucher.Rows[i].Cells[0].Value = List[i].IdVoucherDetail;
                    DgvVoucher.Rows[i].Cells[1].Value = List[i].IdAccount;
                    DgvVoucher.Rows[i].Cells[2].Value = List[i].AccountNo;
                    DgvVoucher.Rows[i].Cells[3].Value = List[i].AccountType;
                    DgvVoucher.Rows[i].Cells[4].Value = List[i].AccountName;
                    DgvVoucher.Rows[i].Cells[5].Value = List[i].ClosingBalance;
                    DgvVoucher.Rows[i].Cells[6].Value = List[i].Narration;
                    DgvVoucher.Rows[i].Cells[7].Value = List[i].Debit;
                    DgvVoucher.Rows[i].Cells[8].Value = List[i].Credit;
                }
                txtDebit.Text = List.Sum(x => x.Debit).ToString();

                txtCredit.Text = List.Sum(x => x.Credit).ToString();
                VoucherPreviousBillAmount = Validation.GetSafeDecimal(txtDebit.Text);
            }
        }
        #endregion        
    }
}
