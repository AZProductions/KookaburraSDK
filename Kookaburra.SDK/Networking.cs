using System.Net.NetworkInformation;

namespace Kookaburra.SDK.Networking
{
    public static class Networking
    {
        public static bool HasInternet = NetworkInterface.GetIsNetworkAvailable(); //test
    }
}
