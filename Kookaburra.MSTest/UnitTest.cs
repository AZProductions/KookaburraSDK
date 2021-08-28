using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kookaburra.SDK;
using System.Runtime.Versioning;

namespace Kookaburra.MSTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void StartsWithUpper()
        {
            Assert.IsTrue(Markup.StartsWithUpper("Hello"));
        }
        [TestMethod]
        public void GetOSPlatform()
        {
            Assert.IsNotNull(Env.GetOSPlatform());
        }
        [SupportedOSPlatform("windows")]
        [TestMethod]
        public void GetManufacturerName()
        {
            Assert.IsNotNull(Env.GetManufacturerName());
        }
        [SupportedOSPlatform("windows")]
        [TestMethod]
        public void GetBatteryPercentage()
        {
            BatteryInformation bi = new BatteryInformation();
            Assert.IsNotNull(bi.GetPercentage());
        }
    }
}
