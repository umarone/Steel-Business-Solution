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
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmDailyBusinessActivities : MetroForm
    {
        public frmDailyBusinessActivities()
        {
            InitializeComponent();
        }

        private void frmDailyBusinessActivities_Load(object sender, EventArgs e)
        {
            this.grdStocksActivity.AutoGenerateColumns = false;
            this.grdFinancialActivity.AutoGenerateColumns = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new TransactionBLL();
            List<TransactionsEL> list = new List<TransactionsEL>();

            //First Evaluate Stock Activity
            list = manager.GetDailyBusinessStockActivity(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                grdStocksActivity.DataSource = list;
            }
            else
            {
                grdStocksActivity.DataSource = null;
            }
            //Second Evaluate Financial Activity
            list = manager.GetDailyBusinessFinancialActivity(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                grdFinancialActivity.DataSource = list;
            }
            else
            {
                grdFinancialActivity.DataSource = null;
            }

        }
    }
}
