using System;
using Project_Sce.CodeLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using Project_Sce.PL;


namespace merge_A.PL
{
    public partial class StudentsSec : Form
    {
        Project_Sce.CodeLayer.Project_Sce.CodeLayer.Student std = new Project_Sce.CodeLayer.Student();
        public StudentsSec()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = std.get_All_Students();
        }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
        private void Open_Click(object sender, EventArgs e)
        {
            DataTable dt = std.Get_Courses(Project_Sce.CodeLayer.StudentID_txt.Text);

            try
            {
                if (dt.Rows.Count > 0)
                {
                    StudentSectionDirect st = new StudentSectionDirect(Project_Sce.CodeLayer.StudentID_txt.Text);
                    st.ShowDialog();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Incorrect ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            StudentID_txt.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = std.Search_Student(textBox1.Text);
            this.dataGridView1.DataSource = dt;
        }
       

        private void Remove_From_Cyber_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=mahdias.database.windows.net;Initial Catalog=ProjectSCE;User ID=Mahdias;Password=Aa123123");
                SqlCommand cmd = new SqlCommand("update Project_Sce.CodeLayer.Student set Cyber='false' where StudID= @ID", con);
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = StudentId.Text;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.ExecuteNonQuery();
                StudentId.Clear();
                MessageBox.Show("The student was successfully removed from the cyber section!", "Remove From Cyber", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = std.get_All_Students();
            }
            catch (Exception ex) { string x = ex.ToString(); }
        }

        private void Add_To_Cyber_Click_1(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=mahdias.database.windows.net;Initial Catalog=ProjectSCE;User ID=Mahdias;Password=Aa123123");
                SqlCommand cmd = new SqlCommand("update Project_Sce.CodeLayer.Student set Cyber='true' where StudID= @ID", con);
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = StudentId.Text;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.ExecuteNonQuery();
                StudentId.Clear();
                MessageBox.Show("The student was successfully added from the cyber section!", "Remove From Cyber", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = std.get_All_Students();

            }
            catch (Exception ex) { string x = ex.ToString(); }

        }

        private void Block_Student_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=mahdias.database.windows.net;Initial Catalog=ProjectSCE;User ID=Mahdias;Password=Aa123123");
                SqlCommand cmd = new SqlCommand("delete from Student where StudID= @ID", con);
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = StudentId.Text;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.ExecuteNonQuery();
                StudentId.Clear();
                MessageBox.Show("The student was successfully Blocked and removed from the system ", "Block Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.DataSource = std.get_All_Students();

            }
            catch (Exception ex) { string x = ex.ToString(); }

        }
    }
}
