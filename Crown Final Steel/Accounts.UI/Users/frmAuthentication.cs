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
    public partial class frmAuthentication : MetroFramework.Forms.MetroForm
    {
        List<UsersEL> oelUserCollection = null;
        UserRolesEL oelUsers = new UserRolesEL();
        public frmAuthentication()
        {
            InitializeComponent();
        }

        private void frmAuthentication_Load(object sender, EventArgs e)
        {

        }
        private bool isValidData()
        {
            if (string.IsNullOrEmpty(mtxtUserName.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(mtxtPassword.Text))
            {
                return false;
            }
            return true;
        }
        private void mbtnLogin_Click(object sender, EventArgs e)
        {
            var manager = new UsersBLL();
            if (isValidData())
            {
                if (mbtnLogin.DialogResult == DialogResult.OK)
                {
                    oelUsers.UserName = mtxtUserName.Text;
                    oelUsers.Password = mtxtPassword.Text;
                    oelUsers.IdCompany = Operations.IdCompany;

                    oelUserCollection = manager.verifyUser(oelUsers);
                    if (oelUserCollection != null && oelUserCollection.Count > 0)
                    {
                        if (!oelUserCollection[0].IsActive.Value)
                        {
                            MessageBox.Show("User Is Blocked,Please Contact Administrator");
                            this.DialogResult = System.Windows.Forms.DialogResult.None;
                            mtxtUserName.Focus();
                            return;
                        }
                        Operations.IsAuthenticate = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong UserName Or Password", "Authentication Failed", MessageBoxButtons.OKCancel);
                        this.DialogResult = System.Windows.Forms.DialogResult.None;
                        mtxtUserName.Focus();
                        mtxtPassword.Text = string.Empty;
                    }

                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                }
            }
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Operations.IsAuthenticate = false;
            this.Close();
        }
    }
}
