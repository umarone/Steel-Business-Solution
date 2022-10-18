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

namespace Accounts.UI
{
    public partial class frmUsersRoles : MetroForm
    {
        public frmUsersRoles()
        {
            InitializeComponent();
        }

        private void frmUsersRoles_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FillData();
        }
        private void FillData()
        {
            FillUsers();
            FillRoles();
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
        private void FillRoles()
        {
            var manager = new RoleBLL();
            List<RoleEL> list = manager.GetAllRoles();
            //if (Operations.IdRole != Validation.GetSafeLong(EnRoles.CheifExecutive))
            //{
            //    list.Remove(list.Find(x => x.RoleName == "Cheif Executive"));
            //}
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    grdUserRoles.Rows.Add();
                    grdUserRoles.Rows[i].Cells["colIdRole"].Value = list[i].IdRole;
                    grdUserRoles.Rows[i].Cells["colIdUserRole"].Value = Guid.Empty;
                    grdUserRoles.Rows[i].Cells["colRoleName"].Value = list[i].RoleName;
                }
            }
        }
        private void cbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var manager = new UserRolesBLL();
            if (cbxUsers.SelectedIndex > 0)
            {
                List<UserRolesEL> list = manager.GetUserRolesById(Validation.GetSafeLong(cbxUsers.SelectedValue));
                if (list.Count > 0)
                {
                    //if (Operations.IdRole != Validation.GetSafeLong(EnRoles.CheifExecutive))
                    //{
                    //    list.Remove(list.Find(x => x.RoleName == "Cheif Executive"));
                    //}
                    grdUserRoles.Rows.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        grdUserRoles.Rows.Add();
                        grdUserRoles.Rows[i].Cells["colIdRole"].Value = list[i].IdRole;
                        grdUserRoles.Rows[i].Cells["colIdUserRole"].Value = list[i].IdUserRole;
                        grdUserRoles.Rows[i].Cells["colRoleName"].Value = list[i].RoleName;
                        if (list[i].IdUserRole.HasValue && list[i].IdUserRole.Value > 0 && list[i].IsActive.Value)
                        {
                            grdUserRoles.Rows[i].Cells["colRoleRight"].Value = true;
                        }
                        else
                        {
                            grdUserRoles.Rows[i].Cells["colRoleRight"].Value = false;
                        }
                    }
                }
            }
            else if (grdUserRoles.Rows.Count > 0)
            {
                grdUserRoles.Rows.Clear();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<UserRolesEL> listUserRoles = new List<UserRolesEL>();
            var manager = new UserRolesBLL();
            if (Validation.GetSafeLong(cbxUsers.SelectedValue) > 0)
            {
                for (int i = 0; i < grdUserRoles.Rows.Count; i++)
                {
                    UserRolesEL oelUserRole = new UserRolesEL();
                    oelUserRole.UserId = Validation.GetSafeLong(cbxUsers.SelectedValue);
                    oelUserRole.IdRole = Validation.GetSafeLong(grdUserRoles.Rows[i].Cells["colIdRole"].Value);
                    if (Validation.GetSafeLong(grdUserRoles.Rows[i].Cells["colIdUserRole"].Value) == 0)
                    {
                        oelUserRole.IdUserRole = 1;
                    }
                    else
                    {
                        oelUserRole.IdUserRole = Validation.GetSafeLong(grdUserRoles.Rows[i].Cells["colIdUserRole"].Value);
                    }
                    if (Validation.GetSafeBooleanNullable(grdUserRoles.Rows[i].Cells["colRoleRight"].Value) == true)
                    {
                        oelUserRole.RoleAction = "Assign";
                        oelUserRole.IsActive = true;
                    }
                    //else
                    //{
                    //    oelUserRole.RoleAction = "Remove";
                    //    oelUserRole.IsActive = false;
                    //}
                    oelUserRole.CreatedDateTime = DateTime.Now;

                    listUserRoles.Add(oelUserRole);

                }
                if (manager.AssignRoles(listUserRoles).IsSuccess)
                {
                    MessageBox.Show("Roles Assigned For Selected User");
                    cbxUsers_SelectedIndexChanged(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Select User First For Roles Rights");
            }
        }
        private void chkUserRoles_CheckedChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < grdUserRoles.Rows.Count; i++)
            //{
            //    grdUserRoles.Rows[i].Cells["colRoleRight"].Value = chkUserRoles.Checked;
            //}
        }
        private void grdUserRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbxUsers.SelectedIndex > 0)
            {
                if (grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value != null)
                {
                    if (Operations.IdRole != Validation.GetSafeLong(EnRoles.CheifExecutive))
                    {
                        if (Validation.GetSafeString(grdUserRoles.Rows[e.RowIndex].Cells["colRoleName"].Value) == "Cheif Executive")
                        {
                            MessageBox.Show("You Can Not Make YourSelf As chief Executive...");
                            DataGridViewCheckBoxCell chk = (grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"] as DataGridViewCheckBoxCell);
                            if (chk.EditingCellFormattedValue != null)
                            {
                                chk.EditingCellFormattedValue = true;
                                //grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value = null;
                                //grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value = false; 
                            }
                            //grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value = null;
                            //grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value = false;
                        }
                        else
                        {
                            for (int i = 0; i < grdUserRoles.Rows.Count; i++)
                            {
                                if (e.RowIndex != i)
                                {
                                    grdUserRoles.Rows[i].Cells["colRoleRight"].Value = false;
                                }
                            }
                        }
                    }
                    else if (Operations.IdRole == Validation.GetSafeLong(EnRoles.Administrator))
                    {
                        if (Validation.GetSafeString(grdUserRoles.Rows[e.RowIndex].Cells["colRoleName"].Value) == "Cheif Executive")
                        {
                            MessageBox.Show("You Can Not Make YourSelf As chief Executive...");
                            DataGridViewCheckBoxCell chk = (grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"] as DataGridViewCheckBoxCell);
                            if (chk.EditingCellFormattedValue != null)
                            {
                                chk.EditingCellFormattedValue = true;
                                //grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value = null;
                                //grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value = false; 
                            }
                            //grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value = null;
                            //grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value = false;
                        }
                        else
                        {
                            for (int i = 0; i < grdUserRoles.Rows.Count; i++)
                            {
                                if (e.RowIndex != i)
                                {
                                    grdUserRoles.Rows[i].Cells["colRoleRight"].Value = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < grdUserRoles.Rows.Count; i++)
                        {
                            if (e.RowIndex != i)
                            {
                                grdUserRoles.Rows[i].Cells["colRoleRight"].Value = false;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select User");
                if (grdUserRoles.Rows.Count > 0)
                {
                    if (e.RowIndex > -1)
                    {
                        DataGridViewCheckBoxCell chk = (grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"] as DataGridViewCheckBoxCell);
                        if (chk.EditingCellFormattedValue != null)
                        {
                            chk.EditingCellFormattedValue = true;
                            //grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value = null;
                            //grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value = false; 
                        }
                    }
                    //if (chk.Selected == true)
                    //{
                    //    chk.Selected = false;
                    //    chk.Value = false;
                    //    chk.TrueValue = false;
                    //    grdUserRoles.Rows[e.RowIndex].Cells["colRoleRight"].Value = null; 
                    //}
                    //else
                    //{
                    //    chk.Selected = true;
                    //}
                }
            }
        }
    }
}
