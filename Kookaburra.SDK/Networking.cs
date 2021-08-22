using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Kookaburra.SDK
{
    /// <summary>
    /// Networking Class for the Kookaburra SDK.
    /// </summary>
    public static class Networking
    {
        /// <summary>
        /// If True, the current PC has an internet connection.
        /// </summary>
        public static readonly bool HasInternet = NetworkInterface.GetIsNetworkAvailable();
        /// <summary>
        /// Returns the local IP of the current system.
        /// </summary>
        public static string GetLocalIP() 
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address found.");
        }
        /// <summary>
        /// Returns the public IP of the current system using the 'checkip.dydns.org' API.
        /// </summary>
        public static string GetPublicIP() 
        {
            string url = "http://checkip.dyndns.org";
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            string a4 = a3[0];
            return a4;
        }
        /// <summary>
        /// Downloads the mentioned file to the mentioned address, using the System.Net.DownloadFile API.
        /// </summary>
        public static void Download(string Address, string FileLocation) 
        {
            WebClient client = new WebClient();
            client.DownloadFile(Address, FileLocation);
        }
        /// <summary>
        /// Downloads the mentioned file to the mentioned address asynchronous, using the System.Net.DownloadFileAsync API.
        /// </summary>
        public static void DownloadAsync(string Address, string FileLocation)
        {
            WebClient client = new WebClient();
            client.DownloadFileAsync(new System.Uri(Address), FileLocation);
        }
        /// <summary>
        /// Sends a HTTP web request to the specified server and returns the raw html.
        /// </summary>
        public static string APIRequest(string Url) 
        {
            string html = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            return html;
        }
    }
}
