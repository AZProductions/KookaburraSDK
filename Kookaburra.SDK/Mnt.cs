using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kookaburra.SDK
{
    /// <summary>
    /// Mount Class for the Kookaburra SDK.
    /// </summary>
    public static class Mnt
    {
        public static class Drives 
        {
            public static string[] List() 
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                List<string> List = new List<string>();
                foreach (DriveInfo Drives in allDrives) 
                {
                    List.Add(Drives.Name.ToString());
                }
                return List.ToArray();
            }
        }
    }
}
