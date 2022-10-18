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
    public partial class frmPostDatedChequesDetail : MetroForm
    {
        #region Variables
        frmPostedDatedCheques frmpostdated;
        #endregion
        #region Form Methods And Events
        public frmPostDatedChequesDetail()
        {
            InitializeComponent();
        }
        private void frmPostDatedChequesDetail_Load(object sender, EventArgs e)
        {
            grdNewCheques.AutoGenerateColumns = false;
            grdBadCheques.AutoGenerateColumns = false;
            grdCashedCheques.AutoGenerateColumns = false;
            metroTabControl1.SelectedIndex = 0;
            FillNewChequesData();
        }
        private void FillNewChequesData()
        {
            var manager = new ChequesBLL();
            List<ChequesEL> list = manager.GetAllChequesByInitialStatus(Operations.IdProject, Operations.BookNo);
            if (list.Count > 0)
            {
                grdNewCheques.DataSource = list;
            }
            else
                grdNewCheques.DataSource = null;
        }
        #endregion
        #region New Cheque Grid Events
        private void grdNewCheques_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                e.Value = "Update";
            }
            else if (e.ColumnIndex == 11)
            {
                e.Value = "Delete";
            }
        }
        private void grdNewCheques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("Do You Want To Update This Cheque..", "Update Cheque...", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    frmpostdated = new frmPostedDatedCheques();
                    frmpostdated.IsChequeLoaded = true;
                    frmpostdated.IdCheque = Validation.GetSafeLong(grdNewCheques.Rows[e.RowIndex].Cells[0].Value);
                    frmpostdated.ShowDialog();
                }
            }
            else if (e.ColumnIndex == 11)
            {
                if (MessageBox.Show("Do You Want To Delete This Cheque..", "Deleting Cheque...", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var manager = new ChequesBLL();
                    if (manager.DeletePostDatedCheque(Validation.GetSafeLong(grdNewCheques.Rows[e.RowIndex].Cells[0].Value)).IsSuccess)
                    {
                        MessageBox.Show("Cheque Deleted Successfully....");
                        FillNewChequesData();
                    }
                }
            }

        }
        #endregion
        #region Bad Cheques Events
        private void grdBadCheques_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                e.Value = "Update";
            }
            else if (e.ColumnIndex == 10)
            {
                e.Value = "Delete";
            }
        }
        private void grdBadCheques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("Do You Want To Update This Cheque..", "Update Cheque...", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    frmpostdated = new frmPostedDatedCheques();
                    frmpostdated.IsChequeLoaded = true;
                    frmpostdated.IdCheque = Validation.GetSafeLong(grdBadCheques.Rows[e.RowIndex].Cells[0].Value);
                    frmpostdated.ShowDialog();
                }
            }
            else if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("Do You Want To Delete This Cheque..", "Deleting Cheque...", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var manager = new ChequesBLL();
                    if (manager.DeletePostDatedCheque(Validation.GetSafeLong(grdBadCheques.Rows[e.RowIndex].Cells[0].Value)).IsSuccess)
                    {
                        MessageBox.Show("Cheque Deleted Successfully....");
                        FillNewChequesData();
                    }
                }
            }
        }
        #endregion
        #region Tab Methods and Events
        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var manager = new ChequesBLL();
            List<ChequesEL> list = null;
            if (metroTabControl1.SelectedIndex == 0)
            {
                list = manager.GetAllChequesByInitialStatus(Operations.IdProject, Operations.BookNo);
                if (list.Count > 0)
                {
                    grdNewCheques.DataSource = list;
                }
                else
                    grdNewCheques.DataSource = null;
            }
            else if (metroTabControl1.SelectedIndex == 1)
            {
                list = manager.GetAllChequesByBadStatus(Operations.IdProject, Operations.BookNo);
                if (list.Count > 0)
                {
                    grdBadCheques.DataSource = list;
                }
                else
                    grdBadCheques.DataSource = null;
            }
            else if (metroTabControl1.SelectedIndex == 2)
            {
                list = manager.GetAllChequesByCashedStatus(Operations.IdProject, Operations.BookNo);
                if (list.Count > 0)
                {
                    grdCashedCheques.DataSource = list;
                }
                else
                    grdCashedCheques.DataSource = null;
            }
        }
        #endregion
        #region Button Events
        private void btnReload_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            FillNewChequesData();
        }
        #endregion
    }
}
