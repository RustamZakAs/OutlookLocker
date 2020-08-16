using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace OutlookLocker
{
    public static class WindowState
    {
        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1401:P/Invokes should not be visible", Justification = "<Pending>")]
        public static extern IntPtr SetFocus(HandleRef hWnd);

        //[DllImport("user32.dll")]
        //private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1401:P/Invokes should not be visible", Justification = "<Pending>")]
        public static extern IntPtr FindWindow(string className, string windowTitle);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, ShowWindowEnum flags);
        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hwnd);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowPlacement(IntPtr hWnd, ref Windowplacement lpwndpl);

        //WORKING
        public static void Hide(string ProcessName)
        {
            int hWnd;
            Process[] processRunning = Process.GetProcessesByName(ProcessName);
            foreach (Process pr in processRunning)
            {
                if (pr.ProcessName == ProcessName)
                {
                    hWnd = pr.MainWindowHandle.ToInt32();
                    ShowWindow(hWnd, (int)ShowWindowEnum.HIDE);
                }
            }
        }
        //NOT WORKING
        public static void Show(string processName)
        {
            int hWnd;
            Process[] processRunning = Process.GetProcessesByName(processName);
            foreach (Process pr in processRunning)
            {
                if (pr.ProcessName == processName && pr.Id != Program.CurrentId)
                {
                    hWnd = pr.MainWindowHandle.ToInt32();
                    ShowWindow(hWnd, (int)ShowWindowEnum.SHOW);

                    //SetFocus(new HandleRef(null, pr.MainWindowHandle));
                    //BringWindowToFront(processName);
                    //ShowWindowAsync(pr.MainWindowHandle, (int)State.RESTORE);
                    //int sss = (int)State.SHOWNORMAL;
                    //int ssss = (int)State.SHOWMAXIMIZED;
                    //ShowWindow(pr.MainWindowHandle, sss);
                    //ShowWindow(pr.MainWindowHandle, ssss);
                }
            }
        }

        //static void BringWindowToFront(string processName)
        //{
        //    var currentProcess = Process.GetCurrentProcess();
        //    var processes = Process.GetProcessesByName(currentProcess.ProcessName);
        //    var process = processes.FirstOrDefault(p => p.Id != currentProcess.Id);
        //    if (process == null) return;

        //    SetForegroundWindow(process.MainWindowHandle);
        //}

        public static void Restore()
        {
            // get the name of our process
            string proc = Process.GetCurrentProcess().ProcessName;
            // get the list of all processes by that name
            Process[] processes = Process.GetProcessesByName(proc);
            // if there is more than one process...
            if (processes.Length > 1)
            {
                // Assume there is our process, which we will terminate, 
                // and the other process, which we want to bring to the 
                // foreground. This assumes there are only two processes 
                // in the processes array, and we need to find out which 
                // one is NOT us.

                // get our process
                Process p = Process.GetCurrentProcess();
                int n = 0;        // assume the other process is at index 0
                                  // if this process id is OUR process ID...
                if (processes[0].Id == p.Id)
                {
                    // then the other process is at index 1
                    n = 1;
                }
                // get the window handle
                IntPtr hWnd = processes[n].MainWindowHandle;
                // if iconic, we need to restore the window
                if (IsIconic(hWnd))
                {
                    ShowWindowAsync(hWnd, (int)ShowWindowEnum.RESTORE);
                }
                // bring it to the foreground
                SetForegroundWindow(hWnd);
                // exit our process
                return;
            }
            // ... continue with your application initialization here.
        }

        public enum ShowWindowEnum
        {
            FORCEMINIMIZE = 11,
            HIDE = 0,
            MAXIMIZE = 3,
            MINIMIZE = 6,
            RESTORE = 9,
            SHOW = 5,
            SHOWDEFAULT = 10,
            SHOWMAXIMIZED = 3,
            SHOWMINIMIZED = 2,
            SHOWMINNOACTIVE = 7,
            SHOWNA = 8,
            SHOWNOACTIVATE = 4,
            SHOWNORMAL = 1,

            Hide = 0,
            ShowNormal = 1, 
            ShowMinimized = 2, 
            ShowMaximized = 3,
            Maximize = 3, 
            ShowNormalNoActivate = 4, 
            Show = 5,
            Minimize = 6, 
            ShowMinNoActivate = 7, 
            ShowNoActivate = 8,
            Restore = 9, 
            ShowDefault = 10, 
            ForceMinimized = 11
        }

        private struct Windowplacement
        {
            public int length;
            public int flags;
            public int showCmd;
            public System.Drawing.Point ptMinPosition;
            public System.Drawing.Point ptMaxPosition;
            public System.Drawing.Rectangle rcNormalPosition;
        }

        public static void BringWindowToFront()
        {
            //IntPtr wdwIntPtr = FindWindow(null, "Put_your_window_title_here");
            IntPtr wdwIntPtr = FindWindow(null, "Outlook Locker");

            //get the hWnd of the process
            Windowplacement placement = new Windowplacement();
            GetWindowPlacement(wdwIntPtr, ref placement);

            // Check if window is minimized
            if (placement.showCmd == 2)
            {
                //the window is hidden so we restore it
            }
            ShowWindow(wdwIntPtr, ShowWindowEnum.Restore);

            //set user focus to the window
            SetForegroundWindow(wdwIntPtr);
        }
    }
}
