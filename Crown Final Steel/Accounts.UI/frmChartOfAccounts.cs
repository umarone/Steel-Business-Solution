using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.BLL;
using Accounts.Common;
using Accounts.UI.UserControls;
using Accounts.EL;

namespace Accounts.UI
{
    public partial class frmChartOfAccounts : Form
    {
        frmFindAccounts frmAccount = new frmFindAccounts();
        ChartsOfAccountsEL oelChartOfAccount = new ChartsOfAccountsEL();
        ChartsOfAccountsBLL objChartofAccountBll = new ChartsOfAccountsBLL();
        PersonsEL oelPerson = new PersonsEL();
        PersonsBLL objPersonBll = new PersonsBLL();
        ItemsBLL objItemBll = new ItemsBLL();
        ItemsEL oelItem = new ItemsEL();
        EntityoperationInfo infoResult = null;
        string MiscAccount = "";
        public frmChartOfAccounts()
        {
            InitializeComponent();
        }

        private void frmChartOfAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                pnlPersons.Visible = false;
                pnlItems.Visible = false;
                //this.Size = new Size(572, 554);
                PopulateAccountsHeader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateAccountsHeader()
        {

            List<ChartsOfAccountsEL> list = new List<ChartsOfAccountsEL>();
            list.Add(new ChartsOfAccountsEL { Catagory = 0, SubCategoryName = "" });
            list.Add(new ChartsOfAccountsEL { Catagory = 1, SubCategoryName="Assets" });
            list.Add(new ChartsOfAccountsEL { Catagory = 2, SubCategoryName = "Libilities" });
            list.Add(new ChartsOfAccountsEL { Catagory = 3, SubCategoryName = "Equity / Capital" });
            list.Add(new ChartsOfAccountsEL { Catagory = 4, SubCategoryName = "Income / Revenue" });
            list.Add(new ChartsOfAccountsEL { Catagory = 5, SubCategoryName = "Expense" });

            CbxHeaders.DataSource = list;
            CbxHeaders.DisplayMember = "SubCategoryName";
            CbxHeaders.ValueMember = "Catagory";

        }
        private void CbxHeaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAccountNo.Text != string.Empty && txtAccountName.Text != string.Empty)
            {
                //List<ChartsOfAccountsEL> list = objChartofAccountBll.GetAccountSubCategory(Convert.ToInt32(((ChartsOfAccountsEL)CbxHeaders.SelectedValue).Catagory));
                if (Convert.ToInt32(CbxHeaders.SelectedValue) != 0)
                {
                    List<ChartsOfAccountsEL> list = objChartofAccountBll.GetAccountSubCategory(Convert.ToInt32(CbxHeaders.SelectedValue));
                    list.Insert(0, new ChartsOfAccountsEL { SubCategoryName = "", SubCategory = list[0].SubCategory });
                    if (list != null && list.Count > 0)
                    {
                        cbxSubCategory.DataSource = list;
                        cbxSubCategory.DisplayMember = "SubCategoryName";
                        cbxSubCategory.ValueMember = "SubCategory";
                    }
                }
            }
        }

        private void cbxSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Assets")
            {
                this.pnlPersons.Visible = true;
                this.pnlItems.Visible = false;
                txtPersonName.Text = txtAccountName.Text;
            }
            else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Libilities")
            {
                this.pnlPersons.Visible = true;
                this.pnlItems.Visible = false;
                txtPersonName.Text = txtAccountName.Text;
            }
            else if (cbxSubCategory.SelectedIndex == 2 && CbxHeaders.Text == "Assets")
            {
                this.pnlPersons.Visible = false;
                this.pnlItems.Visible = true;
                txtItemName.Text = txtAccountName.Text;
            }
            else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Expense")
            {
                this.pnlPersons.Visible = true;
                this.pnlItems.Visible = false;
                txtPersonName.Text = txtAccountName.Text;
            }
            else
            {
                this.pnlPersons.Visible = false;
                this.pnlItems.Visible = false;
            }
            
        }
        private void ClearControls()
        {
            txtAccountNo.Text = string.Empty;
            txtAccountName.Text = string.Empty;
            txtPersonName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtNTN.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtItemDescription.Text = string.Empty;
            MiscAccount = string.Empty;
            txtAccountNo.Enabled = true;
        }
        private void ClearPersonPanel()
        {
            if (pnlPersons.Visible)
            {
                foreach (var Control in pnlPersons.Controls)
                {
                    if (Control is TextBox)
                    {
                        ((TextBox)Control).Text = string.Empty;
                    }
                }
            }
            CbxHeaders.SelectedIndex = 0;
            cbxSubCategory.DataSource = null;
            MiscAccount = string.Empty;
            txtAccountNo.Enabled = true;
        }
        private void ClearItemsPanel()
        { 
            if (pnlItems.Visible)
            {
                foreach (var Control in pnlItems.Controls)
                {
                    if (Control is TextBox)
                    {
                        ((TextBox)Control).Text = string.Empty;
                    }
                }
            }
            CbxHeaders.SelectedIndex = 0;
            cbxSubCategory.DataSource = null;
            MiscAccount = string.Empty;
            txtAccountNo.Enabled = true;
        }
        private bool ValidateFields()
        {
            if (txtAccountNo.Text == string.Empty)
            {
                AccountError.SetError(txtAccountNo, "*");
                return false;
            }
            else if (txtAccountName.Text == string.Empty)
            {
                AccountError.SetError(txtAccountNo, "");
                AccountError.SetError(txtAccountName, "*");
                return false;
            }
            else if (CbxHeaders.SelectedIndex == 0)
            {
                AccountError.SetError(txtAccountNo, "");
                AccountError.SetError(txtAccountName, "");
                AccountError.SetError(CbxHeaders, "*");
                return false;
            }
            else if (cbxSubCategory.SelectedIndex == 0)
            {
                AccountError.SetError(txtAccountNo, "");
                AccountError.SetError(txtAccountName, "");
                AccountError.SetError(CbxHeaders, "");
                AccountError.SetError(cbxSubCategory, "*");
                return false;
            }
            else
            {
                AccountError.SetError(txtAccountNo, "");
                AccountError.SetError(txtAccountName, "");
                AccountError.SetError(CbxHeaders, "");
                AccountError.SetError(cbxSubCategory, "");
                return true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
            {
            if (ValidateFields())
            {
                if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Assets")
                {
                    oelChartOfAccount.AccountNo = txtAccountNo.Text.Trim();
                    oelChartOfAccount.AccountName = txtAccountName.Text;
                    oelChartOfAccount.Catagory = Convert.ToInt32(cbxSubCategory.SelectedValue);
                    oelChartOfAccount.IsPrescriber = null;
                    //oelChartOfAccount.Catagory = Convert.ToInt32(((ChartsOfAccountsEL)CbxHeaders.SelectedValue).Catagory); ;
                    oelChartOfAccount.HeaderAccount = CbxHeaders.SelectedIndex;
                    oelChartOfAccount.AccountType = cbxSubCategory.Text.ToString();
                    oelPerson.AccountNo = txtAccountNo.Text;
                    oelPerson.PersonName = txtPersonName.Text;
                    oelPerson.Address = txtAddress.Text;
                    oelPerson.NTN = txtNTN.Text;
                    oelPerson.Contact = txtContact.Text;
                    if (MiscAccount == string.Empty)
                    {
                        if (!objChartofAccountBll.CheckAccount(txtAccountNo.Text))
                        {
                            infoResult = objPersonBll.InsertPersonAccount(oelPerson, oelChartOfAccount);
                            if (infoResult.IsSuccess)
                            {
                                MessageBox.Show("Account Created Successfully");
                                ClearControls();
                                pnlPersons.Visible = false;
                                cbxSubCategory.DataSource = null;
                                CbxHeaders.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Some Problem occured while loading Record");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account Already Exists");
                        }
                    }
                    else
                    {
                        infoResult = objPersonBll.UpdatePersonAccount(oelChartOfAccount, oelPerson);
                        if (infoResult.IsSuccess)
                        {
                            MessageBox.Show("Account Updated Successfully");
                            ClearControls();
                            pnlPersons.Visible = false;
                            cbxSubCategory.DataSource = null;
                            CbxHeaders.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Some Problem occured while loading Record");
                        }
                    }

                }
                else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Libilities")
                {
                    oelChartOfAccount.AccountNo = txtAccountNo.Text.Trim();
                    oelChartOfAccount.AccountName = txtAccountName.Text;
                    oelChartOfAccount.Catagory = Convert.ToInt32(cbxSubCategory.SelectedValue);
                    //oelChartOfAccount.Catagory = Convert.ToInt32(((ChartsOfAccountsEL)CbxHeaders.SelectedValue).Catagory); ;
                    oelChartOfAccount.HeaderAccount = CbxHeaders.SelectedIndex;
                    oelChartOfAccount.AccountType = cbxSubCategory.Text.ToString();
                    oelPerson.AccountNo = txtAccountNo.Text;
                    oelPerson.AccountName = txtPersonName.Text.Trim();
                    oelPerson.PersonName = txtPersonName.Text.Trim();
                    oelPerson.Address = txtAddress.Text;
                    oelPerson.NTN = txtNTN.Text;
                    oelPerson.Contact = txtContact.Text;
                    if (MiscAccount == string.Empty)
                    {
                        if (!objChartofAccountBll.CheckAccount(txtAccountNo.Text))
                        {
                            infoResult = objPersonBll.InsertPersonAccount(oelPerson, oelChartOfAccount);
                            if (infoResult.IsSuccess)
                            {
                                MessageBox.Show("Account Created Successfully");
                                pnlPersons.Visible = false;
                                cbxSubCategory.DataSource = null;
                                ClearControls();
                                CbxHeaders.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Some Problem occured while loading Record");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account Already Exists");
                        }
                    }
                    else
                    {
                        infoResult = objPersonBll.UpdatePersonAccount(oelChartOfAccount, oelPerson);
                        if (infoResult.IsSuccess)
                        {
                            MessageBox.Show("Account Updated Successfully");
                            pnlPersons.Visible = false;
                            cbxSubCategory.DataSource = null;
                            ClearControls();
                            CbxHeaders.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Some Problem occured while loading Record");
                        }
                    }
                }
                else if (cbxSubCategory.SelectedIndex == 2 && CbxHeaders.Text == "Assets")
                {
                    oelChartOfAccount.AccountNo = txtAccountNo.Text.Trim();
                    oelChartOfAccount.AccountName = txtAccountName.Text;
                    oelChartOfAccount.Catagory = Convert.ToInt32(cbxSubCategory.SelectedValue);
                    oelChartOfAccount.IsPrescriber = null;
                    //oelChartOfAccount.Catagory = Convert.ToInt32(((ChartsOfAccountsEL)CbxHeaders.SelectedValue).Catagory); ;
                    oelChartOfAccount.HeaderAccount = CbxHeaders.SelectedIndex;
                    oelChartOfAccount.AccountType = cbxSubCategory.Text.ToString();
                    oelChartOfAccount.IsPrescriber = null;
                    oelItem.ItemNo = txtAccountNo.Text;
                    oelItem.ItemName = txtItemName.Text;
                    oelItem.PackingSize = txtPackingSize.Text;
                    oelItem.Description = txtItemDescription.Text;
                    if (MiscAccount == string.Empty)
                    {
                        if (!objChartofAccountBll.CheckAccount(txtAccountNo.Text))
                        {
                            infoResult = objItemBll.InsertStockWithAccount(oelChartOfAccount, oelItem);
                            if (infoResult.IsSuccess)
                            {
                                MessageBox.Show("Account Created Successfully...");
                                pnlItems.Visible = false;
                                cbxSubCategory.DataSource = null;
                                CbxHeaders.SelectedIndex = 0;
                                ClearControls();
                            }
                            else
                            {
                                MessageBox.Show("Some Problem Occured while Saving Account...");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account Already Exists...");
                        }
                    }
                    else
                    {
                        infoResult = objItemBll.UpdateItemsWithAccount(oelChartOfAccount, oelItem);
                        if (infoResult.IsSuccess)
                        {
                            MessageBox.Show("Account Updated Successfully...");
                            pnlItems.Visible = false;
                            cbxSubCategory.DataSource = null;
                            CbxHeaders.SelectedIndex = 0;
                            ClearControls();
                        }
                        else
                        {
                            MessageBox.Show("Some Problem Occured while Saving Account...");
                        }
                    }
                }
                else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Expense")
                {
                    oelChartOfAccount.AccountNo = txtAccountNo.Text.Trim();
                    oelChartOfAccount.AccountName = txtAccountName.Text;
                    oelChartOfAccount.Catagory = Convert.ToInt32(cbxSubCategory.SelectedValue);
                    //oelChartOfAccount.Catagory = Convert.ToInt32(((ChartsOfAccountsEL)CbxHeaders.SelectedValue).Catagory); ;
                    oelChartOfAccount.HeaderAccount = CbxHeaders.SelectedIndex;
                    oelChartOfAccount.AccountType = cbxSubCategory.Text.ToString();
                    oelChartOfAccount.IsPrescriber = null;
                    oelPerson.AccountNo = txtAccountNo.Text;
                    oelPerson.PersonName = txtPersonName.Text;
                    oelPerson.Address = txtAddress.Text;
                    oelPerson.NTN = txtNTN.Text;
                    oelPerson.Contact = txtContact.Text;
                    if (MiscAccount == string.Empty)
                    {
                        if (!objChartofAccountBll.CheckAccount(txtAccountNo.Text))
                        {
                            infoResult = objPersonBll.InsertPersonAccount(oelPerson, oelChartOfAccount);
                            if (infoResult.IsSuccess)
                            {
                                MessageBox.Show("Account Created Successfully");
                                ClearControls();
                                pnlPersons.Visible = false;
                                cbxSubCategory.DataSource = null;
                                CbxHeaders.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Some Problem occured while loading Record");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account Already Exists");
                        }
                    }
                    else
                    {
                        infoResult = objPersonBll.UpdatePersonAccount(oelChartOfAccount, oelPerson);
                        if (infoResult.IsSuccess)
                        {
                            MessageBox.Show("Account Updated Successfully");
                            ClearControls();
                            pnlPersons.Visible = false;
                            cbxSubCategory.DataSource = null;
                            CbxHeaders.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Some Problem occured while loading Record");
                        }
                    }
                }
                else
                {
                    oelChartOfAccount.AccountNo = txtAccountNo.Text.Trim();
                    oelChartOfAccount.AccountName = txtAccountName.Text;
                    oelChartOfAccount.IsPrescriber = null;
                    if (cbxSubCategory.SelectedValue != null)
                    {
                        oelChartOfAccount.Catagory = Convert.ToInt32(cbxSubCategory.SelectedValue);
                    }
                    else
                    {
                        oelChartOfAccount.Catagory = Convert.ToInt32(CbxHeaders.SelectedValue);
                    }
                    //oelChartOfAccount.Catagory = Convert.ToInt32(((ChartsOfAccountsEL)CbxHeaders.SelectedValue).Catagory);
                    oelChartOfAccount.HeaderAccount = CbxHeaders.SelectedIndex;
                    oelChartOfAccount.AccountType = cbxSubCategory.Text.ToString();
                    if (MiscAccount == string.Empty)
                    {
                        if (!objChartofAccountBll.CheckAccount(txtAccountNo.Text))
                        {
                            infoResult = objChartofAccountBll.InsertChartsOfAccounts(oelChartOfAccount);
                            if (infoResult.IsSuccess)
                            {
                                MessageBox.Show("Account Created Successfully...");
                                ClearControls();
                                cbxSubCategory.DataSource = null;
                                CbxHeaders.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Some Problem Occured while Saving Account...");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account Already Exists...");
                        }
                    }
                    else
                    {
                        infoResult = objChartofAccountBll.UpdateChartsOfAccounts(oelChartOfAccount);
                        if (infoResult.IsSuccess)
                        {
                            MessageBox.Show("Account Updated Successfully...");
                            ClearControls();
                            cbxSubCategory.DataSource = null;
                            CbxHeaders.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Some Problem Occured while Saving Account...");
                        }
                    }
                }                
            }
        }

       
        private void txtAccountNo_ClickButton(object sender, EventArgs e)
        {
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog(this);
        }
        void frmAccount_ExecuteFindAccountEvent(ChartsOfAccountsEL oelChartOfAccount)
        {
            var manager = new ChartsOfAccountsBLL();
            if (oelChartOfAccount != null)
            {
                MiscAccount = oelChartOfAccount.AccountNo;
                List<ChartsOfAccountsEL> list = manager.GetAccount(oelChartOfAccount.AccountNo);
                if (list.Count > 0)
                {
                    txtAccountNo.Text = list[0].AccountNo;
                    txtAccountName.Text = list[0].AccountName;
                    CbxHeaders.SelectedIndex = list[0].HeaderAccount;
                    oelChartOfAccount.SubCategory = list[0].Catagory;
                    cbxSubCategory.SelectedIndex = cbxSubCategory.FindString(list[0].AccountType);
                    txtAccountNo.Enabled = false;
                    if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Assets")
                    {
                        var Personmanager = new PersonsBLL();
                        PersonsEL oelPerson = Personmanager.GetPersonByAccount(oelChartOfAccount.AccountNo);
                        if (oelPerson != null)
                        {
                            txtPersonName.Enabled = false;
                            txtPersonName.Text = oelPerson.PersonName;
                            txtContact.Text = oelPerson.Contact;
                            txtAddress.Text = oelPerson.Address;
                            txtNTN.Text = oelPerson.NTN;
                        }
                    }
                    else if (cbxSubCategory.SelectedIndex == 2 && CbxHeaders.Text == "Assets")
                    {
                        var itemManager = new ItemsBLL();
                        ItemsEL oelItem = itemManager.GetItemByAccount(oelChartOfAccount.AccountNo);
                        if (oelItem != null)
                        {
                            txtItemName.Enabled = false;
                            txtItemName.Text = oelItem.ItemName;
                            txtPackingSize.Text = oelItem.PackingSize;
                            txtItemDescription.Text = oelItem.Description;
                        }
                    }
                    else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Libilities")
                    {
                        var Personmanager = new PersonsBLL();
                        PersonsEL oelPerson = Personmanager.GetPersonByAccount(oelChartOfAccount.AccountNo);
                        if (oelPerson != null)
                        {
                            txtPersonName.Enabled = false;
                            txtPersonName.Text = oelPerson.PersonName;
                            txtContact.Text = oelPerson.Contact;
                            txtAddress.Text = oelPerson.Address;
                            txtNTN.Text = oelPerson.NTN;
                        }
                    }
                    else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Expense")
                    {
                        var Personmanager = new PersonsBLL();
                        PersonsEL oelPerson = Personmanager.GetPersonByAccount(oelChartOfAccount.AccountNo);
                        if (oelPerson != null)
                        {
                            txtPersonName.Enabled = false;
                            txtPersonName.Text = oelPerson.PersonName;
                            txtContact.Text = oelPerson.Contact;
                            txtAddress.Text = oelPerson.Address;
                            txtNTN.Text = oelPerson.NTN;
                        }
                    }
                    else
                    {
                        //var CoaManger = new ChartsOfAccountsBLL();
                        //List<ChartsOfAccountsEL> oelAccount = CoaManger.GetAccount(oelChartOfAccount.AccountNo);
                        //if (oelAccount.Count > 0)
                        //{ 
                            
                        //}

                    }

                }
            }
        }
        private void frmChartOfAccounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (MiscAccount != string.Empty)
                {
                    if (pnlPersons.Visible == true)
                    {                        
                        foreach (var Control in pnlPersons.Controls)
                        {
                            if (Control is TextBox)
                            {
                                TextBox txtGeneric = (TextBox)Control;
                                txtGeneric.Text = string.Empty;
                                cbxSubCategory.DataSource = null;
                                CbxHeaders.SelectedIndex = 0;
                            }
                        }
                        pnlPersons.Visible = false;
                    }
                    else if (pnlItems.Visible == true)
                    {
                        foreach (var Control in pnlItems.Controls)
                        {
                            if (Control is TextBox)
                            {
                                TextBox txtGeneric = (TextBox)Control;
                                txtGeneric.Text = string.Empty;
                                cbxSubCategory.DataSource = null;
                                CbxHeaders.SelectedIndex = 0;
                            }
                        }
                        pnlItems.Visible = false;
                    }
                    else
                    {
                        cbxSubCategory.DataSource = null;
                        CbxHeaders.SelectedIndex = 0;                        
                    }
                    txtAccountNo.Enabled = true;
                    txtAccountNo.Text = string.Empty;
                    txtAccountName.Text = string.Empty;
                    MiscAccount = string.Empty;
                }
            }
        }
        private void txtAccountName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (MiscAccount != string.Empty)
                {
                    if (pnlPersons.Visible)
                    {
                        txtPersonName.Text += e.KeyChar;
                    }
                    else
                    {
                        txtItemName.Text += e.KeyChar;
                    }
                }
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                if (MiscAccount != string.Empty)
                {
                    if (pnlPersons.Visible)
                    {
                        txtPersonName.Text = "";
                    }
                    else
                    {
                        txtItemName.Text = "";
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Transactionmanager = new TransactionBLL();
            var CoaManager = new ChartsOfAccountsBLL();
            EntityoperationInfo deleteInfo = null;
            List<TransactionsEL> list = null;
            if (MiscAccount == string.Empty)
            {
                MessageBox.Show("Select Account To Delete");
            }
            else if (MiscAccount != string.Empty)
            {
                list = Transactionmanager.GetAccountInTransaction(MiscAccount);
                if (list.Count > 0)
                {
                    MessageBox.Show("Account Is In Transaction");
                }
                else
                {
                    if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Assets")
                    {
                        if (CoaManager.DeletePersonAccount(MiscAccount) == true)
                        {
                            MessageBox.Show("Account Deleted SuccessFully...");
                        }
                        ClearPersonPanel();
                    }                    
                    else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Libilities")
                    {
                        if (CoaManager.DeletePersonAccount(MiscAccount) == true)
                        {
                            MessageBox.Show("Account Deleted SuccessFully...");
                        }
                        ClearPersonPanel();
                    }                    
                    else if (cbxSubCategory.SelectedIndex == 2 && CbxHeaders.Text == "Assets" && MiscAccount != string.Empty)
                    {
                        if (CoaManager.DeleteItemAccount(MiscAccount) == true)
                        {
                            MessageBox.Show("Account Deleted SuccessFully...");
                        }
                        ClearItemsPanel();
                    }                   
                    else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Expense" && MiscAccount != string.Empty)
                    {
                        if (CoaManager.DeletePersonAccount(MiscAccount) == true)
                        {
                            MessageBox.Show("Account Deleted SuccessFully...");
                        }
                        ClearPersonPanel();
                    }                  
                    else
                    {
                        deleteInfo = CoaManager.DeleteChartOfAccount(MiscAccount);
                        if (deleteInfo != null && deleteInfo.IsSuccess)
                        {
                            MessageBox.Show("Account Deleted...");
                        }                       
                    }
                    foreach (var Control in pnlChartOfAccounts.Controls)
                    {
                        if (Control is TextBox)
                        {
                            ((TextBox)Control).Text = string.Empty;
                        }
                        else if (Control is RichTextBox)
                        {
                            ((RichTextBox)Control).Text = string.Empty;
                        }
                    }
                    txtAccountNo.Enabled = true;
                    MiscAccount = string.Empty;
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Assets" && MiscAccount != string.Empty)
            {
                ClearPersonPanel();
            }
            else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Assets" && MiscAccount == string.Empty)
            {
                ClearPersonPanel();
            }
            else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Libilities" && MiscAccount != string.Empty)
            {
                ClearPersonPanel();
            }
            else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Libilities" && MiscAccount == string.Empty)
            {
                ClearPersonPanel();
            }
            else if (cbxSubCategory.SelectedIndex == 2 && CbxHeaders.Text == "Assets" && MiscAccount != string.Empty)
            {
                ClearItemsPanel();
            }
            else if (cbxSubCategory.SelectedIndex == 2 && CbxHeaders.Text == "Assets" && MiscAccount == string.Empty)
            {
                ClearItemsPanel();
            }
            else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Expense" && MiscAccount != string.Empty)
            {
                ClearPersonPanel();
            }
            else if (cbxSubCategory.SelectedIndex == 1 && CbxHeaders.Text == "Expense" && MiscAccount == string.Empty)
            {
                ClearPersonPanel();
            }
            else
            {
                foreach (var Control in pnlChartOfAccounts.Controls)
                {
                    if (Control is TextBox)
                    {
                        ((TextBox)Control).Text = string.Empty;
                    }
                    else if (Control is RichTextBox)
                    {
                        ((RichTextBox)Control).Text = string.Empty;
                    }
                }
                txtAccountNo.Enabled = true;
                MiscAccount = string.Empty;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
    }
}
