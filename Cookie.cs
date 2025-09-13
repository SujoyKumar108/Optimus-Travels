using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimus_Travels
{
    public static class Cookie
    {
        public static int userId;
        public static string role;
        public static int UserId
        {
            set { userId = value; }
            get { return userId; }
        }
        public static string Role
        {
            set { role = value; }
            get { return role; }
        }
        public static void ClearCookie()
        {
            userId = -1;
            role = string.Empty;
        }
    }
}
