using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Korvi.Vimeo.Api.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var client = new ApiClient("");

            var video = client.GetVideo("");


            Assert.IsTrue(video != null);
        }
    }
}
