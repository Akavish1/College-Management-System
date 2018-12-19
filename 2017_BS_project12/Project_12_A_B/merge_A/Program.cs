using merge_A.CodeLayer;
using Project_Sce.DAL;
using merge_A.PL;
using Project_Sce.CodeLayer;
using Project_Sce.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sce
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Handler h = new Handler();
           
            if (h.ConnectToDB())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new PL.LogIn());
            }
            else
            {
                MessageBox.Show("Cannot connect to Data Base! Please try later.");
            }

        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            Handler h = new Handler();
            h.DisconnectFromDB();
        }
    }
}
