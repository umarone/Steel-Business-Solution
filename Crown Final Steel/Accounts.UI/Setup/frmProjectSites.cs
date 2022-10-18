using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;


namespace Accounts.UI
{
    public partial class frmProjectSites : MetroForm
    {
        Guid IdProject = Guid.Empty;
        public frmProjectSites()
        {
            InitializeComponent();
        }

        private void frmProjectSites_Load(object sender, EventArgs e)
        {
            this.grdProjects.AutoGenerateColumns = false;
            FillProjects();
        }
        private void FillProjects()
        {
            var manager = new ProjectBLL();
            List<ProjectEL> listProjects = manager.List();
            if (listProjects.Count > 0)
            {
                grdProjects.DataSource = listProjects;
            }
        }

        private void grdProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                IdProject = Validation.GetSafeGuid(grdProjects.Rows[e.RowIndex].Cells["colIdProject"].Value);
                frmSiteStore.IdProject2 = IdProject;                               
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
        private void grdProjects_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
            IdProject = Validation.GetSafeGuid(grdProjects.CurrentRow.Cells["colIdProject"].Value);
            frmSiteStore.IdProject2 = IdProject;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void frmProjectSites_FormClosing(object sender, FormClosingEventArgs e)
        {
            // this.Close();
        }

        private void frmProjectSites_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }       
    }
}
