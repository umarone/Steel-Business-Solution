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
using MetroFramework.Forms;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmBalanceSheet : MetroForm
    {
        #region Variables
        DataTable dtAssets;
        DataTable dtLibilities;
        string AssetHeadName,LibilitiesHeadName;
        #endregion
        #region Form Methods and Events
        public frmBalanceSheet()
        {
            InitializeComponent();
        }
        private void frmBalanceSheet_Load(object sender, EventArgs e)
        {
            this.grdAssets.AutoGenerateColumns = false;
            this.grdLibilities.AutoGenerateColumns = false;
            FillAssetsAndLibilitiesTreeViews();           
        }
        private void FillAssetsAndLibilitiesTreeViews()
        {
            var manager = new AccountsBLL();
            List<AccountsEL> list = manager.GetAccountByLevel(1);
            if (list.Count > 0)
            {
                AccountsEL oelAssets = list.Find(x => x.AccountName == "Assets");
                if (oelAssets != null)
                {
                   TreeNode AParent = trvAssets.Nodes.Add(oelAssets.IdAccount.ToString(), "Assets");
                   AParent.Nodes.Add("");
                }
                AccountsEL oelLibilities = list.Find(x => x.AccountName == "Libilities");
                if (oelLibilities != null)
                {
                    TreeNode BParent = trvLibilities.Nodes.Add(oelLibilities.IdAccount.ToString(), "Libilities");
                    BParent.Nodes.Add("");
                }

            }
        }
        #endregion
        #region TreeViewsEvents
        private void trvAssets_AfterExpand(object sender, TreeViewEventArgs e)
        {
            var manager = new AccountsBLL();
            List<AccountsEL> list = null;
            if (e.Node.Level == 0)
            {
                list = manager.GetAccountsByParent(Validation.GetSafeLong(e.Node.Name), Operations.IdProject, Operations.IdCompany, 2);
                if (list != null && list.Count > 0)
                {
                    e.Node.Nodes.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        TreeNode s = e.Node.Nodes.Add(list[i].IdAccount.ToString(), list[i].AccountName);
                        s.Nodes.Add("");
                    }
                }
            }
            if (e.Node.Level == 1)
            {
                list = manager.GetAccountsByParent(Validation.GetSafeLong(e.Node.Name), Operations.IdProject, Operations.IdCompany, 2);
                if (list != null && list.Count > 0)
                {
                    e.Node.Nodes.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        e.Node.Nodes.Add(list[i].IdAccount.ToString(), list[i].AccountName);                        
                    }
                }
            }
            //if (e.Node.Level == 2)
            //{
            //    list = manager.GetAccountsByParent(Validation.GetSafeGuid(e.Node.Name), Operations.IdCompany, 3);
            //    if (list != null && list.Count > 0)
            //    {
            //        e.Node.Nodes.Clear();
            //        for (int i = 0; i < list.Count; i++)
            //        {
            //            e.Node.Nodes.Add(list[i].IdAccount.ToString(), list[i].AccountName);
            //        }
            //    }
            //}
        }
        private void trvAssets_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var manager = new TransactionBLL();
            List<TransactionsEL> list = null;
            if (e.Node.Level == 2)
            {
                AssetHeadName = e.Node.Text;
                list = manager.GetBalanceSheetAccountsBalances(Operations.IdProject, Operations.BookNo, 1, AssetHeadName);
                 if (list != null && list.Count > 0)
                 {
                     dtAssets = DataOperations.ToDataTable(list);
                     grdAssets.DataSource = dtAssets;
                     lblTotalAssetsAmount.Text = list.Sum(x => x.ClosingBalance).ToString(); //list[0].ClosingBalance.ToString();
                     lblAssetHeadName.Text = AssetHeadName + " : " + list.Sum(x => x.ClosingBalance).ToString();
                 }
                 else
                 {
                     grdAssets.DataSource = null;
                     lblTotalAssetsAmount.Text = string.Empty;
                 }
            }
        }
        private void trvLibilities_AfterExpand(object sender, TreeViewEventArgs e)
        {
            var manager = new AccountsBLL();
            List<AccountsEL> list = null;
            if (e.Node.Level == 0)
            {
                list = manager.GetAccountsByParent(Validation.GetSafeLong(e.Node.Name), Operations.IdProject, Operations.IdCompany, 2);
                if (list != null && list.Count > 0)
                {
                    e.Node.Nodes.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        TreeNode s = e.Node.Nodes.Add(list[i].IdAccount.ToString(), list[i].AccountName);
                        s.Nodes.Add("");
                    }
                }
            }
            if (e.Node.Level == 1)
            {
                list = manager.GetAccountsByParent(Validation.GetSafeLong(e.Node.Name), Operations.IdProject, Operations.IdCompany, 2);
                if (list != null && list.Count > 0)
                {
                    e.Node.Nodes.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        e.Node.Nodes.Add(list[i].IdAccount.ToString(), list[i].AccountName);
                    }
                }
            }
        }
        private void trvLibilities_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var manager = new TransactionBLL();
            List<TransactionsEL> list = null;
            if (e.Node.Level == 2)
            {
                LibilitiesHeadName = e.Node.Text;
                list = manager.GetBalanceSheetAccountsBalances(Operations.IdProject, Operations.BookNo, 2, LibilitiesHeadName);
                if (list != null && list.Count > 0)
                {
                    dtLibilities = DataOperations.ToDataTable(list);
                    grdLibilities.DataSource = dtLibilities;
                    lblTotalLibilitiesAmount.Text = list.Sum(x => x.ClosingBalance).ToString();  //list[0].ClosingBalance.ToString();
                    lblLibilitiesHeadName.Text = LibilitiesHeadName + " : " + list.Sum(x => x.ClosingBalance).ToString();
                }
                else
                {
                    grdLibilities.DataSource = null;
                    lblTotalAssetsAmount.Text = string.Empty;
                }
            }
        }
        #endregion
        #region TextBoxesEvents
        private void txtAssetsAccounts_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtAssets);
            DV.RowFilter = string.Format("AccountName LIKE '%{0}%'", txtAssetsAccounts.Text);
            grdAssets.DataSource = DV;
        }
        private void txtLibilitiesAccounts_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtLibilities);
            DV.RowFilter = string.Format("AccountName LIKE '%{0}%'", txtLibilitiesAccounts.Text);
            grdLibilities.DataSource = DV;
        }
        #endregion
    }
}
