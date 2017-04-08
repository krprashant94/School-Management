using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management
{
    static class Program
    {
        private static string state;
        private static string server;
        private static string auth;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Regedit reg = new Regedit();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            reg.add("Login", "false", "Initial");
            server = reg.get("Server", "Server");
            auth = reg.get("Auth", "Initial");
            if (String.IsNullOrEmpty(server) || String.IsNullOrEmpty(auth))
            {
                Application.Run(new FirstRun());
            }
            Application.Run(new Login());
            try
            {
                state = reg.get("Login", "Initial");
                if (state.Equals("true"))
                {
                    Application.Run(new MainPage());
                }
            }
            catch (Exception)
            {
                Application.Exit();
            }
            
        }
    }
}
