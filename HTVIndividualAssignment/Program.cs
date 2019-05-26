using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTVIndividualAssignment
{

    static class Program
    {
        static string dbFilePath = @"|DataDirectory|\Database\HTVDatabase.mdf"; //Change this to a relative path at the end!!
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(dbFilePath));
        }
    }
}
