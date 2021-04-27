using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace TestSamples
{
    [TestClass]
    public class PlatformTests
    {
        [TestMethod]
        public void IsRunningOnLinux()
        {
            Console.WriteLine(RuntimeInformation.OSDescription);
            Assert.IsTrue(RuntimeInformation.IsOSPlatform(OSPlatform.Linux));
        }

        [TestMethod]
        public void IsRunningOnWindows()
        {
            Console.WriteLine(RuntimeInformation.OSDescription);
            Assert.IsTrue(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
        }

        [TestMethod]
        public void IsRunningOnNet31()
        {
            Console.WriteLine(RuntimeInformation.FrameworkDescription);
            Assert.IsTrue(RuntimeInformation.FrameworkDescription.Contains("3.1"));
        }

        [TestMethod]
        public void IsRunningOnNet50()
        {
            Console.WriteLine(RuntimeInformation.FrameworkDescription);
            Assert.IsTrue(RuntimeInformation.FrameworkDescription.Contains("5.0"));

        }

        [TestMethod]
        public void IsRunningOnNet60()
        {
            Console.WriteLine(RuntimeInformation.FrameworkDescription);
            Assert.IsTrue(RuntimeInformation.FrameworkDescription.Contains("6.0"));
        }
    }
}
