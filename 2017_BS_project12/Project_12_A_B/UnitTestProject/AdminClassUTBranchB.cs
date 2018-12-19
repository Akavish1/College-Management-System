using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjBTesting
{
    [TestClass]
    public class AdminClassUT
    {
        Project_12_A_B.Classes.Admin adminclass = new Project_12_A_B.Classes.Admin();
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
