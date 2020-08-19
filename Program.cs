using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookLocker
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var processName = "notepad";
            //var process = Process.GetProcessesByName(processName).FirstOrDefault();
            //if (process != null)
            //    ShowWindow(process.MainWindowHandle, SW_SHOWNORMAL);
            //else
            //    Process.Start(processName);

            bool hide = false;
            CurrentId = Process.GetCurrentProcess().Id;
            Process[] pname = Process.GetProcessesByName("OutlookLocker");
            if (pname.Length > 1)
            {
                //WindowState.Show("OutlookLocker");
                WindowState.BringWindowToFront();
                Environment.Exit(0);
            }
            else if (pname.Length == 1)
            {
                //hide = true;
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLocker(hide));
        }

        public static int CurrentId { get; set; }
        public static int OutlookId { get; set; }


        //use this flag to maximize process window.
        const int SW_SHOWMAXIMIZED = 3;
        //use this flag to open process window normally.
        const int SW_SHOWNORMAL = 1;

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }
}
