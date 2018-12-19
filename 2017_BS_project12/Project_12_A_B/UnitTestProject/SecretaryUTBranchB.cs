using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ProjBTesting
{
    [TestClass]
    public class SecretaryUT
    {
        Project_12_A_B.Classes.SecretaryClass seclass = new Project_12_A_B.Classes.SecretaryClass();

        [TestMethod]
        public void seccAddCourseToStudent()
        {
            bool result = false;
            result = seclass.addcourseStudent("1024", "1", "1234");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void seccRemoveCourseToStudent()
        {
            bool result = false;
            result = seclass.removeCourse("1024", "1");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void saveStudInfo()
        {
            bool result = false;
            result = seclass.SaveStudentInfo("1", "Mahdi Asali", "1", "Kafr Qaraa", "Together.m.1995@gmail.com", "1");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void postAnnouncement()
        {
            string checkpost = null;
            seclass.PostAnnouncement("Tomorrow will not be lesson in subject: Algorithms");
            checkpost = seclass.getPost();
            Assert.AreEqual(checkpost, "Tomorrow will not be lesson in subject: Algorithms");
        }
        [TestMethod]
        public void RequestTechnicalSupportTesting()
        {
            bool res = false;
            res=seclass.RequestTechnicalSupport("Testing asking for help!");
            Assert.IsTrue(res);
        }
    }
}