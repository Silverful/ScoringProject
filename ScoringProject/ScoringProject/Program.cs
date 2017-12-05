using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoringProject
{
    static class Program
    {
        public static Auth GlobalAuth;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalAuth = new Auth();
            Application.Run(GlobalAuth);
            
        }
    }
}
