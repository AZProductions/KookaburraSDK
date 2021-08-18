using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kookaburra.SDK
{
    /// <summary>
    /// Environment Class for the Kookaburra SDK.
    /// </summary>
    public static class Env
    {
        /// <summary>
        /// If True, the system is x64 based.
        /// </summary>
        public static readonly bool Is64x = Environment.Is64BitProcess;
        /// <summary>
        /// If True, the running program is x64 based.
        /// </summary>
        public static readonly bool Is64xProcess = Environment.Is64BitOperatingSystem;
        /// <summary>
        /// Returns the current OS Platform.
        /// </summary>
        public static readonly string OSPlatform = Environment.OSVersion.Platform.ToString();
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
    }
}
