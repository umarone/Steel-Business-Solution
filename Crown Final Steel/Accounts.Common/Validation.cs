using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

using System.Security.Principal;
using System.Globalization;

namespace Accounts.Common
{
    public class Validation
    {

        public static bool? GetSafeBooleanNullable(Object value)
        {
            bool? returnValue;

            if ((value == DBNull.Value) || (value == null) || (value.ToString() == string.Empty))
            {
                returnValue = null;
            }
            else
            {
                try
                {
                    returnValue = System.Convert.ToBoolean(value);
                }
                catch
                {
                    returnValue = null;
                }
            }

            return returnValue;
        }

        public static Guid GetSafeGuid(Object value)
        {
            Guid returnValue;

            if ((value == DBNull.Value) || (value == null) || (value.ToString() == Guid.Empty.ToString()))
            {
                returnValue = Guid.Empty;
            }
            else
            {
                try
                {
                    returnValue = new Guid(value.ToString());
                }
                catch
                {
                    returnValue = Guid.Empty;
                }
            }

            return returnValue;
        }

        public static Guid? GetNullableGuid(Object value)
        {
            Guid? returnValue;

            if ((value == DBNull.Value) || (value == null) || (value.ToString() == Guid.Empty.ToString()))
            {
                returnValue = null;
            }
            else
            {
                try
                {
                    returnValue = new Guid(value.ToString());
                }
                catch
                {
                    returnValue = null;
                }
            }

            return returnValue;
        }

        public static string GetSafeString(Object value)
        {
            string returnValue;

            if ((value == DBNull.Value) || (value == null) || (value.ToString() == string.Empty))
            {
                returnValue = "";
            }
            else
            {
                try
                {
                    returnValue = value.ToString().Trim();
                }
                catch
                {
                    returnValue = "";
                }

            }

            return returnValue;
        }

        public static short GetSafeShort(Object value)
        {
            short returnValue;

            if ((value == DBNull.Value) || (value == null) || (value.ToString() == String.Empty))
            {
                returnValue = 0;
            }
            else
            {
                try
                {
                    returnValue = System.Convert.ToInt16(value);
                }
                catch
                {
                    returnValue = 0;
                }
            }

            return returnValue;
        }

        public static int GetSafeInteger(Object value)
        {
            int returnValue;

            if ((value == DBNull.Value) || (value == null) || (value.ToString() == String.Empty))
            {
                returnValue = 0;
            }
            else
            {
                try
                {
                    returnValue = System.Convert.ToInt32(value);
                }
                catch
                {
                    returnValue = 0;
                }    
            }

            return returnValue;
        }
        public static int? GetSafeNullableInteger(Object value)
        {
            int? returnValue;

            if ((value == DBNull.Value) || (value == null) || (value.ToString() == string.Empty))
            {
                returnValue = null;
            }
            else
            {
                try
                {
                    returnValue = System.Convert.ToInt32(value);
                }
                catch
                {
                    returnValue = null;
                }
            }

            return returnValue;
        }

        public static long GetSafeLong(Object value)
        {
            long returnValue;

            if ((value == DBNull.Value) || (value == null) || (value.ToString() == String.Empty))
            {
                returnValue = 0;
            }
            else
            {
                try
                {
                    returnValue = System.Convert.ToInt64(value);
                }
                catch
                {
                    returnValue = 0;
                }
            }

            return returnValue;
        }
        public static long? GetSafeNullableLong(Object value)
        {
            long? returnValue;

            if ((value == DBNull.Value) || (value == null) || (value.ToString() == String.Empty))
            {
                returnValue = null;
            }
            else
            {
                try
                {
                    returnValue = System.Convert.ToInt64(value);
                }
                catch
                {
                    returnValue = null;
                }
            }

            return returnValue;
        }

        public static decimal GetSafeDecimal(Object value)
        {
            decimal returnValue;

            if ((value == DBNull.Value) || (value == null) || (value.ToString() == String.Empty))
            {
                returnValue = 0;
            }
            else
            {
                try
                {
                    returnValue = System.Convert.ToDecimal(value);
                }
                catch
                {
                    returnValue = 0;
                }
            }

            return returnValue;
        }
        public static decimal? GetSafeNullableDecimal(Object value)
        {
            decimal? returnValue;

            if ((value == DBNull.Value) || (value == null) || (value.ToString() == String.Empty))
            {
                returnValue = null;
            }
            else
            {
                try
                {
                    returnValue = System.Convert.ToDecimal(value);
                }
                catch
                {
                    returnValue = null;
                }
            }

            return returnValue;
        }

        public static DateTime? GetSafeDateTime(Object value)
        {
            DateTime? returnValue = null;

            if ((value == DBNull.Value) || (value == null)) //''OrElse (value Is String.Empty) Then
            {
                returnValue = DateTime.MinValue;
            }
            else
            {
                try
                {
                    returnValue = System.Convert.ToDateTime(value, new CultureInfo("en-GB"));
                }
                catch
                {
                    returnValue = DateTime.MinValue;
                }
            }
            return returnValue;
        }
        public static DateTime? GetSafeNullableDateTime(Object value)
        {
            DateTime? returnValue = null;

            if ((value == DBNull.Value) || (value == null)) //''OrElse (value Is String.Empty) Then
            {
                returnValue = null;
            }
            else
            {
                try
                {
                    returnValue = System.Convert.ToDateTime(value, new CultureInfo("en-GB"));
                }
                catch
                {
                    returnValue = null;
                }
            }
            return returnValue;
        }

        
    }

}