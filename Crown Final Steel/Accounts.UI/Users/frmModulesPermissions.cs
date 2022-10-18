using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.Common;
using Accounts.EL;
using Accounts.BLL;
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmModulesPermissions : MetroForm
    {
        public frmModulesPermissions()
        {
            InitializeComponent();
        }

        private void frmModulesPermissions_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FillData();
        }
        private void FillData()
        {
            FillUsers();
        }
        private void FillUsers()
        {
            var manager = new UsersBLL();
            List<UsersEL> list = manager.GetAllUsers();
            if (list.Count > 0)
            {
                list.Insert(0, new UsersEL() { UserId = 0, UserName = "Select User" });

                cbxUsers.DataSource = list;
                cbxUsers.DisplayMember = "UserName";
                cbxUsers.ValueMember = "UserId";
                cbxUsers.SelectedIndex = 0;
            }
        }
        private void cbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var manager = new UserModulesPermissionsBLL();
            if (cbxUsers.SelectedIndex > 0)
            { 
                List<UserModulesPermissionsEL> list = manager.GetUserModulePermissionsById(Validation.GetSafeLong(cbxUsers.SelectedValue));
                if (list.Count > 0)
                {
                    grdUserModulePermissions.Rows.Clear();
                    FillUserModulePermissions(list);
                }
                else
                {
                    grdUserModulePermissions.Rows.Clear();
                }
            }
            else if (grdUserModulePermissions.Rows.Count > 0)
            {
                grdUserModulePermissions.Rows.Clear();
            }
        }
        private void FillUserModulePermissions(List<UserModulesPermissionsEL> list)
        {   
            for (int i = 0; i < list.Count; i++)
            {
                grdUserModulePermissions.Rows.Add();
                grdUserModulePermissions.Rows[i].Cells["colIdModulePermission"].Value = list[i].IdMoudlePermission;
                grdUserModulePermissions.Rows[i].Cells["colIdModule"].Value = list[i].IdModule;
                grdUserModulePermissions.Rows[i].Cells["colIdUserModule"].Value = list[i].IdUserModule;
                grdUserModulePermissions.Rows[i].Cells["colModuleName"].Value = list[i].ModuleName;
                grdUserModulePermissions.Rows[i].Cells["colSave"].Value = list[i].Saving;
                grdUserModulePermissions.Rows[i].Cells["colUpdate"].Value = list[i].Updating;
                grdUserModulePermissions.Rows[i].Cells["colDelete"].Value = list[i].Deleting;
                grdUserModulePermissions.Rows[i].Cells["colView"].Value = list[i].Viewing;
                grdUserModulePermissions.Rows[i].Cells["colPost"].Value = list[i].Posting;
                grdUserModulePermissions.Rows[i].Cells["colPrinting"].Value = list[i].Printing;
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<UserModulesPermissionsEL> list = new List<UserModulesPermissionsEL>();
            var manager = new UserModulesPermissionsBLL();
            if (Validation.GetSafeLong(cbxUsers.SelectedValue) > 0)
            {
                for (int i = 0; i < grdUserModulePermissions.Rows.Count; i++)
                {
                    UserModulesPermissionsEL oelUserModulePermissions = new UserModulesPermissionsEL();
                    if (Validation.GetSafeLong(grdUserModulePermissions.Rows[i].Cells["colIdModulePermission"].Value) == 0)
                    {
                        oelUserModulePermissions.IdMoudlePermission = 0;
                        oelUserModulePermissions.ModuleAction = "Assign";
                    }
                    else
                    {
                        oelUserModulePermissions.IdMoudlePermission = Validation.GetSafeLong(grdUserModulePermissions.Rows[i].Cells["colIdModulePermission"].Value);
                        oelUserModulePermissions.ModuleAction = "Update";
                    }
                    oelUserModulePermissions.IdModule = Validation.GetSafeLong(grdUserModulePermissions.Rows[i].Cells["colIdModule"].Value);
                    oelUserModulePermissions.UserId = Validation.GetSafeLong(cbxUsers.SelectedValue);
                    if (grdUserModulePermissions.Rows[i].Cells["colSave"].Value != null)
                    {
                        oelUserModulePermissions.Saving = Validation.GetSafeBooleanNullable(grdUserModulePermissions.Rows[i].Cells["colSave"].Value);
                    }
                    else
                    {
                        oelUserModulePermissions.Saving = false;
                    }
                    if (grdUserModulePermissions.Rows[i].Cells["colUpdate"].Value != null)
                    {
                        oelUserModulePermissions.Updating = Validation.GetSafeBooleanNullable(grdUserModulePermissions.Rows[i].Cells["colUpdate"].Value);
                    }
                    else
                    {
                        oelUserModulePermissions.Updating = false;
                    }
                    if (grdUserModulePermissions.Rows[i].Cells["colDelete"].Value != null)
                    {
                        oelUserModulePermissions.Deleting = Validation.GetSafeBooleanNullable(grdUserModulePermissions.Rows[i].Cells["colDelete"].Value);
                    }
                    else
                    {
                        oelUserModulePermissions.Deleting = false;
                    }
                    if (grdUserModulePermissions.Rows[i].Cells["colView"].Value != null)
                    {
                        oelUserModulePermissions.Viewing = Validation.GetSafeBooleanNullable(grdUserModulePermissions.Rows[i].Cells["colView"].Value);
                    }
                    else
                    {
                        oelUserModulePermissions.Viewing = false;
                    }
                    if (grdUserModulePermissions.Rows[i].Cells["colPost"].Value != null)
                    {
                        oelUserModulePermissions.Posting = Validation.GetSafeBooleanNullable(grdUserModulePermissions.Rows[i].Cells["colPost"].Value);
                    }
                    else
                    {
                        oelUserModulePermissions.Posting = false;
                    }
                    if (grdUserModulePermissions.Rows[i].Cells["colPrinting"].Value != null)
                    {
                        oelUserModulePermissions.Printing = Validation.GetSafeBooleanNullable(grdUserModulePermissions.Rows[i].Cells["colPrinting"].Value);
                    }
                    else
                    {
                        oelUserModulePermissions.Printing = false;
                    }
                    oelUserModulePermissions.CreatedDateTime = DateTime.Now;
                    if(grdUserModulePermissions.Rows[i].Cells["colSave"].Value != null || grdUserModulePermissions.Rows[i].Cells["colUpdate"].Value != null
                        || grdUserModulePermissions.Rows[i].Cells["colDelete"].Value != null || grdUserModulePermissions.Rows[i].Cells["colPost"].Value != null || grdUserModulePermissions.Rows[i].Cells["colPrinting"].Value != null)

                    list.Add(oelUserModulePermissions);
                }
                if (manager.AssignPermissions(list).IsSuccess)
                {
                    MessageBox.Show("Permissions Assigned");
                    cbxUsers_SelectedIndexChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Problem Occured While Assigning Permissions");
                }
            }
            else
            {
                MessageBox.Show("Select User For Permissions");
            }
        }
    }
}
