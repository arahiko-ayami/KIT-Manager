using System;
using System.Windows.Forms;
using Project_KIT_Manager.UI;

namespace Project_KIT_Manager
{
    static class Program
    {
        public static String ApplicationName = "KIT Manager";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
        }
    }
}
