using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.BLL;
using Accounts.EL;
using Accounts.Common;


namespace Accounts.UI.UserControls
{
    public partial class UCPersons : UserControl
    {
        #region Variables
        PersonsEL oelPerson = new PersonsEL();
        ChartsOfAccountsEL oelChartOfAccounts = new ChartsOfAccountsEL();
        EntityoperationInfo objOperationInfo = null;
        PersonsBLL bPersons = new PersonsBLL();
        //ChartsOfAccountsBLL objChartOfAccountBLL = new ChartsOfAccountsBLL();
        AccountsBLL objAccounts = new AccountsBLL();
        #endregion
        #region Properties
        public bool IsCustomer { get; set; }
        #endregion
        public UCPersons()
        {
            InitializeComponent();
        }

        private void UCPersons_Load(object sender, EventArgs e)
        {

        }
        private void ClearControls()
        {
            txtCustomerName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtNTN.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
        private bool ValidateControls()
        {
            bool status = true;
            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                status = false;
            }
            if (string.IsNullOrEmpty(txtContact.Text))
            {
                status = false;
            }
            return status;
        }
        //private void DisplayMessage(string msg, bool IsSuccess)
        //{
        //    if (IsSuccess)
        //    {
        //        lblmsg.Text = msg;
        //    }
        //    else
        //    {
        //        lblmsg.Text = "";

        //    }
        //}
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                oelChartOfAccounts.AccountNo = objChartOfAccountBLL.GetAccountType(AccountTypes.Customers.ToString());
                oelChartOfAccounts.AccountName = txtCustomerName.Text;
                oelChartOfAccounts.AccountType = AccountTypes.Customers.ToString();
                oelChartOfAccounts.Catagory = 1;
                oelPerson.Number = txtCustomerName.Text;
                oelPerson.PersonName = txtCustomerName.Text;
                oelPerson.Number = oelChartOfAccounts.AccountNo;
                oelPerson.NTN = txtNTN.Text;
                oelPerson.Contact = txtContact.Text;
                oelPerson.Address = txtAddress.Text;
                oelPerson.IsCustomer = IsCustomer;
                objOperationInfo = bPersons.InsertPerson(oelPerson, oelChartOfAccounts);
               
                if (objOperationInfo.IsSuccess)
                {
                    //DisplayMessage("Customer Saved Successfully", true);
                    ClearControls();
                }

            }
            else
            {
                //DisplayMessage("Enter Values", false);

            }
        }
    }
}
