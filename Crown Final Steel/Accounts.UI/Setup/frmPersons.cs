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
using Accounts.EL;
using MetroFramework.Forms;
using System.IO;


namespace Accounts.UI
{
    public partial class frmPersons : MetroForm
    {
        //UCPersons ucPerson = new UCPersons();
        ImageConverter converter = new ImageConverter();
        frmFindAccounts frmaccounts = null;
        public string PersonsType { get; set; }
        public string ViewDetailType { get; set; }
        public string AccountNo { get; set; }
        Int64? IdPerson;
        Int64 AccountCode;
        int ParentId;
        string PersonType;
        public frmPersons()
        {
            //this.Size = ucPerson.Size;
            InitializeComponent();
        }

        private void frmPersons_Load(object sender, EventArgs e)
        {
            if (PersonsType == "Customers")
            {
                this.Text = "Customers";
                txtSalary.Visible = false;
            }
            else if (PersonsType == "Suppliers")
            {
                this.Text = "Suppliers";
                txtSalary.Visible = false;
            }
            else if (PersonsType == "Employees")
            {
                this.Text = "Employees";
                txtSalary.Visible = true;
            }
            if (ViewDetailType != string.Empty || ViewDetailType != null)
            {
                if(AccountNo != null && AccountNo != string.Empty)
                GetPerson(AccountNo);
            }
        }
        private void CheckModulePermissions()
        {
            List<UserModulesPermissionsEL> PermissionsList = UserPermissions.GetUserModulePermissionsByUserAndModuleId(Operations.UserID);
            if (PermissionsList != null && PermissionsList.Count > 0)
            {
                if (PermissionsList[0].Saving == true)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
                if (PermissionsList[0].Deleting == true)
                {
                    //btnDelete.Enabled = true;
                }
                else
                {
                    //btnDelete.Enabled = false;
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
        //private void txtSearchPersons_Enter(object sender, EventArgs e)
        //{
        //    txtSearchPersons.WaterMark = "";
        //}
        //private void txtSearchPersons_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        grdPersons.Focus();
        //        e.KeyChar = (char)Keys.Tab;
        //    }
        //}
        //private void txtSearchPersons_TextChanged(object sender, EventArgs e)
        //{
        //    var manager = new PersonsBLL();
        //    List<PersonsEL> list = new List<PersonsEL>();
        //    string searchString = "";
        //    if (txtSearchPersons.Text != string.Empty)
        //    {
        //        char[] chars = txtSearchPersons.Text.ToArray();
        //        if (chars.Length > 0 && char.IsNumber(chars[0]))
        //        {
        //            list = manager.SearchPersonsByAccountNo(Validation.GetSafeLong(txtSearchPersons.Text), Operations.IdCompany);
        //            PopulatePersonsBySearch(list);
        //        }
        //        else
        //        {
        //            searchString = txtSearchPersons.Text;
        //            if (txtSearchPersons.Text.Contains("\t"))
        //                searchString = txtSearchPersons.Text.Remove(txtSearchPersons.Text.Count() - 1);
        //            list = manager.SearchPersonByPersonName(searchString, Operations.IdCompany);
        //            PopulatePersonsBySearch(list);
        //        }
        //    }
        //    else if (grdPersons.Rows.Count > 0)
        //    {
        //        grdPersons.DataSource = null;
        //    }
        //}
        //private void PopulatePersonsBySearch(List<PersonsEL> list)
        //{
        //    if (grdPersons.Rows.Count > 1)
        //    {
        //        grdPersons.DataSource = null;
        //    }
        //    grdPersons.DataSource = list;
        //}

        //private void grdPersons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    IdPerson = Validation.GetSafeGuid(grdPersons.Rows[e.RowIndex].Cells["colAccountId"].Value);
        //    AccountCode = Validation.GetSafeLong(grdPersons.Rows[e.RowIndex].Cells["colAccountCode"].Value);
        //    PersonType = Validation.GetSafeString(grdPersons.Rows[e.RowIndex].Cells["colType"].Value);
        //    //CbxHeads.SelectedValue = Validation.GetSafeInteger(grdAccounts.Rows[e.RowIndex].Cells["colIdParent1"].Value);
        //    //CbxHeads_SelectedIndexChanged(sender, e);
        //    GetPerson(IdPerson);
        //}
        //private void grdPersons_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        if (grdPersons.CurrentRow != null)
        //        {
        //            int RowIndex = grdPersons.CurrentRow.Index;
                    
        //            IdPerson = Validation.GetSafeGuid(grdPersons.Rows[RowIndex].Cells["colAccountId"].Value);
        //            AccountCode = Validation.GetSafeLong(grdPersons.Rows[RowIndex].Cells["colAccountCode"].Value);
        //            PersonType = Validation.GetSafeString(grdPersons.Rows[RowIndex].Cells["colType"].Value);

        //            GetPerson(IdPerson);
        //        }
        //    }
        //}
        private void frmPersons_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                ClearControls();
                txtAccountNo.Focus();
                txtAccountNo.Enabled = true;
                
            }
        }        
        private void btnSave_Click(object sender, EventArgs e)
        {
            var manager = new PersonsBLL();

            PersonsEL oelPerson = new PersonsEL();
            oelPerson.IdAccount = Validation.GetSafeLong(IdPerson);
            oelPerson.IdProject = Operations.IdProject;
            oelPerson.AccountNo = Validation.GetSafeString(txtAccountNo.Text);
            oelPerson.PersonName = txtFirstName.Text;
            oelPerson.LastName = txtLastName.Text;
            oelPerson.Cnic = txtNIC.Text;
            oelPerson.IdParent1 = ParentId;
            oelPerson.Contact = txtContact.Text;
            oelPerson.Salary = txtSalary.Text;
            oelPerson.PersonPic = (byte[])converter.ConvertTo(PersonPic.Image,typeof(byte[]));
            oelPerson.Address = Validation.GetSafeString(txtAddress.Text);
            oelPerson.NTN = txtNTN.Text;
            oelPerson.Discription = Validation.GetSafeString(txtDiscription.Text);
            oelPerson.PersonType = PersonType;

            if (!IdPerson.HasValue)
            {
                manager.CreatePersons(oelPerson);
                MessageBox.Show("Person Information Created Successfully.....");
                ClearControls();
            }
            else if (manager.UpdatePerson(oelPerson).IsSuccess)
            {
                MessageBox.Show("Person Information Updated Successfully.....");
                ClearControls();
            }
            else
            {
                MessageBox.Show("Problem Occured.....");
            }
        }
        private void ClearControls()
        {
            IdPerson = null;
            txtAccountNo.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNTN.Text = string.Empty;
            txtDiscription.Text = string.Empty;
        }

        private void mtlPic_Click(object sender, EventArgs e)
        {
            if (picDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PersonPic.Image = Image.FromFile(picDialog.FileName);
            }
        }

        private void txtAccountNo_ButtonClick(object sender, EventArgs e)
        {
            frmaccounts = new frmFindAccounts();
            frmaccounts.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmaccounts_ExecuteFindAccountEvent);
            frmaccounts.ShowDialog();
        }

        void frmaccounts_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            //IdPerson = oelAccount.IdAccount;
            PersonType = oelAccount.AccountType;
            txtAccountNo.Text = oelAccount.AccountNo;
            txtFirstName.Text = oelAccount.AccountName;
            txtAccountNo.Enabled = false;
            GetPerson(oelAccount.AccountNo);
        }
        private void GetPerson(string AccountNo)
        {
            var manager = new PersonsBLL();
            PersonsEL oelPerson = new PersonsEL();
            List<PersonsEL> list = manager.GetPersonByAccountNo(AccountNo, Operations.IdProject);
            if (list.Count > 0)
            {
                IdPerson = list[0].IdAccount;
                txtAccountNo.Text = list[0].AccountNo.ToString();
                txtFirstName.Text = list[0].PersonName;
                txtLastName.Text = list[0].LastName;
                txtNIC.Text = list[0].Cnic;
                txtContact.Text = list[0].Contact;
                txtNTN.Text = list[0].NTN;
                txtSalary.Text = list[0].Salary;
                txtAddress.Text = list[0].Address;
                if (list[0].PersonPic != null)
                {
                    PersonPic.Image = Image.FromStream(new MemoryStream(list[0].PersonPic));
                }
                txtDiscription.Text = list[0].Discription;
                ParentId = list[0].IdParent1;
            }
            else if (ViewDetailType != string.Empty)
            {
                MessageBox.Show("No Detail Is Provided For This Person, Please Add");
            }
            else
            {
                MessageBox.Show("No Detail Is Provided For This Person, Please Add");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAccountNo.Enabled = true;
            ClearControls();
        }

        private void txtAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
               
                    e.Handled = true;
                    frmaccounts = new frmFindAccounts();
                    frmaccounts.SearchText = e.KeyChar.ToString();
                    frmaccounts.ExecuteFindAccountEvent +=new frmFindAccounts.FindAccountDelegate(frmaccounts_ExecuteFindAccountEvent);
                    frmaccounts.ShowDialog();
                
            }
            else
                e.Handled = false;
        }
    }
}
