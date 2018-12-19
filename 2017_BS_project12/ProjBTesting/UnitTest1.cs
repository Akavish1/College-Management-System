using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjBTesting
{
    [TestClass]
    public class UnitTest1
    {
        projB2.Classes.Admin adminclass = new projB2.Classes.Admin();
        [TestMethod]
        public void ClassAdminTesting()
        {
            bool res = false;
            adminclass.setId("98764");
            adminclass.setName("TesterRobot");
            res=adminclass.SendRequest("aaa");
            Assert.IsTrue(res);
        }
    }
}
