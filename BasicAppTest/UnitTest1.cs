using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AB_Basic_App_GitHub; //add

namespace BasicAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 tp = new Class1();
            Assert.AreEqual(tp.Name, "[Alyssa Butac] - The Code Master");
        }
    }
}
