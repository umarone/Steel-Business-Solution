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
using MetroFramework.Forms;
using System.Collections;

namespace Accounts.UI
{
    public partial class frmCompanyProjectInfo : MetroForm
    {
        public frmCompanyProjectInfo()
        {
            InitializeComponent();
        }
        private void frmCompanyProjectInfo_Load(object sender, EventArgs e)
        {
            txtCompanyName.Text = Operations.CompanyName;
            txtProjectName.Text = Operations.ProjectName;
        }
        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mbtnUpdate_Click(object sender, EventArgs e)
        {
            if (mbtnUpdate.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var manager = new ProjectBLL();
                ProjectEL obj = new ProjectEL();
                obj.CompanyName = txtCompanyName.Text;
                obj.ProjectName = txtProjectName.Text;

                if (manager.UpdateProjectAndCompanyName(obj).IsSuccess)
                {
                    this.Close();
                }
                Operations.ProjectName = obj.ProjectName;
                Operations.CompanyName = obj.CompanyName;
            }
        }
    }
}
