using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjBTesting
{
    [TestClass]
    public class AnnouncementUT
    {
        Project_12_A_B.Classes.SecretaryClass addann = new Project_12_A_B.Classes.SecretaryClass();
        [TestMethod]
        public void AddingAnnouncement()
        {
            addann.PostAnnouncement("A new version of project 12 has been released !");
            string get=addann.getPost();
            Assert.AreEqual(get, "A new version of project 12 has been released !");
        }
    }
}
