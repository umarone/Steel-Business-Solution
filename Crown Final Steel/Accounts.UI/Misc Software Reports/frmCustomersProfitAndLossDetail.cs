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
    public partial class frmCustomersProfitAndLossDetail : MetroForm
    {
        #region Variables
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        #endregion
        #region Form Methods And Events
        public frmCustomersProfitAndLossDetail()
        {
            InitializeComponent();
        }
        private void frmCustomersProfitAndLossDetail_Load(object sender, EventArgs e)
        {
            grdCustomers.AutoGenerateColumns = false;
            lblCustomerName.Text = AccountName;
            lblStartDate.Text = StartDate.ToShortDateString();
            lblEndDate.Text = EndDate.ToShortDateString();
            FillData();
        }
        private void FillData()
        {
            var manager = new SalesDetailBLL();
            List<TransactionsEL> list = manager.GetCustomersProfitAndLossDetailByDate(Operations.IdProject, Operations.BookNo, AccountNo, StartDate, EndDate);
            if (list.Count > 0)
            {
                grdCustomers.DataSource = list;
                lblTotalAmount.Text = list.Sum(x => x.GrossProfit).ToString();
            }
        }
        #endregion
    }
}
