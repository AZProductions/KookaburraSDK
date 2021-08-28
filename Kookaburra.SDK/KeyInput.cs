using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Kookaburra.SDK
{
    [SupportedOSPlatform("windows")]
    public static class KeyInput
    {
        [UnsupportedOSPlatform("")]
        /// <summary>
        /// Converts Char to ConsoleKey.
        /// </summary>
        public static ConsoleKey CharToKey(char input) 
        {
            ConsoleKey ck = (ConsoleKey)input;
            return ck;
        }

        [DllImport("user32.dll")]
        static private extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        /// <summary>
        /// Simulates a KeyDown event with specified ConsoleKey, without the System.Windows.Forms class. (using user32.dll API)
        /// </summary>
        public static void Send(ConsoleKey Key) 
        {
            keybd_event((byte)Key, 0, 0, 0);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, ShowWindowEnum flags);
        [SupportedOSPlatform("windows")]
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hwnd);

        private enum ShowWindowEnum
        {
            Hide = 0,
            ShowNormal = 1, ShowMinimized = 2, ShowMaximized = 3,
            Maximize = 3, ShowNormalNoActivate = 4, Show = 5,
            Minimize = 6, ShowMinNoActivate = 7, ShowNoActivate = 8,
            Restore = 9, ShowDefault = 10, ForceMinimized = 11
        };

        /// <summary>
        /// Makes the specified window appear in the forground. (https://stackoverflow.com/a/2315589/16688940)
        /// </summary>
        public static void BringMainWindowToFront(string processName)
        {
            // get the process
            Process bProcess = Process.GetProcessesByName(processName).FirstOrDefault();

            // check if the process is running
            if (bProcess != null)
            {
                // check if the window is hidden / minimized
                if (bProcess.MainWindowHandle == IntPtr.Zero)
                {
                    // the window is hidden so try to restore it before setting focus.
                    ShowWindow(bProcess.Handle, ShowWindowEnum.Restore);
                }

                // set user the focus to the window
                SetForegroundWindow(bProcess.MainWindowHandle);
            }
            else
            {
                // the process is not running, so start it
                Process.Start(processName);
            }
        }
    }
}
