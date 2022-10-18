using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounts.UI
{
    public class CustomDataGrid : DataGridView
    {
        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                return true;             
            return base.ProcessDataGridViewKey(e); 
        }
        ////protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        ////{
        ////    if (keyData == Keys.Enter)
        ////    {
        ////        SendKeys.Send("{TAB}");
        ////        return true;
        ////    }
        ////    return base.ProcessCmdKey(ref msg, keyData);
        ////}
    }
}
