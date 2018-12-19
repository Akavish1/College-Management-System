using System;
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

namespace Project_Sce.PL

{
    public partial class FrmViewSchedule : Form
    {

       
     
        DAL.DataBase DB;

        private string  User, Password;
        private string  LctID;



        public FrmViewSchedule()
        {
            InitializeComponent();
            
        }

        public FrmViewSchedule(string  user,string  pass)
        {
            InitializeComponent();
            DB = new DAL.DataBase();
            DB.open();


            this.Password = pass;
            this.User = user;
            LctID = getLectID();
            if(LctID==null)
            {
                MessageBox.Show("ID not found in the system!");
            }
            else if(LctID!=null)
                 loadDataToGrid();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmViewSchedule_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void loadDataToGrid()

        {


           
            string temp = "SELECT Lesson.Type, Lesson.ClassRoom,Lesson.LecturerID, Lesson.CourseID,Lesson.Day,Lesson.StrtTime,Lesson.EndTime ,Courses.CourseID,Courses.Name FROM Lesson INNER JOIN Courses ON Courses.CourseID=Lesson.CourseID ORDER BY Day";

            SqlCommand cmd = new SqlCommand(temp, DB.Return_Connection());
            
            
            

            

            try
            {
               SqlDataReader read = cmd.ExecuteReader();
              
                while (read.Read())
                {
                    if (LctID == read["LecturerID"].ToString().Trim())
                    {
                        ListViewItem items = new ListViewItem(read["Day"].ToString());
                        items.SubItems.Add(read["ClassRoom"].ToString());
                        items.SubItems.Add(read["Type"].ToString());
                        items.SubItems.Add(read["CourseID"].ToString().Trim());
                        items.SubItems.Add(read["Name"].ToString().Trim());
                        items.SubItems.Add(read["StrtTime"].ToString());
                        items.SubItems.Add(read["EndTime"].ToString());
                        listView1.Items.Add(items);
                    }

                    }
                read.Close();
                read.Dispose();



            }
            catch(DataException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void GoBack()
        {
            Application.Run(new FrmLecturer(User,Password));
        }
      

        private string getLectID()
        {
            string name = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM  Lecturer", DB.Return_Connection());

            try
            {
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    if (read["login"].ToString().Trim() == User)
                    {
                        
                        name= read["id"].ToString().Trim();
                        read.Close();
                        read.Dispose();
                        return name;
                    }
                }
                read.Close();
                read.Dispose();
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
           
            return null;

        }






    }

    
}
