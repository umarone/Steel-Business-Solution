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
    public partial class frmTradingCo : MetroForm
    {
        #region Variables
        Int64? IdTrading;
        frmFindTradingCo frmfindTradingCo = null;
        #endregion
        #region Form Methods And Events
        public frmTradingCo()
        {
            InitializeComponent();
        }
        private void frmTradingCo_Load(object sender, EventArgs e)
        {

        }
        private void frmTradingCo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                ClearControls();
            }
        }
        #endregion
        #region Simple Methods
        private void GetMaxTradingCode()
        {
            var Manager = new TradingBLL();
            txtTradingCode.Text = Validation.GetSafeString(Manager.GetMaxTradingCode(Operations.IdCompany));
        }
        private void ClearControls()
        {
            IdTrading = null;
            txtTradingCode.Text = string.Empty;
            txtTradingName.Text = string.Empty;
            txtTradingDescription.Text = string.Empty;
            chkAllow.Checked = false;
            chkActive.Checked = false;
        }
        #endregion
        #region Buttons Events And Methods
        private void btnSave_Click(object sender, EventArgs e)
        {
            TradingEL oelTrading = new TradingEL();
            var Manager = new TradingBLL();
            if (Validate())
            {
                if (!IdTrading.HasValue)
                {
                    oelTrading.IdTrading = 0;
                }
                else
                {
                    oelTrading.IdTrading = IdTrading.Value;
                }
                oelTrading.IdProject = Operations.IdProject;
                oelTrading.UserId = Operations.UserID;
                oelTrading.TradingCode = Validation.GetSafeLong(txtTradingCode.Text);
                oelTrading.TradingName = txtTradingName.Text.Trim();
                oelTrading.TradingDiscription = Validation.GetSafeString(txtTradingDescription.Text);
                if (!chkActive.Checked)
                    oelTrading.IsActive = true;
                else
                    oelTrading.IsActive = false;
                oelTrading.CreatedDateTime = TradingDate.Value;
                if (!chkAllow.Checked)
                {
                    if (!IdTrading.HasValue)
                    {
                        if (Manager.CheckTradingCodeDuplication(Validation.GetSafeLong(txtTradingCode.Text)))
                        {
                            MessageBox.Show("Trading Brand Code Already Exists");
                            return;
                        }
                    }
                }
                if (!IdTrading.HasValue)
                {
                    if (!Manager.CheckTradingNameDuplication(txtTradingName.Text.Trim()))
                    {
                        if (Manager.InsertTradingCo(oelTrading).IsSuccess)
                        {
                            //GetMaxTradingCode();
                            ClearControls();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trading Brand Already Exists");
                    }
                }
                else
                {
                    if (Manager.UpdateTradingCo(oelTrading).IsSuccess)
                    {
                        //GetMaxTradingCode();
                        ClearControls();
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var manager = new TradingBLL();
            if (manager.DeleteTradingCo(IdTrading.Value).IsSuccess)
            {
                GetMaxTradingCode();
                ClearControls();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmfindTradingCo = new frmFindTradingCo();
            frmfindTradingCo.ExecuteFindTradingEvent += new frmFindTradingCo.FindTradingDelegate(frmfindTradingCo_ExecuteFindTradingEvent);
            frmfindTradingCo.ShowDialog();
        }
        #endregion
        #region Other Controls Methods And Events
        private void txtTradingCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
        void frmfindTradingCo_ExecuteFindTradingEvent(object Sender, TradingEL oelTrading)
        {
            IdTrading = oelTrading.IdTrading;
            GetTrading(IdTrading);
        }
        private void GetTrading(Int64? Id)
        {
            var manager = new TradingBLL();
            List<TradingEL> list = manager.GetTradingCoById(Id);
            if (list.Count > 0)
            {
                txtTradingCode.Text = Validation.GetSafeString(list[0].TradingCode);
                txtTradingName.Text = list[0].TradingName;
                txtTradingDescription.Text = list[0].TradingDiscription;
                if (!Convert.ToBoolean(list[0].IsActive))
                {
                    chkActive.Checked = true;
                }
                else
                    chkActive.Checked = false;
                //chkActive.Checked = Convert.ToBoolean(Validation.GetSafeBooleanNullable(list[0].IsActive));
                TradingDate.Value = list[0].CreatedDateTime.Value;
            }
        }
        #endregion       
    }
}
