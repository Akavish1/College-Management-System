﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MetroFramework.Forms;
using System.Data.SqlClient;
namespace Project_12_A_B
{
    public partial class EditStudentSchedule : MetroForm
    {
        private int b;
        public EditStudentSchedule()
        {
            InitializeComponent();
        }
        private void GetCompulsoryCourses()
        {
            //clearing first
            compCoursesText.Items.Clear();
            // use a SqlAdapter to execute the query
            using (SqlDataAdapter b = new SqlDataAdapter("SELECT * FROM Courses where Semester='" + SemText.Text.ToString() + "'and Category='" + "Required" + "'", Globals.conn))
            {

                // fill a data table
                var t = new DataTable();
                b.Fill(t);
                if (t.Rows.Count == 0)
                {
                    compCoursesText.Items.Add("NO Registered Courses");
                    return;
                }
                foreach (DataRow row in t.Rows)
                {
                    if (!MyCourses.Items.Contains(row[1].ToString()))
                    {
                        compCoursesText.Items.Add(row[1]);
                    }
                }
            }
        }
        private void GetCoursesOfStudent()
        {
            //clearing first
            MyCourses.Items.Clear();
            //Getting all the details
            string Select = @"SELECT s.StudID, s.CourseID, c.Name, c.Semester
            FROM dbo.Login l 
	        INNER JOIN dbo.StudentCourses s ON ( l.Id = s.StudID  )  
		    INNER JOIN dbo.Courses c ON ( s.CourseID = c.CourseID  )  ";
            using (SqlDataAdapter a = new SqlDataAdapter(Select, Globals.conn))
            {
                // fill a data table
                var t = new DataTable();
                a.Fill(t);
                foreach (DataRow row in t.Rows)
                {
                    //displaying to student suitable data.
                    if (row[3].ToString() == SemText.Text.ToString() && row[0].ToString() == IDText.Text.ToString())
                    {
                        MyCourses.Items.Add(row[2]);
                    }
                }
            }
        }
        private void optional_Courses()
        {
            OptionCourses.Items.Clear();
            //getting the optional courses.
            using (SqlDataAdapter b = new SqlDataAdapter("SELECT * FROM Courses where Semester='" +SemText.Text.ToString() + "'and Category='" + "Not Required" + "'", Globals.conn))
            {

                // fill a data table
                var t = new DataTable();
                b.Fill(t);
                if (t.Rows.Count == 0)
                {
                    OptionCourses.Items.Add("No Available Courses");
                    return;
                }
                foreach (DataRow row in t.Rows)
                {
                    if (!MyCourses.Items.Contains(row[1].ToString()))
                    {
                        OptionCourses.Items.Add(row[1]);
                    }
                }
            }
        }
        private void EditStudentSchedule_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void addPanelToTable(int day, int startTime, int endTime, string courseid, string coursename, string classnum)
        {
            //doing random colors          
            Thread.Sleep(20); //delaying.
            Random r = new Random();
            b = r.Next(1, 5);
            MetroFramework.Controls.MetroTile pan = new MetroFramework.Controls.MetroTile();

            switch (b)
            {
                case 1:
                    {
                        pan.Style = MetroFramework.MetroColorStyle.Lime;

                    }
                    break;
                case 2:
                    {
                        pan.Style = MetroFramework.MetroColorStyle.Green;
                    }
                    break;
                case 3:
                    {
                        pan.Style = MetroFramework.MetroColorStyle.Red;
                    }
                    break;

                case 4:
                    {
                        pan.Style = MetroFramework.MetroColorStyle.Brown;
                    }

                    break;
            }
            pan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            pan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            pan.Dock = DockStyle.Fill;
            pan.Location = new Point(100, 100);
            this.table.Controls.Add(pan);
            this.table.Controls.Add(pan, (day - 1), (startTime - 7));
            this.table.SetRowSpan(pan, endTime - startTime + 1);


            pan.Text = "" + coursename + "\n" + courseid + "\n" + classnum + "\n" + startTime + "-" + endTime;
            pan.Width = 100;
            pan.Height = 100;
            pan.Click += (sender, e) => panelButton(sender, e, coursename);

        }
        protected void panelButton(object sender, EventArgs e, string coursename)
        {
            RemoveStudentCourses cd = new RemoveStudentCourses(coursename,IDText.Text.ToString());
            cd.ShowDialog();
        }






        //creating schedule function
        private void createSchedule()
        {
            //getting all the courses 
            //Getting the courses that student registered for.
            string Select = @"SELECT s.StudID, s.CourseID, c.Name, c.Semester, l1.ClassRoom, l1.Day, l1.StrtTime, l1.EndTime
            FROM dbo.Login l 
	        INNER JOIN dbo.StudentCourses s ON ( l.Id = s.StudID  )  
		    INNER JOIN dbo.Courses c ON ( s.CourseID = c.CourseID  )  
			INNER JOIN dbo.Lesson l1 ON ( c.CourseID = l1.CourseID  )  ";
            string day;
            string cname;
            string cid;
            string classnum;
            int startTime;
            int endTime;
            int dayInNum = 2;
            using (SqlDataAdapter a = new SqlDataAdapter(Select, Globals.conn))
            {
                // fill a data table
                var t = new DataTable();
                a.Fill(t);
                foreach (DataRow row in t.Rows)
                {
                    //displaying to student suitable data.
                    if (row[3].ToString() == SemText.Text.ToString() && row[0].ToString() == IDText.Text.ToString())
                    {
                        day = row[5].ToString();
                        startTime = Int32.Parse(row[6].ToString());
                        endTime = Int32.Parse(row[7].ToString());
                        cid = row[1].ToString();
                        cname = row[2].ToString();
                        classnum = row[4].ToString();
                        switch (day)
                        {
                            case "Sunday":
                                dayInNum = 1;
                                break;
                            case "Monday":
                                dayInNum = 2;
                                break;
                            case "Tuesday":
                                dayInNum = 3;
                                break;
                            case "Wednesday":
                                dayInNum = 4;
                                break;
                            case "Thursday":
                                dayInNum = 5;
                                break;
                            default:
                                break;
                        }
                        this.addPanelToTable(dayInNum, startTime, endTime, cid, cname, classnum);
                    }
                }
            }
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            /*//saving details
            this.Close();
            Thread th = new Thread(GoSecretary);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();*/



            //if the user is secretary
            if (Int32.Parse(Globals.LoggedUser.getPerm()) == 1)
            {
                //View login Panel
                this.Close();
                Thread th = new Thread(GoSecretary);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            //if the user is Admin
            else if (Int32.Parse(Globals.LoggedUser.getPerm()) == 2)
            {
                //View login Panel
                this.Close();
                Thread th = new Thread(GoAdmin);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
        private void GoAdmin()
        {
            Application.Run(new Admin());
        }
        private void GoSecretary()
        {
            Application.Run(new SecretaryFrm());
        }
        private void clearSchedule()
        {
            for(int i=0;i<5;i++)
            {
                for(int j=1;j<=14;j++)
                {
                    Control a = table.GetControlFromPosition(i, j);
                    table.Controls.Remove(a);
                }
            }
        }
        private void FindBtn_Click(object sender, EventArgs e)
        {


            //clearing schedule
            clearSchedule();


            //Gettings details of student such name id sem etc..
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Login where id='" + IDText.Text.ToString() + "'" + "and Permission=0", Globals.conn))
                {
                    sda.Fill(dt);
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("Invalid Input or there are no id such this!");
                        return;
                    }
                    //////////////////////////////////////////////////
                    IDText.Text = dt.Rows[0][0].ToString();
                    NameTextBox.Text = dt.Rows[0][1].ToString();
                    PasswordTextBox.Text = dt.Rows[0][2].ToString();
                    AddressTextBox.Text = dt.Rows[0][7].ToString();
                    EmailTextBox.Text = dt.Rows[0][5].ToString();
                    SemText.Text = dt.Rows[0][6].ToString();
                    ///////////////////////////////////////////////////

                    ///////////////////////////////////////////////////
                }
            }
            catch
            {
                MessageBox.Show("unExpected ERROR Occured!", "ERROR", MessageBoxButtons.OK);
            }



            /////////////////////////////////////////////////////
            /*Getting courses details*/
            /////////////////////////////////////////////////////
            GetCoursesOfStudent();


            /////////////////////////////////////////////////////
            /*Getting courses details*/
            /////////////////////////////////////////////////////

            GetCompulsoryCourses();

            optional_Courses();

            /////////////////////////////////////////////////////
            /*Getting courses details*/
            /////////////////////////////////////////////////////
            createSchedule();
        
            
        }










        private void compCoursesText_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id;//stud id
            id = IDText.Text.ToString();
            if (compCoursesText.SelectedItem == null)
                return;
            //checking if student already registered to the specific course.
            foreach (string item in MyCourses.Items)
            {
                if (item == compCoursesText.GetItemText(compCoursesText.SelectedItem))
                {
                    MessageBox.Show("You are already registered to this course!", "ERROR", MessageBoxButtons.OK);
                    return;
                }
            }
            //if not..
            //demo version of registering to course..//

            //Do Draw of the course so student can see hours. ==> #1



            //Do available hours of same course. ==> #2



            //Do registering.. and save to DB. ==> #3
            AddCourseToStudent StudCourseAdd = new AddCourseToStudent(compCoursesText.GetItemText(compCoursesText.SelectedItem),id);
            StudCourseAdd.ShowDialog();

        }

        private void OptionCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OptionCourses.SelectedItem == null)
                return;
            AddCourseToStudent AddCourseToStudent = new AddCourseToStudent(OptionCourses.GetItemText(OptionCourses.SelectedItem).ToString(), IDText.Text.ToString());
            AddCourseToStudent.ShowDialog();
        }

        private void MyCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MyCourses.SelectedItem == null)
                return;
            RemoveStudentCourses cd = new RemoveStudentCourses(MyCourses.GetItemText(MyCourses.SelectedItem).ToString(), IDText.Text.ToString());
            cd.ShowDialog();
        }
    }

}
