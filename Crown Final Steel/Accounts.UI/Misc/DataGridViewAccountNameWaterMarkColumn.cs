using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Drawing;
using System.Windows.Forms;

namespace Accounts.UI
{
    internal class DataGridViewAccountNameWaterMarkColumn : DataGridViewTextBoxColumn
    {
        public DataGridViewAccountNameWaterMarkColumn()
        {
            CellTemplate = new DataGridViewWatermarkAccountsCell();
        }
        public String WatermarkText
        {

            get
            {

                if (((DataGridViewWatermarkAccountsCell)CellTemplate) == null)
                {

                    throw new InvalidOperationException("cell template required");

                }

                return ((DataGridViewWatermarkAccountsCell)CellTemplate).WatermarkText;

            }
            set
            {

                if (this.WatermarkText != value)
                {

                    ((DataGridViewWatermarkAccountsCell)CellTemplate).WatermarkText = value;

                    if (this.DataGridView != null)
                    {

                        DataGridViewRowCollection dataGridViewRows =

                            this.DataGridView.Rows;

                        int rowCount = dataGridViewRows.Count;

                        for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
                        {

                            DataGridViewRow dataGridViewRow =

                                dataGridViewRows.SharedRow(rowIndex);

                            DataGridViewWatermarkCell cell =

                                dataGridViewRow.Cells[this.Index]

                                as DataGridViewWatermarkCell;

                            if (cell != null)
                            {

                                cell.WatermarkText = value;

                            }

                        }

                    }

                }

            }

        }
    }
    public class DataGridViewWatermarkAccountsCell : DataGridViewTextBoxCell
    {
        private String watermarkTextValue = "Type Here For Accounts Selection";

        public String WatermarkText
        {

            get { return watermarkTextValue; }

            set { watermarkTextValue = value; }

        }

        public override object Clone()
        {

            DataGridViewWatermarkAccountsCell cell = (DataGridViewWatermarkAccountsCell)base.Clone();

            cell.WatermarkText = this.WatermarkText;

            return cell;

        }



        protected override void Paint(Graphics graphics, Rectangle clipBounds,

            Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState,

            object value, object formattedValue, string errorText,

            DataGridViewCellStyle cellStyle,

            DataGridViewAdvancedBorderStyle advancedBorderStyle,

            DataGridViewPaintParts paintParts)
        {
            if (this.RowIndex >= -1)
                if ((OwningColumn.Site == null || !OwningColumn.Site.DesignMode) &&
                    (RowIndex < 0 || !IsInEditMode) && !String.IsNullOrEmpty(WatermarkText) &&
                    (GetValue(rowIndex) == null || GetValue(rowIndex) == DBNull.Value))
                {

                    cellStyle.Font = new Font(cellStyle.Font, FontStyle.Italic);

                    cellStyle.ForeColor = Color.Gray;

                    formattedValue = WatermarkText;

                }

            base.Paint(graphics, clipBounds, cellBounds, rowIndex,

                cellState, value, formattedValue, errorText,

                cellStyle, advancedBorderStyle, paintParts);

        }

    }
}
