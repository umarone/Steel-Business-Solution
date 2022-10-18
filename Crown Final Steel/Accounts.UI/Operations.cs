using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using Accounts.EL;

namespace Accounts.UI
{
    public class Operations
    {        
            static Int64 UserId;
            static string username;
            static Int64 IDCompany;
            static string _CompanyName;
            static Int64 _IdProject;
            static string _ProjectName;
            static string _ProjectInvoiceName;
            static string _ProjectPurchaseInvoiceName;
            static Int64 _ProjectConfiguration;
            static Int64 _BookNo;
            static string _BookPeriod;
            static Int64 IDRole;
            static Int64 IDAuthenticationRole;
            static bool _IsAuthenticate;
            public static Int64 IdCompany
            {
                get { return IDCompany; }
                set { IDCompany = value; }
            }
            public static string CompanyName
            {
                get { return _CompanyName; }
                set { _CompanyName = value; }
            }
            public static Int64 IdProject
            {
                get { return _IdProject; }
                set { _IdProject = value; }
            }
            public static string ProjectName
            {
                get { return _ProjectName; }
                set { _ProjectName = value; }
            }
            public static string ProjectInvoiceName
            {
                get { return _ProjectInvoiceName; }
                set { _ProjectInvoiceName = value; }
            }
            public static string ProjectPurchaseInvoiceName
            {
                get { return _ProjectPurchaseInvoiceName; }
                set { _ProjectPurchaseInvoiceName = value; }
            }
            public static Int64 ProjectConfiguration
            {
                get { return _ProjectConfiguration; }
                set { _ProjectConfiguration = value; }
            }
            public static Int64 UserID
            {
                get { return UserId; }
                set { UserId = value; }
            }
            public static Int64 IdRole
            {
                get { return IDRole; }
                set { IDRole = value; }
            }
            public static Int64 IdAuthenticationRole
            {
                get { return IDRole; }
                set { IDRole = value; }
            }
            public static string UserName
            {
                get { return username; }
                set { username = value; }
            }
            public static bool IsAuthenticate
            {
                get { return _IsAuthenticate; }
                set { _IsAuthenticate = value; }
            }
            public static Int64 BookNo
            {
                get { return _BookNo; }
                set { _BookNo = value; }
            }
            public static string BookPeriod
            {
                get { return _BookPeriod; }
                set { _BookPeriod = value; }
            }
    }
    public static class DataOperations
    {
        public static List<SoftwareTypesEL> SoftwareCollection;
        public static List<SoftwareChecksEL> SoftwareChecksCollection;
        public static List<ModulesEL> _SoftwareEnabledModules;
        public static List<TabsEL> _SoftwareTabs;
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType != null)
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(
                prop.PropertyType) ?? prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
        public static List<SoftwareTypesEL> SoftwareTypes 
        {
            get
            {
                return SoftwareCollection;
            }
            set
            {
                SoftwareCollection = value;
            }
        }
        public static List<SoftwareChecksEL> SoftwareChecks
        {
            get
            {
                return SoftwareChecksCollection;
            }
            set
            {
                SoftwareChecksCollection = value;
            }
        }
        public static List<ModulesEL> SoftwareEnabledModules
        {
            get
            {
                return _SoftwareEnabledModules;
            }
            set
            {
                _SoftwareEnabledModules = value;
            }
        }
        public static List<TabsEL> SoftwareTabs
        {
            get
            {
                return _SoftwareTabs;
            }
            set
            {
                _SoftwareTabs = value;
            }
        }
    }
}
