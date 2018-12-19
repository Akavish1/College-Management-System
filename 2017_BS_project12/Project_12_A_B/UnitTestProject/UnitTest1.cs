using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_12_A_B;
using System.Data;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestCourse
    {
        [TestMethod]
        public void TestAddCourse()
        {
            Project_Sce.CodeLayer.Course c = new Project_Sce.CodeLayer.Course();
            bool ExpectedAns;
            ExpectedAns = c.Add_Course("12320","Algebra 3",3, (float)5, "Required", true, false, "2");
            Assert.IsTrue(ExpectedAns);
        }
        [TestMethod]
        public void TestAddCourseFail()
        {
            Project_Sce.CodeLayer.Course c = new Project_Sce.CodeLayer.Course();
            bool ExpectedAns;
            ExpectedAns = c.Add_Course("12328", "Algebra 3",-1, (float)5, "Required", true, false, "2");
            Assert.IsFalse(ExpectedAns);
        }

        [TestMethod]
        public void TestVerify_CourseID()
        {
            Project_Sce.CodeLayer.Course c = new Project_Sce.CodeLayer.Course();
            int ExpectedAns;
            ExpectedAns = c.Verify_CourseID("0").Rows.Count;
            Assert.AreEqual(ExpectedAns,1);
        }

        [TestMethod]
        public void TestDeleteCourse()
        {
            Project_Sce.CodeLayer.Course c = new Project_Sce.CodeLayer.Course();
            bool ExpectedAns;
            ExpectedAns = c.Delete_Course("3");
            Assert.IsFalse(ExpectedAns);
        }

    }
}
