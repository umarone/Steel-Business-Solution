using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
        public class UsersEL : ProjectEL
        {
            //public Int64 UserId
            //{
            //    get;
            //    set;
            //}
            public Int64 IdRole
            {
                get;
                set;
            }
            public string FirstName
            {
                get;
                set;
            }
            public string LastName
            {
                get;
                set;
            }
            //public string UserName
            //{
            //    get;
            //    set;
            //}
            public string Password
            {
                get;
                set;
            }
            public string Contact
            {
                get;
                set;
            }
            public string Cnic
            {
                get;
                set;

            }
            public string Address
            {
                get;
                set;
            }

        }
}
