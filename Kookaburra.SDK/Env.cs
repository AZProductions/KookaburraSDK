using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Management;
using System.Threading.Tasks;

namespace Kookaburra.SDK
{
    /// <summary>
    /// Environment Class for the Kookaburra SDK.
    /// </summary>
    public static class Env
    {
        /// <summary>
        /// If True, the running program is x64 based.
        /// </summary>
        public static readonly bool Is64x = Environment.Is64BitProcess;

        /// <summary>
        /// If True, the system is x64 based.
        /// </summary>
        public static readonly bool Is64xProcess = Environment.Is64BitOperatingSystem;
        
        /// <summary>
        /// Returns the current OS Platform.
        /// </summary>
        public static string GetOSPlatform()
        {
            return Environment.OSVersion.Platform.ToString();
        }

        /// <summary>
        /// Returns the current machinename.
        /// </summary>
        public static readonly string MachineName = Environment.MachineName;
        
        /// <summary>
        /// Returns the current username.
        /// </summary>
        public static readonly string UserName = Environment.UserName;
        
        /// <summary>
        /// Returns the current working directory.
        /// </summary>
        public static readonly string CurrentDirectory = Environment.CurrentDirectory;

        [SupportedOSPlatform("windows")]
        [DllImport("shell32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsUserAnAdmin();
        [SupportedOSPlatform("windows")]
        /// <summary>
        /// Returns the current program is running in administrator mode.
        /// </summary>
        public static bool IsCurrentProcessAdmin()
        {
            return IsUserAnAdmin();
        }

        [SupportedOSPlatform("windows")]
        /// <summary>
        /// Returns the manufacturer name of the current computer.
        /// </summary>
        public static string GetManufacturerName() 
        {
            string Name = "";
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            //collection to store all management objects
            ManagementObjectCollection moc = mc.GetInstances();
            if (moc.Count != 0)
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    // display general system information
                    Name = mo["Manufacturer"].ToString();
                }
            }
            return Name;
        }

        [SupportedOSPlatform("windows")]
        /// <summary>
        /// Returns the CPU status. (using Win32_Processor API)
        /// </summary>
        public static string GetCPUStatus()
        {
            string Name = "";
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            if (moc.Count != 0)
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    // display general system information
                    Name = mo["Status"].ToString();
                }
            }
            return Name;
        }

        [SupportedOSPlatform("windows")]
        /// <summary>
        /// Returns the CPU caption. (using Win32_Processor API)
        /// </summary>
        public static string GetCPUCaption()
        {
            string Name = "";
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            if (moc.Count != 0)
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    // display general system information
                    Name = mo["Caption"].ToString();
                }
            }
            return Name;
        }

        [SupportedOSPlatform("windows")]
        /// <summary>
        /// Returns the GPU caption. (using Win32_VideoController API)
        /// </summary>
        public static string GetGPUCaption()
        {
            string Name = "";
            ManagementClass mc = new ManagementClass("Win32_VideoController");
            ManagementObjectCollection moc = mc.GetInstances();
            if (moc.Count != 0)
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    // display general system information
                    Name = mo["Caption"].ToString();
                }
            }
            return Name;
        }

        [SupportedOSPlatform("windows")]
        /// <summary>
        /// Returns the local drive caption. (using Win32_VideoController API)
        /// </summary>
        public static string GetLocalDriveCaption()
        {
            string Name = "";
            ManagementClass mc = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection moc = mc.GetInstances();
            if (moc.Count != 0)
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    // display general system information
                    Name = mo["Caption"].ToString();
                }
            }
            return Name;
        }

        [SupportedOSPlatform("windows")]
        /// <summary>
        /// Returns the requested data from the Win32 API.
        /// </summary>
        public static string GetWin32Info(string Class, string Instance)
        {
            string Name = "";
            ManagementClass mc = new ManagementClass(Class);
            ManagementObjectCollection moc = mc.GetInstances();
            if (moc.Count != 0)
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    Name = mo[Instance].ToString();
                }
            }
            return Name;
        }

        /// <summary>
        /// Returns the current Operating System. (Windows, Linux, MacOS, FreeBSD)
        /// </summary>
        public static string GetOSType() 
        {
            string OS = "";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                OS = "Windows";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                OS = "Linux";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                OS = "MacOS";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                OS = "FreeBSD";
            }
            else 
            {
                throw new Exception("Invalid OS.");
            }
            return OS;
        }

        [SupportedOSPlatform("windows")]
        /// <summary>
        /// Returns the current Screen Brightness. (using WmiMonitorBrightness API)
        /// </summary>
        public static int GetScreenBrightness()
        {
            using var mclass = new ManagementClass("WmiMonitorBrightness")
            {
                Scope = new ManagementScope(@"\\.\root\wmi")
            };
            using var instances = mclass.GetInstances();
            foreach (ManagementObject instance in instances)
            {
                return (byte)instance.GetPropertyValue("CurrentBrightness");
            }
            return 0;
        }

        [SupportedOSPlatform("windows")]
        /// <summary>
        /// Sets the current Screen Brightness. (using WmiMonitorBrightness API) [Max: 100, Min:1]
        /// </summary>
        public static void SetScreenBrightness(int brightness)
        {
            using var mclass = new ManagementClass("WmiMonitorBrightnessMethods")
            {
                Scope = new ManagementScope(@"\\.\root\wmi")
            };
            using var instances = mclass.GetInstances();
            var args = new object[] { 1, brightness };
            foreach (ManagementObject instance in instances)
            {
                instance.InvokeMethod("WmiSetBrightness", args);
            }
        }

        [SupportedOSPlatform("windows")]
        [DllImport("user32.dll")]
        static private extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        [SupportedOSPlatform("windows")]
        /// <summary>
        /// Increases the users volume. (using user32.dll API)
        /// </summary>
        public static void IncreaseVolume()
        {
            keybd_event((byte)ConsoleKey.VolumeUp, 0, 0, 0);
        }

        [SupportedOSPlatform("windows")]
        /// <summary>
        /// Decreases the users volume. (using user32.dll API)
        /// </summary>
        public static void DecreaseVolume()
        {
            keybd_event((byte)ConsoleKey.VolumeDown, 0, 0, 0);
        }
    }
}
