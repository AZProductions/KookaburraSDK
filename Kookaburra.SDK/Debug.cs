using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Kookaburra.SDK
{
    /// <summary>
    /// Debug Class for the Kookaburra SDK.
    /// </summary>
    public class Debug
    {
        /// <summary>
        /// If True, the system is x64 based.
        /// </summary>
        public bool Is64x { get; }
        /// <summary>
        /// The location of the debug executable.
        /// </summary>
        public string ExecutableLocation { get; }
        /// <summary>
        /// The arguments of the debug executable.
        /// </summary>
        public string ExecutableArguments { get; set; }
        Process process = new Process();

        /// <summary>
        /// Debug module of the Kookaburra SDK.
        /// </summary>
        public Debug(string executablelocation, string arguments = "")
        {
            ExecutableLocation = executablelocation;
            Is64x = Environment.Is64BitProcess;
            ExecutableArguments = arguments;
        }

        /// <summary>
        /// Starts the specified program for debugging.
        /// </summary>
        public void Start(bool tracevalue) 
        {
            PrintInput(tracevalue);
        }
        /// <summary>
        /// Stops the specified program for debugging.
        /// </summary>
        public void Stop()
        {
            process.Close();
        }
        void PrintInput(bool tracevalue)
        {
            process.StartInfo.FileName = ExecutableLocation;
            process.StartInfo.Arguments = ExecutableArguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            if (tracevalue)
                Trace.WriteLine(process.StandardOutput.ReadToEnd());
            else
                Console.WriteLine(process.StandardOutput.ReadToEnd());
            process.WaitForExitAsync();
        }
    }
}
