using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class StockAdjustmentsEL : ItemsEL
    {
        public Int64 IdStockAdjustmentType { get; set; }
        public string StockAdjustmentName { get; set; }
        public int StockAdjustmentType { get; set; }
        public bool? IsMeasureAble { get; set; }
    }
}
