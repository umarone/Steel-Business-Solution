using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.BLL;
using Accounts.EL;
using Accounts.Common;
using SpreadsheetLight;

//using DocumentFormat.OpenXml;
//using DocumentFormat.OpenXml.Packaging;
//using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;
using System.Diagnostics;
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmTrialBalance : MetroForm
    {
        #region Variables
        TextBox txtDebit = new TextBox();
        TextBox txtCredit = new TextBox();
        TextBox txtClosingBalance = new TextBox();
        TextBox txtOpeningDebit = new TextBox();
        TextBox txtOpeningCredit = new TextBox();
        Label labelDgv1 = new Label();
        Panel pnlAmountSum = new Panel();
        #endregion
        #region Form Methods And Events
        public frmTrialBalance()
        {
            InitializeComponent();
        }
        private void frmTrialBalance_Load(object sender, EventArgs e)
        {
            this.DgvTrial.AutoGenerateColumns = false;
            CreateAndInitializeFooterRow();
            CheckModulePermissions();
        }
        private void CheckModulePermissions()
        {
            List<UserModulesPermissionsEL> PermissionsList = UserPermissions.GetUserModulePermissionsByUserAndModuleId(Operations.UserID);
            if (PermissionsList != null && PermissionsList.Count > 0)
            {
                if (PermissionsList[0].Viewing == true)
                {
                    btnGetTrial.Enabled = true;
                }
                else
                {
                    btnGetTrial.Enabled = false;
                }
                if (PermissionsList[0].Printing == true)
                {
                    btnExportTrial.Enabled = true;
                }
                else
                {
                    btnExportTrial.Enabled = false;
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
        private void CreateAndInitializeFooterRow()
        {
            txtOpeningCredit.Enabled = false;
            txtOpeningDebit.Enabled = false;
            txtDebit.Enabled = false;
            txtCredit.Enabled = false;
            txtClosingBalance.Enabled = false;
            txtClosingBalance.TextAlign = HorizontalAlignment.Center;
            txtCredit.TextAlign = HorizontalAlignment.Center;
            txtDebit.TextAlign = HorizontalAlignment.Center;
            txtClosingBalance.TextAlign = HorizontalAlignment.Center;
            txtOpeningDebit.TextAlign = HorizontalAlignment.Center;
            txtOpeningCredit.TextAlign = HorizontalAlignment.Center;

            int Xdgv1 = this.DgvTrial.GetCellDisplayRectangle(6, -1, true).Location.X;

            labelDgv1.Text = "Total";

            labelDgv1.Height = 21;
            pnlAmountSum.Height = 21;
            pnlAmountSum.BackColor = Color.Wheat;
            pnlAmountSum.AutoSize = false;
            pnlAmountSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlAmountSum.Width = this.DgvTrial.Columns[6].Width + Xdgv1;
            pnlAmountSum.Location = new Point(0, this.DgvTrial.Height - txtClosingBalance.Height);

            this.DgvTrial.Controls.Add(pnlAmountSum);

            int Xdgvx1 = this.DgvTrial.GetCellDisplayRectangle(2, -1, true).Location.X;
             

            txtOpeningDebit.Width = this.DgvTrial.Columns[2].Width;

            txtOpeningDebit.Location = new Point(Xdgvx1, DgvTrial.Height - txtOpeningDebit.Height);

            this.DgvTrial.Controls.Add(txtOpeningDebit);

            int Xdgvx2 = this.DgvTrial.GetCellDisplayRectangle(3, -1, true).Location.X;


            txtOpeningCredit.Width = this.DgvTrial.Columns[3].Width;

            txtOpeningCredit.Location = new Point(Xdgvx2, DgvTrial.Height - txtOpeningCredit.Height);

            this.DgvTrial.Controls.Add(txtOpeningCredit);


            int Xdgvx3 = this.DgvTrial.GetCellDisplayRectangle(4, -1, true).Location.X;


            txtDebit.Width = this.DgvTrial.Columns[4].Width;

            txtDebit.Location = new Point(Xdgvx3, DgvTrial.Height - txtDebit.Height);

            this.DgvTrial.Controls.Add(txtDebit);


            int Xdgvx4 = DgvTrial.GetCellDisplayRectangle(5, -1, true).Location.X;

            txtCredit.Width = this.DgvTrial.Columns[5].Width;
            txtCredit.Location = new Point(Xdgvx4, DgvTrial.Height - txtCredit.Height);

            this.DgvTrial.Controls.Add(txtCredit);


            int Xdgvx5 = DgvTrial.GetCellDisplayRectangle(6, -1, true).Location.X;

            txtClosingBalance.Width = this.DgvTrial.Columns[6].Width;
            txtClosingBalance.Location = new Point(Xdgvx5, DgvTrial.Height - txtClosingBalance.Height);

            this.DgvTrial.Controls.Add(txtClosingBalance);


            //int Xdgvx3 = DgvTrial.GetCellDisplayRectangle(6, -1, true).Location.X;
            //txtBalance.Width = this.DgvTrial.Columns[6].Width;
            //txtBalance.Location = new Point(Xdgvx3, DgvTrial.Height - txtBalance.Height);
            //DgvTrial.Controls.Add(txtBalance);

            pnlAmountSum.SendToBack();


        }
        #endregion
        #region Button Events
        private void btnGetTrial_Click(object sender, EventArgs e)
        {
            var manager = new TransactionBLL();
            List<TransactionsEL> list = null;
            if (chkDate.Checked) /// Complete Business Ledger
            {
                list = manager.GetTrialBalance(Operations.IdProject, Operations.BookNo);
                //PopulateTrial(list, false);

            }
            else   /// Periodic Business Ledger 
            {
                list = manager.GetDateWiseTrialBalance(Operations.IdProject, Operations.BookNo, Convert.ToDateTime(StartDate.Value.ToShortDateString()), Convert.ToDateTime(EndDate.Value.ToShortDateString()));
                //PopulateTrial(list, true);

            }
            if (list.Count > 0)
            {
                txtDebit.Text = list.Sum(x => x.Debit).ToString();
                txtCredit.Text = list.Sum(x => x.Credit).ToString();
                txtOpeningDebit.Text = list.Sum(x => x.DebitX).ToString();
                txtOpeningCredit.Text = list.Sum(x => x.CreditX).ToString();
                if(chkDate.Checked)
                    txtClosingBalance.Text = (Validation.GetSafeDecimal(txtDebit.Text) - Validation.GetSafeDecimal(txtCredit.Text)).ToString();
                else
                    txtClosingBalance.Text = ((Validation.GetSafeDecimal(txtOpeningDebit.Text) + Validation.GetSafeDecimal(txtDebit.Text)) - (Math.Abs(Validation.GetSafeDecimal(txtOpeningCredit.Text)) +Math.Abs(Validation.GetSafeDecimal(txtCredit.Text)))).ToString();
                DgvTrial.DataSource = list;
            }
            else
            {
                DgvTrial.DataSource = null;
            }
        }
        private void PopulateTrial(List<TransactionsEL> list, bool IsDateWise)
        {
            if (list.Count > 0)
            {
                decimal openingDebit = 0, openingCredit = 0, closingBalance = 0;
                if (DgvTrial.Rows.Count > 0)
                {
                    DgvTrial.Rows.Clear();
                }
                for (int i = 0; i < list.Count; i++)
                {
                    DgvTrial.Rows.Add();

                    DgvTrial.Rows[i].Cells["colAccountNo"].Value = Validation.GetSafeString(list[i].AccountNo);
                    DgvTrial.Rows[i].Cells["colAccountName"].Value = Validation.GetSafeString(list[i].AccountName);
                    if (!IsDateWise)
                    {
                        DgvTrial.Rows[i].Cells["colOpeningBalanceDebit"].Value = 0;
                        DgvTrial.Rows[i].Cells["colOpeningBalanceCredit"].Value = 0;
                    }
                    else
                    {
                        //if (!list[i].OpeningBalance.ToString().Contains('-'))
                        if (list[i].OpeningBalance > 0)
                        {
                            DgvTrial.Rows[i].Cells["colOpeningBalanceDebit"].Value = Math.Abs(list[i].OpeningBalance);
                            DgvTrial.Rows[i].Cells["colOpeningBalanceCredit"].Value = 0;
                        }
                        else
                        {
                            DgvTrial.Rows[i].Cells["colOpeningBalanceDebit"].Value = 0;
                            DgvTrial.Rows[i].Cells["colOpeningBalanceCredit"].Value = Math.Abs(list[i].OpeningBalance);
                        }
                    }
                    DgvTrial.Rows[i].Cells["colDebit"].Value = list[i].Debit;
                    DgvTrial.Rows[i].Cells["colCredit"].Value = list[i].Credit;
                    if (!IsDateWise)
                    {
                        if (list[i].Credit < 0)
                        {
                            DgvTrial.Rows[i].Cells["colClosingBalance"].Value = list[i].Debit - Math.Abs(list[i].Credit);
                        }
                        else
                        {
                            DgvTrial.Rows[i].Cells["colClosingBalance"].Value = list[i].Debit - list[i].Credit;
                        }
                    }
                    else
                    {
                        //if (!list[i].OpeningBalance.ToString().Contains('-'))
                        if (list[i].OpeningBalance > 0)
                        {
                            DgvTrial.Rows[i].Cells["colClosingBalance"].Value = (Validation.GetSafeDecimal(DgvTrial.Rows[i].Cells["colOpeningBalanceDebit"].Value) + Validation.GetSafeDecimal(DgvTrial.Rows[i].Cells["colDebit"].Value)) - Validation.GetSafeDecimal(DgvTrial.Rows[i].Cells["colCredit"].Value);
                        }
                        else
                        {
                            if (list[i].OpeningBalance < 0)
                            {
                                DgvTrial.Rows[i].Cells["colClosingBalance"].Value = Validation.GetSafeDecimal(DgvTrial.Rows[i].Cells["colDebit"].Value) - (Validation.GetSafeDecimal(DgvTrial.Rows[i].Cells["colCredit"].Value) + (Validation.GetSafeDecimal(DgvTrial.Rows[i].Cells["colOpeningBalanceCredit"].Value)));
                            }
                            else
                            {
                                DgvTrial.Rows[i].Cells["colClosingBalance"].Value = (Validation.GetSafeDecimal(DgvTrial.Rows[i].Cells["colOpeningBalanceCredit"].Value) + Validation.GetSafeDecimal(DgvTrial.Rows[i].Cells["colCredit"].Value)) - Validation.GetSafeDecimal(DgvTrial.Rows[i].Cells["colDebit"].Value);
                            }
                        }
                    }
                }
                txtDebit.Text = list.Sum(x => x.Debit).ToString();
                txtCredit.Text = list.Sum(x => x.Credit).ToString();
                for (int j = 0; j < DgvTrial.Rows.Count; j++)
                {
                    openingDebit += Validation.GetSafeDecimal(DgvTrial.Rows[j].Cells["colOpeningBalanceDebit"].Value);
                    openingCredit += Validation.GetSafeDecimal(DgvTrial.Rows[j].Cells["colOpeningBalanceCredit"].Value);
                    closingBalance += Validation.GetSafeDecimal(DgvTrial.Rows[j].Cells["colClosingBalance"].Value);
                }
                txtOpeningDebit.Text = openingDebit.ToString();
                txtOpeningCredit.Text = openingCredit.ToString();
                if (!chkDate.Checked)
                {
                    txtClosingBalance.Text = ((Validation.GetSafeDecimal(txtOpeningDebit.Text) + Validation.GetSafeDecimal(txtDebit.Text)) - (Validation.GetSafeDecimal(txtOpeningCredit.Text) + Validation.GetSafeDecimal(txtCredit.Text))).ToString();
                }
                else
                {
                    txtClosingBalance.Text = (Validation.GetSafeDecimal(txtDebit.Text) - Validation.GetSafeDecimal(txtCredit.Text)).ToString();
                }
                //txtClosingBalance.Text = closingBalance.ToString();
            }
        }
        private void btnExportTrial_Click(object sender, EventArgs e)
        {
            if (DgvTrial.Rows.Count > 0)
            {
                try
                {
                    DataTable dt = new DataTable();

                    //Adding the Columns
                    foreach (DataGridViewColumn column in DgvTrial.Columns)
                    {
                        dt.Columns.Add(column.HeaderText);
                    }

                    //Add Header Rows....
                    dt.Rows.Add();
                    dt.Rows[0][0] = "Account No.";
                    dt.Rows[0][1] = "Account Name";
                    dt.Rows[0][2] = "Debit X";
                    dt.Rows[0][3] = "Credit X";
                    dt.Rows[0][4] = "Debit";
                    dt.Rows[0][5] = "Credit";
                    dt.Rows[0][6] = "Closing";

                    // Add Empty Row....

                    dt.Rows.Add();
                    dt.Rows[1][0] = "";
                    dt.Rows[1][1] = "";
                    dt.Rows[1][2] = "";
                    dt.Rows[1][3] = "";
                    dt.Rows[1][4] = "";
                    dt.Rows[1][5] = "";
                    dt.Rows[1][6] = "";

                    foreach (DataGridViewRow row in DgvTrial.Rows)
                    {
                        dt.Rows.Add();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                        }
                    }

                    dt.Rows.Add();
                    dt.Rows[1][0] = "";
                    dt.Rows[1][1] = "";
                    dt.Rows[1][2] = "";
                    dt.Rows[1][3] = "";
                    dt.Rows[1][4] = "";
                    dt.Rows[1][5] = "";
                    dt.Rows[1][6] = "";


                    dt.Rows.Add();

                    dt.Rows[dt.Rows.Count - 1][2] = Validation.GetSafeDecimal(txtOpeningDebit.Text); ;
                    dt.Rows[dt.Rows.Count - 1][3] = Validation.GetSafeDecimal(txtOpeningCredit.Text); ;
                    dt.Rows[dt.Rows.Count - 1][4] = Validation.GetSafeDecimal(txtDebit.Text); ;
                    dt.Rows[dt.Rows.Count - 1][5] = Validation.GetSafeDecimal(txtCredit.Text); ;
                    dt.Rows[dt.Rows.Count - 1][6] = Validation.GetSafeDecimal(txtClosingBalance.Text);

                    // Exporting to Excel
                    //string folderPath = "C:\\Excel\\";
                    //if (!Directory.Exists(folderPath))
                    //{
                    //    Directory.CreateDirectory(folderPath);
                    //}

                    /// Add Header Row

                    SLDocument slExcelExport = new SLDocument();


                    for (int i = 0; i < 7; i++)
                    {

                        slExcelExport.SetColumnWidth(i, 20);
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            slExcelExport.SetCellValue(j + 1, i + 1, dt.Rows[j].ItemArray[i].ToString());
                        }
                    }
                    slExcelExport.Save();

                    Process.Start("Book1.xlsx");

                    //using (SLDocument slExcelExport = new SLDocument())
                    //{
                    //    for (int i = 1; i < DgvTrial.Columns.Count; i++)
                    //    {
                    //        for (int j = 1; j < dt.Rows.Count; j++)
                    //        {
                    //            slExcelExport.SetCellValue(j + 1, i + 1, dt.Rows[j].ItemArray[i].ToString());
                    //        }
                    //    }
                    //    slExcelExport.Save();
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("If your File Is Opened, please Close your excel File First");
                }

            }
        }
        #endregion
    }
}
