using System;
using System.Collections.Generic;
using System.Text;

namespace Barangay_E_Service_System.DATA
{

    namespace Barangay_E_Service_System.DATA
    {
        public enum UserRole
        {
            Admin,Resident
        }

        public static class UserSession
        {
            public static int UserID { get; private set; }
            public static string Username { get; private set; }
            public static string FullName { get; private set; }
            public static UserRole? Role { get; private set; }

            public static bool IsAuthenticated => Role.HasValue;

            public static void SetSession(int userID, string username, string fullName, UserRole role)
            {
                UserID = userID;
                Username = username;
                FullName = fullName;
                Role = role;
            }

            public static void ClearSession()
            {
                UserID = 0;
                Username = null;
                FullName = null;
                Role = null;
            }
        }
    }

}
