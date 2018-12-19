using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Sce.PL
{
    public partial class FrmDeleteCourses : Form
    {
        CodeLayer.Course c = new CodeLayer.Course();

        private merge_A.PL.FormCourses parent;

        public TextBox CourseIDBox_
        {
            get { return this.CourseIDBox; }
            set { this.CourseIDBox = value; }
        }

        public FrmDeleteCourses()
        {
            InitializeComponent();
        }

        public FrmDeleteCourses(merge_A.PL.FormCourses parent_)
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

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void DeleteCoursebtn_Click(object sender, EventArgs e)
        { 
            
            try
            {
                
                SqlConnection con = new SqlConnection(@"Data Source=mahdias.database.windows.net;Initial Catalog=ProjectSCE;User ID=Mahdias;Password=Aa123123");
                SqlCommand cmd = new SqlCommand("delete from Courses where CourseID= @ID", con);
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = CourseIDBox.Text;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.ExecuteNonQuery();
                CourseIDBox.Clear();
                MessageBox.Show("The course was successfully deleted from the database!", "Deleting Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.parent.RefreshDataSource();
                this.Close();
                /*foreach (DataGridViewRow row in this.Parent.dataGridViewCourses.SelectedRows)
                {
                    //dataGridViewCourses.Rows.Remove(row);
                    //dataGridViewCourses.Rows.Add(row);
                    FormUpdateCourseBySecretary form = new FormUpdateCourseBySecretary();
                }*/
            }
            catch (Exception ex) { string x = ex.ToString(); }


            //c.Delete_Course((CourseIDBox.Text));
            
        }

        public void GoBack()
        {
            Application.Run(new FrmCourses());
        }

        public void Login()
        {
            Application.Run(new LogIn());
        }

        private void CourseIDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
