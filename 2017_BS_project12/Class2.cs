using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_BS_project9
{
    public static class Globals
    {
        /* VARS */
        public static string db_string = "Server=tcp:group-b-server.database.windows.net,1433;Initial Catalog = B_project9; Persist Security Info=False;User ID = gb_admin; Password=1q2w3e4r!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";

        //Set the connection string of the SqlConnection object to connect
        //to the SQL Server database in which you created the sample
        //table.
        public static SqlConnection conn;

        /* OBJECTS */
        public static User loggin_user { get; set; }

        /* MAIN FORM */
        public static logInForm App;

        static Globals()
        {
            // reset stats
            loggin_user = new User();
            loggin_user.setName("");
            loggin_user.setPwd("");
            loggin_user.setType(0);
            loggin_user.setId(0);
            loggin_user.setYear(0);
            logggin_user.setSem("");


            // set db object
            conn = new SqlConnection(Globals.db_string);

        }
    }
}
