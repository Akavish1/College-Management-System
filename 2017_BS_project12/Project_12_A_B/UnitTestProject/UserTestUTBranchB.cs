using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjBTesting
{
    [TestClass]
    public class UserTestUT
    {
        [TestMethod]
        public void TestingName()
        {
            string getName = null;
            Project_12_A_B.Globals.LoggedUser.setName("Hanan");
            getName = Project_12_A_B.Globals.LoggedUser.getName();
            Assert.AreEqual(getName, Project_12_A_B.Globals.LoggedUser.getName());
        }
        [TestMethod]
        public void TestingID()
        {
            string getID = null;
            Project_12_A_B.Globals.LoggedUser.setId("123");
            getID = Project_12_A_B.Globals.LoggedUser.getId();
            Assert.AreEqual(getID, Project_12_A_B.Globals.LoggedUser.getId());
        }
        [TestMethod]
        public void TestingEmail()
        {
            string email="test@test.test";
            Project_12_A_B.Globals.LoggedUser.setMail("test@test.test");
            Assert.AreEqual(email, Project_12_A_B.Globals.LoggedUser.getMail());
        }
        [TestMethod]
        public void TestingSem()
        {
            string sem = "1";
            Project_12_A_B.Globals.LoggedUser.setSemester("1");
            Assert.AreEqual(sem, Project_12_A_B.Globals.LoggedUser.getSemester());
        }
        [TestMethod]
        public void TestingAddress()
        {
            string add = "KafrQaraa";
            Project_12_A_B.Globals.LoggedUser.setAddress("KafrQaraa");
            Assert.AreEqual(add, Project_12_A_B.Globals.LoggedUser.getAddress());
        }
        [TestMethod]
        public void TestingPwd()
        {
            string pwd = "ab24cd45w";
            Project_12_A_B.Globals.LoggedUser.setPwd("ab24cd45w");
            Assert.AreEqual(pwd, Project_12_A_B.Globals.LoggedUser.getPwd());
        }
    }
}
