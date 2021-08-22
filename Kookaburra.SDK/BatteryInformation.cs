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
    /// BatteryInformation Class for the Kookaburra SDK.
    /// </summary>
    public class BatteryInformation
    {
        /// <summary>
        /// BatteryInformation Object for the Kookaburra SDK.
        /// </summary>
        public BatteryInformation() 
        {
              
        }

        /// <summary>
        /// Returns the requested data from the Win32 API.
        /// </summary>
        public string ListAPI() 
        {
            string Result = "";
            System.Management.ObjectQuery query = new ObjectQuery("Select * FROM Win32_Battery");
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
        /// Returns the Battery status. (using Win32_Battery API)
        /// </summary>
        public string GetStatus() 
        {
            return Env.GetWin32Info("Win32_Battery", "Status");
        }

        /// <summary>
        /// Returns the time until the battery is fully charged. (using Win32_Battery API)
        /// </summary>
        public string TimeToFullCharge()
        {
            return Env.GetWin32Info("Win32_Battery", "TimeToFullCharge");
        }

        /// <summary>
        /// Returns the Battery caption. (using Win32_Battery API)
        /// </summary>
        public string GetBatteryCaption()
        {
            return Env.GetWin32Info("Win32_Battery", "Name");
        }

        /// <summary>
        /// Returns True if the battery is PowerManagementSupported. (using Win32_Battery API)
        /// </summary>
        public bool IsPowerManagementSupported()
        {
            return bool.Parse(Env.GetWin32Info("Win32_Battery", "PowerManagementSupported"));
        }

        /// <summary>
        /// Returns the current Battery percentage. (using Win32_Battery API)
        /// </summary>
        public int GetPercentage()
        {
            return int.Parse(Env.GetWin32Info("Win32_Battery", "EstimatedChargeRemaining"));
        }
    }
}
