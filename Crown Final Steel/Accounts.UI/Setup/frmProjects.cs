using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.EL;
using Accounts.Common;
using Accounts.BLL;
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmProjects : MetroForm
    {
        #region Variables
        Int64 IdProject = 0;
        Int64 IdCompany = 0;
        #endregion
        #region Form Events And Methods
        public frmProjects()
        {
            InitializeComponent();
        }
        private void frmProjects_Load(object sender, EventArgs e)
        {
            this.grdProjects.AutoGenerateColumns = false;
            //FillRegions();
            FillProjects();
            FillCompanies();
        }
        private void frmProjects_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                clearControls();
            }
        }
        #endregion
        #region Simple Methods
        private void FillCompanies()
        {
            var manager = new CompanyBLL();
            List<CompanyEL> list = manager.GetAllCompanies();
            if (list.Count > 0)
            {
                list.RemoveAll(x => x.IsActive == false);
                list.Insert(0, new CompanyEL() { IdCompany = 0, CompanyName = "Select Company" });
                cbxCompanies.DataSource = list;
                cbxCompanies.DisplayMember = "CompanyName";
                cbxCompanies.ValueMember = "IdCompany";
                cbxCompanies.SelectedIndex = 0;
            }
        }
        //private void FillRegions()
        //{
        //    var manager = new RegionBLL();
        //    List<RegionEL> list = manager.List();
        //    if (list.Count > 0)
        //    {
        //        list.Insert(0, new RegionEL() { IdRegion = Guid.Empty, RegionName = "Select Region" });
        //        cbxRegions.DataSource = list;
        //        cbxRegions.DisplayMember = "RegionName";
        //        cbxRegions.ValueMember = "IdRegion";
        //        cbxRegions.SelectedIndex = 0;
        //    }
        //    else
        //        grdProjects.DataSource = null;

        //}
        private void FillProjects()
        {
            var manager = new ProjectBLL();
            List<ProjectEL> list = manager.List();
            if (list.Count > 0)
            {
                grdProjects.DataSource = list;
            }
            else
                grdProjects.DataSource = null;
        }
        private bool ValidateProject()
        {
            bool status = true;
            if (txtProjectName.Text == string.Empty)
            {
                status = false;
            }
            if (cbxCompanies.SelectedIndex == 0)
            {
                status = false;
            }
            return status;
        }
        private void clearControls()
        {
            cbxCompanies.SelectedIndex = 0;
            IdProject = 0;
            txtProjectCode.Text = string.Empty;
            txtProjectName.Text = string.Empty;
            txtProjectCity.Text = string.Empty;
            txtProjectLocation.Text = string.Empty;
        }
        #endregion
        #region Grid Events And Methods
        private void grdProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                IdProject = Validation.GetSafeLong(grdProjects.Rows[e.RowIndex].Cells["colIdProject"].Value);
                IdCompany = Validation.GetSafeLong(grdProjects.Rows[e.RowIndex].Cells["colIdCompany"].Value);
                GetProject(IdProject);
                txtProjectName.Focus();
            }
        }
        private void grdProjects_KeyPress(object sender, KeyPressEventArgs e)
        {
            IdProject = Validation.GetSafeLong(grdProjects.CurrentRow.Cells["colIdProject"].Value);
            IdCompany = Validation.GetSafeLong(grdProjects.CurrentRow.Cells["colIdCompany"].Value);
            GetProject(IdProject);
            txtProjectName.Focus();
        }
        private void GetProject(Int64 IdProject)
        {
            var manager = new ProjectBLL();
            ProjectEL obj = manager.Select(IdProject)[0];
            if (obj != null)
            {
                txtProjectCode.Text = obj.ProjectCode.ToString();
                txtProjectName.Text = obj.ProjectName;
                txtProjectCity.Text = obj.City;
                txtProjectLocation.Text = obj.SiteAddress;

                cbxCompanies.SelectedValue = obj.IdCompany;
                //cbxRegions.SelectedValue = obj.IdRegion;
            }
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateProject())
            {
                var manager = new ProjectBLL();
                ProjectEL obj = new ProjectEL();

                if (IdProject == 0)
                {
                    obj.IdProject = 0;
                }
                else
                {
                    obj.IdProject = IdProject;
                }
                //obj.IdRegion = Validation.GetSafeGuid(cbxRegions.SelectedValue);
                obj.IdCompany = Validation.GetSafeLong(cbxCompanies.SelectedValue);
                obj.ProjectCode = Validation.GetSafeLong(txtProjectCode.Text);
                obj.ProjectName = Validation.GetSafeString(txtProjectName.Text.Trim());
                obj.City = Validation.GetSafeString(txtProjectCity.Text);
                obj.SiteAddress = Validation.GetSafeString(txtProjectLocation.Text);
                obj.CreatedDateTime = ProjectStartDate.Value;
                obj.ClosedDate = ProjectStartDate.Value;
                obj.Store = chkStore.Checked;
                obj.HeadOffice = chkHeadOffice.Checked;
                obj.IsActive = true;
                obj.Discription = "";
                if (IdProject == 0)
                {
                    if (!manager.CheckProjectNameDuplication(obj.IdCompany.Value, obj.ProjectName))
                    {
                        if (manager.Create(obj).IsSuccess)
                        {
                            clearControls();
                            FillProjects();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Project Name Already Exists In This Company, Please Select Another Company");
                    }
                }
                else
                {
                    if (manager.Update(obj).IsSuccess)
                    {
                        clearControls();
                        FillProjects();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill Fields");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var manager = new ProjectBLL();
            if (manager.Delete(IdProject).IsSuccess)
            {
                clearControls();
            }
        }
        #endregion
    }
}
