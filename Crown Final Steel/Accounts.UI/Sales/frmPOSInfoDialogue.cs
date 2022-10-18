using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounts.UI
{
    public partial class frmPOSInfoDialogue : Form
    {
        public string TotalItems { get; set; }
        public string InvoiceTotal { get; set; }
        public string CashRecieved { get; set; }
        public string BalanceAmount { get; set; }
        public frmPOSInfoDialogue()
        {
            InitializeComponent();
        }

        private void frmPOSInfoDialogue_Load(object sender, EventArgs e)
        {
            this.txtTotalItems.Text = TotalItems.ToString();
            this.txtInvoiceTotal.Text = InvoiceTotal.ToString();
            this.txtCashRecieved.Text = CashRecieved.ToString();
            this.txtBalance.Text = BalanceAmount.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
