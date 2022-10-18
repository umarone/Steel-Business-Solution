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
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmLogin :MetroFramework.Forms.MetroForm
    {
        #region Variables
        //UsersEL oelUsers = new UsersEL();
        UserRolesEL oelUsers = new UserRolesEL();
        List<UsersEL> oelUserCollection = null;
        frmMain frmmain = null;
        //List<UserRolesEL> oelUserCollection = null;
        #endregion
        #region Forms Methods And Events
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            FillProjects();
            GetAllActiveUsers();
            this.Opacity = 100;
            this.cbxUsers.Focus();
        }
        #endregion
        #region Simple Methds
        private void FillProjects()
        { 
             //var manager = new CompanyBLL();
            //List<CompanyEL> list = manager.GetAllCompanies();
            var manager = new ProjectBLL();
             List<ProjectEL> list = manager.List();
            if(list != null && list.Count > 0)
            {
                cbxProjects.DataSource = list;
                
                cbxProjects.DisplayMember = "ProjectName";
                cbxProjects.ValueMember = "IdProject";
                
                cbxProjects.SelectedIndex = 0;
            }
        }
        private bool isValidData()
        {
            //if (string.IsNullOrEmpty(mtxtUserName.Text))
            //{
            //    return false;
            //}
            if (string.IsNullOrEmpty(mtxtPassword.Text))
            {
                return false;
            }
            return true;
        }
        private void GetAllActiveUsers()
        {
            var manager = new UsersBLL();
            List<UsersEL> list = manager.GetAllActiveUsers();
            if (list.Count > 0)
            {
                list.Insert(0, new UsersEL() { UserId = 0, UserName = "Select Login User" });
                cbxUsers.DataSource = list;
                cbxUsers.DisplayMember = "UserName";
                cbxUsers.ValueMember = "UserId";
            }
        }
        #endregion
        #region Button Events
        private void mbtnLogin_Click(object sender, EventArgs e)
        {
            var manager = new UsersBLL();
            var softManager = new SoftwareTypesBLL();
            var TabsManager = new SoftwareTabsBLL();
            var ModulesManager = new ModulesBLL();
            if (frmmain == null)
            {
                frmmain = new frmMain();
            }
            if (isValidData())
            {
                if (mbtnLogin.DialogResult == DialogResult.OK)
                {
                    oelUsers.UserName = cbxUsers.Text; //mtxtUserName.Text;
                    oelUsers.Password = mtxtPassword.Text;
                    oelUsers.IdProject = Validation.GetSafeLong(cbxProjects.SelectedValue);

                    oelUserCollection = manager.verifyUser(oelUsers);
                    if (oelUserCollection != null && oelUserCollection.Count > 0)
                    {
                        if (!oelUserCollection[0].IsActive.Value)
                        {
                            MessageBox.Show("User Is Blocked,Please Contact Administrator");
                            this.DialogResult = System.Windows.Forms.DialogResult.None;
                            //mtxtUserName.Focus();
                            mtxtPassword.Focus();
                            return;
                        }
                        else if (!oelUserCollection[0].ProjectStatus.Value)
                        {
                            MessageBox.Show("Project Is Blocked OR Suspended OR Closed,Please Contact Administrator");
                            this.DialogResult = System.Windows.Forms.DialogResult.None;
                           // mtxtUserName.Focus();
                            mtxtPassword.Focus();
                            return;
                        }
                        Operations.UserID = oelUserCollection[0].UserId;
                        Operations.UserName = oelUserCollection[0].UserName;
                        Operations.IdCompany = Validation.GetSafeLong(oelUserCollection[0].IdCompany);
                        Operations.IdRole = oelUserCollection[0].IdRole;
                        Operations.CompanyName = oelUserCollection[0].CompanyName;
                        Operations.IdProject = Validation.GetSafeLong(oelUserCollection[0].IdProject);
                        Operations.ProjectName = oelUserCollection[0].ProjectName;
                        Operations.ProjectInvoiceName = oelUserCollection[0].ProjectInvoiceName;
                        Operations.ProjectPurchaseInvoiceName = oelUserCollection[0].ProjectPurchaseInvoiceName;
                        Operations.ProjectConfiguration = oelUserCollection[0].ProjectConfiguration;
                        Operations.BookNo = Validation.GetSafeLong(oelUserCollection[0].BookNo);
                        Operations.BookPeriod = oelUserCollection[0].BookPeriod;
                        DataOperations.SoftwareCollection = SoftwareTypesBLL.List();
                        DataOperations.SoftwareChecksCollection = SoftwareChecksBLL.List();
                        DataOperations.SoftwareEnabledModules = ModulesManager.GetAllModules();
                        DataOperations.SoftwareTabs = TabsManager.GetAllSoftwareTabs();
                        //mtxtUserName.Focus();
                        //mtxtUserName.Text = "";
                        mtxtPassword.Text = "";
                        this.Hide();
                        frmmain.Show();
                        this.Dispose(false);
                        //this.Hide();
                        //MessageBox.Show(XmlConfiguration.ReadXmlTerminalsConfiguration()[0] + " " + XmlConfiguration.ReadXmlTerminalsConfiguration()[1]);
                        
                    }
                    else
                    {
                        MessageBox.Show("Wrong UserName OR Password OR May Be No Role Is Assigned...", "Login Failed", MessageBoxButtons.OKCancel);
                        this.DialogResult = System.Windows.Forms.DialogResult.None;
                        mtxtPassword.Focus();
                        mtxtPassword.Text = string.Empty;
                    }

                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                }

            }
            else
            {
                MessageBox.Show("Input UserName OR Password");
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }
        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region TextBoxes Events 
        private void mtxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mtxtPassword.Focus();
            }
        }
        private void mtxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //cbxCompany.Focus();
                //cbxCompany.DroppedDown = true;
                mbtnLogin.Focus();
                mbtnLogin_Click(sender, e);
            }
        }
        private void mtxtPassword_Click(object sender, EventArgs e)
        {

        }
        private void mtxtUserName_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Other Controls Events And Methods
        private void cbxCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //mbtnLogin.Focus();
            }
        }
        private void cbxUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mtxtPassword.Focus();
            }
        }
        #endregion
    }
}
