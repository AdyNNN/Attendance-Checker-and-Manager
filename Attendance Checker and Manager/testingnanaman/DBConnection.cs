using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingnanaman
{
    internal class DBConnection
    {
        static internal string databaseConnection_account = $"{GetBasePath()}\\TeacherPortal\\testingnanaman_account.db";
        static internal string databaseConnection_attendance = $"{GetBasePath()}\\TeacherPortal\\testingnanaman_attendance.db";

        static internal string GetBasePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }
    }
}