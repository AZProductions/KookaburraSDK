using System;
using Kookaburra.SDK;
using System.Threading;
using Kookaburra.SDK.Networking;

namespace Kookaburra.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug test = new Debug(@"D:\Projects\Kookaburra\publish\win-x64\KookaburraShell.exe");
            test.Start(true);
            test.Stop();
        }
    }
}
