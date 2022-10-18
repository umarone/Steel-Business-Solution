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
    public partial class frmSampleSaleDays : MetroForm
    {
        public frmSampleSaleDays()
        {
            InitializeComponent();
        }

        private void frmSampleSaleDays_Load(object sender, EventArgs e)
        {
            this.grdRemaingDays.AutoGenerateColumns = false;
            cbxEmployees.Enabled = false;
            FillEmployees();
        }
        private void FillEmployees()
        {
            var manager = new AccountsBLL();
            List<AccountsEL> listAccounts = manager.GetEmployeesAccounts(Operations.IdCompany);

            cbxEmployees.DataSource = listAccounts;
            cbxEmployees.DisplayMember = "AccountName";
            cbxEmployees.ValueMember = "AccountNo";
        }
        private void grdRemaingDays_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.Value = "Check Detail";
            }
            else if (e.ColumnIndex == 6)
            {
                e.Value = "Recieved";
            }
        }

        private void rdSamples_CheckedChanged(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroRadioButton rbtn = sender as MetroFramework.Controls.MetroRadioButton;
            List<VouchersEL> list = null;
            if (rbtn.Name == "rdSamples")
            {
                var SampleManager = new SamplesHeadBLL();
                if (!chkEmployees.Checked)
                {
                    list = SampleManager.GetSamplesDays(Operations.IdCompany);
                    
                }
                else
                {
                    list = SampleManager.GetSamplesDaysByEmployess(Operations.IdCompany, cbxEmployees.SelectedValue.ToString());
                }
            }
            else
            {
                var SalesManager = new SalesHeadBLL();
                if (!chkEmployees.Checked)
                {
                    list = SalesManager.GetSaleDays(Operations.IdCompany);

                }
                else
                {
                    list = SalesManager.GetSaleDaysByEmployees(Operations.IdCompany, cbxEmployees.SelectedValue.ToString());
                }
            }
            if (list.Count > 0)
            {
                FillGrid(list);
            }
            else
            {
                grdRemaingDays.DataSource = null;
            }
        }
        private void FillGrid(List<VouchersEL> list)
        {
            grdRemaingDays.DataSource = list;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<VouchersEL> list = null;
            if (rdSamples.Checked)
            {
                var SampleManager = new SamplesHeadBLL();
                list = SampleManager.GetSamplesDaysByEmployess(Operations.IdCompany, cbxEmployees.SelectedValue.ToString());
            }
            else if (rdSales.Checked)
            {
                var SalesManager = new SalesHeadBLL();
                list = SalesManager.GetSaleDaysByEmployees(Operations.IdCompany, cbxEmployees.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Please Select Sample OR Sales :");
                return;
            }
            if (list.Count > 0)
            {
                grdRemaingDays.DataSource = list;
            }
            else
            {
                grdRemaingDays.DataSource = null;
            }
        }

        private void chkEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmployees.Checked)
            {
                cbxEmployees.Enabled = true;
            }
            else
            {
                cbxEmployees.Enabled = false;
            }
        }

        private void grdRemaingDays_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                var manager = new VoucherBLL();
                List<VouchersEL> list = null;
                VouchersEL oelVoucher = new VouchersEL();
                oelVoucher.IdCompany = Operations.IdCompany;
                oelVoucher.VoucherNo = Validation.GetSafeLong(grdRemaingDays.Rows[e.RowIndex].Cells[0].Value);
                int isSale = 0;
                if (rdSamples.Checked)
                {
                    isSale = 1;
                }
                else
                {
                    isSale = 0;
                }
                if (manager.UpdateDaysStatus(oelVoucher, isSale).IsSuccess)
                {
                    if (chkEmployees.Checked)
                    {
                        btnLoad_Click(sender, e);
                    }
                    else if(rdSamples.Checked)
                    {
                        var SampleManager = new SamplesHeadBLL();
                        list = SampleManager.GetSamplesDaysByEmployess(Operations.IdCompany, cbxEmployees.SelectedValue.ToString());
                        if (list.Count > 0)
                        {
                            FillGrid(list);
                        }
                    }
                    else if (rdSales.Checked)
                    {
                        var SalesManager = new SalesHeadBLL();
                        list = SalesManager.GetSaleDaysByEmployees(Operations.IdCompany, cbxEmployees.SelectedValue.ToString());
                        if (list.Count > 0)
                        {
                            FillGrid(list);
                        }
                    }
                }
            }
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked)
            {
                dtStart.Enabled = true;
                dtEnd.Enabled = false;
            }
            else
            {
                dtStart.Enabled = false;
                dtEnd.Enabled = false;
            }
        }

        private void btnLoadByDate_Click(object sender, EventArgs e)
        {
            var SalesManager = new SalesHeadBLL();
            var SamplesManager = new SamplesHeadBLL();
            List<VouchersEL> list = null;
            if (chkEmployees.Checked == false && chkDate.Checked)
            {
                if (rdSamples.Checked)
                {
                    list = SamplesManager.GetSamplesDaysByDate(Operations.IdCompany, dtStart.Value, dtEnd.Value); 
                }
                else if (rdSales.Checked)
                {
                    list = SalesManager.GetSaleDaysByDate(Operations.IdCompany, dtStart.Value, dtEnd.Value);
                }
            }
            else if (chkEmployees.Checked && chkDate.Checked)
            {
                if (rdSamples.Checked)
                {
                    list = SamplesManager.GetSamplesDaysByEmployeesByDate(Operations.IdCompany, cbxEmployees.SelectedValue.ToString(), dtStart.Value, dtEnd.Value);
                }
                else if (rdSales.Checked)
                {
                    list = SalesManager.GetSaleDaysByEmployeesByDate(Operations.IdCompany, cbxEmployees.SelectedValue.ToString(), dtStart.Value, dtStart.Value);
                }
            }
            if (list.Count > 0)
            {
                FillGrid(list);
            }
        }
    }
}
