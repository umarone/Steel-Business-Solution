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
    public class PurchaseDetailDAL
    {
        IDataReader objReader;
        public static bool InsertPurchaseDetail(PurchaseDetailEL oelPurchaseDetail, SqlConnection oConn)
        {
            using (SqlCommand cmdPurchaseDetail = new SqlCommand("sp_insertPurchaseDetail", oConn))
            {
                cmdPurchaseDetail.CommandType = CommandType.StoredProcedure;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelPurchaseDetail.VoucherNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelPurchaseDetail.Seq;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ItemNo", DbType.String)).Value = oelPurchaseDetail.ItemNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ItemName", DbType.String)).Value = oelPurchaseDetail.ItemName;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelPurchaseDetail.BatchNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelPurchaseDetail.Discription;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Qty", DbType.Decimal)).Value = oelPurchaseDetail.Units;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelPurchaseDetail.UnitPrice;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelPurchaseDetail.Amount;
                cmdPurchaseDetail.ExecuteNonQuery();
                cmdPurchaseDetail.Parameters.Clear();
                return true;

            }
        }
        public bool InsertPurchaseDetail(List<VoucherDetailEL> oelPurchaseCollection, Int64? Identity, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdPurchaseDetail = new SqlCommand("[Transactions].[Proc_CreatePurchaseDetail]", objConn);
            cmdPurchaseDetail.CommandType = CommandType.StoredProcedure;
            cmdPurchaseDetail.Transaction = objTran;
            for (int i = 0; i < oelPurchaseCollection.Count; i++)
            {
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelPurchaseCollection[i].IdVoucherDetail;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = Identity;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelPurchaseCollection[i].SeqNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelPurchaseCollection[i].IdItem;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelPurchaseCollection[i].Discription;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = oelPurchaseCollection[i].TotalCartons;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelPurchaseCollection[i].BatchNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = oelPurchaseCollection[i].Expiry;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = oelPurchaseCollection[i].EngineNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ChasisNo", DbType.String)).Value = oelPurchaseCollection[i].ChasisNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelPurchaseCollection[i].VehicleNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = oelPurchaseCollection[i].FirstIMEI;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = oelPurchaseCollection[i].SecondIMEI;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = oelPurchaseCollection[i].ColorCode;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelPurchaseCollection[i].Units;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@BonusUnits", DbType.Int64)).Value = oelPurchaseCollection[i].Bonus;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@RemainingUnits", DbType.Decimal)).Value = oelPurchaseCollection[i].RemainingUnits;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ItemWeight", DbType.Decimal)).Value = oelPurchaseCollection[i].ItemWeight;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelPurchaseCollection[i].UnitPrice;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelPurchaseCollection[i].Amount;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@DiscPercentage", DbType.Decimal)).Value = oelPurchaseCollection[i].Discount;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@DiscountAmount", DbType.Decimal)).Value = oelPurchaseCollection[i].DiscountAmount;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@FlatDiscount", DbType.Decimal)).Value = oelPurchaseCollection[i].FlatDiscount;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@NetAmount", DbType.Decimal)).Value = oelPurchaseCollection[i].NetAmount;
                cmdPurchaseDetail.ExecuteNonQuery();
                cmdPurchaseDetail.Parameters.Clear();

            }
            return true;
        }
        public bool InsertPurchaseReturnDetail(List<VoucherDetailEL> oelPurchaseCollection, Int64? Identity, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdPurchaseDetail = new SqlCommand("[Transactions].[Proc_CreatePurchaseReturnDetail]", objConn);
            cmdPurchaseDetail.CommandType = CommandType.StoredProcedure;
            cmdPurchaseDetail.Transaction = objTran;
            for (int i = 0; i < oelPurchaseCollection.Count; i++)
            {
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelPurchaseCollection[i].IdVoucherDetail;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = Identity;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelPurchaseCollection[i].SeqNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelPurchaseCollection[i].IdItem;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelPurchaseCollection[i].Discription;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = oelPurchaseCollection[i].TotalCartons;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelPurchaseCollection[i].BatchNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = oelPurchaseCollection[i].Expiry;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = oelPurchaseCollection[i].EngineNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ChasisNo", DbType.String)).Value = oelPurchaseCollection[i].ChasisNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelPurchaseCollection[i].VehicleNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = oelPurchaseCollection[i].FirstIMEI;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = oelPurchaseCollection[i].SecondIMEI;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = oelPurchaseCollection[i].ColorCode;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelPurchaseCollection[i].Units;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ItemWeight", DbType.Decimal)).Value = oelPurchaseCollection[i].ItemWeight;
                //cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Bonus", DbType.Int64)).Value = oelPurchaseCollection[i].Bonus;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelPurchaseCollection[i].UnitPrice;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Disc", DbType.Decimal)).Value = oelPurchaseCollection[i].Discount;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelPurchaseCollection[i].Amount;
                cmdPurchaseDetail.ExecuteNonQuery();
                cmdPurchaseDetail.Parameters.Clear();

            }
            return true;
        }
        public static bool UpdatePurchaseDetail(PurchaseDetailEL oelPurchaseDetail, SqlConnection oConn)
        {
            using (SqlCommand cmdPurchaseDetail = new SqlCommand("sp_updatePurchaseDetail", oConn))
            {
                cmdPurchaseDetail.CommandType = CommandType.StoredProcedure;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelPurchaseDetail.VoucherNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelPurchaseDetail.Seq;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ItemNo", DbType.String)).Value = oelPurchaseDetail.ItemNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ItemName", DbType.String)).Value = oelPurchaseDetail.ItemName;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelPurchaseDetail.Discription;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelPurchaseDetail.BatchNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Qty", DbType.Decimal)).Value = oelPurchaseDetail.Units;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelPurchaseDetail.UnitPrice;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelPurchaseDetail.Amount;
                cmdPurchaseDetail.ExecuteNonQuery();
                cmdPurchaseDetail.Parameters.Clear();
                return true;

            }
        }
        public bool UpdatePurchaseDetail(List<VoucherDetailEL> oelPurchaseCollection, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdPurchaseDetail = new SqlCommand();
            cmdPurchaseDetail.CommandType = CommandType.StoredProcedure;
            cmdPurchaseDetail.Connection = objConn;
            cmdPurchaseDetail.Transaction = objTran;
            for (int i = 0; i < oelPurchaseCollection.Count; i++)
            {
                if (oelPurchaseCollection[i].IsNew)
                {
                    cmdPurchaseDetail.CommandText = "[Transactions].[Proc_CreatePurchaseDetail]";
                }
                else
                {
                    cmdPurchaseDetail.CommandText = "[Transactions].[Proc_UpdatePurchaseDetail]";
                }
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelPurchaseCollection[i].IdVoucherDetail;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelPurchaseCollection[i].IdVoucher;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelPurchaseCollection[i].SeqNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelPurchaseCollection[i].IdItem;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelPurchaseCollection[i].Discription;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = oelPurchaseCollection[i].TotalCartons;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelPurchaseCollection[i].BatchNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = oelPurchaseCollection[i].Expiry;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = oelPurchaseCollection[i].EngineNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ChasisNo", DbType.String)).Value = oelPurchaseCollection[i].ChasisNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelPurchaseCollection[i].VehicleNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = oelPurchaseCollection[i].FirstIMEI;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = oelPurchaseCollection[i].SecondIMEI;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = oelPurchaseCollection[i].ColorCode;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelPurchaseCollection[i].Units;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@BonusUnits", DbType.Decimal)).Value = oelPurchaseCollection[i].Bonus;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@RemainingUnits", DbType.Int64)).Value = oelPurchaseCollection[i].RemainingUnits;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ItemWeight", DbType.Decimal)).Value = oelPurchaseCollection[i].ItemWeight;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelPurchaseCollection[i].UnitPrice;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelPurchaseCollection[i].Amount;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@DiscPercentage", DbType.Decimal)).Value = oelPurchaseCollection[i].Discount;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@DiscountAmount", DbType.Decimal)).Value = oelPurchaseCollection[i].DiscountAmount;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@FlatDiscount", DbType.Decimal)).Value = oelPurchaseCollection[i].FlatDiscount;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@NetAmount", DbType.Decimal)).Value = oelPurchaseCollection[i].NetAmount;
                cmdPurchaseDetail.ExecuteNonQuery();
                cmdPurchaseDetail.Parameters.Clear();
            }
            return true;
        }      
        public bool UpdatePurchaseReturnDetail(List<VoucherDetailEL> oelPurchaseCollection, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdPurchaseDetail = new SqlCommand();
            cmdPurchaseDetail.CommandType = CommandType.StoredProcedure;
            cmdPurchaseDetail.Connection = objConn;
            cmdPurchaseDetail.Transaction = objTran;
            for (int i = 0; i < oelPurchaseCollection.Count; i++)
            {
                if (oelPurchaseCollection[i].IsNew)
                {
                    cmdPurchaseDetail.CommandText = "[Transactions].[Proc_CreatePurchaseReturnDetail]";
                }
                else
                {
                    cmdPurchaseDetail.CommandText = "[Transactions].[Proc_UpdatePurchaseReturnDetail]";
                }
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelPurchaseCollection[i].IdVoucherDetail;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelPurchaseCollection[i].IdVoucher;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelPurchaseCollection[i].SeqNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelPurchaseCollection[i].IdItem;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelPurchaseCollection[i].Discription;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = oelPurchaseCollection[i].TotalCartons;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelPurchaseCollection[i].BatchNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = oelPurchaseCollection[i].Expiry;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = oelPurchaseCollection[i].EngineNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ChasisNo", DbType.String)).Value = oelPurchaseCollection[i].ChasisNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelPurchaseCollection[i].VehicleNo;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = oelPurchaseCollection[i].FirstIMEI;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = oelPurchaseCollection[i].SecondIMEI;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = oelPurchaseCollection[i].ColorCode;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelPurchaseCollection[i].Units;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@ItemWeight", DbType.Decimal)).Value = oelPurchaseCollection[i].ItemWeight;
                //cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Bonus", DbType.Int64)).Value = oelPurchaseCollection[i].Bonus;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelPurchaseCollection[i].UnitPrice;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Disc", DbType.Decimal)).Value = oelPurchaseCollection[i].Discount;
                cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelPurchaseCollection[i].Amount;
                cmdPurchaseDetail.ExecuteNonQuery();
                cmdPurchaseDetail.Parameters.Clear();
            }
            return true;
        }
        public bool InsertPurchaseTransactionsDetail(List<VoucherDetailEL> oelDetailCollection, Int64? Identity, string LedgerVoucherNo, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdVoucherDetail = new SqlCommand("[Transactions].[Proc_CreateTransactionsDetails]", objConn);
            cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
            cmdVoucherDetail.CommandTimeout = 0;
            cmdVoucherDetail.Transaction = objTran;
            for (int i = 0; i < oelDetailCollection.Count; i++)
            {
                cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdTransactionDetail", DbType.Int64)).Value = oelDetailCollection[i].IdTransactionDetail;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = Identity;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelDetailCollection[i].IdProject;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelDetailCollection[i].BookNo;
                if (oelDetailCollection[i].VoucherType == "P" && oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "NPU" + "-" + LedgerVoucherNo;
                }
                else if (oelDetailCollection[i].VoucherType == "P" && !oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "CPU" + "-" + LedgerVoucherNo;
                }
                else if (oelDetailCollection[i].VoucherType == "PR" && oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "NPR" + "-" + LedgerVoucherNo;
                }
                else if (oelDetailCollection[i].VoucherType == "PR" && !oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "CPR" + "-" + LedgerVoucherNo;
                }
                //cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = oelDetailCollection[i].VoucherType + "-" + LedgerVoucherNo.ToString();
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = LedgerVoucherNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelDetailCollection[i].AccountNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelDetailCollection[i].SeqNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Narration", DbType.String)).Value = oelDetailCollection[i].Description;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelDetailCollection[i].Debit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelDetailCollection[i].Credit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TransactionMode", DbType.String)).Value = oelDetailCollection[i].TransactionMode;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TrackNumber", DbType.Decimal)).Value = oelDetailCollection[i].TrackNumber;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@VType", DbType.Decimal)).Value = oelDetailCollection[i].VoucherType;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelDetailCollection[i].CreatedDateTime;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Posted", DbType.DateTime)).Value = oelDetailCollection[i].Posted;
                cmdVoucherDetail.ExecuteNonQuery();
                cmdVoucherDetail.Parameters.Clear();
            }
            return true;
        }
        public bool UpdatePurchaseTransactionsDetail(List<VoucherDetailEL> oelDetailCollection, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdVoucherDetail = new SqlCommand();
            cmdVoucherDetail.Connection = objConn;
            cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
            cmdVoucherDetail.CommandTimeout = 0;
            cmdVoucherDetail.Transaction = objTran;
            for (int i = 0; i < oelDetailCollection.Count; i++)
            {
                if (oelDetailCollection[i].IsNew)
                {
                    cmdVoucherDetail.CommandText = "[Transactions].[Proc_CreateTransactionsDetails]";
                }
                else
                {
                    cmdVoucherDetail.CommandText = "[Transactions].[Proc_UpdateTransactionsDetails]";
                }
                cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdTransactionDetail", DbType.Int64)).Value = oelDetailCollection[i].IdTransactionDetail;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelDetailCollection[i].IdVoucher;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelDetailCollection[i].IdProject;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelDetailCollection[i].BookNo;
                if (oelDetailCollection[i].VoucherType == "P" && oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "NPU" + "-" + oelDetailCollection[i].VoucherNo.ToString();
                }
                else if (oelDetailCollection[i].VoucherType == "P" && !oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "CPU" + "-" + oelDetailCollection[i].VoucherNo.ToString();
                }
                else if (oelDetailCollection[i].VoucherType == "PR" && oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "NPR" + "-" + oelDetailCollection[i].VoucherNo.ToString();
                }
                else if (oelDetailCollection[i].VoucherType == "PR" && !oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "CPR" + "-" + oelDetailCollection[i].VoucherNo.ToString();
                }
                //cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = oelDetailCollection[i].VoucherType + "-" + oelDetailCollection[i].VoucherNo.ToString();
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelDetailCollection[i].VoucherNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelDetailCollection[i].AccountNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelDetailCollection[i].SeqNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Narration", DbType.String)).Value = oelDetailCollection[i].Description;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelDetailCollection[i].Debit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelDetailCollection[i].Credit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TransactionMode", DbType.String)).Value = oelDetailCollection[i].TransactionMode;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TrackNumber", DbType.Decimal)).Value = oelDetailCollection[i].TrackNumber;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@VType", DbType.Decimal)).Value = oelDetailCollection[i].VoucherType;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelDetailCollection[i].CreatedDateTime;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Posted", DbType.DateTime)).Value = oelDetailCollection[i].Posted;
                cmdVoucherDetail.ExecuteNonQuery();
                cmdVoucherDetail.Parameters.Clear();
            }
            return true;
        }
        public List<PurchaseDetailEL> GetSupplierPurchase(string AccountNo, Int64 IdProject, SqlConnection objConn)
        {
            List<PurchaseDetailEL> list = new List<PurchaseDetailEL>();
            using (SqlCommand cmdSupplierPurchase = new SqlCommand("[Transactions].[Proc_GetSupplierPurchase]", objConn))
            {
                cmdSupplierPurchase.CommandType = CommandType.StoredProcedure;
                cmdSupplierPurchase.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSupplierPurchase.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdSupplierPurchase.ExecuteReader();
                while (objReader.Read())
                {
                    PurchaseDetailEL oelPurchaseDetail = new PurchaseDetailEL();
                    oelPurchaseDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelPurchaseDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelPurchaseDetail.Qty = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelPurchaseDetail.Amount = Validation.GetSafeDecimal(objReader["TotalPurchaseAmount"]);
                    oelPurchaseDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelPurchaseDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelPurchaseDetail.NetAmount = Validation.GetSafeDecimal(objReader["NetAmount"]);
                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<PurchaseDetailEL> GetSupplierPurchaseByDate(string AccountNo, DateTime StartDate, DateTime EndDate, Int64 IdProject, SqlConnection objConn)
        {
            List<PurchaseDetailEL> list = new List<PurchaseDetailEL>();
            using (SqlCommand cmdSupplierPurchase = new SqlCommand("[Transactions].[Proc_GetSupplierPurchaseByDate]", objConn))
            {
                cmdSupplierPurchase.CommandType = CommandType.StoredProcedure;
                cmdSupplierPurchase.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSupplierPurchase.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdSupplierPurchase.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSupplierPurchase.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSupplierPurchase.ExecuteReader();
                while (objReader.Read())
                {
                    PurchaseDetailEL oelPurchaseDetail = new PurchaseDetailEL();
                    oelPurchaseDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelPurchaseDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelPurchaseDetail.Qty = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelPurchaseDetail.Amount = Validation.GetSafeDecimal(objReader["TotalPurchaseAmount"]);
                    oelPurchaseDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelPurchaseDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelPurchaseDetail.NetAmount = Validation.GetSafeDecimal(objReader["NetAmount"]);
                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<PurchaseDetailEL> GetProductsTotalPurchase(Int64 IdProject, SqlConnection objConn)
        {
            List<PurchaseDetailEL> list = new List<PurchaseDetailEL>();
            using (SqlCommand cmdProductPurchase = new SqlCommand("[Transactions].[Proc_GetProductsTotalPurchase]", objConn))
            {
                cmdProductPurchase.CommandType = CommandType.StoredProcedure;
                cmdProductPurchase.Parameters.Add("@IdProject", SqlDbType.VarChar).Value = IdProject;
                objReader = cmdProductPurchase.ExecuteReader();
                while (objReader.Read())
                {
                    PurchaseDetailEL oelPurchaseDetail = new PurchaseDetailEL();
                    oelPurchaseDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelPurchaseDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelPurchaseDetail.Qty = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelPurchaseDetail.Amount = Validation.GetSafeDecimal(objReader["TotalPurchaseAmount"]);
                    oelPurchaseDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelPurchaseDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelPurchaseDetail.NetAmount = Validation.GetSafeDecimal(objReader["NetAmount"]);
                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<PurchaseDetailEL> GetProductsTotalPurchaseByDate(DateTime StartDate, DateTime EndDate, Int64 IdProject, SqlConnection objConn)
        {
            List<PurchaseDetailEL> list = new List<PurchaseDetailEL>();
            using (SqlCommand cmdProductPurchase = new SqlCommand("[Transactions].[Proc_GetProductsTotalPurchaseByDate]", objConn))
            {
                cmdProductPurchase.CommandType = CommandType.StoredProcedure;
                cmdProductPurchase.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdProductPurchase.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdProductPurchase.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdProductPurchase.ExecuteReader();
                while (objReader.Read())
                {
                    PurchaseDetailEL oelPurchaseDetail = new PurchaseDetailEL();
                    oelPurchaseDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelPurchaseDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelPurchaseDetail.Qty = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelPurchaseDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelPurchaseDetail.Amount = Validation.GetSafeDecimal(objReader["TotalPurchaseAmount"]);
                    oelPurchaseDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelPurchaseDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelPurchaseDetail.NetAmount = Validation.GetSafeDecimal(objReader["NetAmount"]);
                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<PurchaseDetailEL> GetProductDetailPurchase(Int64 AccountNo, Int64 IdProject, SqlConnection objConn)
        {
            List<PurchaseDetailEL> list = new List<PurchaseDetailEL>();
            using (SqlCommand cmdProductPurchase = new SqlCommand("[Transactions].[Proc_GetProductDetailPurchase]", objConn))
            {
                cmdProductPurchase.CommandType = CommandType.StoredProcedure;
                cmdProductPurchase.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdProductPurchase.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdProductPurchase.ExecuteReader();
                while (objReader.Read())
                {
                    PurchaseDetailEL oelPurchaseDetail = new PurchaseDetailEL();
                    oelPurchaseDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelPurchaseDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelPurchaseDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelPurchaseDetail.Qty = Validation.GetSafeLong(objReader["Units"]);
                    oelPurchaseDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelPurchaseDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelPurchaseDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelPurchaseDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelPurchaseDetail.NetAmount = Validation.GetSafeDecimal(objReader["NetAmount"]);
                    if (objReader["SupplierName"] != null)
                    {
                        oelPurchaseDetail.AccountName = Validation.GetSafeString(objReader["SupplierName"]);
                    }
                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<PurchaseDetailEL> GetProductDetailPurchaseByDate(string AccountNo, DateTime StartDate, DateTime EndDate, Int64 IdProject, SqlConnection objConn)
        {
            List<PurchaseDetailEL> list = new List<PurchaseDetailEL>();
            using (SqlCommand cmdProductPurchase = new SqlCommand("[Transactions].[Proc_GetProductDetailPurchaseByDate]", objConn))
            {
                cmdProductPurchase.CommandType = CommandType.StoredProcedure;

                cmdProductPurchase.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdProductPurchase.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdProductPurchase.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                cmdProductPurchase.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdProductPurchase.ExecuteReader();
                while (objReader.Read())
                {
                    PurchaseDetailEL oelPurchaseDetail = new PurchaseDetailEL();
                    oelPurchaseDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelPurchaseDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelPurchaseDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelPurchaseDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelPurchaseDetail.Qty = Validation.GetSafeLong(objReader["Units"]);
                    oelPurchaseDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelPurchaseDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelPurchaseDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelPurchaseDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelPurchaseDetail.NetAmount = Validation.GetSafeDecimal(objReader["NetAmount"]);
                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlyPurchases(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdPurchases = new SqlCommand("[Transactions].[Proc_GetMonthlyPurchaseReport]", objConn))
            {
                cmdPurchases.CommandType = CommandType.StoredProcedure;
                cmdPurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPurchases.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdPurchases.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                cmdPurchases.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdPurchases.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdPurchases.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelPurchaseDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlyPurchasesWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdPurchases = new SqlCommand("[Transactions].[Proc_GetMonthlyPurchaseDetailedReport]", objConn))
            {
                cmdPurchases.CommandType = CommandType.StoredProcedure;
                cmdPurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPurchases.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdPurchases.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdPurchases.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                cmdPurchases.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdPurchases.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdPurchases.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlyStraightPurchases(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdPurchases = new SqlCommand("[Transactions].[Proc_GetMonthlyPurchaseStraightReport]", objConn))
            {
                cmdPurchases.CommandType = CommandType.StoredProcedure;
                cmdPurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPurchases.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdPurchases.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdPurchases.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdPurchases.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelPurchaseDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlyStraightPurchasesWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdPurchases = new SqlCommand("[Transactions].[Proc_GetMonthlyPurchaseDetailedStraightReport]", objConn))
            {
                cmdPurchases.CommandType = CommandType.StoredProcedure;
                cmdPurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPurchases.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdPurchases.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdPurchases.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdPurchases.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdPurchases.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        
        
        public List<TransactionsEL> GetMonthlyPurchasesReturn(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdPurchases = new SqlCommand("[Transactions].[Proc_GetMonthlyPurchaseReturnReport]", objConn))
            {
                cmdPurchases.CommandType = CommandType.StoredProcedure;
                cmdPurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPurchases.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdPurchases.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                cmdPurchases.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdPurchases.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdPurchases.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelPurchaseDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlyPurchasesReturnWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdPurchases = new SqlCommand("[Transactions].[Proc_GetMonthlyPurchaseReturnDetailedReport]", objConn))
            {
                cmdPurchases.CommandType = CommandType.StoredProcedure;
                cmdPurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPurchases.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdPurchases.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdPurchases.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                cmdPurchases.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdPurchases.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdPurchases.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlyStraightPurchasesReturn(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdPurchases = new SqlCommand("[Transactions].[Proc_GetMonthlyStraightPurchaseReturnReport]", objConn))
            {
                cmdPurchases.CommandType = CommandType.StoredProcedure;
                cmdPurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPurchases.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdPurchases.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdPurchases.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdPurchases.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelPurchaseDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlyStraightPurchasesReturnWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdPurchases = new SqlCommand("[Transactions].[Proc_GetMonthlyStraightPurchaseReturnDetailedReport]", objConn))
            {
                cmdPurchases.CommandType = CommandType.StoredProcedure;
                cmdPurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPurchases.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdPurchases.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdPurchases.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdPurchases.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdPurchases.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
    }
}
