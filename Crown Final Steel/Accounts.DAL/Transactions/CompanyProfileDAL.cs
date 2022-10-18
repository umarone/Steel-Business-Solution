using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Accounts.EL;

namespace Accounts.DAL
{
   public class CompanyProfileDAL
    {
       public static bool InsertCompanyProfile(CompanyProfileEL oelCompanyProfile, SqlConnection oConn)
       {
           using (SqlCommand cmdCompanyProfile = new SqlCommand("sp_insertCompanyProfile", oConn))
           {
               cmdCompanyProfile.CommandType = CommandType.StoredProcedure;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@CompanyNo", DbType.Int32)).Value = oelCompanyProfile.CompanyNo;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@CompanyName", DbType.String)).Value = oelCompanyProfile.CompanyName;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelCompanyProfile.Contact;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelCompanyProfile.Address;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@NTN", DbType.String)).Value = oelCompanyProfile.NTN;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@StartDate", DbType.DateTime)).Value = oelCompanyProfile.StartDate;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@EndDate", DbType.DateTime)).Value = oelCompanyProfile.EndDate;
               cmdCompanyProfile.ExecuteNonQuery();
               return true;

           }
       }
       public static bool UpdateCompanyProfile(CompanyProfileEL oelCompanyProfile, SqlConnection oConn)
       {
           using (SqlCommand cmdCompanyProfile = new SqlCommand("sp_updateCompanyProfile", oConn))
           {
               cmdCompanyProfile.CommandType = CommandType.StoredProcedure;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@CompanyNo", DbType.Int32)).Value = oelCompanyProfile.CompanyNo;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@CompanyName", DbType.String)).Value = oelCompanyProfile.CompanyName;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelCompanyProfile.Contact;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelCompanyProfile.Address;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@NTN", DbType.String)).Value = oelCompanyProfile.NTN;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@StartDate", DbType.DateTime)).Value = oelCompanyProfile.StartDate;
               cmdCompanyProfile.Parameters.Add(new SqlParameter("@EndDate", DbType.DateTime)).Value = oelCompanyProfile.EndDate;
               cmdCompanyProfile.ExecuteNonQuery();
               return true;

           }
       }
    }
}
