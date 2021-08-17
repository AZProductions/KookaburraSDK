using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace Kookaburra.SDK.Networking
{
    public static class Networking
    {
        public static bool HasInternet = NetworkInterface.GetIsNetworkAvailable();
    }
}
