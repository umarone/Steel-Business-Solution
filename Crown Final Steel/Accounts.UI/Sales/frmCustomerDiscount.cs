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
using Accounts.UI.UserControls;
using Accounts.EL;

using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmCustomerDiscount : MetroForm
    {
        public Guid IdItem { get; set; }
        public string AccountNo { get; set; }
        public frmCustomerDiscount()
        {
            InitializeComponent();
        }

        private void frmCustomerDiscount_Load(object sender, EventArgs e)
        {
            this.grdCustomerDiscounts.AutoGenerateColumns = false;
            LoadCustomerDiscounts();
        }
        private void LoadCustomerDiscounts()
        { 
            var manager = new SalesDetailBLL();
            List<SaleDetailEL> list = manager.GetCustomerDiscountDetail(Operations.IdCompany, IdItem, AccountNo);
            if (list.Count > 0)
            {
                grdCustomerDiscounts.DataSource = list;
            }
        }

        private void frmCustomerDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
