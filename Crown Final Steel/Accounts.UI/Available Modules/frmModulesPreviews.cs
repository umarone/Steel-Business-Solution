using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;
using MetroFramework.Controls;

namespace Accounts.UI
{
    public partial class frmModulesPreviews : MetroForm
    {
        #region Variables
        public Int64 IdModule { get; set; }
        #endregion
        #region Form Events And Methods
        public frmModulesPreviews()
        {
            InitializeComponent();
        }
        private void frmModulesPreviews_Load(object sender, EventArgs e)
        {
            FillModuleWithImageAndDiscription();
        }
        private void frmModulesPreviews_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void FillModuleWithImageAndDiscription()
        {
            ModuleImageBox.Image = Image.FromFile(@"..\..\Modules Preview Images\"+IdModule+".png");
            if (IdModule == 27)
            { 
                txtDiscription.Text = "This Module Is Used For Opening Multiple Companies In This Software," + Environment.NewLine + 
                                      "So When u Buy This Module You Need Not Buy New Software For Another Company";
            }
            else if (IdModule == 28)
            {
                txtDiscription.Text = "Basically This Application is Multi Project Application, Means if you have multiple Businesses Then you can buy this Module, " 
                                        + Environment.NewLine + "moreover each Project has Its Own Invoice and this module works Independently With Company...";
            }
            else if (IdModule == 29)
            {
                txtDiscription.Text = "Trial Balance Is a Financial Module / Report, Trial Balance Always Keeps You Update About Your Business Activities" + Environment.NewLine +
                                      "That Any of your account is behaving wrong, all your system entries are correct or some where error";
            }
            else if (IdModule == 30)
            {
                txtDiscription.Text = "This Is Mini Trial Balance, So It Indicate you in one galance that your Application Vouchers Whether have any differences or equal";
            }
            else if (IdModule == 31)
            {
                txtDiscription.Text = "This Is Profit And Loss Statement of your business which keeps you update on month, yearly and even on daily basis that you business is in loss or Profit";
            }
            else if (IdModule == 32)
            {
                txtDiscription.Text = "This is most powerful financial statement which covers all your business activity";
            }
            else if (IdModule == 33)
            {
                txtDiscription.Text = "Aging Report Refers To Customer Payments, Basically This Report Timely Based Report, Means It Specifies That How Much Time Has Been Passed" +Environment.NewLine+
                                      "To Customers Without Payment, It Is Detailed Report Which Tells Also Tell You About Last Customer's Transactions";
            }
            else if (IdModule == 34)
            {
                txtDiscription.Text = "Day End And Day Start Report Are Most Powerful Reports Which Tells You About All Your Business Volume That Your Investment Is Going In Profit"+Environment.NewLine+
                                      "OR In Loss, So This Report Is Very Useful For Any Business Man To See On Daily Basis That What Is His/Her Capital Condition, Whether It Is Increasing Or IN Loss...";
            }
            else if (IdModule == 35)
            {
                txtDiscription.Text = "This Is Detailed Ledger Report, Company Can Print Anually Base All Customers Or Supplier Or Any Head Ledgers, This Is Annual Based Report Which Indicates Whole Year Transactions";
            }
            else if (IdModule == 36)
            {
                txtDiscription.Text = "This Is Also A Financial Report Which Describes The Customers Recovery In Both Modes (DateWise And With Out Date), And Also It Shows A Specific Customer Or All Customers Recovery Report";
            }
            else if (IdModule == 37)
            {
                txtDiscription.Text = "This Is Financial Report Which Helps You Printing Any Type Of Fnancial Head Closing Balances With Date And WithOut Date";
            }
            else if (IdModule == 38)
            {
                txtDiscription.Text = "This Is Day Book Report Which Is Almost Important In All Over Business, It Shows You All Business Activities On Date Basis";
            }
            else if (IdModule == 39)
            {
                txtDiscription.Text = "This Is Another Day Book Long Format Report Which Is Almost Important In All Over Business, It Shows You All Business Activities On Date Basis With Four Heads";
            }
            else if (IdModule == 40)
            {
                txtDiscription.Text = "As This Image Indicates That You Can See The Expenses Head Wise And Also All Accounts Expense In That Head With Or WithOut Date" + Environment.NewLine+
                                        "This Is Powerful Report Which Shows You All Company Expenses At One Galance...";
            }
            else if (IdModule == 41)
            {
                txtDiscription.Text = "This Is Stock Based Report Which Tells You About You Stock Position, It Tells You That Which Items Need To Be Orders For Further Sale Or Store";
            }
            else if (IdModule == 42)
            {
                txtDiscription.Text = "This Is Stock Based Report Which Shows You Each Product Ledger, As Image Show You That You Can See Each Product In OR Out Status With Its Specific Dates";
            }
            else if (IdModule == 43)
            {
                txtDiscription.Text = "Activity Logger Report Is Part Of User Management Which Monitors All User Activities In Software, This Report Occupies All Software Modules Activities Done By User...";
            }
            else if (IdModule == 44)
            {
                txtDiscription.Text = "Monthly Purchases Report Shows Purchases of each Supplier Purchases either Credit OR Cash Purchases, Moreover You can see the detail of each" + Environment.NewLine +
                    "Supplier's Purchases Made During That Date With Their Date And Amount";
            }
            else if (IdModule == 45)
            {
                txtDiscription.Text = "Monthly Purchases Return Report Shows Purchases Return of each Supplier Purchases Return either Credit OR Cash Purchases, Moreover You can see the detail of each" + Environment.NewLine +
                    "Supplier's Purchases Return Made During That Date With Their Date And Amount";
            }
            else if (IdModule == 46)
            {
                txtDiscription.Text = "Monthly Sales Report Shows Sales of each Customer Sales either Credit OR Cash Sales, Moreover You can see the detail of each" + Environment.NewLine +
                    "Customers's Sales Made During That Date With Their Date And Amount";
            }
            else if (IdModule == 47)
            {
                txtDiscription.Text = "Monthly Sales Return Report Shows Sales Return of each Customer Sales Return either Credit OR Cash Sales, Moreover You can see the detail of each" + Environment.NewLine +
                    "Customers's Sales Return Made During That Date With Their Date And Amount";
            }
            else if (IdModule == 48)
            {
                txtDiscription.Text = "This Modules Shows you that how much profit / Loss Earned By Your Customer In Specific Period Of Time" + Environment.NewLine +
                                      "MoreOver It Tells You That How Much Products You Have Sold You To Customers And On Clicking Detail Button Software Will" + Environment.NewLine +
                                      "Shows You Profit / Loss On Single Sale Basis";
            }
            else if (IdModule == 49)
            {
                txtDiscription.Text = "Top Most Selling Module Is Very Best And Recommended Module For You Business, This Will Show You Most Selling Items Of Your Business" + Environment.NewLine +
                                      "And You Can Order That Items To Your Supplier For Increasing Your Business..." + Environment.NewLine +
                                      "This Modules Will Also Suggest You Which Items Are Least Sold And Which Items Are Mostly Returned OR Disliked By Customers";
            }
            else if (IdModule == 50)
            {
                txtDiscription.Text = "If You Want To See Cash Flow OR Bank Flow Of Your Business, Then This Module Will Help You To See What Are Your Cash OR Bank Transactions";
            }
            else if (IdModule == 51)
            {
                txtDiscription.Text = "This Is Best Module For You, If You Want To See To Which Accounts Cash Been Paid Between Which Dates";
            }
            else if (IdModule == 52)
            {
                txtDiscription.Text = "If You Want To See Which Product Is Giving You Profit OR Loss, Then This Module Best Suits You";
            }
            else if (IdModule == 53)
            {
                txtDiscription.Text = "If You Want To See All Products Profit And Loss Then Surely Use This Module Will Help You";
            }
            else if (IdModule == 54)
            {
                txtDiscription.Text = "If You Want To See All Products Profit And Loss With Specifi Customer Then Use This Module" + Environment.NewLine +
                                      "Moreover You Can Focus Selling Items To Customers Who Are Profitable";
            }
            else if (IdModule == 55)
            {
                txtDiscription.Text = "At One Galance This Module Will Show You All Inventory Status With Date OR WithOut Date With Product's Average Amount Flow";
            }
            else if (IdModule == 56)
            {
                txtDiscription.Text = "This Is State Of The Art Group Wise Stock Report, If It Is Your Requirement To View Stock In Grouping State, Then We Stongly " + Environment.NewLine +
                                      "Recommend You To Buy This Module";
            }
            else if (IdModule == 57)
            {
                txtDiscription.Text = "This Is Strong Module if you Really want to see the position of your business whether your business is going down or going up...";
            }
            else if (IdModule == 58)
            {
                txtDiscription.Text = "This Is State Of The Party Wise Sale Summary, If It Is Your Requirement To View Each Party Sale Summary, Then We Stongly " + Environment.NewLine +
                                      "Recommend You To Buy This Module";
            }
            else if (IdModule == 59)
            {
                txtDiscription.Text = "This Is State Of The Art Aging Report where you can see that what is invoice payments status by any specific customers," +
                                        Environment.NewLine + "We Recommend You To Buy This Module";
            }
        }
        #endregion
    }
}
