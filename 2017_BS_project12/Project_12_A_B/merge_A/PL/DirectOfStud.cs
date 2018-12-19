using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Project_Sce.PL
{
    public partial class DirectOfStud : Form
    {
        public DirectOfStud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudents st = new FrmStudents();
            st.Text = "Direct Of Students";
            st.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            Thread th = new Thread(HomePage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void DirectOfStud_Load(object sender, EventArgs e) { }

        public void HomePage()
        {
            Application.Run(new LogIn());
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoCoursesForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void GoCoursesForm()
        {
            merge_A.PL.FormCourses form = new merge_A.PL.FormCourses();
            form.Permission = 6;
            form.Text = "Direct Of Students - Courses";
            Application.Run(form);
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoStudentsForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void buttonLecturers_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoLecturerForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void GoClassesForm()
        {
            Application.Run(new merge_A.PL.FormClasses(6));
        }

        private void GoLecturerForm()
        {
            merge_A.PL.FormLecturers form = new merge_A.PL.FormLecturers();
            form.Permission = 6;
            form.Text = "Direct Of Students - Lecturers";
            Application.Run(form);
        }

        private void GoStudentsForm()
        {
            merge_A.PL.FormStudents form = new merge_A.PL.FormStudents();
            form.Permission = 6;
            form.Text = "Direct Of Students - Students";
            Application.Run(form);
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoClassesForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
