using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace RestaurantManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //            Configuration configuration =
            //ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //            configuration.AppSettings.Settings["database"].Value = "";
            //            MessageBox.Show(ConfigurationManager.AppSettings["database"]);
            //            configuration.Save(ConfigurationSaveMode.Modified, true);
            // Saves settings in application configuration file
          //  Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            // config.AppSettings.Settings.Remove("database");
            //config.Save(ConfigurationSaveMode.Minimal);
            string Test = "";
            Test =  ConfigurationManager.AppSettings["database"];
            
            //MessageBox.Show("." + Test + ".");
            if (Test == null)
                Application.Run(new LoginMasterForm());
            else
                Application.Run(new LoginForm());
        }
    }
}

