using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Accounts.EL;
using Accounts.Common;


namespace Accounts.DAL
{
   public class PurchaseHeadDAL
   {
       #region Variables
       TransactionsDAL Tdal;
       PurchaseDetailDAL Pdal;
       ItemsDAL IDal;
       Int64? Identity;
       IDataReader objReader;
       public PurchaseHeadDAL()
       {
           Tdal = new TransactionsDAL();
           Pdal = new PurchaseDetailDAL();
           IDal = new ItemsDAL();
       }
       #endregion
       #region Purchases Methods
       public Int64 GetMaxPurchaseNumber(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
       {
           using (SqlCommand cmdPurchases = new SqlCommand("[Transactions].[Proc_GetMaxPurchaseNumber]", objConn))
           {
               cmdPurchases.CommandType = CommandType.StoredProcedure;
               cmdPurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdPurchases.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               //cmdPurchases.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
               return Validation.GetSafeLong(cmdPurchases.ExecuteScalar());
           }
       }
       public EntityoperationInfo InsertPurchases(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseCollection, List<TransactionsEL> oelTransactionsCollection,
                                                  List<VoucherDetailEL> oelPurchaseTransactionsCollection, SqlConnection objConn)
       {
           lock (this)
           {
               EntityoperationInfo infoResult = new EntityoperationInfo();
               SqlTransaction objTran = null;
               SqlCommand cmdPurchaseHead = new SqlCommand("[Transactions].[Proc_CreatePurchaseHead]", objConn);

               try
               {
                   objTran = objConn.BeginTransaction();
                   cmdPurchaseHead.Transaction = objTran;
                   cmdPurchaseHead.CommandType = CommandType.StoredProcedure;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdEditedUser", DbType.Int64)).Value = oelVoucher.EditedByUserId;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdPostedUser", DbType.Int64)).Value = oelVoucher.PostedByUserId;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@SheetNo", DbType.String)).Value = oelVoucher.SheetNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelVoucher.BookNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BiltyNo", DbType.String)).Value = oelVoucher.BiltyNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@EditedDateTime", DbType.DateTime)).Value = oelVoucher.EditedDateTime;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@PostedDateTime", DbType.DateTime)).Value = oelVoucher.PostedDateTime;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TransactionAccountNo", DbType.String)).Value = oelVoucher.TransactionAccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BillNo", DbType.String)).Value = oelVoucher.BillNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.VDiscription;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BillAmount", DbType.Decimal)).Value = oelVoucher.BillAmount;

                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalDiscount", DbType.Decimal)).Value = oelVoucher.TotalDiscount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@ExtraDiscount", DbType.Decimal)).Value = oelVoucher.ExtraDiscount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BillAmountAfterDiscount", DbType.Decimal)).Value = oelVoucher.BillAmountAfterDiscount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalFreight", DbType.Decimal)).Value = oelVoucher.TotalFreight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VAT", DbType.Decimal)).Value = oelVoucher.VAT;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VATTotalAmount", DbType.Decimal)).Value = oelVoucher.VATAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalItems", DbType.Decimal)).Value = oelVoucher.TotalItems;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TaxPercentage", DbType.Decimal)).Value = oelVoucher.TaxPercentage;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalTaxAmount", DbType.Decimal)).Value = oelVoucher.TotalTaxAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalAmountAfterTax", DbType.Decimal)).Value = oelVoucher.TotalAmountAfterTax;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IsNetTransaction", DbType.Boolean)).Value = oelVoucher.IsNetTransaction;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IsImportTransaction", DbType.Boolean)).Value = oelVoucher.IsImportTransaction;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@SystemWeight", DbType.Decimal)).Value = oelVoucher.SystemWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@ManualWeight", DbType.Decimal)).Value = oelVoucher.ManualWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@AutoWeight", DbType.Decimal)).Value = oelVoucher.AutoWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                   Identity = Validation.GetSafeLong(cmdPurchaseHead.ExecuteScalar());

                   // Insert Purchase Collection...
                   Pdal.InsertPurchaseDetail(oelPurchaseCollection, Identity, objConn, objTran);

                   infoResult.VoucherNo = GetPurchaseNumber(Identity.Value, oelVoucher.IdProject.Value, oelVoucher.BookNo, objConn, objTran);


                   Pdal.InsertPurchaseTransactionsDetail(oelPurchaseTransactionsCollection, Identity, infoResult.VoucherNo.ToString(), objConn, objTran);

                   IDal.UpdateEvaluationPrice(oelPurchaseCollection, objTran, objConn);

                   // Insert Purchase Transactions...
                   //Tdal.InsertTransactions(oelTransactionsCollection, Identity, objConn, objTran);

                   objTran.Commit();
                   infoResult.IntID = Identity.Value;
                   infoResult.IsSuccess = true;
               }
               catch (Exception ex)
               {
                   objTran.Rollback();
                   throw ex;
               }

               return infoResult;
           }
       }
       public EntityoperationInfo UpdatePurchases(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseCollection, List<TransactionsEL> oelTransactionsCollection,
                                                 List<VoucherDetailEL> oelPurchaseTransactionsCollection, SqlConnection objConn)
       {
           lock (this)
           {
               EntityoperationInfo infoResult = new EntityoperationInfo();
               SqlTransaction objTran = null;
               SqlCommand cmdPurchaseHead = new SqlCommand("[Transactions].[Proc_UpdatePurchaseHead]", objConn);
               try
               {
                   objTran = objConn.BeginTransaction();

                   cmdPurchaseHead.Transaction = objTran;
                   cmdPurchaseHead.CommandType = CommandType.StoredProcedure;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdEditedUser", DbType.Int64)).Value = oelVoucher.EditedByUserId;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdPostedUser", DbType.Int64)).Value = oelVoucher.PostedByUserId;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@SheetNo", DbType.String)).Value = oelVoucher.SheetNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelVoucher.BookNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BiltyNo", DbType.String)).Value = oelVoucher.BiltyNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@EditedDateTime", DbType.DateTime)).Value = oelVoucher.EditedDateTime;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@PostedDateTime", DbType.DateTime)).Value = oelVoucher.PostedDateTime;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TransactionAccountNo", DbType.String)).Value = oelVoucher.TransactionAccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BillNo", DbType.String)).Value = oelVoucher.BillNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.VDiscription;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BillAmount", DbType.Decimal)).Value = oelVoucher.BillAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalDiscount", DbType.Decimal)).Value = oelVoucher.TotalDiscount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@ExtraDiscount", DbType.Decimal)).Value = oelVoucher.ExtraDiscount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalFreight", DbType.Decimal)).Value = oelVoucher.TotalFreight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BillAmountAfterDiscount", DbType.Decimal)).Value = oelVoucher.BillAmountAfterDiscount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VAT", DbType.Decimal)).Value = oelVoucher.VAT;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VATTotalAmount", DbType.Decimal)).Value = oelVoucher.VATAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalItems", DbType.Decimal)).Value = oelVoucher.TotalItems;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TaxPercentage", DbType.Decimal)).Value = oelVoucher.TaxPercentage;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalTaxAmount", DbType.Decimal)).Value = oelVoucher.TotalTaxAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalAmountAfterTax", DbType.Decimal)).Value = oelVoucher.TotalAmountAfterTax;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IsNetTransaction", DbType.Boolean)).Value = oelVoucher.IsNetTransaction;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IsImportTransaction", DbType.Boolean)).Value = oelVoucher.IsImportTransaction;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@SystemWeight", DbType.Decimal)).Value = oelVoucher.SystemWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@ManualWeight", DbType.Decimal)).Value = oelVoucher.ManualWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@AutoWeight", DbType.Decimal)).Value = oelVoucher.AutoWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;

                   cmdPurchaseHead.ExecuteNonQuery();


                   // Insert Purchase Collection...
                   Pdal.UpdatePurchaseDetail(oelPurchaseCollection, objConn, objTran);

                   Pdal.UpdatePurchaseTransactionsDetail(oelPurchaseTransactionsCollection, objConn, objTran);

                   // Insert Purchase Transactions...
                   //Tdal.UpdateTransactions(oelTransactionsCollection, objConn, objTran);

                   //IDal.UpdateEvaluationPrice(oelPurchaseCollection, objTran, objConn);

                   objTran.Commit();
                   infoResult.IsSuccess = true;
               }
               catch (Exception ex)
               {
                   objTran.Rollback();
                   throw ex;
               }

               return infoResult;
           }
       }
       public Int64 GetPurchaseNumber(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, SqlConnection objConn, SqlTransaction objTran)
       {
           SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetPurchaseNumberByVoucher]", objConn, objTran);
           cmdSales.CommandType = CommandType.StoredProcedure;
           cmdSales.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
           cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
           cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
           return Validation.GetSafeLong(cmdSales.ExecuteScalar());
       }
       public List<VoucherDetailEL> GetPurchasesTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
       {
           List<VoucherDetailEL> list = new List<VoucherDetailEL>();
           using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetPurchasesTransactions]", objConn))
           {
               cmdVouchers.CommandType = CommandType.StoredProcedure;
               cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
               cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
               objReader = cmdVouchers.ExecuteReader();
               while (objReader.Read())
               {
                   //// Getting Purchases Voucher Header Here...
                   VoucherDetailEL oelVoucher = new VoucherDetailEL();
                   oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                   oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                   oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                   oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                   oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                   oelVoucher.BillNo = Validation.GetSafeString(objReader["BillNo"]);
                   oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                  

                   oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                   oelVoucher.EditedDateTime = Validation.GetSafeNullableDateTime(objReader["EditedDateTime"]);
                   oelVoucher.PostedDateTime = Validation.GetSafeNullableDateTime(objReader["PostedDateTime"]);
                    oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                   oelVoucher.TransactionAccountNo = Validation.GetSafeString(objReader["TransactionAccountNo"]);
                   oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                   oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                   oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                   oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                   oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                   oelVoucher.TotalDiscount = Validation.GetSafeDecimal(objReader["TotalDiscount"]);
                   oelVoucher.ExtraDiscount = Validation.GetSafeDecimal(objReader["ExtraDiscount"]);
                   oelVoucher.BillAmountAfterDiscount = Validation.GetSafeDecimal(objReader["BillAmountAfterDiscount"]);
                   oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                   oelVoucher.VAT = Validation.GetSafeLong(objReader["VAT"]);
                   oelVoucher.VATAmount = Validation.GetSafeLong(objReader["VATTotalAmount"]);
                   oelVoucher.TotalItems = Validation.GetSafeDecimal(objReader["TotalItems"]);
                   oelVoucher.TaxPercentage = Validation.GetSafeDecimal(objReader["TaxPercentage"]);
                   oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(objReader["TotalTaxAmount"]);
                   oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["TotalAmountAfterTax"]);
                   oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                   oelVoucher.SystemWeight = Validation.GetSafeDecimal(objReader["SystemWeight"]);
                   oelVoucher.ManualWeight = Validation.GetSafeDecimal(objReader["ManualWeight"]);
                   oelVoucher.AutoWeight = Validation.GetSafeDecimal(objReader["AutoWeight"]);
                   oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);

                   //// Getting Purchases VoucherDetail Here...
                   oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                   oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                   oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                   oelVoucher.AutoWeightItemIndex = Validation.GetSafeInteger(objReader["AutoWeightItemIndex"]);
                   oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                   oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                   oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                   oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                   oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                   oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                   oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                   oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                   oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                   oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                   oelVoucher.Bonus = Validation.GetSafeDecimal(objReader["BonusUnits"]);
                   oelVoucher.ItemWeight = Validation.GetSafeDecimal(objReader["ItemWeight"]);
                   oelVoucher.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                   oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                   oelVoucher.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                   oelVoucher.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                   oelVoucher.FlatDiscount = Validation.GetSafeDecimal(objReader["FlatDiscount"]);
                   oelVoucher.NetAmount = Validation.GetSafeDecimal(objReader["NetAmount"]);
                   oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);

                   list.Add(oelVoucher);
               }
           }
           return list;
       }
       public List<VoucherDetailEL> GetPurchasesTransactionsByNumber(Int64 VoucherNo, Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
       {
           List<VoucherDetailEL> list = new List<VoucherDetailEL>();
           using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetPurchasesTransactionsByNumber]", objConn))
           {
               cmdVouchers.CommandType = CommandType.StoredProcedure;
               cmdVouchers.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
               cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
               objReader = cmdVouchers.ExecuteReader();
               while (objReader.Read())
               {
                   //// Getting Purchases Voucher Header Here...
                   VoucherDetailEL oelVoucher = new VoucherDetailEL();
                   oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                   oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                   oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                   oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                   oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                   oelVoucher.BillNo = Validation.GetSafeString(objReader["BillNo"]);
                   oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                  

                   oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                   oelVoucher.EditedDateTime = Validation.GetSafeNullableDateTime(objReader["EditedDateTime"]);
                   oelVoucher.PostedDateTime = Validation.GetSafeNullableDateTime(objReader["PostedDateTime"]);
                   oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                   oelVoucher.TransactionAccountNo = Validation.GetSafeString(objReader["TransactionAccountNo"]);
                   oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                   oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                   oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                   oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                   oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                   oelVoucher.TotalDiscount = Validation.GetSafeDecimal(objReader["TotalDiscount"]);
                   oelVoucher.ExtraDiscount = Validation.GetSafeDecimal(objReader["ExtraDiscount"]);
                   oelVoucher.BillAmountAfterDiscount = Validation.GetSafeDecimal(objReader["BillAmountAfterDiscount"]);
                   oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                   oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                   oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATTotalAmount"]);
                   oelVoucher.TotalItems = Validation.GetSafeDecimal(objReader["TotalItems"]);
                   oelVoucher.TaxPercentage = Validation.GetSafeDecimal(objReader["TaxPercentage"]);
                   oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(objReader["TotalTaxAmount"]);
                   oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["TotalAmountAfterTax"]);
                   oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                   oelVoucher.SystemWeight = Validation.GetSafeDecimal(objReader["SystemWeight"]);
                   oelVoucher.ManualWeight = Validation.GetSafeDecimal(objReader["ManualWeight"]);
                   oelVoucher.AutoWeight = Validation.GetSafeDecimal(objReader["AutoWeight"]);
                   oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);

                   //// Getting Purchases VoucherDetail Here...
                   oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                   oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                   oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                   oelVoucher.AutoWeightItemIndex = Validation.GetSafeInteger(objReader["AutoWeightItemIndex"]);
                   oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                   oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                   oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                   oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                   oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                   oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                   oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                   oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                   oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                   oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                   oelVoucher.Bonus = Validation.GetSafeDecimal(objReader["BonusUnits"]);
                   oelVoucher.ItemWeight = Validation.GetSafeDecimal(objReader["ItemWeight"]);
                   oelVoucher.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                   oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                   oelVoucher.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                   oelVoucher.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                   oelVoucher.FlatDiscount = Validation.GetSafeDecimal(objReader["FlatDiscount"]);
                   oelVoucher.NetAmount = Validation.GetSafeDecimal(objReader["NetAmount"]);
                   oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);

                   list.Add(oelVoucher);
               }
           }
           return list;
       }
       public List<VoucherDetailEL> GetPOSPurchasesTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, SqlConnection objConn)
       {
           List<VoucherDetailEL> list = new List<VoucherDetailEL>();
           using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetPOSPurchasesTransactions]", objConn))
           {
               cmdVouchers.CommandType = CommandType.StoredProcedure;
               cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
               cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               objReader = cmdVouchers.ExecuteReader();
               while (objReader.Read())
               {
                   //// Getting Purchases Voucher Header Here...
                   VoucherDetailEL oelVoucher = new VoucherDetailEL();
                   oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                   oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                   oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                   oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                   oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                   oelVoucher.BillNo = Validation.GetSafeString(objReader["BillNo"]);
                   oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                   oelVoucher.FirstName = Validation.GetSafeString(objReader["PersonName"]);
                   oelVoucher.Contact = Validation.GetSafeString(objReader["PersonContact"]);
                   oelVoucher.Cnic = Validation.GetSafeString(objReader["PersonCNIC"]);
                   oelVoucher.Address = Validation.GetSafeString(objReader["PersonAddress"]);

                   oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                   oelVoucher.AccountNo = Validation.GetSafeString(objReader["SupplierAccountNo"]);
                   oelVoucher.TransactionAccountNo = Validation.GetSafeString(objReader["TransctionAccountNo"]);
                   oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                   oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                   oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                   oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                   oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                   oelVoucher.Discount = Validation.GetSafeDecimal(objReader["TotalDiscount"]);
                   oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                   oelVoucher.VAT = Validation.GetSafeLong(objReader["VAT"]);
                   oelVoucher.VATAmount = Validation.GetSafeLong(objReader["VATTotalAmount"]);
                   oelVoucher.TotalItems = Validation.GetSafeDecimal(objReader["TotalItems"]);
                   oelVoucher.TaxPercentage = Validation.GetSafeDecimal(objReader["TaxPercentage"]);
                   oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(objReader["TotalTaxAmount"]);
                   oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["TotalAmountAfterTax"]);
                   oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                   oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);

                   //// Getting Purchases VoucherDetail Here...
                   oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                   oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                   oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                   oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                   oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                   oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                   oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                   oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                   oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                   oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                   oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                   oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                   oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                   oelVoucher.Bonus = Validation.GetSafeDecimal(objReader["BonusUnits"]);
                   oelVoucher.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                   oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                   oelVoucher.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                   oelVoucher.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                   oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);

                   list.Add(oelVoucher);
               }
           }
           return list;
       }
       public List<VoucherDetailEL> GetPOSPurchasesTransactionsByNumber(Int64 VoucherNo, Int64 IdProject, Int64 BookNo, SqlConnection objConn)
       {
           List<VoucherDetailEL> list = new List<VoucherDetailEL>();
           using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetPOSPurchasesTransactionsByNumber]", objConn))
           {
               cmdVouchers.CommandType = CommandType.StoredProcedure;
               cmdVouchers.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
               cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               objReader = cmdVouchers.ExecuteReader();
               while (objReader.Read())
               {
                   //// Getting Purchases Voucher Header Here...
                   VoucherDetailEL oelVoucher = new VoucherDetailEL();
                   oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                   oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                   oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                   oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                   oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                   oelVoucher.BillNo = Validation.GetSafeString(objReader["BillNo"]);
                   oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                   oelVoucher.FirstName = Validation.GetSafeString(objReader["PersonName"]);
                   oelVoucher.Contact = Validation.GetSafeString(objReader["PersonContact"]);
                   oelVoucher.Cnic = Validation.GetSafeString(objReader["PersonCNIC"]);
                   oelVoucher.Address = Validation.GetSafeString(objReader["PersonAddress"]);

                   oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                   oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                   oelVoucher.TransactionAccountNo = Validation.GetSafeString(objReader["TransactionAccountNo"]);
                   oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                   oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                   oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                   oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                   oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                   oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                   oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                   oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATTotalAmount"]);
                   oelVoucher.TotalItems = Validation.GetSafeDecimal(objReader["TotalItems"]);
                   oelVoucher.TaxPercentage = Validation.GetSafeDecimal(objReader["TaxPercentage"]);
                   oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(objReader["TotalTaxAmount"]);
                   oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["TotalAmountAfterTax"]);
                   oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                   oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);

                   //// Getting Purchases VoucherDetail Here...
                   oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                   oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                   oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                   oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                   oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                   oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                   oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                   oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                   oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                   oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                   oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                   oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                   oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                   oelVoucher.Bonus = Validation.GetSafeDecimal(objReader["BonusUnits"]);
                   oelVoucher.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                   oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                   oelVoucher.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                   oelVoucher.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                   oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);

                   list.Add(oelVoucher);
               }
           }
           return list;
       }
       public List<VoucherDetailEL> GetPurchasesSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
       {
           List<VoucherDetailEL> list = new List<VoucherDetailEL>();
           using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetPurchasesSubTransactions]", objConn))
           {
               cmdVouchers.CommandType = CommandType.StoredProcedure;
               cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
               cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
               objReader = cmdVouchers.ExecuteReader();
               while (objReader.Read())
               {
                   VoucherDetailEL oelVoucher = new VoucherDetailEL();

                   //oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                   //oelVoucher.VoucherNo = Convert.ToInt64(objReader["VoucherNo"]);
                   //oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);

                   //oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                   //oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                   //oelVoucher.IsNetPurchases = Convert.ToBoolean(objReader["IsNetPurchases"]);
                   //oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                   //oelVoucher.TotalAmount = Convert.ToInt64(objReader["TotalAmount"]);

                   oelVoucher.IdTransactionDetail = Validation.GetSafeLong(objReader["TransactionDetail_Id"]);
                   oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                   oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                   oelVoucher.Narration = Validation.GetSafeString(objReader["Narration"]);
                   oelVoucher.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                   oelVoucher.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                   oelVoucher.TrackNumber = Validation.GetSafeInteger(objReader["TrackNumber"]);
                   oelVoucher.CreatedDateTime = Validation.GetSafeNullableDateTime(objReader["Created_DateTime"]);


                   list.Add(oelVoucher);
               }
           }
           return list;
       }
       public bool DeletePurchasesByVoucher(Int64 IdVoucher, Int64 IdProject, SqlConnection objConn)
       {
           using (SqlTransaction objTran = objConn.BeginTransaction())
           {
               try
               {
                   SqlCommand cmdDeletePurchases = new SqlCommand("[Transactions].[Proc_DeletePurchasesByVoucher]", objConn);
                   cmdDeletePurchases.CommandType = CommandType.StoredProcedure;
                   cmdDeletePurchases.Transaction = objTran;
                   cmdDeletePurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                   cmdDeletePurchases.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                   cmdDeletePurchases.ExecuteNonQuery();

                   objTran.Commit();
               }
               catch (Exception ex)
               {
                   objTran.Rollback();
                   throw ex;
               }
           }
           return true;
       }

       #endregion
       #region Purchases Return Methods
       public Int64 GetMaxPurchaseReturnNumber(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
       {
           using (SqlCommand cmdPurchasesReturn = new SqlCommand("[Transactions].[Proc_GetMaxPurchaseReturnNumber]", objConn))
           {
               cmdPurchasesReturn.CommandType = CommandType.StoredProcedure;
               cmdPurchasesReturn.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdPurchasesReturn.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               //cmdPurchasesReturn.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
               return Validation.GetSafeLong(cmdPurchasesReturn.ExecuteScalar());
           }
       }       
       public EntityoperationInfo InsertPurchasesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseCollection
                                                        ,List<VoucherDetailEL> oelPurchaseTransactionsCollection, SqlConnection objConn)
       {
           lock (this)
           {
               EntityoperationInfo infoResult = new EntityoperationInfo();
               SqlTransaction objTran = null;
               SqlCommand cmdPurchaseHead = new SqlCommand("[Transactions].[Proc_CreatePurchaseReturnHead]", objConn);

               try
               {
                   objTran = objConn.BeginTransaction();
                   cmdPurchaseHead.Transaction = objTran;
                   cmdPurchaseHead.CommandType = CommandType.StoredProcedure;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdEditedUser", DbType.Int64)).Value = oelVoucher.EditedByUserId;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdPostedUser", DbType.Int64)).Value = oelVoucher.PostedByUserId;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@SheetNo", DbType.String)).Value = oelVoucher.SheetNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelVoucher.BookNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BiltyNo", DbType.String)).Value = oelVoucher.BiltyNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@EditedDateTime", DbType.DateTime)).Value = oelVoucher.EditedDateTime;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@PostedDateTime", DbType.DateTime)).Value = oelVoucher.PostedDateTime;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TransactionAccountNo", DbType.String)).Value = oelVoucher.TransactionAccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BillNo", DbType.String)).Value = oelVoucher.BillNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.Discription;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BillAmount", DbType.Decimal)).Value = oelVoucher.BillAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalFreight", DbType.Decimal)).Value = oelVoucher.TotalFreight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VAT", DbType.Decimal)).Value = oelVoucher.VAT;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VATTotalAmount", DbType.Decimal)).Value = oelVoucher.VATAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalItems", DbType.Decimal)).Value = oelVoucher.TotalItems;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TaxPercentage", DbType.Decimal)).Value = oelVoucher.TaxPercentage;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalTaxAmount", DbType.Decimal)).Value = oelVoucher.TotalTaxAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdStockAdjustmentType", DbType.Int64)).Value = oelVoucher.IdStockAdjustmentType;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IsNetTransaction", DbType.Boolean)).Value = oelVoucher.IsNetTransaction;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IsImportTransaction", DbType.Boolean)).Value = oelVoucher.IsImportTransaction;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@SystemWeight", DbType.Decimal)).Value = oelVoucher.SystemWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@ManualWeight", DbType.Decimal)).Value = oelVoucher.ManualWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@AutoWeight", DbType.Decimal)).Value = oelVoucher.AutoWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                   Identity = Validation.GetSafeLong(cmdPurchaseHead.ExecuteScalar());

                   // Insert Purchase Collection...
                   Pdal.InsertPurchaseReturnDetail(oelPurchaseCollection, Identity, objConn, objTran);

                   infoResult.VoucherNo = GetPurchaseReturnNumber(Identity.Value, oelVoucher.IdProject.Value, oelVoucher.BookNo, objConn, objTran);

                   Pdal.InsertPurchaseTransactionsDetail(oelPurchaseTransactionsCollection, Identity, infoResult.VoucherNo.ToString(), objConn, objTran);

                                      
                   objTran.Commit();
                   infoResult.IntID = Identity.Value;
                   infoResult.IsSuccess = true;
               }
               catch (Exception ex)
               {
                   objTran.Rollback();
                   throw ex;
               }

               return infoResult;
           }
        
       }    
       public EntityoperationInfo UpdatePurchasesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseCollection,
                                                        List<VoucherDetailEL> oelPurchaseTransactionsCollection, SqlConnection objConn)
       {
           lock (this)
           {
               EntityoperationInfo infoResult = new EntityoperationInfo();
               SqlTransaction objTran = null;
               SqlCommand cmdPurchaseHead = new SqlCommand("[Transactions].[Proc_UpdatePurchaseReturnHead]", objConn);
               try
               {
                   objTran = objConn.BeginTransaction();

                   cmdPurchaseHead.Transaction = objTran;
                   cmdPurchaseHead.CommandType = CommandType.StoredProcedure;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdEditedUser", DbType.Int64)).Value = oelVoucher.EditedByUserId;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdPostedUser", DbType.Int64)).Value = oelVoucher.PostedByUserId;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@SheetNo", DbType.String)).Value = oelVoucher.SheetNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelVoucher.BookNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BiltyNo", DbType.String)).Value = oelVoucher.BiltyNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@EditedDateTime", DbType.DateTime)).Value = oelVoucher.EditedDateTime;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@PostedDateTime", DbType.DateTime)).Value = oelVoucher.PostedDateTime;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TransactionAccountNo", DbType.String)).Value = oelVoucher.TransactionAccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BillNo", DbType.String)).Value = oelVoucher.BillNo;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.Discription;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@BillAmount", DbType.Decimal)).Value = oelVoucher.BillAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalFreight", DbType.Decimal)).Value = oelVoucher.TotalFreight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VAT", DbType.Decimal)).Value = oelVoucher.VAT;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@VATTotalAmount", DbType.Decimal)).Value = oelVoucher.VATAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalItems", DbType.Decimal)).Value = oelVoucher.TotalItems;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TaxPercentage", DbType.Decimal)).Value = oelVoucher.TaxPercentage;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@TotalTaxAmount", DbType.Decimal)).Value = oelVoucher.TotalTaxAmount;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IdStockAdjustmentType", DbType.Int64)).Value = oelVoucher.IdStockAdjustmentType;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IsNetPurchasesReturn", DbType.Boolean)).Value = oelVoucher.IsNetTransaction;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@IsImportPurchase", DbType.Boolean)).Value = oelVoucher.IsImport;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@SystemWeight", DbType.Decimal)).Value = oelVoucher.SystemWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@ManualWeight", DbType.Decimal)).Value = oelVoucher.ManualWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@AutoWeight", DbType.Decimal)).Value = oelVoucher.AutoWeight;
                   cmdPurchaseHead.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;


                   Identity = Validation.GetSafeLong(cmdPurchaseHead.ExecuteScalar());

                   // Insert Purchase Collection...
                   Pdal.UpdatePurchaseReturnDetail(oelPurchaseCollection, objConn, objTran);


                   // Insert Purchase Transactions...

                   Pdal.UpdatePurchaseTransactionsDetail(oelPurchaseTransactionsCollection, objConn, objTran);

                   //Tdal.UpdateTransactions(oelTransactionsCollection, objConn, objTran);
                   objTran.Commit();
                   infoResult.IsSuccess = true;
               }
               catch (Exception ex)
               {
                   objTran.Rollback();
                   throw ex;
               }
               return infoResult;   
           }         
       }
       public Int64 GetPurchaseReturnNumber(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, SqlConnection objConn, SqlTransaction objTran)
       {
           SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetPurchaseReturnNumberByVoucher]", objConn, objTran);
           cmdSales.CommandType = CommandType.StoredProcedure;
           cmdSales.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
           cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
           cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
           return Validation.GetSafeLong(cmdSales.ExecuteScalar());
       }
       public List<VoucherDetailEL> GetPurchasesReturnTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
       {
           List<VoucherDetailEL> list = new List<VoucherDetailEL>();
           using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetPurchasesReturnTransactions]", objConn))
           {
               cmdVouchers.CommandType = CommandType.StoredProcedure;
               cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
               cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
               objReader = cmdVouchers.ExecuteReader();
               while (objReader.Read())
               {
                   VoucherDetailEL oelVoucher = new VoucherDetailEL();
                   oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                   oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                   oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                   oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                   oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                   oelVoucher.BillNo = Validation.GetSafeString(objReader["BillNo"]);
                   oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                   //oelVoucher.FirstName = Validation.GetSafeString(objReader["PersonName"]);
                   //oelVoucher.Contact = Validation.GetSafeString(objReader["PersonContact"]);
                   //oelVoucher.Cnic = Validation.GetSafeString(objReader["PersonCNIC"]);
                   //oelVoucher.Address = Validation.GetSafeString(objReader["PersonAddress"]);

                   oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                   oelVoucher.EditedDateTime = Validation.GetSafeNullableDateTime(objReader["EditedDateTime"]);
                   oelVoucher.PostedDateTime = Validation.GetSafeNullableDateTime(objReader["PostedDateTime"]);
                   oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                   oelVoucher.TransactionAccountNo = Validation.GetSafeString(objReader["TransactionAccountNo"]);
                   oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                   oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                   oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                   oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                   oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                   oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                   oelVoucher.VAT = Validation.GetSafeLong(objReader["VAT"]);
                   oelVoucher.VATAmount = Validation.GetSafeLong(objReader["VATTotalAmount"]);
                   oelVoucher.TotalItems = Validation.GetSafeDecimal(objReader["TotalItems"]);
                   oelVoucher.TaxPercentage = Validation.GetSafeDecimal(objReader["TaxPercentage"]);
                   oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(objReader["TotalTaxAmount"]);
                   oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["TotalAmountAfterTax"]);
                   oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                   oelVoucher.IdStockAdjustmentType = Validation.GetSafeLong(objReader["StockAdjustmentType_Id"]);
                   oelVoucher.SystemWeight = Validation.GetSafeDecimal(objReader["SystemWeight"]);
                   oelVoucher.ManualWeight = Validation.GetSafeDecimal(objReader["ManualWeight"]);
                   oelVoucher.AutoWeight = Validation.GetSafeDecimal(objReader["AutoWeight"]);
                   oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);

                   //// Getting Purchases VoucherDetail Here...
                   oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                   oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                   oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                   oelVoucher.AutoWeightItemIndex = Validation.GetSafeInteger(objReader["AutoWeightItemIndex"]);
                   oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                   oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                   oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                   oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                   oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                   oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                   oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                   oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                   oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                   oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                   oelVoucher.ItemWeight = Validation.GetSafeDecimal(objReader["ItemWeight"]);
                   oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                   oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                   oelVoucher.Discount = Validation.GetSafeDecimal(objReader["Disc"]);
                   oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);


                   list.Add(oelVoucher);
               }
           }
           return list;
       }
       public List<VoucherDetailEL> GetPurchasesReturnTransactionsByNumber(Int64 VoucherNo, Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
       {
           List<VoucherDetailEL> list = new List<VoucherDetailEL>();
           using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetPurchasesReturnTransactionsByNumber]", objConn))
           {
               cmdVouchers.CommandType = CommandType.StoredProcedure;
               cmdVouchers.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
               cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
               objReader = cmdVouchers.ExecuteReader();
               while (objReader.Read())
               {
                   VoucherDetailEL oelVoucher = new VoucherDetailEL();
                   oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                   oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                   oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                   oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                   oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                   oelVoucher.BillNo = Validation.GetSafeString(objReader["BillNo"]);
                   oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                   //oelVoucher.FirstName = Validation.GetSafeString(objReader["PersonName"]);
                   //oelVoucher.Contact = Validation.GetSafeString(objReader["PersonContact"]);
                   //oelVoucher.Cnic = Validation.GetSafeString(objReader["PersonCNIC"]);
                   //oelVoucher.Address = Validation.GetSafeString(objReader["PersonAddress"]);

                   oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                   oelVoucher.EditedDateTime = Validation.GetSafeNullableDateTime(objReader["EditedDateTime"]);
                   oelVoucher.PostedDateTime = Validation.GetSafeNullableDateTime(objReader["PostedDateTime"]);
                   oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                   oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                   oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                   oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                   oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                   oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                   oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                   oelVoucher.VAT = Validation.GetSafeLong(objReader["VAT"]);
                   oelVoucher.VATAmount = Validation.GetSafeLong(objReader["VATTotalAmount"]);
                   oelVoucher.TotalItems = Validation.GetSafeDecimal(objReader["TotalItems"]);
                   oelVoucher.TaxPercentage = Validation.GetSafeDecimal(objReader["TaxPercentage"]);
                   oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(objReader["TotalTaxAmount"]);
                   oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["TotalAmountAfterTax"]);
                   oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                   oelVoucher.IdStockAdjustmentType = Validation.GetSafeLong(objReader["StockAdjustmentType_Id"]);
                   oelVoucher.SystemWeight = Validation.GetSafeDecimal(objReader["SystemWeight"]);
                   oelVoucher.ManualWeight = Validation.GetSafeDecimal(objReader["ManualWeight"]);
                   oelVoucher.AutoWeight = Validation.GetSafeDecimal(objReader["AutoWeight"]);
                   oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);

                   //// Getting Purchases VoucherDetail Here...
                   oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                   oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                   oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                   oelVoucher.AutoWeightItemIndex = Validation.GetSafeInteger(objReader["AutoWeightItemIndex"]);
                   oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                   oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                   oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                   oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                   oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                   oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                   oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                   oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                   oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                   oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                   oelVoucher.ItemWeight = Validation.GetSafeDecimal(objReader["ItemWeight"]);
                   oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                   oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                   oelVoucher.Discount = Validation.GetSafeDecimal(objReader["Disc"]);
                   oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);


                   list.Add(oelVoucher);
               }
           }
           return list;
       }
       public List<VoucherDetailEL> GetPurchasesReturnSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
       {
           List<VoucherDetailEL> list = new List<VoucherDetailEL>();
           using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetPurchasesReturnSubTransactions]", objConn))
           {
               cmdVouchers.CommandType = CommandType.StoredProcedure;
               cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
               cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
               objReader = cmdVouchers.ExecuteReader();
               while (objReader.Read())
               {
                   VoucherDetailEL oelVoucher = new VoucherDetailEL();

                   oelVoucher.IdTransactionDetail = Validation.GetSafeLong(objReader["TransactionDetail_Id"]);
                   oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                   oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                   oelVoucher.Narration = Validation.GetSafeString(objReader["Narration"]);
                   oelVoucher.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                   oelVoucher.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                   oelVoucher.TrackNumber = Validation.GetSafeInteger(objReader["TrackNumber"]);
                   oelVoucher.CreatedDateTime = Validation.GetSafeNullableDateTime(objReader["Created_DateTime"]);


                   list.Add(oelVoucher);
               }
           }
           return list;
       }       
       public bool DeletePurchasesReturnByVoucher(Int64 IdVoucher, Int64 IdProject, SqlConnection objConn)
       {
           using (SqlTransaction objTran = objConn.BeginTransaction())
           {
               try
               {
                   SqlCommand cmdDeletePurchases = new SqlCommand("[Transactions].[Proc_DeletePurchasesReturnByVoucher]", objConn);
                   cmdDeletePurchases.CommandType = CommandType.StoredProcedure;
                   cmdDeletePurchases.Transaction = objTran;
                   cmdDeletePurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                   cmdDeletePurchases.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                   cmdDeletePurchases.ExecuteNonQuery();

                   objTran.Commit();
               }
               catch (Exception ex)
               {
                   objTran.Rollback();
                   throw ex;
               }
           }
           return true;
       }
       public bool UpdateStockItems(List<TransactionsEL> oelItemQuatityCollection,string ActionType, SqlConnection objConn)
       {
           using (SqlTransaction objTran = objConn.BeginTransaction())
           {
               try
               {
                   SqlCommand cmdUpdateQuatity = new SqlCommand("sp_updateItemsQty", objConn);
                   cmdUpdateQuatity.CommandType = CommandType.StoredProcedure;
                   cmdUpdateQuatity.CommandTimeout = 0;
                   cmdUpdateQuatity.Transaction = objTran;

                   for (int i = 0; i < oelItemQuatityCollection.Count; i++)
                   {
                       cmdUpdateQuatity.Parameters.Add("@ItemNo", SqlDbType.NVarChar).Value = oelItemQuatityCollection[i].AccountNo;
                       cmdUpdateQuatity.Parameters.Add("@Quantity", SqlDbType.Int).Value = oelItemQuatityCollection[i].Qty;
                       cmdUpdateQuatity.Parameters.Add("@ActionType", SqlDbType.NVarChar).Value = ActionType;
                       cmdUpdateQuatity.ExecuteNonQuery();
                       cmdUpdateQuatity.Parameters.Clear();
                   }
               }
               catch (Exception ex)
               {
                   objTran.Rollback();
                   throw ex;
               }
               objTran.Commit();
           }
           return true;
       }      
       #endregion
   }
}
