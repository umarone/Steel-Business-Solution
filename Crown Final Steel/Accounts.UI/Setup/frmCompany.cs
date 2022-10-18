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
    public partial class frmCompany : MetroForm
    {
        #region Variables
        Int64? IdCompany;
        DataTable dt;
        #endregion
        #region Form Methods and Events
        public frmCompany()
        {
            InitializeComponent();
        }
        private void frmCompany_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            grdCompanies.AutoGenerateColumns = false;
            FillCompanies();
        }
        #endregion
        #region Simple Methods
        private void FillCompanies()
        {
            var manager = new CompanyBLL();
            CompanyEL oelCompany = new CompanyEL();
            List<CompanyEL> list = manager.GetAllCompanies();
            if (list.Count > 0)
            {
                dt = DataOperations.ToDataTable(list);
                grdCompanies.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Validation.GetSafeBooleanNullable(grdCompanies.Rows[i].Cells["colStatus"].Value) == false)
                    {
                        grdCompanies.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
        private void ClearControls()
        {
            txtCompanyName.Text = string.Empty;
            txtDiscription.Text = string.Empty;

            IdCompany = null;
            grdCompanies.DataSource = null;
        }
        private void filterDGV(string rowFilter)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = rowFilter;
            grdCompanies.DataSource = DV;
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            CompanyEL oelCompany = new CompanyEL();

            if (!IdCompany.HasValue)
            {
                oelCompany.IdCompany = 1;
            }
            else
            {
                oelCompany.IdCompany = IdCompany;
            }
            oelCompany.UserId = Operations.UserID;
            oelCompany.CompanyName = Validation.GetSafeString(txtCompanyName.Text.Trim());
            oelCompany.CreatedDateTime = CDate.Value;
            oelCompany.Discription = txtDiscription.Text;
            if (chkSuspend.Checked)
            {
                oelCompany.IsActive = false;
            }
            else
            {
                oelCompany.IsActive = true;
            }
            if (!IdCompany.HasValue)
            {
                var manager = new CompanyBLL();
                if (!manager.CheckCompanyNameDuplication(oelCompany.CompanyName))
                {
                    if (manager.InsertCompany(oelCompany).IsSuccess)
                    {
                        MessageBox.Show("New Company Created Successfully");
                        ClearControls();
                        FillCompanies();
                    }
                }
                else
                {
                    MessageBox.Show("Company Name Already Exists");
                }
            }
            else
            {
                var manager = new CompanyBLL();
                if (manager.UpdateCompany(oelCompany).IsSuccess)
                {
                    MessageBox.Show("Company Updated Successfully");
                    ClearControls();
                    FillCompanies();
                }
            }
        }
        #endregion
        #region Grid Events
        private void grdCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            { 
                IdCompany = Validation.GetSafeLong(grdCompanies.Rows[e.RowIndex].Cells["colIdCompany"].Value);
                txtCompanyName.Text = Validation.GetSafeString(grdCompanies.Rows[e.RowIndex].Cells["colCompanyName"].Value);
                //txtDiscription.Text = Validation.GetSafeString(grdCompanies.Rows[e.RowIndex].Cells["colDiscription"].Value);
                CDate.Value = Convert.ToDateTime(grdCompanies.Rows[e.RowIndex].Cells["ColCreationDate"].Value); 
            }
            else if (e.ColumnIndex == 6)
            {
                var manager = new CompanyBLL();
                if (manager.DeleteCompany(IdCompany).IsSuccess)
                {
                    MessageBox.Show("Company Is InActive Now");
                    ClearControls();
                    FillCompanies();
                }
                //Delete Company Here ....
            }
        }
        private void grdCompanies_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.Value = "Edit";
            }
            if (e.ColumnIndex == 6)
            {
                e.Value = "Delete";
            }
        }
        #endregion
        #region Others Controls Events And Methods
        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            chkAll.Checked = false;
            if (chkFilter.Checked)
            {
                filterDGV("IsActive = 0");
            }
            else
            {
                filterDGV("IsActive = 1");
            }
        }
        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            chkFilter.Checked = false;
            FillCompanies();
        }
        #endregion
    }
}
