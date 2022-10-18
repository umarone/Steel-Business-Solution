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
using MetroFramework.Controls;

namespace Accounts.UI
{
    public partial class frmExpenses : MetroForm
    {
        #region Variables
        frmFindAccounts frmAccount = null;
        DataTable dt;
        public frmExpenses()
        {
            InitializeComponent();
        }
        #endregion
        #region Form Methods
        private void frmExpenses_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.dgvExpenses.AutoGenerateColumns = false;
        }
        private void frmExpenses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void CheckModulePermissions()
        {
            List<UserModulesPermissionsEL> PermissionsList = UserPermissions.GetUserModulePermissionsByUserAndModuleId(Operations.UserID);
            if (PermissionsList != null && PermissionsList.Count > 0)
            {
                if (PermissionsList[0].Viewing == true)
                {
                    btnLoadExpense.Enabled = true;
                }
                else
                {
                    btnLoadExpense.Enabled = false;
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
        #endregion
        #region Events And Methods
        private void btnLoadExpense_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            var manager = new TransactionBLL();
            List<TransactionsEL> list = null;
            if (chkExcludeDate.Checked)
            {
                list = manager.ListExpenses(Operations.IdProject, Operations.BookNo);
            }
            else
            {
                list = manager.ListExpensesByDate(dtStart.Value, dtEnd.Value, Operations.IdProject, Operations.BookNo);
            }
            if (list != null && list.Count > 0)
            {
                dt = DataOperations.ToDataTable(list);
                dgvExpenses.DataSource = dt;
                txtExpenseAmount.Text = list.Sum(x => x.Debit).ToString();
            }
            else
            {
                dgvExpenses.DataSource = null;
                txtExpenseAmount.Text = string.Empty;
            }
        }
        private void PopulateExpenses(List<TransactionsEL> list)
        {
            if (dgvExpenses.Rows.Count > 0)
            {
                dgvExpenses.Rows.Clear();
                txtExpenseAmount.Text = "";
            }
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dgvExpenses.Rows.Add();
                    dgvExpenses.Rows[i].Cells[0].Value = list[i].VoucherNo;
                    dgvExpenses.Rows[i].Cells[1].Value = list[i].AccountName;
                    dgvExpenses.Rows[i].Cells[2].Value = list[i].Description;
                    dgvExpenses.Rows[i].Cells[3].Value = list[i].Debit;                                        
                }               
            }
            txtExpenseAmount.Text = list.Sum(x => x.Debit).ToString();
        }
        private void chkExcludeDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcludeDate.Checked)
            {
                dgvExpenses.Columns[0].Visible = false;
                dgvExpenses.Columns[1].Width = 400;
                dgvExpenses.Rows.Clear();
            }
            else
            {
                dgvExpenses.Columns[0].Visible = true;
                dgvExpenses.Columns[1].Width = 300;
                dgvExpenses.Rows.Clear();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("AccountName LIKE '%{0}%'", txtSearch.Text);
            dgvExpenses.DataSource = DV;
        }
        #endregion
    }
}
