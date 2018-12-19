using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_12_A_B;
using System.Data;

namespace UnitTestProject
{

    [TestClass]
    public class UnitTestStudent
    {
        [TestMethod]
        public void TestSearch_Student()
        {
            Project_Sce.CodeLayer.Student s = new Project_Sce.CodeLayer.Student();
            DataTable Answer = s.Search_Student("123");
            Assert.AreEqual(Answer.Rows.Count, 1);
        }


        [TestMethod]
        public void TestGet_Courses()
        {
            Project_Sce.CodeLayer.Student s = new Project_Sce.CodeLayer.Student();
            DataTable Answer = s.Get_Courses("123");


            foreach (DataRow dataRow in Answer.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Assert.AreEqual(item, 1024);
                }
            }

        }


        [TestMethod]
        public void TestGet_Student_Info()
        {
            Project_Sce.CodeLayer.Student s = new Project_Sce.CodeLayer.Student();
            DataTable Answer = s.Get_Student_Info("bar");

            foreach (DataRow dataRow in Answer.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Assert.AreEqual(item, "123");//id
                    Assert.AreEqual(item, 2);//year
                    Assert.AreEqual(item, 100);//average
                    Assert.AreEqual(item, "bialik");//address
                    Assert.AreEqual(item, "noemail@yahoo.com");//email
                    Assert.AreEqual(item, 2);//semester
                    Assert.AreEqual(item, false);//cyber

                }
            }
        }


    }


}
