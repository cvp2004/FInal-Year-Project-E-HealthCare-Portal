using OPD_Section.Forms;
using System;
using System.Windows.Forms;

namespace OPD_Section
{
    internal static class Program
    {

        public static Data data = new Data();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }
    }
}