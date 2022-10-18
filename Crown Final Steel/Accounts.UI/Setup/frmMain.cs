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
using System.Collections;

namespace Accounts.UI
{
    public partial class frmMain : Form
    {

        #region Variables
        UserModulesBLL manager = new UserModulesBLL();
        frmCompanyProjectInfo cpinfo = null;
        frmLogin frmlogin = null;
        frmInventoryIssuance frmissuance = null;
        frmGatePassReports frmgatepassmiscreports = null;
        //frmChartOfAccounts frmAccounts = null;
        frmAccounts frmAccounts = null;
        frmVouchers frmvouchers = null;
        frmSalesManLedger frmsaleManLedger = null;
        frmSales frmsales = null;
        frmUsers frmusers = null;
        frmOpeningBalance frmopeningbalance = null;
        //frmOpeningBalancesByType frmOpeningType = null;
        frmAccountsOpeningBalanceByTypeAndHeads frmOpeningType = null;
        frmPriceList frmpricelist = new frmPriceList();
        frmStockReceipt frmstockreceipt = null;
        frmPosPurchases frmpospurchase = null;
        frmPosPurchasesReturn frmpospurchasereturn = null;
        frmStockReturn frmstockReturn = null;
        frmgeneralLedger frmledger = null;
        frmExpenses frmExpense = null;
        frmSubHeadExpenses frmsubheadexpense;
        frmSalesReturn frmSaleReturn = null;
        frmInvoicesDateChange frmchangeinvoice = null;
        frmAccountBalance frmAccountbalanceReport = null;
        frmBackup frmbackup = null;
        frmUnpostedVouchers frmunpostedVouchers = null;
        frmIncomeStatement frmincomestatement = null;
        //frmPrescriberSample frmprescriberSample = null;
        frmSaleReports frmSaleReport = null;
        frmJournalVoucher frmjournalvoucher = null;
        frmTrialBalance frmtrialbalance = null;
        frmMiniTrialBalance frmminitrialbalance = null;
        frmDetailedJournalLedger frmDetailLedger;
        frmTotalStock frmtotalStock;
        frmPersons frmPerson;
        frmStockItems frmstockitems;
        frmCompany frmCompanies;
        frmModulesRights frmModuleRights;
        frmModulesPermissions frmModulesPermission;
        frmChangePassword frmchangePassword;
        frmUsersRoles frmuserRoles;
        frmUOM frmAllUOMS = null;
        frmProducts frmProduct = null;
        frmHeadsSetup frmheadsSetup = null;
        frmSamples frmSample = null;
        frmSamplesReturn frmSampleReturn = null;
        frmCategories frmcategories = null;
        frmSampleReports frmsampleReports = null;
        frmRecoveryReport frmrecoveryReport = null;
        frmSampleSaleDays frmsamplesaledays = null;
        frmMonthlySalesReport frmmonthlySaleReport = null;
        frmMonthlyClaimReport frmmonthlyClaimReturn = null;
        frmCurrentStock frmcurrentStock = null;
        frmProductLedger frmproductledger = null;
        frmBusinessVolume frmbusinessvolume = null;
        frmLowStock frmlowstockreport;
        frmUserActivityReport frmuseractivityreport = null;
        frmStockRatesCalculation frmstockrates = null;
        frmInventoryIssuance frminventoryissuance;
        frmSalesMainSummaryWithReturn frmsalemansalesummary;
        frmProjectWiseDatedSales frmallprojectsales;
        frmDistributionSales frmdistributionSale;
        frmDistributionSalesReturn frmdistributionreturn;
        frmDayBook frmdaybook;
        frmDayBookDetail frmdaybooklongformat;
        frmEmployeesMonthlyReport frmmonthlyperformance;
        frmPartyWiseSaleSummary frmpartywisesalesummary;
        frmAgingReport frmagingreportshow;
        frmFifoAgingReport frmfifoawisegingreport;
        frmBalanceSheet frmbalanceSheet;
        frmClosingBalancesReports frmclosingbalancesreports;
        frmProjects frmprojectsSetup;
        frmStockReturnAdjustmentSetup frmStockReturnAdjustments;
        frmTradingCo frmtradingCo = null;
        frmMonthlySalesReport frmmonthlySalesReport = null;
        frmAvailableModules frmextraModules = null;
        frmMonthlyPurchasesReport frmMonthlyPurchaseSaleReports = null;
        frmTopSellingAndReturningItems frmtopStock = null;
        frmCustomersProfitAndLoss frmcustomerwiseprofitLoss = null;
        frmCashBook frmcashbookdetail = null;
        frmProductsChart frmcompanyproductschart = null;
        frmProductWiseProfitLoss frmproductsProfitLoss = null;
        frmAllProductsWiseProfitLoss frmallproductsprofitandloss = null;
        frmDatedCashPaidExpense frmdatedexpenses = null;
        frmCustomerWiseProductsProfitAndLoss frmcustomersproductsProfitLoss = null;
        frmAllProductsInOutWithAvg frmallproductsinoutwithaverage = null;
        frmDailyBusinessActivities frmdailyactivity = null;
        frmPosInvoice frmposinvoice = null;
        frmPosReturn frmposreturninvoice = null;
        frmCustomersWiseDiscountSummary frmcustomersdiscountsummary = null;
        frmCustomersSalesInvoices frmadjustcustomerbalance;
        #region OutSource Related Variables
        frmOutSourceWork frmoutsource = null;
        frmOutSourceWorkTypes frmoutsourceworks;
        #endregion
        #endregion
        #region Form Related Methods And Events
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            rbnMain.ThemeColor = RibbonTheme.Normal;
            rbnMain.Refresh();
            rbnMain.Minimized = true;
            CheckProjectName();
            //ProductionTABShow();
            this.Text = Operations.ProjectName;
            
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.DimGray;
                    break;
                }
            }
            //frmlogin = new frmLogin();
            //frmlogin.ShowDialog(this);
            if (Operations.UserName != null)
            {
                UserNameStatus.Text = Operations.UserName.ToUpper();
            }
            if (Operations.CompanyName != string.Empty)
            {
                toolStripCompanyName.Text = Operations.CompanyName;
            }
            if (Operations.ProjectName != string.Empty)
            {
                toolStripProjectName.Text = Operations.ProjectName;
            }           
            if (SoftwareType() == "POS")
            {
                rbnBtnDistributionSale.Visible = false;
                rbnBtnDistributionSaleReturn.Visible = false;
                rbnBtnStockSales.Visible = false;
                rbnBtnStockReturn.Visible = false;
                rbnBtnPartyWiseSaleSummary.Visible = false;
                rbnBtnSalesManSaleReturnSummaryWithReturn.Visible = false;
                rbnBtnSalesManSaleSummaryWithReturn.Visible = false;
                rbnBtnSalesManHistory.Visible = false;

                rbnBtnDistributionSale.Visible = false;
                rbnBtnDistributionSaleReturn.Visible = false;
                rbnBtnStockSales.Visible = false;
                rbnBtnStockReturn.Visible = false;
                rbnBtnPartyWiseSaleSummary.Visible = false;
                rbnBtnSalesManSaleReturnSummaryWithReturn.Visible = false;
                rbnBtnSalesManSaleSummaryWithReturn.Visible = false;
                rbnBtnSalesManHistory.Visible = false;

                rbnBtnStockPurchases.Visible = false;
                rbnBtnPurchasesReturn.Visible = false;
                rrbnBtnSamples.Visible = false;

            }
            else if (SoftwareType() == "Distribution Trading")
            {
                rbnBtnDistributionSale.Visible = true;
                rbnBtnDistributionSaleReturn.Visible = true;
                rbnBtnStockSales.Visible = false;
                rbnBtnStockReturn.Visible = false;                
                rbnBtnSalesManSaleReturnSummaryWithReturn.Visible = true;
                rbnBtnSalesManSaleSummaryWithReturn.Visible = true;
                rbnBtnSalesManHistory.Visible = true;

                rbnBtnPosPurchases.Visible = false;
                rbnBtnPosPurchasesReturn.Visible = false;
                rbnBtnPOS.Visible = false;
                rbnBtnPosReturn.Visible = false;
            }
            else
            {
                rbnBtnDistributionSale.Visible = false;
                rbnBtnDistributionSaleReturn.Visible = false;
                rbnBtnStockSales.Visible = true;
                rbnBtnStockReturn.Visible = true;
                rbnBtnSalesManSaleReturnSummaryWithReturn.Visible = false;
                rbnBtnSalesManSaleSummaryWithReturn.Visible = false;
                rbnBtnSalesManHistory.Visible = false;


                rbnBtnPosPurchases.Visible = false;
                rbnBtnPosPurchasesReturn.Visible = false;
                rbnBtnPOS.Visible = false;
                rbnBtnPosReturn.Visible = false;
            }
            FillModules();
            FillTabs();
        }
        private void CheckProjectName()
        {
            var manager = new ProjectBLL();
            List<ProjectEL> list = manager.List();
            if (list.Count > 0)
            {
                if (list.Count > 1)
                {

                }
                else
                {
                    if (list[0].ProjectName == "Crown Soft Corp")
                    {
                        cpinfo = new frmCompanyProjectInfo();
                        cpinfo.ShowDialog();
                    }
                    else
                    { 
                        
                    }
                }
            }
        }
        private string SoftwareType()
        {
            string SoftwareType = string.Empty;
            List<SoftwareTypesEL> list = DataOperations.SoftwareTypes;
            if (list.Count > 0)
            {
                SoftwareTypesEL objActiveType = list.Find(x => x.ActiveSoftware == true);
                SoftwareType = objActiveType.SoftwareType;
            }
            return SoftwareType;
        }
        private void FillModules()
        {
            var manager = new ModulesBLL();
            List<ModulesEL> list = manager.GetAllModules();

            if (list.Count > 0)
            {
                List<ModulesEL> listEnabledModules = list.FindAll(x => x.IsEnabled == false);
                if (listEnabledModules.Count > 0)
                {
                    EnableDisableModules(listEnabledModules);
                    MultiEnableDisableModules(listEnabledModules);
                }
            }
        }
        private void EnableDisableModules(List<ModulesEL> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ModuleName == "Account Balances")
                {
                    rbnBtnBalances.Visible = false;
                }
                else if (list[i].ModuleName == "Detailed Ledger Reports")
                {
                    rbnBtnDetailedLedgerReport.Visible = false;
                }
                else if (list[i].ModuleName == "Sales Reports")
                {
                    rbnSaleReport.Visible = false;
                }
                else if (list[i].ModuleName == "Activity Logger")
                {
                    rbnBtnUserActivityLogger.Visible = false;
                }
                else if (list[i].ModuleName == "Multi Company")
                {
                    rbnBtnCompanies.Visible = false;
                }
                else if (list[i].ModuleName == "Multi Project")
                {
                    rbnbtnProjects.Visible = false;
                }
                else if (list[i].ModuleName == "Trial Balance")
                {
                    rbnBtnTrialBalance.Visible = false;
                }
                else if (list[i].ModuleName == "Mini Trial Balance")
                {
                    rbnBtnMiniTrial.Visible = false;
                }
                else if (list[i].ModuleName == "Income Statement")
                {
                    rbnBtnIncome.Visible = false;
                }
                else if (list[i].ModuleName == "Balance Sheet")
                {
                    rbnBtnBalanceSheet.Visible = false;
                }
                else if (list[i].ModuleName == "Closing Balances")
                {
                    rbnBtnClosingBalance.Visible = false;
                }
                else if (list[i].ModuleName == "Aging Report")
                {
                    rbnBtnAgingReport.Visible = false;
                }
                else if (list[i].ModuleName == "Fifo Aging Report")
                {
                    rbnBtnFifoAgingReport.Visible = false;
                }
                else if (list[i].ModuleName == "Business Volume")
                {
                    rbnBtnBusinessVolume.Visible = false;
                }
                else if (list[i].ModuleName == "Detailed Ledger")
                {
                    rbnBtnDetailedLedgerReport.Visible = false;
                }
                else if (list[i].ModuleName == "Recovery Report")
                {
                    rbnBtnRecover.Visible = false;
                }
                else if (list[i].ModuleName == "Short Day Book")
                {
                    rbnBtnShortDayBook.Visible = false;
                }
                else if (list[i].ModuleName == "Long Day Book")
                {
                    rbnBtnLongDayBookFormat.Visible = false;
                }
                else if (list[i].ModuleName == "Daily Business Activity")
                {
                    rbnBtnDailyBusinessActivity.Visible = false;
                }
                else if (list[i].ModuleName == "Head Wise Expenses")
                {
                    rbnBtnHeadWiseExpenseReport.Visible = false;
                }
                else if (list[i].ModuleName == "Dated Cash Paid Expenses")
                {
                    rbnBtnDatedCashPaid.Visible = false;
                }
                else if (list[i].ModuleName == "Low Stock Report")
                {
                    rbnBtnLowStockReport.Visible = false;
                }
                else if (list[i].ModuleName == "Product Ledger Report")
                {
                    rbnBtnProductsLedger.Visible = false;
                }
                else if (list[i].ModuleName == "Monthly Purchase Report")
                {
                    rbnBtnMonthPurchasesReport.Visible = false;
                }
                else if (list[i].ModuleName == "Monthly Purchase Return Report")
                {
                    rbnBtnMonthlyPurchasesReturnReport.Visible = false;
                }
                else if (list[i].ModuleName == "Monthly Sale Report")
                {
                    rbnBtnCustomerWiseReport.Visible = false;
                }
                else if (list[i].ModuleName == "Monthly Sale Return Report")
                {
                    rbnBtnCustomerWiseSaleReturnReport.Visible = false;
                }
                else if (list[i].ModuleName == "Party Wise Sale Summary")
                {
                    rbnBtnPartyWiseSaleSummary.Visible = false;
                }
                else if (list[i].ModuleName == "Customers Profit And Loss")
                {
                    rbnBtnCustomersProfitAndLoss.Visible = false;
                }
                else if (list[i].ModuleName == "Top Selling Products")
                {
                    rbnBtnTopSellingItems.Visible = false;
                }
                else if (list[i].ModuleName == "Cash Book")
                {
                    rbnBtnCashBook.Visible = false;
                }
                else if (list[i].ModuleName == "Product Wise Profit And Loss")
                {
                    rbnBtnProductsProfit.Visible = false;
                }
                else if (list[i].ModuleName == "All Product Profit And Loss")
                {
                    rbnBtnAllProductsProfit.Visible = false;
                }
                else if (list[i].ModuleName == "Customer Wise All Products Profit And Loss")
                {
                    rbnBtnCustomerWiseAllProductsProfitLoss.Visible = false;
                }
                else if (list[i].ModuleName == "All Products IN / Out With Average")
                {
                    rbnBtnAllProductsINOutWithAverage.Visible = false;
                }
            }
        }
        private void MultiEnableDisableModules(List<ModulesEL> list)
        {
            List<ModulesEL> elClosingBalancesModule = list.FindAll(x => x.ModuleName == "Closing Balances" || x.ModuleName == "Aging Report" || x.ModuleName == "Fifo Aging Report");
            //if (elClosingBalancesModule != null && elClosingBalancesModule.Count > 0)
            {
                if (list.Exists(x => x.ModuleName == "Closing Balances"))
                {
                    if (list.Exists(x => x.ModuleName == "Aging Report"))
                    {
                        if (list.Exists(x => x.ModuleName == "Fifo Aging Report"))
                        {
                            rbnBtnClosingBalancesType.Visible = false;
                        }
                    }
                }
            }
            List<ModulesEL> elDayBookModule = list.FindAll(x => x.ModuleName == "Short Day Book" || x.ModuleName == "Long Day Book");
            //if (elClosingBalancesModule != null && elDayBookModule.Count > 0)
            {
                if (list.Exists(x => x.ModuleName == "Short Day Book"))
                {
                    if (list.Exists(x => x.ModuleName == "Long Day Book"))
                    {
                        if (list.Exists(x => x.ModuleName == "Daily Business Activity"))
                        {
                            rbnBtnDayBook.Visible = false;
                        }
                    }
                }
            }

            List<ModulesEL> elTrialBalanceModule = list.FindAll(x => x.ModuleName == "Trial Balance" || x.ModuleName == "Mini Trial Balance");
            //if (elTrialBalanceModule != null && elTrialBalanceModule.Count > 0)
            {
                if (list.Exists(x => x.ModuleName == "Trial Balance"))
                {
                    if (list.Exists(x => x.ModuleName == "Mini Trial Balance"))
                    {
                        rbnBtnTrial.Visible = false;
                    }
                }
            }

        }
        private void FillTabs()
        {
            var manager = new SoftwareTabsBLL();
            List<TabsEL> list = manager.GetAllSoftwareTabs();

            if (list.Count > 0)
            {
                ShowHideSoftwareTabs(list);
            }
        }
        private void ShowHideSoftwareTabs(List<TabsEL> list)
        {
            List<TabsEL> listInActive = list.FindAll(x => x.IsEnabled == false);
            if (listInActive.Count > 0)
            {
                for (int i = 0; i < listInActive.Count; i++)
                {
                    if (listInActive[i].TabName == "Administration")
                    {
                        rbnAdministration.Visible = false;
                    }
                    else if (listInActive[i].TabName == "Stock Management")
                    {
                        rbnStockManagement.Visible = false;
                    }
                    else if (listInActive[i].TabName == "General Ledger")
                    {
                        rbnGeneralLedger.Visible = false;
                    }
                    else if (listInActive[i].TabName == "Financial Activity")
                    {
                        rbnFinancialActivity.Visible = false;
                    }
                    else if (listInActive[i].TabName == "Production")
                    {
                        rbnProduction.Visible = false;
                    }
                }
            }
        }
        private void ProductionTABShow()
        {
            SoftwareChecksEL oelSoftwareCheck = DataOperations.SoftwareChecks.ToList().Find(x => x.SoftwareCheckName == "ProductionTABShow");
            if (oelSoftwareCheck != null)
            {
                if (oelSoftwareCheck.IsMust.Value)
                {
                    rbnProduction.Visible = true;
                }
                else
                {
                    rbnProduction.Visible = false;
                }
            }
            else
                rbnProduction.Visible = false;
        }
        private void RibbonAutoclose()
        {
            SoftwareChecksEL oelSoftwareCheck = DataOperations.SoftwareChecks.ToList().Find(x => x.SoftwareCheckName == "RibbonAutoClose");
            if (oelSoftwareCheck != null)
            {
                if (oelSoftwareCheck.IsMust.Value)
                {
                    rbnMain.Minimized = true;
                }
            }
        }
        #endregion
        #region Accounts Related Methods
        private void rbnBtnAccount_Click(object sender, EventArgs e)
        {
            frmAccounts = new frmAccounts();
            frmAccounts.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmAccounts.Show();
            }
            else if (CheckModuleRights(frmAccounts.Name) != 0)
            {
                frmAccounts.Show();
            }
            else
            {
                frmAccounts.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnHeads_Click(object sender, EventArgs e)
        {
            frmheadsSetup = new frmHeadsSetup();
            frmheadsSetup.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmheadsSetup.Show();
            }
            else if (CheckModuleRights(frmheadsSetup.Name) != 0)
            {
                frmheadsSetup.Show();
            }
            else
            {
                frmheadsSetup.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnOpeningBalances_Click(object sender, EventArgs e)
        {
            frmopeningbalance = new frmOpeningBalance();
            frmopeningbalance.MdiParent = this;
            frmopeningbalance.Show();
            RibbonAutoclose();

        }
        private void rbnBtnViewOpening_Click(object sender, EventArgs e)
        {
            frmOpeningType = new frmAccountsOpeningBalanceByTypeAndHeads();
            frmOpeningType.MdiParent = this;
            frmOpeningType.Show();
        }
        #endregion
        #region Setup Related Methods
        private void rbnBtnAvailableModules_Click(object sender, EventArgs e)
        {
            frmextraModules = new frmAvailableModules();
            frmextraModules.MdiParent = this;
            frmextraModules.Show();
            RibbonAutoclose();
        }
        private void rbnBtnCompanies_Click(object sender, EventArgs e)
        {
            frmCompanies = new frmCompany();
            frmCompanies.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmCompanies.Show();
            }
            else if (CheckModuleRights(frmCompanies.Name) != 0)
            {
                frmCompanies.Show();
            }
            else
            {
                frmCompanies.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
            //MessageBox.Show("Access Is Denied");
        }
        private void rbnBtnCompany_Click(object sender, EventArgs e)
        {
            frmCompanies = new frmCompany();
            frmCompanies.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmCompanies.Show();
            }
            else if (CheckModuleRights(frmCompanies.Name) != 0)
            {
                frmCompanies.Show();
            }
            else
            {
                frmCompanies.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnbtnProjects_Click(object sender, EventArgs e)
        {
            frmprojectsSetup = new frmProjects();
            frmprojectsSetup.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmprojectsSetup.Show();
            }
            else if (CheckModuleRights(frmprojectsSetup.Name) != 0)
            {
                frmprojectsSetup.Show();
            }
            else
            {
                frmprojectsSetup.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCustomers_Click(object sender, EventArgs e)
        {
            frmPerson = new frmPersons();
            frmPerson.PersonsType = "Customers";
            frmPerson.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmPerson.Show();
            }
            else if (CheckModuleRights(frmPerson.Name) != 0)
            {
                frmPerson.Show();
            }
            else
            {
                frmPerson.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnSuppliers_Click(object sender, EventArgs e)
        {
            frmPerson = new frmPersons();
            frmPerson.PersonsType = "Suppliers";
            frmPerson.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmPerson.Show();
            }
            else if (CheckModuleRights(frmPerson.Name) != 0)
            {
                frmPerson.Show();
            }
            else
            {
                frmPerson.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnPersons_Click(object sender, EventArgs e)
        {
            frmPerson = new frmPersons();
            frmPerson.PersonsType = "Employees";
            frmPerson.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmPerson.Show();
            }
            else if (CheckModuleRights(frmPerson.Name) != 0)
            {
                frmPerson.Show();
            }
            else
            {
                frmPerson.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnBackUp_Click(object sender, EventArgs e)
        {
            frmbackup = new frmBackup();
            frmbackup.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmbackup.Show();
            }
            else if (CheckModuleRights(frmbackup.Name) != 0)
            {
                frmbackup.Show();
            }
            else
            {
                frmbackup.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        #endregion
        #region Stock Products Related Methods
        private void rbnBtnUOMSetup_Click(object sender, EventArgs e)
        {
            frmAllUOMS = new frmUOM();
            frmAllUOMS.MdiParent = this;
            frmAllUOMS.Show();
            RibbonAutoclose();
        }
        private void rbnBtnItems_Click(object sender, EventArgs e)
        {
            frmProduct = new frmProducts();
            frmProduct.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmProduct.Show();
            }
            else if (CheckModuleRights(frmProduct.Name) != 0)
            {
                frmProduct.Show();
            }
            else
            {
                frmProduct.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnOpeningStock_Click(object sender, EventArgs e)
        {
            frmcurrentStock = new frmCurrentStock();
            frmcurrentStock.MdiParent = this;
            frmcurrentStock.Show();
            RibbonAutoclose();
        }
        private void rbnBtnCompanyProductsChart_Click(object sender, EventArgs e)
        {
            frmcompanyproductschart = new frmProductsChart();
            frmcompanyproductschart.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmcompanyproductschart.Show();
            }
            else if (CheckModuleRights(frmcompanyproductschart.Name) != 0)
            {
                frmcompanyproductschart.Show();
            }
            else
            {
                frmcompanyproductschart.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnTradingCo_Click(object sender, EventArgs e)
        {
            frmtradingCo = new frmTradingCo();
            frmtradingCo.MdiParent = this;
            frmtradingCo.Show();
            RibbonAutoclose();
        }
        private void rbnBtnCategory_Click(object sender, EventArgs e)
        {
            frmcategories = new frmCategories();
            frmcategories.MdiParent = this;
            frmcategories.Show();
            RibbonAutoclose();
        }
        private void rbnBtnPriceList_Click(object sender, EventArgs e)
        {
            frmpricelist = new frmPriceList();
            frmpricelist.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmpricelist.Show();
            }
            else if (CheckModuleRights(frmpricelist.Name) != 0)
            {
                frmpricelist.Show();
            }
            else
            {
                frmpricelist.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }

        #endregion
        #region Stock Transactions Related Methods
        private void rbnBtnCreditPurchases_Click(object sender, EventArgs e)
        {
            frmstockreceipt = new frmStockReceipt();
            frmstockreceipt.MdiParent = this;
            frmstockreceipt.IsNetTransaction = false;
            frmstockreceipt.IsImportTransaction = false;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmstockreceipt.Show();
            }
            else if (CheckModuleRights(frmstockreceipt.Name) != 0)
            {
                frmstockreceipt.Show();
            }
            else
            {
                frmstockreceipt.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnNetPurchases_Click(object sender, EventArgs e)
        {
            frmstockreceipt = new frmStockReceipt();
            frmstockreceipt.MdiParent = this;
            frmstockreceipt.IsNetTransaction = true;
            frmstockreceipt.IsImportTransaction = true;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmstockreceipt.Show();
            }
            else if (CheckModuleRights(frmstockreceipt.Name) != 0)
            {
                frmstockreceipt.Show();
            }
            else
            {
                frmstockreceipt.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnStockPurchases_Click(object sender, EventArgs e)
        {
            frmstockreceipt = new frmStockReceipt();
            frmstockreceipt.MdiParent = this;
            //frmstockreceipt.IsNetTransaction = false;
            frmstockreceipt.IsImportTransaction = false;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmstockreceipt.Show();
            }
            else if (CheckModuleRights(frmstockreceipt.Name) != 0)
            {
                frmstockreceipt.Show();
            }
            else
            {
                frmstockreceipt.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCreditPurchaseReturn_Click(object sender, EventArgs e)
        {
            frmstockReturn = new frmStockReturn();
            frmstockReturn.MdiParent = this;
            frmstockReturn.IsImport = false;
            frmstockReturn.IsNetTransaction = false;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmstockReturn.Show();
            }
            else if (CheckModuleRights(frmstockReturn.Name) != 0)
            {
                frmstockReturn.Show();
            }
            else
            {
                frmstockReturn.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCashPurchaseReturn_Click(object sender, EventArgs e)
        {
            frmstockReturn = new frmStockReturn();
            frmstockReturn.MdiParent = this;
            frmstockReturn.IsImport = true;
            frmstockReturn.IsNetTransaction = true;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmstockReturn.Show();
            }
            else if (CheckModuleRights(frmstockReturn.Name) != 0)
            {
                frmstockReturn.Show();
            }
            else
            {
                frmstockReturn.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnPurchasesReturn_Click(object sender, EventArgs e)
        {
            frmstockReturn = new frmStockReturn();
            frmstockReturn.MdiParent = this;
            frmstockReturn.IsImport = false;
            //frmstockReturn.IsNetTransaction = false;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmstockReturn.Show();
            }
            else if (CheckModuleRights(frmstockReturn.Name) != 0)
            {
                frmstockReturn.Show();
            }
            else
            {
                frmstockReturn.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnPosPurchases_Click(object sender, EventArgs e)
        {
            frmpospurchase = new frmPosPurchases();
            frmpospurchase.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmpospurchase.Show();
            }
            else if (CheckModuleRights(frmpospurchase.Name) != 0)
            {
                frmpospurchase.Show();
            }
            else
            {
                frmpospurchase.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnPosPurchasesReturn_Click(object sender, EventArgs e)
        {
            frmpospurchasereturn = new frmPosPurchasesReturn();
            frmpospurchasereturn.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmpospurchasereturn.Show();
            }
            else if (CheckModuleRights(frmpospurchase.Name) != 0)
            {
                frmpospurchasereturn.Show();
            }
            else
            {
                frmpospurchasereturn.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCreditSales_Click(object sender, EventArgs e)
        {
            frmsales = new frmSales();
            frmsales.MdiParent = this;
            frmsales.IsImportTransaction = false;
            frmsales.IsNetTransaction = false;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmsales.Show();
            }
            else if (CheckModuleRights(frmsales.Name) != 0)
            {
                frmsales.Show();
            }
            else
            {
                frmsales.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCashSales_Click(object sender, EventArgs e)
        {

            frmsales = new frmSales();
            frmsales.MdiParent = this;
            frmsales.IsNetTransaction = true;
            frmsales.IsImportTransaction = true;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmsales.Show();
            }
            else if (CheckModuleRights(frmsales.Name) != 0)
            {
                frmsales.Show();
            }
            else
            {
                frmsales.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnStockSales_Click(object sender, EventArgs e)
        {
            frmsales = new frmSales();
            frmsales.MdiParent = this;
            frmsales.IsImportTransaction = false;
            //frmsales.IsNetTransaction = false;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmsales.Show();
            }
            else if (CheckModuleRights(frmsales.Name) != 0)
            {
                frmsales.Show();
            }
            else
            {
                frmsales.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCreditSalesReturn_Click(object sender, EventArgs e)
        {
            frmSaleReturn = new frmSalesReturn();
            frmSaleReturn.MdiParent = this;
            frmSaleReturn.IsNetTransaction = false;
            frmSaleReturn.IsImportTransaction = false;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmSaleReturn.Show();
            }
            else if (CheckModuleRights(frmSaleReturn.Name) != 0)
            {
                frmSaleReturn.Show();
            }
            else
            {
                frmSaleReturn.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnDebitSalesReturn_Click(object sender, EventArgs e)
        {
            frmSaleReturn = new frmSalesReturn();
            frmSaleReturn.MdiParent = this;
            frmSaleReturn.IsNetTransaction = true;
            frmSaleReturn.IsImportTransaction = true;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmSaleReturn.Show();
            }
            else if (CheckModuleRights(frmSaleReturn.Name) != 0)
            {
                frmSaleReturn.Show();
            }
            else
            {
                frmSaleReturn.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnStockReturnVocuher_Click(object sender, EventArgs e)
        {
            frmSaleReturn = new frmSalesReturn();
            frmSaleReturn.MdiParent = this;
            //frmSaleReturn.IsNetTransaction = true;
            frmSaleReturn.IsImportTransaction = true;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmSaleReturn.Show();
            }
            else if (CheckModuleRights(frmSaleReturn.Name) != 0)
            {
                frmSaleReturn.Show();
            }
            else
            {
                frmSaleReturn.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnStockCalculationRates_Click(object sender, EventArgs e)
        {
            frmstockrates = new frmStockRatesCalculation();
            frmstockrates.MdiParent = this;
            frmstockrates.Show();
            RibbonAutoclose();
        }
        private void rbnBtnPurchasesAdjustment_Click(object sender, EventArgs e)
        {
            frmStockReturnAdjustments = new frmStockReturnAdjustmentSetup();
            frmStockReturnAdjustments.AdjustmentType = 1;
            frmStockReturnAdjustments.MdiParent = this;
            frmStockReturnAdjustments.Show();
            RibbonAutoclose();
        }
        private void rbnBtnSalesAdjustments_Click(object sender, EventArgs e)
        {
            frmStockReturnAdjustments = new frmStockReturnAdjustmentSetup();
            frmStockReturnAdjustments.AdjustmentType = 2;
            frmStockReturnAdjustments.MdiParent = this;
            frmStockReturnAdjustments.Show();
            RibbonAutoclose();
        }
        private void rbnBtnChangeInvoicePreviousBalance_Click(object sender, EventArgs e)
        {
            frmadjustcustomerbalance = new frmCustomersSalesInvoices();
            frmadjustcustomerbalance.MdiParent = this;
            frmadjustcustomerbalance.Show();
        }
        #endregion
        #region Stock Reports
        private void rbnBtnStockAnalysisReort_Click(object sender, EventArgs e)
        {
            frmtotalStock = new frmTotalStock();
            frmtotalStock.MdiParent = this;
            frmtotalStock.Show();
            RibbonAutoclose();
        }
        private void rbnBtnProductLedger_Click(object sender, EventArgs e)
        {
            frmproductledger = new frmProductLedger();
            frmproductledger.MdiParent = this;
            frmproductledger.Show();
            RibbonAutoclose();
        }
        private void rbnBtnLowStockReport_Click(object sender, EventArgs e)
        {
            frmlowstockreport = new frmLowStock();
            frmlowstockreport.MdiParent = this;
            frmlowstockreport.Show();
            RibbonAutoclose();
        }
        private void rbnBtnProductsProfit_Click(object sender, EventArgs e)
        {
            frmproductsProfitLoss = new frmProductWiseProfitLoss();
            frmproductsProfitLoss.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmproductsProfitLoss.Show();
            }
            else if (CheckModuleRights(frmproductsProfitLoss.Name) != 0)
            {
                frmproductsProfitLoss.Show();
            }
            else
            {
                frmproductsProfitLoss.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnAllProductsProfit_Click(object sender, EventArgs e)
        {
            frmallproductsprofitandloss = new frmAllProductsWiseProfitLoss();
            frmallproductsprofitandloss.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmallproductsprofitandloss.Show();
            }
            else if (CheckModuleRights(frmallproductsprofitandloss.Name) != 0)
            {
                frmallproductsprofitandloss.Show();
            }
            else
            {
                frmallproductsprofitandloss.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCustomerWiseAllProductsProfitLoss_Click(object sender, EventArgs e)
        {
            frmcustomersproductsProfitLoss = new frmCustomerWiseProductsProfitAndLoss();
            frmcustomersproductsProfitLoss.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmcustomersproductsProfitLoss.Show();
            }
            else if (CheckModuleRights(frmcustomersproductsProfitLoss.Name) != 0)
            {
                frmcustomersproductsProfitLoss.Show();
            }
            else
            {
                frmcustomersproductsProfitLoss.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnAllProductsINOutWithAverage_Click(object sender, EventArgs e)
        {
            frmallproductsinoutwithaverage = new frmAllProductsInOutWithAvg();
            frmallproductsinoutwithaverage.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmallproductsinoutwithaverage.Show();
            }
            else if (CheckModuleRights(frmallproductsinoutwithaverage.Name) != 0)
            {
                frmallproductsinoutwithaverage.Show();
            }
            else
            {
                frmallproductsinoutwithaverage.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        #endregion
        #region Users Related Methods
        private void rbnBtnUsers_Click(object sender, EventArgs e)
        {
            frmusers = new frmUsers();
            frmusers.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmusers.Show();
            }
            else if (CheckModuleRights(frmusers.Name) != 0)
            {
                frmusers.Show();
            }
            else
            {
                frmusers.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnUserActivityLogger_Click(object sender, EventArgs e)
        {
            frmuseractivityreport = new frmUserActivityReport();
            frmuseractivityreport.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmuseractivityreport.Show();
            }
            else if (CheckModuleRights(frmuseractivityreport.Name) != 0)
            {
                frmuseractivityreport.Show();
            }
            else
            {
                frmuseractivityreport.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnPassword_Click(object sender, EventArgs e)
        {
            frmchangePassword = new frmChangePassword();
            frmchangePassword.MdiParent = this;
            frmchangePassword.Show();
            RibbonAutoclose();
        }
        private void rbnBtnUserRoles_Click(object sender, EventArgs e)
        {
            frmuserRoles = new frmUsersRoles();
            frmuserRoles.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmuserRoles.Show();
            }
            else if (CheckModuleRights(frmuserRoles.Name) != 0)
            {
                frmuserRoles.Show();
            }
            else
            {
                frmuserRoles.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnModules_Click(object sender, EventArgs e)
        {
            frmModuleRights = new frmModulesRights();
            frmModuleRights.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmModuleRights.Show();
            }
            else if (CheckModuleRights(frmModuleRights.Name) != 0)
            {
                frmModuleRights.Show();
            }
            else
            {
                frmModuleRights.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnPermissions_Click(object sender, EventArgs e)
        {
            frmModulesPermission = new frmModulesPermissions();
            frmModulesPermission.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmModulesPermission.Show();
            }
            else if (CheckModuleRights(frmModulesPermission.Name) != 0)
            {
                frmModulesPermission.Show();
            }
            else
            {
                frmModulesPermission.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private Int64 CheckModuleRights(string FormName)
        {
            var Manager = new UserModulesBLL();
            List<UserModulesEL> list = manager.GetUserModuleRightsByIdAndForm(Operations.UserID, FormName);
            if (list.Count > 0)
            {
                UserPermissions.IdModule = list[0].IdModule;
                return list[0].IdModule;
            }
            else
            {
                UserPermissions.IdModule = 0;
                return 0;
            }
            RibbonAutoclose();
        }
        private void rbnBtnSignOut_Click(object sender, EventArgs e)
        {
            try
            {
                //frmlogin = new frmLogin();
                foreach (Form form in MdiChildren)
                {
                    form.Close();
                }
                if (frmlogin == null)
                {
                    this.Hide();
                    frmlogin = new frmLogin();
                    frmlogin.ShowDialog();
                    this.Dispose(true);
                }
                else
                {
                    frmlogin.ShowDialog();
                }
                //if (!frmlogin.IsDisposed)
                //{
                //    frmlogin.ShowDialog(this);
                //}
                //else
                //{
                //    frmlogin = new frmLogin();
                //    frmlogin.ShowDialog();
                //    //frmlogin.ShowDialog(this);
                //}
                if (Operations.UserName != null)
                {
                    UserNameStatus.Text = Operations.UserName.ToUpper();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Umar");
            }
        }
        #endregion
        #region Sales Related Methods
        private void rbnBtnPOS_Click(object sender, EventArgs e)
        {
            frmposinvoice = new frmPosInvoice();
            frmposinvoice.MdiParent = this;
            frmposinvoice.Show();
        }
        private void rbnBtnPosReturn_Click(object sender, EventArgs e)
        {
            frmposreturninvoice = new frmPosReturn();
            frmposreturninvoice.MdiParent = this;
            frmposreturninvoice.Show();
        }
        private void rbnBtnDistributionSale_Click(object sender, EventArgs e)
        {
            frmdistributionSale = new frmDistributionSales();
            frmdistributionSale.MdiParent = this;
            frmdistributionSale.Show();
            RibbonAutoclose();
        }
        private void rbnBtnDistributionSaleReturn_Click(object sender, EventArgs e)
        {
            frmdistributionreturn = new frmDistributionSalesReturn();
            frmdistributionreturn.MdiParent = this;
            frmdistributionreturn.Show();
            RibbonAutoclose();
        }
        private void rbnBtnSalesManSaleSummaryWithReturn_Click(object sender, EventArgs e)
        {
            frmsalemansalesummary = new frmSalesMainSummaryWithReturn();
            frmsalemansalesummary.MdiParent = this;
            frmsalemansalesummary.TransactionType = 1;
            frmsalemansalesummary.Show();
            RibbonAutoclose();
        }
        private void rbnBtnSalesManSaleReturnSummaryWithReturn_Click(object sender, EventArgs e)
        {
            frmsalemansalesummary = new frmSalesMainSummaryWithReturn();
            frmsalemansalesummary.MdiParent = this;
            frmsalemansalesummary.TransactionType = 2;
            frmsalemansalesummary.Show();
            RibbonAutoclose();
        }
        private void rbnBtnDatedInvoices_Click(object sender, EventArgs e)
        {
            frmallprojectsales = new frmProjectWiseDatedSales();
            frmallprojectsales.MdiParent = this;
            frmallprojectsales.Show();
            RibbonAutoclose();
        }
        private void rbnBtnPartyWiseSaleSummary_Click(object sender, EventArgs e)
        {
            frmpartywisesalesummary = new frmPartyWiseSaleSummary();
            frmpartywisesalesummary.MdiParent = this;
            frmpartywisesalesummary.Show();
            RibbonAutoclose();
        }
        private void rbnBtnInvoiceschangedate_Click(object sender, EventArgs e)
        {
            frmchangeinvoice = new frmInvoicesDateChange();
            frmchangeinvoice.ChangedNumber = 1;
            frmchangeinvoice.MdiParent = this;
            frmchangeinvoice.Show();
            RibbonAutoclose();
        }
        #endregion
        #region Sale Reports
        private void rbnBtnSaleReport_Click(object sender, EventArgs e)
        {
            frmSaleReport = new frmSaleReports();
            frmSaleReport.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmSaleReport.ReportType = "Sale";
                frmSaleReport.Show();
            }
            else if (CheckModuleRights(frmSaleReport.Name) != 0)
            {
                frmSaleReport.ReportType = "Sale";
                frmSaleReport.Show();
            }
            else
            {
                frmSaleReport.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnClaimReturn_Click(object sender, EventArgs e)
        {
            frmmonthlyClaimReturn = new frmMonthlyClaimReport();
            frmmonthlyClaimReturn.MdiParent = this;
            frmmonthlyClaimReturn.Show();
            RibbonAutoclose();
        }
        private void rbnBtnMonthlySalesReport_Click(object sender, EventArgs e)
        {
            frmmonthlySaleReport = new frmMonthlySalesReport();
            frmmonthlySaleReport.MdiParent = this;
            frmmonthlySaleReport.Show();
            RibbonAutoclose();
        }
        private void rbnBtnMonthlySale_Click(object sender, EventArgs e)
        {
            frmmonthlySalesReport = new frmMonthlySalesReport();
            frmmonthlySalesReport.MdiParent = this;
            frmmonthlySalesReport.Show();
            RibbonAutoclose();
        }
        private void rbnBtnSalesManHistory_Click(object sender, EventArgs e)
        {
            if (SoftwareType() == "Distribution Trading")
            {
                frmmonthlyperformance = new frmEmployeesMonthlyReport();
                frmmonthlyperformance.MdiParent = this;
                frmmonthlyperformance.Show();
            }
            else
            {
                frmsaleManLedger = new frmSalesManLedger();
                frmsaleManLedger.MdiParent = this;
                frmsaleManLedger.Show();
            }
            RibbonAutoclose();
        }
        private void rbnBtnCustomerWiseReport_Click(object sender, EventArgs e)
        {
            frmMonthlyPurchasesReport frmMonthlySaleReports = new frmMonthlyPurchasesReport();
            frmMonthlySaleReports.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmMonthlySaleReports.ReportType = 3;
                frmMonthlySaleReports.Show();
            }
            else if (CheckModuleRights(frmMonthlySaleReports.Name + "/S") != 0)
            {
                frmMonthlySaleReports.ReportType = 3;
                frmMonthlySaleReports.Show();
            }
            else
            {
                frmMonthlySaleReports.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCustomerWiseSaleReturnReport_Click(object sender, EventArgs e)
        {
            frmMonthlyPurchasesReport frmMonthlySaleReports = new frmMonthlyPurchasesReport();
            frmMonthlySaleReports.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmMonthlySaleReports.ReportType = 4;
                frmMonthlySaleReports.Show();
            }
            else if (CheckModuleRights(frmMonthlySaleReports.Name + "/SR") != 0)
            {
                frmMonthlySaleReports.ReportType = 4;
                frmMonthlySaleReports.Show();
            }
            else
            {
                frmMonthlySaleReports.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnTopSellingItems_Click(object sender, EventArgs e)
        {
            frmtopStock = new frmTopSellingAndReturningItems();
            frmtopStock.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmtopStock.Show();
            }
            else if (CheckModuleRights(frmtopStock.Name) != 0)
            {
                frmtopStock.Show();
            }
            else
            {
                frmtopStock.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCustomersProfitAndLoss_Click(object sender, EventArgs e)
        {
            frmcustomerwiseprofitLoss = new frmCustomersProfitAndLoss();
            frmcustomerwiseprofitLoss.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmcustomerwiseprofitLoss.Show();
            }
            else if (CheckModuleRights(frmcustomerwiseprofitLoss.Name) != 0)
            {
                frmcustomerwiseprofitLoss.Show();
            }
            else
            {
                frmcustomerwiseprofitLoss.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCustomersDiscountSummary_Click(object sender, EventArgs e)
        {
            frmcustomersdiscountsummary = new frmCustomersWiseDiscountSummary();
            frmcustomersdiscountsummary.MdiParent = this;
            frmcustomersdiscountsummary.Show();
        }
        #endregion
        #region Purchase Reports
        private void rbnBtnPurchaseReport_Click(object sender, EventArgs e)
        {
            frmSaleReport = new frmSaleReports();
            frmSaleReport.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmSaleReport.ReportType = "Purchase";
                frmSaleReport.Show();
            }
            else if (CheckModuleRights(frmSaleReport.Name) != 0)
            {
                frmSaleReport.ReportType = "Purchase";
                frmSaleReport.Show();
            }
            else
            {
                frmSaleReport.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnMonthPurchasesReport_Click(object sender, EventArgs e)
        {
            frmMonthlyPurchaseSaleReports = new frmMonthlyPurchasesReport();
            frmMonthlyPurchaseSaleReports.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmMonthlyPurchaseSaleReports.ReportType = 1;
                frmMonthlyPurchaseSaleReports.Show();
            }
            else if (CheckModuleRights(frmMonthlyPurchaseSaleReports.Name + "/P") != 0)
            {
                frmMonthlyPurchaseSaleReports.ReportType = 1;
                frmMonthlyPurchaseSaleReports.Show();
            }
            else
            {
                frmMonthlyPurchaseSaleReports.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnMonthlyPurchasesReturnReport_Click(object sender, EventArgs e)
        {
            frmMonthlyPurchaseSaleReports = new frmMonthlyPurchasesReport();
            frmMonthlyPurchaseSaleReports.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmMonthlyPurchaseSaleReports.ReportType = 2;
                frmMonthlyPurchaseSaleReports.Show();
            }
            else if (CheckModuleRights(frmMonthlyPurchaseSaleReports.Name + "/PR") != 0)
            {
                frmMonthlyPurchaseSaleReports.ReportType = 2;
                frmMonthlyPurchaseSaleReports.Show();
            }
            else
            {
                frmMonthlyPurchaseSaleReports.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        #endregion
        #region Expense Reports Region
        private void rbnBtnDailyExpenseReport_Click(object sender, EventArgs e)
        {
            frmExpense = new frmExpenses();
            frmExpense.MdiParent = this;

            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmExpense.Show();
            }
            else if (CheckModuleRights(frmExpense.Name) != 0)
            {
                frmExpense.Show();
            }
            else
            {
                frmExpense.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnHeadWiseExpenseReport_Click(object sender, EventArgs e)
        {
            frmsubheadexpense = new frmSubHeadExpenses();
            frmsubheadexpense.MdiParent = this;

            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmsubheadexpense.Show();
            }
            else if (CheckModuleRights(frmsubheadexpense.Name) != 0)
            {
                frmsubheadexpense.Show();
            }
            else
            {
                frmsubheadexpense.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnDatedCashPaid_Click(object sender, EventArgs e)
        {
            frmdatedexpenses = new frmDatedCashPaidExpense();
            frmdatedexpenses.MdiParent = this;

            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmdatedexpenses.Show();
            }
            else if (CheckModuleRights(frmdatedexpenses.Name) != 0)
            {
                frmdatedexpenses.Show();
            }
            else
            {
                frmdatedexpenses.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        #endregion
        #region Financial Vouchers
        private void rbnBtnCashPayment_Click(object sender, EventArgs e)
        {
            frmvouchers = new frmVouchers();
            frmvouchers.MdiParent = this;
            frmvouchers.VoucherType = VoucherTypes.PaymentVoucher.ToString();
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {

                frmvouchers.Show();
            }
            else if (CheckModuleRights(frmvouchers.Name + "/Cash Payments") != 0)
            {
                frmvouchers.MdiParent = this;
                frmvouchers.Show();
            }
            else
            {
                frmvouchers.Dispose();
                MessageBox.Show("Access Is Denied !");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCashReciept_Click(object sender, EventArgs e)
        {
            frmvouchers = new frmVouchers();
            frmvouchers.MdiParent = this;
            frmvouchers.VoucherType = VoucherTypes.CashReceiptVoucher.ToString();
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmvouchers.Show();
            }
            else if (CheckModuleRights(frmvouchers.Name + "/Cash Receipts") != 0)
            {
                frmvouchers.Show();
            }
            else
            {
                frmvouchers.Dispose();
                MessageBox.Show("Access Is Denied !");
            }
            RibbonAutoclose();
        }
        private void rbnBtnBankPayment_Click(object sender, EventArgs e)
        {
            frmvouchers = new frmVouchers();
            frmvouchers.MdiParent = this;
            frmvouchers.VoucherType = VoucherTypes.BankPaymentVoucher.ToString();
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {

                frmvouchers.Show();
            }
            else if (CheckModuleRights(frmvouchers.Name + "/Bank Payment") != 0)
            {
                frmvouchers.Show();
            }
            else
            {
                frmvouchers.Dispose();
                MessageBox.Show("Access Is Denied !");
            }
            RibbonAutoclose();
        }
        private void rbnBtnBankReceipt_Click(object sender, EventArgs e)
        {
            frmvouchers = new frmVouchers();
            frmvouchers.MdiParent = this;
            frmvouchers.VoucherType = VoucherTypes.BankReceiptVoucher.ToString();
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmvouchers.Show();
            }
            else if (CheckModuleRights(frmvouchers.Name + "/Bank Receipt") != 0)
            {
                frmvouchers.Show();
            }
            else
            {
                frmvouchers.Dispose();
                MessageBox.Show("Access Is Denied !");
            }
            RibbonAutoclose();
        }
        private void rbtnBtnJournalVoucher_Click(object sender, EventArgs e)
        {
            frmjournalvoucher = new frmJournalVoucher();
            frmjournalvoucher.MdiParent = this;
            frmjournalvoucher.VoucherType = VoucherTypes.JournalVoucher.ToString();
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmjournalvoucher.Show();
            }
            else if (CheckModuleRights(frmjournalvoucher.Name) != 0)
            {
                frmjournalvoucher.Show();
            }
            else
            {
                frmjournalvoucher.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        #endregion
        #region Financial Reports
        private void rbnBtnBalances_Click(object sender, EventArgs e)
        {
            frmAccountbalanceReport = new frmAccountBalance();
            frmAccountbalanceReport.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmAccountbalanceReport.Show();
            }
            else if (CheckModuleRights(frmAccountbalanceReport.Name) != 0)
            {
                frmAccountbalanceReport.Show();
            }
            else
            {
                frmAccountbalanceReport.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnRecover_Click(object sender, EventArgs e)
        {
            frmrecoveryReport = new frmRecoveryReport();
            frmrecoveryReport.MdiParent = this;

            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmrecoveryReport.Show();
            }
            else if (CheckModuleRights(frmrecoveryReport.Name) != 0)
            {
                frmrecoveryReport.Show();
            }
            else
            {
                frmrecoveryReport.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnMiniTrial_Click(object sender, EventArgs e)
        {
            frmminitrialbalance = new frmMiniTrialBalance();
            frmminitrialbalance.MdiParent = this;

            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmminitrialbalance.Show();
            }
            else if (CheckModuleRights(frmminitrialbalance.Name) != 0)
            {
                frmminitrialbalance.Show();
            }
            else
            {
                frmminitrialbalance.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnTrial_Click(object sender, EventArgs e)
        {
            frmtrialbalance = new frmTrialBalance();
            frmtrialbalance.MdiParent = this;

            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmtrialbalance.Show();
            }
            else if (CheckModuleRights(frmtrialbalance.Name) != 0)
            {
                frmtrialbalance.Show();
            }
            else
            {
                frmtrialbalance.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnClosingBalance_Click(object sender, EventArgs e)
        {
            frmclosingbalancesreports = new frmClosingBalancesReports();
            frmclosingbalancesreports.MdiParent = this;
            frmclosingbalancesreports.Show();
            RibbonAutoclose();
        }
        private void rbnBtnLedgerReport_Click(object sender, EventArgs e)
        {
            frmledger = new frmgeneralLedger();
            frmledger.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmledger.Show();
            }
            else if (CheckModuleRights(frmledger.Name) != 0)
            {
                frmledger.Show();
            }
            else
            {
                frmledger.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnDetailedLedgerReport_Click(object sender, EventArgs e)
        {
            frmDetailLedger = new frmDetailedJournalLedger();
            frmDetailLedger.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmDetailLedger.Show();
            }
            else if (CheckModuleRights(frmDetailLedger.Name) != 0)
            {
                frmDetailLedger.Show();
            }
            else
            {
                frmDetailLedger.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnCashBook_Click(object sender, EventArgs e)
        {
            frmcashbookdetail = new frmCashBook();
            frmcashbookdetail.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmcashbookdetail.Show();
            }
            else if (CheckModuleRights(frmcashbookdetail.Name) != 0)
            {
                frmcashbookdetail.Show();
            }
            else
            {
                frmcashbookdetail.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnIncome_Click(object sender, EventArgs e)
        {
            frmincomestatement = new frmIncomeStatement();
            frmincomestatement.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmincomestatement.Show();
            }
            else if (CheckModuleRights(frmincomestatement.Name) != 0)
            {
                frmincomestatement.Show();
            }
            else
            {
                frmincomestatement.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnBalanceSheet_Click(object sender, EventArgs e)
        {
            frmbalanceSheet = new frmBalanceSheet();
            frmbalanceSheet.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmbalanceSheet.Show();
            }
            else if (CheckModuleRights(frmbalanceSheet.Name) != 0)
            {
                frmbalanceSheet.Show();
            }
            else
            {
                frmbalanceSheet.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnPosting_Click(object sender, EventArgs e)
        {
            frmunpostedVouchers = new frmUnpostedVouchers();
            frmunpostedVouchers.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmunpostedVouchers.Show();
            }
            else if (CheckModuleRights(frmunpostedVouchers.Name) != 0)
            {
                frmunpostedVouchers.Show();
            }
            else
            {
                frmunpostedVouchers.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        #endregion
        #region Inventory Issuance / Gate Pass
        private void rbnBtnStoreInventoryIssuance_Click(object sender, EventArgs e)
        {
            frminventoryissuance = new frmInventoryIssuance();
            frminventoryissuance.StoreType = 1;
            frminventoryissuance.MdiParent = this;
            frminventoryissuance.Show();
            RibbonAutoclose();
        }
        private void rbnBtnStoreInventoryReturn_Click(object sender, EventArgs e)
        {
            frminventoryissuance = new frmInventoryIssuance();
            frminventoryissuance.StoreType = 2;
            frminventoryissuance.MdiParent = this;
            frminventoryissuance.Show();
            RibbonAutoclose();
        }
        private void rbnBtnGatePassReports_Click(object sender, EventArgs e)
        {
            frmgatepassmiscreports = new frmGatePassReports();
            frmgatepassmiscreports.MdiParent = this;
            frmgatepassmiscreports.Show();
            RibbonAutoclose();
        }
        #endregion
        #region OutSource Work
        private void rbnBtnOutSourceWorkTypes_Click(object sender, EventArgs e)
        {
            frmoutsourceworks = new frmOutSourceWorkTypes();
            frmoutsourceworks.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmoutsourceworks.Show();
            }
            else if (CheckModuleRights(frmoutsourceworks.Name) != 0)
            {
                frmoutsourceworks.Show();
            }
            else
            {
                frmoutsourceworks.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnOutSourceIssuance_Click(object sender, EventArgs e)
        {
            frmoutsource = new frmOutSourceWork();
            frmoutsource.MdiParent = this;
            frmoutsource.OutSourceWorkNature = 1;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmoutsource.Show();
            }
            else if (CheckModuleRights(frmoutsource.Name) != 0)
            {
                frmoutsource.Show();
            }
            else
            {
                frmoutsource.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnOutSourceRecieving_Click(object sender, EventArgs e)
        {
            frmoutsource = new frmOutSourceWork();
            frmoutsource.MdiParent = this;
            frmoutsource.OutSourceWorkNature = 2;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmoutsource.Show();
            }
            else if (CheckModuleRights(frmoutsource.Name) != 0)
            {
                frmoutsource.Show();
            }
            else
            {
                frmoutsource.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        #endregion
        #region Aging Report
        private void rbnBtnAgingReport_Click(object sender, EventArgs e)
        {
            frmagingreportshow = new frmAgingReport();
            frmagingreportshow.MdiParent = this;

            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmagingreportshow.Show();
            }
            else if (CheckModuleRights(frmagingreportshow.Name) != 0)
            {
                frmagingreportshow.Show();
            }
            else
            {
                frmagingreportshow.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnFifoAgingReport_Click(object sender, EventArgs e)
        {
            frmfifoawisegingreport = new frmFifoAgingReport();
            frmfifoawisegingreport.MdiParent = this;

            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmfifoawisegingreport.Show();
            }
            else if (CheckModuleRights(frmfifoawisegingreport.Name) != 0)
            {
                frmfifoawisegingreport.Show();
            }
            else
            {
                frmfifoawisegingreport.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        #endregion
        #region Business Volume Reports
        private void rbnBtnDayStartBusinessVolume_Click(object sender, EventArgs e)
        {
            frmbusinessvolume = new frmBusinessVolume();
            frmbusinessvolume.VolumeType = 1;
            frmbusinessvolume.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmbusinessvolume.Show();
            }
            else if (CheckModuleRights(frmbusinessvolume.Name) != 0)
            {
                frmbusinessvolume.Show();
            }
            else
            {
                frmbusinessvolume.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnDayEndBusinessVolume_Click(object sender, EventArgs e)
        {
            frmbusinessvolume = new frmBusinessVolume();
            frmbusinessvolume.VolumeType = 2;
            frmbusinessvolume.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmbusinessvolume.Show();
            }
            else if (CheckModuleRights(frmbusinessvolume.Name) != 0)
            {
                frmbusinessvolume.Show();
            }
            else
            {
                frmbusinessvolume.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnShortDayBook_Click(object sender, EventArgs e)
        {
            frmdaybook = new frmDayBook();
            frmdaybook.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmdaybook.Show();
            }
            else if (CheckModuleRights(frmdaybook.Name) != 0)
            {
                frmdaybook.Show();
            }
            else
            {
                frmdaybook.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnLongDayBookFormat_Click(object sender, EventArgs e)
        {
            frmdaybooklongformat = new frmDayBookDetail();
            frmdaybooklongformat.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmdaybooklongformat.Show();
            }
            else if (CheckModuleRights(frmdaybooklongformat.Name) != 0)
            {
                frmdaybooklongformat.Show();
            }
            else
            {
                frmdaybooklongformat.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        private void rbnBtnDailyBusinessActivity_Click(object sender, EventArgs e)
        {
            frmdailyactivity = new frmDailyBusinessActivities();
            frmdailyactivity.MdiParent = this;
            if (Operations.IdRole == Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
            {
                frmdailyactivity.Show();
            }
            else if (CheckModuleRights(frmdailyactivity.Name) != 0)
            {
                frmdailyactivity.Show();
            }
            else
            {
                frmdailyactivity.Dispose();
                MessageBox.Show("Access Is Denied");
            }
            RibbonAutoclose();
        }
        #endregion
        #region Banks Post Dated Cheques Region
        frmPostedDatedCheques frmchequesMain;
        private void rbnBtnBankChecquesHeader_Click(object sender, EventArgs e)
        {
            frmchequesMain = new frmPostedDatedCheques();
            frmchequesMain.MdiParent = this;
            frmchequesMain.Show();
        }
        frmPostDatedChequesDetail frmpostchequedetails;
        private void rbnBtnBankChequesDetail_Click(object sender, EventArgs e)
        {
            frmpostchequedetails = new frmPostDatedChequesDetail();
            frmpostchequedetails.MdiParent = this;
            frmpostchequedetails.Show();
        }
        #endregion
        #region Others
        private void rbnBtnCustomerSampleReport_Click(object sender, EventArgs e)
        {
            frmsampleReports = new frmSampleReports();
            frmsampleReports.MdiParent = this;
            frmsampleReports.Show();
            RibbonAutoclose();
        }
        private void rbnBtnCustomerSamples_Click(object sender, EventArgs e)
        {
            frmSample = new frmSamples();
            frmSample.MdiParent = this;
            frmSample.Show();
            RibbonAutoclose();
        }
        private void rbnBtnCustomerSamplesReturn_Click(object sender, EventArgs e)
        {
            frmSampleReturn = new frmSamplesReturn();
            frmSampleReturn.MdiParent = this;
            frmSampleReturn.Show();
            RibbonAutoclose();
        }
        private void rbnBtnAlerts_Click(object sender, EventArgs e)
        {
            frmsamplesaledays = new frmSampleSaleDays();
            frmsamplesaledays.MdiParent = this;
            frmsamplesaledays.Show();
            RibbonAutoclose();
        }
        #endregion
        #region Exit
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion       
       
        //private string GetNonNullableUserRoleNames()
        //{
        //    string RoleName = "";
        //    var manager = new UserRolesBLL();
        //    List<UserRolesEL> list = manager.GetUserRolesById(Operations.UserID);
        //    if (list.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i].IdUserRole != Guid.Empty)
        //            {
        //                RoleName = list[i].RoleName;
        //            }
        //        }
        //    }
        //    return RoleName;
        //}
    }
}
