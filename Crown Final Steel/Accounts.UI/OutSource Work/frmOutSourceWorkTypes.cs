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
    public partial class frmOutSourceWorkTypes : MetroForm
    {
        #region Variables
        Int64? IdOutSourceWorkType;
        frmFindOutSourceWorkType frmfindoutsouceworks = null;
        #endregion
        #region Form Methods And Events
        public frmOutSourceWorkTypes()
        {
            InitializeComponent();
        }
        private void frmOutSourceWorkTypes_Load(object sender, EventArgs e)
        {
            //GetMaxCategoryCode();
        }
        private void GetMaxOutSourceWorkTypeCode()
        {
            var Manager = new OutSourceWorkTypeBLL();
            txtOutSourceWorkTypeCode.Text = Validation.GetSafeString(Manager.GetMaxOutSourceWorkTypeCode(Operations.IdProject));
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
            IdOutSourceWorkType = null;
            txtOutSourceWorkTypeCode.Text = string.Empty;
            txtOutSourceWorkTypeName.Text = string.Empty;
            txtOutSourceWorkTypeCode.Focus();
            chkActive.Checked = false;
            chkAllow.Checked = false;
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            OutSourceWorkTypeEL oelOutSourceWorkType = new OutSourceWorkTypeEL();
            var Manager = new OutSourceWorkTypeBLL();
            if (Validate())
            {
                if (!IdOutSourceWorkType.HasValue)
                {
                    oelOutSourceWorkType.IdOutSourceWorkType = 1;
                }
                else
                {
                    oelOutSourceWorkType.IdOutSourceWorkType = IdOutSourceWorkType.Value;
                }

                oelOutSourceWorkType.IdProject = Operations.IdProject;
                oelOutSourceWorkType.OutSourceWorkTypeCode = txtOutSourceWorkTypeCode.Text;
                oelOutSourceWorkType.OutSourceWorkTypeName = txtOutSourceWorkTypeName.Text.Trim();
                oelOutSourceWorkType.Discription = txtDiscription.Text;
                oelOutSourceWorkType.CreatedDateTime = CategoryDate.Value;
                if (!chkActive.Checked)
                    oelOutSourceWorkType.IsActive = true;
                else
                    oelOutSourceWorkType.IsActive = false;
                oelOutSourceWorkType.UserId = Operations.UserID;
                if (!chkAllow.Checked)
                {
                    if (!IdOutSourceWorkType.HasValue)
                    {
                        if (Manager.CheckOutSourceWorkTypeCodeDuplication(Validation.GetSafeLong(txtOutSourceWorkTypeCode.Text)))
                        {
                            MessageBox.Show("OutSource Work Type Code Already Exists");
                            return;
                        }
                    }
                }
                if (!IdOutSourceWorkType.HasValue)
                {
                    if (!Manager.CheckOutSourceWorkTypeNameDuplication(txtOutSourceWorkTypeName.Text.Trim()))
                    {
                        if (Manager.CreateOutSourceWorkType(oelOutSourceWorkType).IsSuccess)
                        {
                            //GetMaxCategoryCode();
                            ClearControls();
                        }
                    }
                    else
                    {
                        MessageBox.Show("OutSource Work Type Name Already Exists");
                    }
                }
                else
                {
                    if (Manager.UpdateOutSourceWorkType(oelOutSourceWorkType).IsSuccess)
                    {
                        //GetMaxCategoryCode();
                        ClearControls();
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var manager = new OutSourceWorkTypeBLL();
            if (manager.DeleteOutSourceWorkType(IdOutSourceWorkType.Value).IsSuccess)
            {
                GetMaxOutSourceWorkTypeCode();
                ClearControls();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmfindoutsouceworks = new frmFindOutSourceWorkType();
            frmfindoutsouceworks.ExecuteFindOutSourceWorkTypeEvent += new frmFindOutSourceWorkType.FindOutSourceWorkDelegate(frmfindoutsouceworks_ExecuteFindOutSourceWorkTypeEvent);
            frmfindoutsouceworks.ShowDialog(this);
        }
        void frmfindoutsouceworks_ExecuteFindOutSourceWorkTypeEvent(object Sender, OutSourceWorkTypeEL oelOutSourceWorkType)
        {
            IdOutSourceWorkType = oelOutSourceWorkType.IdOutSourceWorkType;
            GetOutSourceWorkByID(IdOutSourceWorkType);
        }
        #endregion
        #region Other Controls Methods and Events
        private void txtOutSourceWorkTypeCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
        private void GetOutSourceWorkByID(Int64? Id)
        {
            var manager = new OutSourceWorkTypeBLL();
            List<OutSourceWorkTypeEL> list = manager.GetOutSourceWorkTypeById(Id.Value);
            if (list.Count > 0)
            {
                txtOutSourceWorkTypeCode.Text = list[0].OutSourceWorkTypeCode.ToString();
                txtOutSourceWorkTypeName.Text = list[0].OutSourceWorkTypeName;
                txtDiscription.Text = list[0].Discription;
                //chkActive.Checked = Convert.ToBoolean(list[0].IsActive);
                if (!Convert.ToBoolean(list[0].IsActive))
                {
                    chkActive.Checked = true;
                }
                else
                    chkActive.Checked = false;
                CategoryDate.Value = Convert.ToDateTime(list[0].CreatedDateTime);
            }
        }
        #endregion

    }
}
