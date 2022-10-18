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
    public partial class frmPostedDatedCheques : MetroForm
    {
        #region Variables
        frmFindAccounts frmfindaccounts;
        public Int64 IdCheque = 0;
        public bool IsChequeLoaded { get; set; }
        string AccountNo = "";
        #endregion
        #region Form Methods And Events
        public frmPostedDatedCheques()
        {
            InitializeComponent();
        }
        private void frmPostedDatedCheques_Load(object sender, EventArgs e)
        {
            FillData();
            if (IsChequeLoaded)
            {
                LoadChequeById();
            }
        }
        #endregion
        #region Simple Methods
        private void FillData()
        {
            var manager = new ChequesBLL();
            VEditBox.Text = Validation.GetSafeString(manager.GetMaxPostDatedChequeNo(Operations.IdProject, Operations.BookNo));
        }
        private void LoadChequeById()
        {
            var manager = new ChequesBLL();
            List<ChequesEL> list = manager.GetChequeById(IdCheque);
            if (list.Count > 0)
            {
                VEditBox.Text = Validation.GetSafeString(list[0].VoucherNo);
                txtChequeNo.Text = Validation.GetSafeString(list[0].ChequeNo);
                AccountNo = list[0].AccountNo;
                txtPartyName.Text = list[0].AccountName;
                txtBankName.Text = list[0].BankName;
                cbxChequeType.SelectedIndex = list[0].ChequeType;
                cbxChequeStatus.SelectedIndex = list[0].ChequeStatus;
                dtGivenTake.Value = list[0].ChequeGivenTakenDate;
                dtWithDrawl.Value = list[0].ChequeWithDrawlDate;
                txtChequeAmount.Text = Validation.GetSafeString(list[0].TotalAmount);
                if (list[0].IsDeleted != null && list[0].IsDeleted.Value)
                {
                    lblStatus.Text = "Deleted Check...";
                }
            }
        }
        private void LoadChequeByVoucherNo(Int64 VoucherNo)
        {
            var manager = new ChequesBLL();
            List<ChequesEL> list = manager.GetChequeByVoucher(VoucherNo);
            if (list.Count > 0)
            {
                VEditBox.Text = Validation.GetSafeString(list[0].VoucherNo);
                txtChequeNo.Text = Validation.GetSafeString(list[0].ChequeNo);
                AccountNo = list[0].AccountNo;
                txtPartyName.Text = list[0].AccountName;
                txtBankName.Text = list[0].BankName;
                cbxChequeType.SelectedIndex = list[0].ChequeType;
                cbxChequeStatus.SelectedIndex = list[0].ChequeStatus;
                dtGivenTake.Value = list[0].ChequeGivenTakenDate;
                dtWithDrawl.Value = list[0].ChequeWithDrawlDate;
                txtChequeAmount.Text = Validation.GetSafeString(list[0].TotalAmount);
                if (list[0].IsDeleted != null && list[0].IsDeleted.Value)
                {
                    lblStatus.Text = "Deleted Check...";
                }
            }
        }
        private void ClearControls()
        {
            IdCheque = 0;
            txtPartyName.Text = string.Empty;
            txtBankName.Text = string.Empty;
            txtChequeNo.Text = string.Empty;
            cbxChequeType.SelectedIndex = 0;
            cbxChequeStatus.SelectedIndex = 0;
            dtGivenTake.Value = DateTime.Now;
            dtWithDrawl.Value = DateTime.Now;
            txtChequeAmount.Text = string.Empty;
            lblStatus.Text = string.Empty;

        }
        #endregion
        #region Custom Methods and Events
        private void txtPartyName_ButtonClick(object sender, EventArgs e)
        {
            frmfindaccounts = new frmFindAccounts();
            frmfindaccounts.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmfindaccounts_ExecuteFindAccountEvent);
            frmfindaccounts.ShowDialog();
        }
        private void txtPartyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                e.Handled = true;
                frmfindaccounts = new frmFindAccounts();
                frmfindaccounts.SearchText = e.KeyChar.ToString();
                frmfindaccounts.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmfindaccounts_ExecuteFindAccountEvent);
                frmfindaccounts.ShowDialog();

            }
            else
                e.Handled = false;
        }
        void frmfindaccounts_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            AccountNo = oelAccount.AccountNo;
            txtPartyName.Text = oelAccount.AccountName;
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            var manager = new ChequesBLL();
            ChequesEL oelCheque = new ChequesEL();
            if (IdCheque > 0)
            {
                oelCheque.IdCheque = IdCheque;
            }
            else
                oelCheque.IdCheque = 0;
            oelCheque.IdProject = Operations.IdProject;
            oelCheque.BookNo = Operations.BookNo;
            oelCheque.IdUser = Operations.UserID;
            oelCheque.TerminalNumber = Validation.GetSafeInteger(XmlConfiguration.ReadXmlTerminalsConfiguration()[0]);
            oelCheque.AccountNo = AccountNo;
            oelCheque.BankName = txtBankName.Text;
            oelCheque.ChequeNo = txtChequeNo.Text;
            oelCheque.ChequeType = cbxChequeType.SelectedIndex;
            oelCheque.ChequeStatus = cbxChequeStatus.SelectedIndex;
            oelCheque.ChequeGivenTakenDate = dtGivenTake.Value;
            oelCheque.ChequeWithDrawlDate = dtWithDrawl.Value;
            oelCheque.CreatedDateTime = DateTime.Now;
            oelCheque.TotalAmount = Validation.GetSafeDecimal(txtChequeAmount.Text);
            if (IdCheque == 0)
            {
                if (manager.CreatePostDatedCheque(oelCheque).IsSuccess)
                {
                    lblStatus.Text = "Post Dated Cheque Created Successfully....";
                    ClearControls();
                    FillData();
                }
                else
                {
                    lblStatus.Text = "Some Problem Occured....";
                }
            }
            else
            {
                if (manager.UpdatePostDatedCheque(oelCheque).IsSuccess)
                {
                    lblStatus.Text = "Post Dated Cheque Updated Successfully....";
                    ClearControls();
                    FillData();
                }
                else
                {
                    lblStatus.Text = "Some Problem Occured....";
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (VEditBox.Text != string.Empty)
            {
                long PreviousVoucherNo = Convert.ToInt64(VEditBox.Text);
                if (PreviousVoucherNo > 1)
                {
                    PreviousVoucherNo -= 1;
                    VEditBox.Text = PreviousVoucherNo.ToString();
                    LoadChequeByVoucherNo(PreviousVoucherNo);
                }
                else
                {
                    MessageBox.Show("Can Not Go Back");
                }
            }
            else
            {
                MessageBox.Show("Please Load Any Invoice First Then Move Back....");
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (VEditBox.Text != string.Empty)
            {
                long NextVoucherNo = Convert.ToInt64(VEditBox.Text);
                NextVoucherNo += 1;
                VEditBox.Text = NextVoucherNo.ToString();
                LoadChequeByVoucherNo(NextVoucherNo);
            }
            else
            {
                MessageBox.Show("Please Load Any Invoice First Then Move Forward....");
            }
        }
        #endregion
    }
}
