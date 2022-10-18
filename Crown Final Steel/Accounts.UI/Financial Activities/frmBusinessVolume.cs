using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;
using Accounts.EL;
using Accounts.BLL;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmBusinessVolume : MetroForm
    {
        #region Variables
        public int VolumeType { get; set; }
        #endregion
        #region Form Methods And Events
        public frmBusinessVolume()
        {
            InitializeComponent();
        }
        private void frmBusinessVolume_Load(object sender, EventArgs e)
        {
            this.grdBusinessVolume.AutoGenerateColumns = false;
            if (VolumeType == 1)
            {
                this.Text = "Day Start Business Volume";
            }
            else
            {
                this.Text = "Day End Business Volume";
            }
        }
        private void frmBusinessVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
        #region Button Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new TransactionBLL();
            List<TransactionsEL> list = null;
            if (VolumeType == 1)
                list = manager.DayStartBusinessVolume(Operations.IdProject, Operations.BookNo, Convert.ToDateTime(dt.Value.ToShortDateString()));
            else
                list = manager.DayEndBusinessVolume(Operations.IdProject, Operations.BookNo, Convert.ToDateTime(dt.Value.ToShortDateString()));
            if (list.Count > 0)
            {
                grdBusinessVolume.DataSource = list;
            }
            else
            {
                grdBusinessVolume.DataSource = null;
            }
        }
        #endregion
    }
}
