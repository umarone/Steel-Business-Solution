using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Accounts.EL;
using Accounts.BLL;

using MetroFramework.Forms;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmUsers : MetroForm
    {
        #region Variables
        Int64? IdUser;
        string emailValidator = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
        #endregion
        #region Form Methods And Events
        public frmUsers()
        {
            InitializeComponent();
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.grdUsers.AutoGenerateColumns = false;
            FillCompanies();
            FillUsers();
        }
        #endregion
        #region Simple Methods
        private void FillCompanies()
        { 
             var manager = new CompanyBLL();
            List<CompanyEL> list = manager.GetAllCompanies();
            if(list != null && list.Count > 0)
            {
                list.RemoveAll(x => x.IsActive == false);
                list.Insert(0, new CompanyEL() { IdCompany = -1, CompanyName = "Select Company" });
                
                cbxCompany.DataSource = list;
                
                cbxCompany.DisplayMember = "CompanyName";
                cbxCompany.ValueMember = "IdCompany";
                
                //cbxCompany.SelectedIndex = -1;
            }
        }
        private void FillProjects(Int64 IdCompany)
        {
            var Manager = new ProjectBLL();
            List<ProjectEL> list = Manager.ListByCompany(IdCompany);
            if (list.Count > 0)
            {
                list.Insert(0, new ProjectEL() { IdProject = 0, ProjectName = "Select Project" });

                cbxProjects.DataSource = list;

                cbxProjects.DisplayMember = "ProjectName";
                cbxProjects.ValueMember = "IdProject";

                cbxProjects.SelectedIndex = 0;
            }
        }
        private void FillUsers()
        {
            var manager = new UsersBLL();
            List<UsersEL> list = manager.GetAllUsers();
            if(list.Count > 0)
            {
                grdUsers.DataSource = list;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsActive.Value)
                {
                    grdUsers.Rows[i].Cells["colUserStatus"].Value = false;
                }
                else if (!list[i].IsActive.Value)
                {
                    grdUsers.Rows[i].Cells["colUserStatus"].Value = true;
                }
            }
        }
        private bool ValidateControls()
        {
            bool Status = true;
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                //lblMsgStatus.Text = "User Name Missing";
                Status = false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                //lblMsgStatus.Text = "Password Missing";
                Status = false;
            }
            else if (cbxCompany.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Company");
                Status = false;
            }
            else if (cbxProjects.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Project");
                Status = false;
            }
            else if (txtFirstName.Text == string.Empty)
            {
                MessageBox.Show("First Name Is Missing....");
                Status = false;
            }
            return Status;
        }
        private bool ValidateEmail()
        {
            bool status = true;
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (!reg.IsMatch(txtUserName.Text))
            {
                status = false;
            }
            return status;
        }
        private void ClearControls()
        {
            IdUser = null;
            cbxCompany.SelectedIndex = 0;
            cbxProjects.SelectedIndex = -1;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtAddress.Text = string.Empty;
            chkSuspend.Checked = false;
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            var manager = new UsersBLL();
            try
            {
                UsersEL oelUser = new UsersEL();
                if (ValidateControls())
                {
                    if (ValidateEmail())
                    {
                        oelUser.UserId = Validation.GetSafeLong(IdUser);
                        oelUser.IdCompany = Validation.GetSafeLong(cbxCompany.SelectedValue);
                        oelUser.IdProject = Validation.GetSafeLong(cbxProjects.SelectedValue); //Operations.IdProject;
                        oelUser.UserName = Validation.GetSafeString(txtUserName.Text.Trim());
                        oelUser.Password = txtPassword.Text;
                        oelUser.FirstName = txtFirstName.Text;
                        oelUser.LastName = txtLastName.Text;
                        oelUser.Cnic = txtNIC.Text;
                        oelUser.Contact = txtContact.Text;
                        oelUser.Address = txtAddress.Text;
                        if (chkSuspend.Checked)
                        {
                            oelUser.IsActive = false;
                        }
                        else
                        {
                            oelUser.IsActive = true;
                        }
                        oelUser.CreatedDateTime = dtUserCreation.Value;

                        if (!IdUser.HasValue)
                        {
                            if (!manager.CheckUserNameDuplication(Validation.GetSafeLong(cbxProjects.SelectedValue), oelUser.UserName))
                            {
                                if (manager.CreateUsers(oelUser).IsSuccess)
                                {
                                    //lblMsgStatus.Text = "User Saved SuccessFully";
                                    MessageBox.Show("User Successfully Created....");
                                    ClearControls();
                                    FillUsers();
                                }
                            }
                            else
                            {
                                MessageBox.Show("User Name Already Exists In This Project, Please Choose Different User Name OR Choose Different Project");
                            }
                        }
                        else
                        {
                            oelUser.UserId = IdUser.Value;
                            if (manager.UpdateUsers(oelUser).IsSuccess)
                            {
                                //lblMsgStatus.Text = "User Updated SuccessFully";
                                MessageBox.Show("User Successfully Updated....");
                                ClearControls();
                                FillUsers();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Follow Up Standard For User Creation....");
                    }
                }
            }
            catch (Exception ex)
            {
                //lblMsgStatus.Text = "Some Problem Occured While Saving Record";
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var manager = new UsersBLL();
            if (MessageBox.Show("Deleting ?", "Delete User", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
            {
                UsersEL oelUser = new UsersEL();
                oelUser.UserId = IdUser.Value;
                manager.DeleteUsers(oelUser);
                ClearControls();
            }
        }
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        #endregion
        #region Grid Events And Methods
        private void grdPersons_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                e.Value = "Edit";
            }
        }
        private void grdPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                IdUser = Validation.GetSafeLong(grdUsers.Rows[e.RowIndex].Cells["colIdUser"].Value);
                GetUserById(IdUser);
            }
        }
        private void GetUserById(Int64? IdUser)
        {
            var manager = new UsersBLL();
            UsersEL oelUser = manager.GetUserById(IdUser.Value)[0];
            if (oelUser != null)
            {
                txtUserName.Text = oelUser.UserName;
                txtPassword.Text = oelUser.Password;
                txtFirstName.Text = oelUser.FirstName;
                txtLastName.Text = oelUser.LastName;
                txtNIC.Text = oelUser.Cnic;
                txtContact.Text = oelUser.Contact;
                txtAddress.Text = oelUser.Address;
                dtUserCreation.Value = Convert.ToDateTime(oelUser.CreatedDateTime);

                if (oelUser.IsActive.Value)
                {
                    chkSuspend.Checked = false;
                }
                else
                {
                    chkSuspend.Checked = true;
                }

                cbxCompany.SelectedValue = oelUser.IdCompany;
            }
        }
        #endregion
        #region Other Controls And Events
        private void cbxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbxCompany.SelectedIndex == -1 || cbxCompany.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Company");
            }
            else
            {
                FillProjects(Validation.GetSafeLong(cbxCompany.SelectedValue));
            }
        }
        #endregion
    }
}
