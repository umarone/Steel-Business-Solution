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

namespace Accounts.UI
{
    public partial class frmBackup : MetroForm
    {

        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPath.Text != string.Empty)
                {
                    lblStatusMsg.Text = "Please Wait BackUp Is In process";
                    var manager = new BackupBLL();
                    bool Status = manager.DbBackUp(txtPath.Text);
                    if (Status)
                    {
                        txtPath.Text = string.Empty;
                       MessageBox.Show("Backup Successful...");
                    }
                    else
                    {
                         MessageBox.Show("Problem In Backup...");
                    }
                }
                else
                {
                    MessageBox.Show("Please Provide Backup Path");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Problem During Backup");
            }

        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            SaveDialog.ShowDialog();
            txtPath.Text = SaveDialog.FileName;
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            CheckModulePermissions();
        }
        private void CheckModulePermissions()
        {
            List<UserModulesPermissionsEL> PermissionsList = UserPermissions.GetUserModulePermissionsByUserAndModuleId(Operations.UserID);
            if (PermissionsList != null && PermissionsList.Count > 0)
            {
                if (PermissionsList[0].Printing == true)
                {
                    btnBackUp.Enabled = true;
                }
                else
                {
                    btnBackUp.Enabled = false;
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
    }
}
