using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using MetroFramework.Forms;
namespace merge_B
{
    public partial class AddCourseToStudent : MetroForm
    {
        static string _ID;
        Boolean Res = true;
        public AddCourseToStudent(string coursename,string id)
        {
            _ID = id;
            InitializeComponent();
            this.CenterToScreen();
            using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Courses WHERE Name='" + coursename + "'", Globals.conn))
            {

                // fill a data table
                var t = new DataTable();
                a.Fill(t);

                CourseIdText.Text = t.Rows[0][0].ToString();
                CourseNameText.Text = t.Rows[0][1].ToString();
                CourseHoursText.Text = t.Rows[0][2].ToString();
                CoursePointsText.Text = t.Rows[0][3].ToString();
                CourseCatagoryText.Text = t.Rows[0][4].ToString();
                CourseLabText.Text = t.Rows[0][5].ToString();
                CoursePractitionText.Text = t.Rows[0][6].ToString();

            }
            try
            {
                using (SqlDataAdapter b = new SqlDataAdapter("SELECT * FROM Lesson WHERE CourseID='" + CourseIdText.Text.ToString() + "'", Globals.conn))
                {

                    // fill a data table
                    var Table = new DataTable();
                    b.Fill(Table);
                    if (Table.Rows.Count == 0)
                    {
                        MessageBox.Show("Can not register to this course , because yet there are no class for this course!\n- You have to Add Lesson for this course", "ERROR", MessageBoxButtons.OK);
                        Res = false;
                    }
                    AvailableSlotsText.Text = Table.Rows[0][7].ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void AddCourseToStudent_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (Res == false)
            {
                MessageBox.Show("Note: No lessons was found, No changes has been done!","NOTE",MessageBoxButtons.OK);
                this.Close();
                return;
            }
            Boolean res = false;
            res=Globals.GlobalSecretary.addcourseStudent(CourseIdText.Text.ToString(),_ID);
            if (res)
            {
                MessageBox.Show("Successfully added course:" + CourseNameText.Text.ToString() + "' to" + "ID:" + _ID);
            }
            this.Close();
        }
    }
}
