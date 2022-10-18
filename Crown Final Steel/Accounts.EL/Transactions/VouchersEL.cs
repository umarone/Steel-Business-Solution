using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class VouchersEL : StockAdjustmentsEL
    {
        public Int64? IdVoucher 
        { 
            get; 
            set; 
        }
        public Int64 VoucherNo
        {
            get;
            set;
        }
        public Int64 SheetNo
        {
            get;
            set;
        }
        public int OutSourceWork { get; set; }
        public int OutSourceWorkType { get; set; }
        public int StoreType 
        {
            get;
            set; 
        }
        public decimal StoreIn
        {
            get;
            set;
        }
        public decimal StoreOut
        {
            get;
            set;
        }
        public Int64 SampleNo
        {
            get;
            set;
        }
        public Int64 InvoiceNo
        {
            get;
            set;
        }
        public string BiltyNo
        {
            get;
            set;
        }
        public decimal TotalSales
        {
            get;
            set;
        }
        public decimal TotalSalesReturn
        {
            get;
            set;
        }
        public decimal SaleCost
        {
            get;
            set;
        }
        public decimal GrossProfit
        {
            get;
            set;
        }
        public decimal NetProfit
        {
            get;
            set;
        }
        public decimal NetSaleReturnAmount
        {
            get;
            set;
        }
        public decimal ActualSoldAmount
        {
            get;
            set;
        }
        public decimal ReturnedCost
        {
            get;
            set;
        }        
        public string DemandNo
        {
            get;
            set;
        }
        public string OutWardGatePassNo
        {
            get;
            set;
        }
        public string InWardGatePassNo
        {
            get;
            set;
        }
        public string SettlementType
        {
            get;
            set;
        }
        public string SoftwareType { get; set; }
        public Int64 IdUser
        {
            get;
            set;
        }
        public Int64 EditedByUserId { get; set; }
        public Int64 PostedByUserId { get; set; }
        public DateTime Date
        {
            get;
            set;
        }
        public DateTime? VDate
        {
            get;
            set;
        }
        public DateTime? EditedDateTime
        {
            get;
            set;
        }
        public DateTime? PostedDateTime
        {
            get;
            set;
        }
        public DateTime? DueDate
        {
            get;
            set;
        }
        public string ChequeNo
        {
            get;
            set;
        }
        public string BillNo
        {
            get;
            set;
        }
        public string MemoSaleNo
        {
            get;
            set;
        }
        public Int64 TrackNumber
        {
            get;
            set;
        }
        public string VDiscription
        {
            get;
            set;
        }
        public string Narration
        {
            get;
            set;
        }
        public int TransactionType
        {
            get;
            set;
        }
        public string TypedClosingBalance
        {
            get;
            set;
        }
        public decimal ClosingBalance
        {
            get;
            set;
        }
        public decimal Debit
        {
            get;
            set;
        }
        public decimal Credit
        {
            get;
            set;
        }
        public decimal DebitX
        {
            get;
            set;
        }
        public decimal CreditX
        {
            get;
            set;
        }
        public decimal DebitCount
        {
            get;
            set;
        }
        public decimal CreditCount
        {
            get;
            set;
        }
        public decimal Amount
        {
            get;
            set;
        }
        public decimal BillAmount
        {
            get;
            set;
        }
        public decimal TotalFreight
        {
            get;
            set;
        }
        public decimal TotalAmount
        {
            get;
            set;
        }
        public decimal VAT
        {
            get;
            set;
        }
        public decimal VATAmount
        {
            get;
            set;
        }
        public decimal CashPaid
        {
            get;
            set;
        }
        public decimal Discount
        {
            get;
            set;
        }
        public decimal LineDiscount
        {
            get;
            set;
        }
        public decimal PromoDiscount
        {
            get;
            set;
        }
        public decimal ExtraDiscount
        {
            get;
            set;
        }
        public decimal TotalDiscount
        {
            get;
            set;
        }
        public decimal NetSaleAmount
        {
            get;
            set;
        }
        public decimal DiscountAmount
        {
            get;
            set;
        }
        public bool IsSold
        {
            get;
            set;
        }
        public bool? IsImport
        {
            get;
            set;
        }
        public bool IsNetPurchases
        {
            get;
            set;
        }
        public bool IsNetPurchasesReturn
        {
            get;
            set;
        }
        public bool IsNetSales
        {
            get;
            set;
        }
        public bool IsNetSalesReturn
        {
            get;
            set;
        }
        public bool? IsNetTransaction { get; set; }
        public bool? IsImportTransaction { get; set; }
        public int SaleType
        {
            get;
            set;
        }
        public decimal FreeVoucher { get; set; }
        public string CardNo { get; set; }
        public Int32 PaymentType { get; set; }
        public decimal CashRecieved { get; set; }
        public decimal CashBalance { get; set; }
        public bool? Posted
        {
            get;
            set;
        }
        public string VoucherType
        {
            get;
            set;
        }
        public string DriverName
        {
            get;
            set;
        }
        public string JVType
        {
            get;
            set;
        }
        public string PersonName
        {
            get;
            set;
        }
        public bool IsNew
        {
            get;
            set;
        }
        public Int64 Transactiondays
        {
            get;
            set;
        }
        public Int64 RemainingDays
        {
            get;
            set;
        }
        public Boolean? IsRecieved
        {
            get;
            set;
        }
        public decimal OneTimeUnits
        {
            get;
            set;
        }
        public Int32 ReturnType
        {
            get;
            set;
        }
        public string TransactionMode
        {
            get;
            set;
        }
        public Boolean? IsDeleted
        {
            get;
            set;
        }

        public decimal BillAmountAfterDiscount { get; set; }
        public decimal TotalItems { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public decimal TotalAmountAfterTax { get; set; }
        public decimal FlatDiscount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal LoadingCharges { get; set; }
        public decimal CuttingCharges { get; set; }
        public decimal MiscCharges { get; set; }
        public decimal SystemWeight { get; set; }
        public decimal ManualWeight { get; set; }
        public decimal AutoWeight { get; set; }
    }
}
