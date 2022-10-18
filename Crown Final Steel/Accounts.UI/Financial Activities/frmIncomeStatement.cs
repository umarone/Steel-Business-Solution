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

using MetroFramework.Forms;
using SpreadsheetLight;
using System.Diagnostics;

namespace Accounts.UI
{
    public partial class frmIncomeStatement : MetroForm
    {
        public frmIncomeStatement()
        {
            InitializeComponent();
        }

        private void frmIncomeStatement_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.grdIncome.AutoGenerateColumns = false;
            //FillCompany();
        }
        private void FillCompany()
        {
            var manager = new CompanyBLL();
            List<CompanyEL> listCompany = manager.GetCompanyById(Operations.IdCompany);
        }
        private void btnIncome_Click(object sender, EventArgs e)
        {
           
            //decimal TotalRevenue= 0, CostOfGoods = 0, TotalExpenses = 0, OtherIncome = 0, openingBalances, closingBalances;
            var manager = new IncomeBLL();
            List<TransactionsEL> listIncomeStatement = manager.GetIncomeStatement(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEndDate.Value);
            if (listIncomeStatement.Count > 0)
            {
                grdIncome.DataSource = listIncomeStatement;
            }
            else
                grdIncome.DataSource = null;
            //TransactionsEL oelIncomeStatement = new TransactionsEL();
            
            
            //List<TransactionsEL> oelListTotalSale = manager.GetTotalIncomeSale(StartDate,EndDate);
            //List<TransactionsEL> oelListDiscount = manager.GetTotalIncomeCommission(StartDate, EndDate);
            //List<TransactionsEL> oelListgoodCost = manager.GetTotalIncomeCostOfGoods(StartDate, EndDate);
            //List<TransactionsEL> oelListSalary = manager.GetTotalIncomeSalary(StartDate, EndDate);
            //List<TransactionsEL> oelListExpenses = manager.GetTotalIncomeExpense(StartDate,EndDate);
            
            /// Evaluate Total Revenue Within Business Period.....
            //List<TransactionsEL> listRevenue = manager.GetTotalSaleRevenue(Operations.IdCompany, StartDate, EndDate);
            //List<TransactionsEL> listReturnRevenue = manager.GetTotalSaleReturnRevenue(Operations.IdCompany, StartDate, EndDate);
           
            /// Evaluate Total Cost Of Goods Sold
            //List<TransactionsEL> listOpeningStock = manager.GetOpeningStockAmount(Operations.IdCompany,StartDate);
            //List<TransactionsEL> listClosingStock = manager.GetClosingStockAmount(Operations.IdCompany, Convert.ToDateTime(dtStart.Value.ToShortDateString()), Convert.ToDateTime(dtEndDate.Value.ToShortDateString()));
            //List<TransactionsEL> listStockBalances = manager.GetStockOpeningAndClosingBalances(Operations.IdCompany, Convert.ToDateTime(dtStart.Value.ToShortDateString()), Convert.ToDateTime(dtEndDate.Value.ToShortDateString()));
            //List<TransactionsEL> listTotalPurchases = manager.GetTotalPurchases(Operations.IdCompany, Convert.ToDateTime(dtStart.Value.ToShortDateString()), Convert.ToDateTime(dtEndDate.Value.ToShortDateString()));

            /// Evaluate Total Expense
            //List<TransactionsEL> listExpenses = manager.GetTotalIncomeExpense(Operations.IdCompany, Convert.ToDateTime(dtStart.Value.ToShortDateString()), Convert.ToDateTime(dtEndDate.Value.ToShortDateString()));

            /// Evaluate Other Income
            //List<TransactionsEL> listOtherInCome = manager.GetTotalOtherIncome(Operations.IdCompany, Convert.ToDateTime(dtStart.Value.ToShortDateString()), Convert.ToDateTime(dtEndDate.Value.ToShortDateString()));
            //if (listOtherInCome.Count > 0)
            //{
            //}
            /// Add Total Revenue....

            //oelIncomeStatement.AccountName = "Total Revenue";
            //TotalRevenue = listRevenue[0].Amount;
            //oelIncomeStatement.Amount = listRevenue[0].Amount;

            //listIncomeStatement.Insert(0,oelIncomeStatement);

            ///// Subtract Cost Of Goods Sold

            //oelIncomeStatement = new TransactionsEL();
            //oelIncomeStatement.AccountName = "Cost Of Goods Sold";
            //openingBalances = listStockBalances.Sum(x => x.OpeningBalance);
            //closingBalances = listStockBalances.Sum(x => x.ClosingBalance);
            //CostOfGoods = (openingBalances + listTotalPurchases[0].Amount) - closingBalances;
            //oelIncomeStatement.Amount = CostOfGoods;

            //listIncomeStatement.Insert(1,oelIncomeStatement);

            ///// Gross Profit
            //oelIncomeStatement = new TransactionsEL();
            //oelIncomeStatement.AccountName = "Gross Profit";
            //oelIncomeStatement.Amount = TotalRevenue - CostOfGoods;
            //listIncomeStatement.Insert(2, oelIncomeStatement);

            ///// Empty Record
            //oelIncomeStatement = new TransactionsEL();
            //oelIncomeStatement.AccountName = "";
            //oelIncomeStatement.Amount = 0;

            //listIncomeStatement.Insert(3, oelIncomeStatement);

            ///// Adding Expense Head
            //oelIncomeStatement = new TransactionsEL();
            //oelIncomeStatement.AccountName = "Expenses";
            //oelIncomeStatement.Amount = 0;

            //listIncomeStatement.Insert(4, oelIncomeStatement);
            //int i = 4;
            //foreach (var item in listExpenses)
            //{
            //    oelIncomeStatement = new TransactionsEL();
            //    oelIncomeStatement.AccountName = item.AccountName;
            //    oelIncomeStatement.Amount = item.Amount;
            //    i = i + 1;

            //    listIncomeStatement.Insert(i,oelIncomeStatement);

            //    TotalExpenses += item.Amount;
            //}

            //oelIncomeStatement = new TransactionsEL();
            //oelIncomeStatement.AccountName = "Total Expenses";
            //oelIncomeStatement.Amount = TotalExpenses;

            //i = i + 1;
            //listIncomeStatement.Insert(i,oelIncomeStatement);

            //oelIncomeStatement = new TransactionsEL();
            //oelIncomeStatement.AccountName = "";
            //oelIncomeStatement.Amount = 0;
           
            //i = i + 1;
            //listIncomeStatement.Insert(i, oelIncomeStatement);

            //oelIncomeStatement = new TransactionsEL();
            //oelIncomeStatement.AccountName = "OtherInCome";
            //oelIncomeStatement.Amount = 0;

            //i = i + 1;
            //listIncomeStatement.Insert(i,oelIncomeStatement);

            //foreach (var item in listOtherInCome)
            //{
            //    oelIncomeStatement = new TransactionsEL();
            //    oelIncomeStatement.AccountName = item.AccountName;
            //    oelIncomeStatement.Amount = item.Amount;
            //    i = i + 1;
            //    listIncomeStatement.Insert(i, oelIncomeStatement);

            //    OtherIncome += item.Amount;
            //}

            //oelIncomeStatement = new TransactionsEL();
            //oelIncomeStatement.AccountName = "NetICome";
            //oelIncomeStatement.Amount = (TotalRevenue + OtherIncome) - (TotalExpenses + CostOfGoods);

            //i = i + 1;
            //listIncomeStatement.Insert(i, oelIncomeStatement);

            //if (listIncomeStatement.Count > 0)
            //{
            //    FillInComeStatement(listIncomeStatement);
            //}

        }
        private void FillInComeStatement(List<TransactionsEL> listIncome)
        {
            for (int i = 0; i < listIncome.Count; i++)
            {
                grdIncome.Rows.Add();
                grdIncome.Rows[i].Cells["colIncomeDetail"].Value = listIncome[i].AccountName;
                if (listIncome[i].AccountName == "" || listIncome[i].AccountName == "Expenses" || listIncome[i].AccountName == "OtherInCome")
                {
                    grdIncome.Rows[i].Cells["ColIncome"].Value = "";
                }
                else
                {
                    grdIncome.Rows[i].Cells["ColIncome"].Value = listIncome[i].Amount;
                }

            }
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdIncome.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdIncome.Columns)
                {
                    if (column.Visible)
                    {
                        dt.Columns.Add(column.HeaderText);
                    }
                }

                //Add Header Rows....
                dt.Rows.Add();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    dt.Rows[0][i] = dt.Columns[i].ColumnName; //"Account Name"; 
                }

                // Add Empty Row....
                dt.Rows.Add();
                for (int i = 0; i < grdIncome.Columns.Count; i++)
                {
                    if (i != dt.Columns.Count)
                    {
                        dt.Rows[1][i] = "";
                    }
                    else
                    {
                        break;
                    }
                }

                foreach (DataGridViewRow row in grdIncome.Rows)
                {
                    dt.Rows.Add();
                    int colindex = 0;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //if (cell.Value != null)
                        //{
                        if (cell.Visible)
                        {
                            //dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                            dt.Rows[dt.Rows.Count - 1][colindex] = cell.Value ?? 0.ToString();
                            colindex++;
                        }
                        //}
                    }
                }

                SLDocument slExcelExport = new SLDocument();


                for (int i = 0; i < dt.Columns.Count; i++)
                {

                    slExcelExport.SetColumnWidth(i, 20);
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        slExcelExport.SetCellValue(j + 1, i + 1, dt.Rows[j].ItemArray[i].ToString());
                    }
                }
                slExcelExport.Save();

                Process.Start("Book1.xlsx");
            }
        }
    }
}
