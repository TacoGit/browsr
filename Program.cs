using System;
using EasyTabs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browsr
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContainer container = new AppContainer();

            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new main
                    {
                        Text = "New Tab"
                    }
                }
            );

            container.SelectedTabIndex = 0;

            try
            {
                TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
                applicationContext.Start(container);
                Application.Run(applicationContext);
            }
            catch
            {
                MessageBox.Show("Something very unexpected happened! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
