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
    public partial class frmCategories : MetroForm
    {
        #region Variables
        Int64? IdCategory;
        frmFindCategories frmCategory = null;
        #endregion
        #region Form Methods And Events
        public frmCategories()
        {
            InitializeComponent();
        }
        private void frmCategories_Load(object sender, EventArgs e)
        {
            //GetMaxCategoryCode();
        }
        private void GetMaxCategoryCode()
        {
            var Manager = new CategoryBLL();
            txtCategoryCode.Text = Validation.GetSafeString(Manager.GetMaxCategoryCode(Operations.IdCompany));
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
            IdCategory = null;
            txtCategoryCode.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtCategoryCode.Focus();
            chkActive.Checked = false;
            chkAllow.Checked = false;
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            CategoryEL oelCategory = new CategoryEL();
            var Manager = new CategoryBLL();
            if (Validate())
            {
                if (!IdCategory.HasValue)
                {
                    oelCategory.IdCategory = 1;
                }
                else
                {
                    oelCategory.IdCategory = IdCategory.Value;
                }

                oelCategory.IdProject = Operations.IdProject;
                oelCategory.CategoryCode = txtCategoryCode.Text;
                oelCategory.CategoryName = txtCategoryName.Text.Trim();
                oelCategory.CreatedDateTime = CategoryDate.Value;
                if (!chkActive.Checked)
                    oelCategory.IsActive = true;
                else
                    oelCategory.IsActive = false;
                oelCategory.UserId = Operations.UserID;
                if (!chkAllow.Checked)
                {
                    if (!IdCategory.HasValue)
                    {
                        if (Manager.CheckCategoryCodeDuplication(Validation.GetSafeLong(txtCategoryCode.Text)))
                        {
                            MessageBox.Show("Category Code Already Exists");
                            return;
                        }
                    }
                }
                if (!IdCategory.HasValue)
                {
                    if (!Manager.CheckCategoryNameDuplication(txtCategoryName.Text.Trim()))
                    {
                        if (Manager.CreateCategory(oelCategory).IsSuccess)
                        {
                            //GetMaxCategoryCode();
                            ClearControls();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Category Name Already Exists");
                    }
                }
                else
                {
                    if (Manager.UpdateCategory(oelCategory).IsSuccess)
                    {
                        //GetMaxCategoryCode();
                        ClearControls();
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var manager = new CategoryBLL();
            if (manager.DeleteCategory(IdCategory.Value).IsSuccess)
            {
                GetMaxCategoryCode();
                ClearControls();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCategory = new frmFindCategories();
            frmCategory.ExecuteFindCategoryEvent += new frmFindCategories.FindCategoryDelegate(frmCategory_ExecuteFindCategoryEvent);
            frmCategory.ShowDialog(this);
        }
        #endregion
        #region Other Controls Methods and Events
        private void txtCategoryCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
        void frmCategory_ExecuteFindCategoryEvent(object Sender, CategoryEL oelCategory)
        {
            IdCategory = oelCategory.IdCategory;
            GetCategory(IdCategory);
        }
        private void GetCategory(Int64? Id)
        {
            var manager = new CategoryBLL();
            List<CategoryEL> list = manager.GetCategoryById(Id.Value);
            if (list.Count > 0)
            {
                txtCategoryCode.Text = list[0].CategoryCode.ToString();
                txtCategoryName.Text = list[0].CategoryName;
                if (!Convert.ToBoolean(list[0].IsActive))
                {
                    chkActive.Checked = true;
                }
                else
                    chkActive.Checked = false;
                //chkActive.Checked = Convert.ToBoolean(list[0].IsActive);
                CategoryDate.Value = Convert.ToDateTime(list[0].CreatedDateTime);
            }
        }
        #endregion
    }
}
