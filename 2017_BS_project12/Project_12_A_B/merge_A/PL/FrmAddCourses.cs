using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Sce.PL
{
    public partial class FrmAddCourses : Form
    {
        CodeLayer.Course c = new CodeLayer.Course();
        private merge_A.PL.FormCourses parent;

        public FrmAddCourses()
        {
            InitializeComponent();
        }

        public FrmAddCourses(merge_A.PL.FormCourses parent_)
        {
            this.parent = parent_;
            InitializeComponent();
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {

            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
       
        private void label8_Click(object sender, EventArgs e){}

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (c.Verify_CourseID(CourseID.Text).Rows.Count==0)
            {
                c.Add_Course(CourseID.Text, CourseName.Text, Convert.ToInt32(HoursPerWk.Text), (float)Convert.ToDouble(Points.Text), Category.Text, Convert.ToBoolean(pract.Checked), Convert.ToBoolean(lab.Checked), textBox1.Text);
                MessageBox.Show("The course was successfully added to the database!", "Adding Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CourseName.Text = "";
                CourseID.Text = "";
                Points.Text = "";
                HoursPerWk.Text = "";
                Category.Text = "";
                pract.Text = "";
                lab.Text = "";
                textBox1.Text = "";
                this.parent.RefreshDataSource();
                this.Close();
            }
            else
                MessageBox.Show("The course already exist in database!", "Adding Course", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void Login()
        {
            Application.Run(new LogIn());
        }

        private void GoBack()
        {
            Application.Run(new FrmCourses());
        }
    }
}
