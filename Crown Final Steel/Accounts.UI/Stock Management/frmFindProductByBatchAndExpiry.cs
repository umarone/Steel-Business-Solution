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
    public partial class frmFindProductByBatchAndExpiry : MetroForm
    {
        public long IdItem { get; set; }
        public string ProductName { get; set; }
        ItemsEL Items = null;
        public delegate void FindStockDelegate(Object Sender, ItemsEL oelItems);
        public event FindStockDelegate ExecuteFindStockEvent;
        public frmFindProductByBatchAndExpiry()
        {
            InitializeComponent();
        }

        private void frmFindProductByBatchAndExpiry_Load(object sender, EventArgs e)
        {
            this.grdFindStock.AutoGenerateColumns = false;
            this.Text = ProductName;
            LoadStock();
        }
        private void LoadStock()
        {
            var manager = new ItemsBLL();
            List<ItemsEL> list = manager.GetItemByBatchAndExpiry(IdItem);
            if (list.Count > 0)
            {
                grdFindStock.DataSource = list;
            }
        }
        private void grdFindStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Items = new ItemsEL();
            
            Items.IdItem = Validation.GetSafeLong(grdFindStock.Rows[e.RowIndex].Cells[0].Value);
            Items.PackingSize = Validation.GetSafeString(grdFindStock.Rows[e.RowIndex].Cells[1].Value);
            Items.Qty = Validation.GetSafeLong(grdFindStock.Rows[e.RowIndex].Cells[2].Value);

            this.Close();
        }

        private void grdFindStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (grdFindStock.CurrentRow != null)
                {
                    int RowIndex = grdFindStock.CurrentRow.Index;
                    Items = new ItemsEL();  
                    Items.IdItem = Validation.GetSafeLong(grdFindStock.Rows[RowIndex].Cells[0].Value);
                    Items.PackingSize = Validation.GetSafeString(grdFindStock.Rows[RowIndex].Cells[1].Value);
                    Items.Qty = Validation.GetSafeLong(grdFindStock.Rows[RowIndex].Cells[2].Value);

                    this.Close();
                }
            }
        }

        private void frmFindProductByBatchAndExpiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Items != null)
            {
                ExecuteFindStockEvent(sender, Items);
            }
        }
    }
}
