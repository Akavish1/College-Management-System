using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


using System.Drawing;

using System.Windows.Forms;


namespace Project_12_A_B.Classes
{
    public class Student:User
    {
        public int SemCount { get; set; }
       
        /// <summary>
        /// 
        /// </summary>
        public Student() : base()
        {
            init();
        }
        /// <summary>
        /// Copy Ctor for User -> Student
        /// </summary>
        /// <param name="u"></param>
        public Student(User u) : base(u)
        {
            init();
        }
        /// <summary>
        /// 
        /// </summary>
        private void init()
        {
            /// create a new Curriculum       
        }
        public Boolean removeCourse(string courseid)
        {
            Boolean res = false;
            int numofStudents;
            string RegisterOption;
            try
            {
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Courses", Globals.conn))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);
                    RegisterOption = t.Rows[0][8].ToString();
                    //checking if the secretary has already disabled/enabled the registration
                    if (Int32.Parse(RegisterOption) == 0) //
                    {//
                        MessageBox.Show("Secretary has disabled course cancellation.", "ERROR", MessageBoxButtons.OK);//
                        return false;//
                    }//
                }
                using (SqlCommand cmd = new SqlCommand("DELETE FROM StudentCourses WHERE StudID= @StudID AND CourseID = @CourseID", Globals.conn))//
                { //                   
                    cmd.CommandText = "DELETE FROM StudentCourses WHERE StudID= @StudID AND CourseID = @CourseID";//
                    cmd.Parameters.AddWithValue("@StudID", (Globals.LoggedUser as Classes.Student).getId());//
                    cmd.Parameters.AddWithValue("@CourseID", courseid);//

                    cmd.ExecuteNonQuery();//
                }//
                //Getting the current slots in lesson.
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Lesson WHERE CourseID='" + courseid + "'", Globals.conn))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);
                    numofStudents = Int32.Parse(t.Rows[0][7].ToString()) + 1; //has been registered so count --
                }
                //updating the slots.
                SqlCommand cmd2 = new SqlCommand("UPDATE Lesson SET Numofstud= @Numofstud WHERE CourseID='" + courseid + "'", Globals.conn);
                cmd2.Parameters.AddWithValue("@Numofstud", numofStudents.ToString());
                cmd2.ExecuteNonQuery();
                res = true;
            }
            catch
            {
                MessageBox.Show("Error occured while trying to remove course id: '" + courseid + "' , try again later", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            //inform the user.
            MessageBox.Show("successfully Removed course id:"+courseid ,"Course Registeration", MessageBoxButtons.OK);
            return res;
        }
        public Boolean registertoCourse(string courseid , string lecID)
        {
            Boolean res = false;
            int numofStudents;
            //updating the details .
            //Getting all the details
            try
            {
                //Checking if possible to register.
                string RegisterOption;
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Courses", Globals.conn))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);
                    RegisterOption = t.Rows[0][8].ToString();
                }
                //let's check if secretary disabled/enabled registration :D
                if (Int32.Parse(RegisterOption) == 0)
                {
                    MessageBox.Show("Secretary has disabled course registation.", "ERROR", MessageBoxButtons.OK);
                    return false;
                }
                //Getting the current slots in lesson.
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Lesson WHERE CourseID='" + courseid + "'"+"AND LecturerID='"+lecID+"'", Globals.conn))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);
                    numofStudents = Int32.Parse(t.Rows[0][7].ToString()) - 1; //has been registered so count --
                }
                //////////////////////////////////////////////////////////////
                if(numofStudents+1<=0)
                {
                    MessageBox.Show("No available slots in this class!");
                    return false;
                }
                //////////////////////////////////////////////////////////////
                //registering to course.
                //updating course table
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentCourses (StudID, CourseID,LecturerID) VALUES (@StudID, @CourseID,@LecturerID)", Globals.conn);
                cmd.Parameters.AddWithValue("@StudID", (Globals.LoggedUser as Classes.Student).getId());
                cmd.Parameters.AddWithValue("@CourseID", courseid);
                cmd.Parameters.AddWithValue("@LecturerID", lecID);
                cmd.ExecuteNonQuery();
                //////////////////////////////////////////////////////////////
                //updating the slots.
                SqlCommand cmd2 = new SqlCommand("UPDATE Lesson SET Numofstud= @Numofstud WHERE CourseID='"+courseid+"'", Globals.conn);
                cmd2.Parameters.AddWithValue("@Numofstud", numofStudents.ToString()); 
                cmd2.ExecuteNonQuery();
                res = true;
            }
            catch
            {
                MessageBox.Show("Error occured while trying to register to course id: '" + courseid + "' , try again later","ERROR",MessageBoxButtons.OK);
                return false;
            }
            //inform the user.
            MessageBox.Show("Details have been successfully changed!", "Course Registeration", MessageBoxButtons.OK);
            return res;
        }
        public Boolean SendRequest(String Option,String Request)
        {
            Boolean res = false;
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Requests (id, Choice, Reason) VALUES (@id ,@Choice, @Reason)", Globals.conn);
                cmd.Parameters.AddWithValue("@id",Globals.LoggedUser.getId());
                cmd.Parameters.AddWithValue("@Choice", Option);
                cmd.Parameters.AddWithValue("@Reason", Request);
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (SqlException v)
            {
                MessageBox.Show("Error occured while submitting request reason:"+v, "ERROR", MessageBoxButtons.OK);
                return false;
            }
            return res;
        }
    }
}
