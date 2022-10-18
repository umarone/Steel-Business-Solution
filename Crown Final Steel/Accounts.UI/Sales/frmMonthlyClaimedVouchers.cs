using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;

using Accounts.BLL;
using Accounts.EL;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmMonthlyClaimedVouchers : MetroForm
    {
        public string AccountNo { get; set; }
        public frmMonthlyClaimedVouchers()
        {
            InitializeComponent();
        }

        private void frmMonthlyClaimedVouchers_Load(object sender, EventArgs e)
        {
            this.grdClamiedVouchers.AutoGenerateColumns = false;
            this.grdClaimDetail.AutoGenerateColumns = false;
            FillVouchers();
        }
        private void FillVouchers()
        {
            var manager = new SalesHeadBLL();
            List<VouchersEL> list = manager.GetClaimedVouchersByAccountNo(Operations.IdCompany, AccountNo);
            if (list.Count > 0)
            {
                grdClamiedVouchers.DataSource = list;
            }
            else
                grdClamiedVouchers.DataSource = null;
        }
        private void grdClamiedVouchers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = "View Detail";
            }
        }

        private void grdClamiedVouchers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var manager = new SalesHeadBLL();
                List<VoucherDetailEL> list = manager.GetClaimedVouchersDetail(Validation.GetSafeGuid(grdClamiedVouchers.Rows[e.RowIndex].Cells[0].Value));
                if(list.Count > 0)
                    grdClaimDetail.DataSource = list;
                else
                    grdClaimDetail.DataSource = null;

            }
        }
    }
}
