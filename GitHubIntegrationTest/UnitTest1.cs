using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GitHubIntegrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(100,100);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(100, 101);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(101, 102);
        }
    }
}
