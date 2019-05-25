using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTVIndividualAssignment
{

    static class Program
    {
        static string dbFilePath = @"C:\\Users\Carl\source\repos\HTVIndividualAssignment\HTVIndividualAssignment\Database\HTVDatabase.mdf";
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
