using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.EL;
using Accounts.Common;
using Accounts.BLL;

namespace Accounts.UI
{
    class UserPermissions
    {
       public static Int64 IdModule { get; set; }
       public static List<UserModulesPermissionsEL> GetUserModulePermissionsByUserAndModuleId(Int64? IdUser)
       {
           List<UserModulesPermissionsEL> PermissionsList = new List<UserModulesPermissionsEL>();
           if (Operations.IdRole != Validation.GetSafeLong(EnRoles.CheifExecutive) || Operations.IdRole != Validation.GetSafeLong(EnRoles.Administrator))
           {
               if (IdModule > 0)
               {
                   UserModulesPermissionsBLL Manager = new UserModulesPermissionsBLL();
                   PermissionsList = Manager.GetUserModulePermissionsByUserAndModuleId(IdUser, IdModule);
               }
           }
           return PermissionsList;
       }
    }
}
