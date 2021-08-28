using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Kookaburra.SDK
{
    [SupportedOSPlatform("windows")]
    /// <summary>
    /// CPUInformation Class for the Kookaburra SDK.
    /// </summary>
    public class CPUInformation
    {
        /// <summary>
        /// CPUInformation Object for the Kookaburra SDK.
        /// </summary>
        public CPUInformation()
        {
            
        }

        /// <summary>
        /// Returns the requested data from the Win32 API.
        /// </summary>
        public string ListAPI()
        {
            string Result = "";
            System.Management.ObjectQuery query = new ObjectQuery("Select * FROM Win32_Processor");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            ManagementObjectCollection collection = searcher.Get();

            foreach (ManagementObject mo in collection)
            {
                foreach (PropertyData property in mo.Properties)
                {
                    Console.WriteLine("Property {0}: Value: {1}", property.Name, property.Value);
                }
            }
            return Result;
        }

        /// <summary>
        /// Returns the Battery status. (using Win32_Processor API)
        /// </summary>
        public string GetStatus()
        {
            return Env.GetWin32Info("Win32_Processor", "Status");
        }

        /// <summary>
        /// Returns the load percentage of the CPU. (using Win32_Processor API)
        /// </summary>
        public string GetLoadPercentage()
        {
            return Env.GetWin32Info("Win32_Processor", "LoadPercentage");
        }

        /// <summary>
        /// Returns the description of the CPU. (using Win32_Processor API)
        /// </summary>
        public string GetDescription()
        {
            return Env.GetWin32Info("Win32_Processor", "Description");
        }

        /// <summary>
        /// Returns the CPU name. (using Win32_Processor API)
        /// </summary>
        public string GetName() 
        {
            return Env.GetWin32Info("Win32_Processor", "Name");
        }
    }
}
