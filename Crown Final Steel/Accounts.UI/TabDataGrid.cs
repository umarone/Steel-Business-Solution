using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounts.UI
{
    public class TabDataGrid : DataGridView
    {
        protected override bool  ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Enter)
            {                
                SendKeys.Send("{TAB}");
                return true;
            }
 	        return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
