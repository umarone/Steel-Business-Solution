using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.Common;
using Accounts.BLL;
using Accounts.EL;
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmChangePassword : MetroForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "WelCome" + " " + Operations.UserName;
            this.txtOldPassword.Enabled = false;
            FilUser();
        }
        private void FilUser()
        {
            var manager = new UsersBLL();
            List<UsersEL> list = manager.GetUserById(Operations.UserID);
            if (list.Count > 0)
            {
                txtOldPassword.Text = list[0].Password;
            }
        }
        private bool ValidateControls()
        {
            bool Status = true;
            if (txtNewPassword.Text == string.Empty)
            {
                Status = false;
            }
            else if (txtOldPassword.Text == string.Empty)
            {
                Status = false;
            }
            return Status;
        }
        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            var manager = new UsersBLL();
            if (ValidateControls())
            {
                if (txtNewPassword.Text == txtRepeatPassword.Text)
                {
                    UsersEL oelUser = manager.GetUserById(Operations.UserID)[0];
                    if (oelUser != null)
                    {
                        oelUser.Password = txtNewPassword.Text;
                    }
                    if (manager.UpdateUsers(oelUser).IsSuccess == true)
                    {
                        MessageBox.Show("Password Changed Successfully....");
                    }
                }
                else
                {
                    MessageBox.Show("Please Math The Password Fields");
                }
            }
            else
            {
                MessageBox.Show("Password Field Empty...");
            }
        }
    }
}
