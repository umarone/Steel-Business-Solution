using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;
using Accounts.EL;
using Accounts.BLL;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmMiniTrialBalance : MetroForm
    {
        public frmMiniTrialBalance()
        {
            InitializeComponent();
        }

        private void frmMiniTrialBalance_Load(object sender, EventArgs e)
        {
            this.grdMiniTrial.AutoGenerateColumns = false;
            grdMiniTrial.Columns[1].Visible = false;
            grdMiniTrial.Columns[3].Visible = false;
            LoadMiniTrial();
        }
        private void LoadMiniTrial()
        {
            var manager = new TransactionBLL();
            List<TransactionsEL> list = manager.GetMiniTrialBalance(Operations.IdCompany);
            if (list.Count > 0)
            {
                grdMiniTrial.DataSource = list;
            }
            else
            {
                grdMiniTrial.DataSource = null;
            }
        }
        private void chkIncludeDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIncludeDate.Checked)
            {
                dtStart.Enabled = true;
                dtEnd.Enabled = true;
                grdMiniTrial.DataSource = null;
                grdMiniTrial.Columns[1].Visible = true;
                grdMiniTrial.Columns[3].Visible = true;
            }
            else
            {
                dtStart.Enabled = false;
                dtEnd.Enabled = false;
                grdMiniTrial.Columns[1].Visible = false;
                grdMiniTrial.Columns[3].Visible = false;
                LoadMiniTrial();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            var manager = new TransactionBLL();
            List<TransactionsEL> list = new List<TransactionsEL>();
            if (!chkIncludeDate.Checked)
            {
                LoadMiniTrial();
            }
            else
            {
               list = manager.GetDateWiseMiniTrialBalance(Operations.IdCompany, dtStart.Value, dtEnd.Value);
            }
            if (list.Count > 0)
            {
                grdMiniTrial.DataSource = list;
            }
            else
            {
                grdMiniTrial.DataSource = null;
            }
        }
    }
}
