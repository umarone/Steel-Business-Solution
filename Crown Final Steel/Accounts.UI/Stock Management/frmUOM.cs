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
    public partial class frmUOM : MetroForm
    {
        #region Variables
        Int64? IdUOM;
        #endregion
        #region Form Methods And Events
        public frmUOM()
        {
            InitializeComponent();
        }
        private void frmUOM_Load(object sender, EventArgs e)
        {
            this.grdUOM.AutoGenerateColumns = false;
            GetALLUOMS();
        }       
        #endregion
        #region Simple Methods
        private bool Validate()
        {
            bool isValid = true;
            return isValid;
        }
        private void ClearControls()
        {
            IdUOM = null;
            txtUOM.Text = string.Empty;           
            chkActive.Checked = false;
            UOMDate.Value = DateTime.Now;
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            UOMEL oelUOM = new UOMEL();
            var Manager = new UOMBLL();
            if (Validate())
            {
                if (!IdUOM.HasValue)
                {
                    oelUOM.IdUOM = 1;
                }
                else
                {
                    oelUOM.IdUOM = IdUOM.Value;
                }

                oelUOM.IdProject = Operations.IdProject;
                oelUOM.UOMName = txtUOM.Text.Trim();
                oelUOM.CreatedDateTime = UOMDate.Value;
                if (!chkActive.Checked)
                    oelUOM.IsActive = true;
                else
                    oelUOM.IsActive = false;
                oelUOM.UserId = Operations.UserID;
               
                if (!IdUOM.HasValue)
                {
                    if (Manager.CreateUOM(oelUOM).IsSuccess)
                    {
                        MessageBox.Show("UOM Is Inserted Successfully...");
                        GetALLUOMS();
                        ClearControls();
                    }                           
                }
                else
                {
                    if (Manager.UpdateUOM(oelUOM).IsSuccess)
                    {
                        MessageBox.Show("UOM Is Updated Successfully...");
                        GetALLUOMS();
                        ClearControls();
                    }
                }
            }
        }       
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearControls();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        #endregion
        #region Other Controls Methods and Events
        private void grdUOM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = "Edit";
            }
        }
        private void grdUOM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool Val = false;
            if (e.ColumnIndex == 3)
            {
                IdUOM = Validation.GetSafeLong(grdUOM.Rows[e.RowIndex].Cells[0].Value);
                txtUOM.Text = Validation.GetSafeString(grdUOM.Rows[e.RowIndex].Cells[1].Value);
                Val = Convert.ToBoolean(grdUOM.Rows[e.RowIndex].Cells[2].Value);
                if (Val == false)
                {
                    chkActive.Checked = true;
                }
                else
                    chkActive.Checked = false;
            }
        }
        private void GetALLUOMS()
        {
            var manager = new UOMBLL();
            List<UOMEL> list = manager.GetAllUOMS();
            if (list.Count > 0)
            {
                grdUOM.DataSource = list;
            }
            else
                grdUOM.DataSource = null;
        }
        #endregion


    }
}
