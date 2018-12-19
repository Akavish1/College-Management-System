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

namespace Project_Sce.PL
{
    public partial class FrmCourses : Form
    {
        public FrmCourses()
        {
            InitializeComponent();
        }



        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void AddCoursebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(AddCourses);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void DelCoursebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(DelCourses);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void GoBack()
        {
            Application.Run(new FrmSecretary());
        }

        private void GoToLogin()
        {
            Application.Run(new LogIn());
        }

        private void AddCourses()
        {
            Application.Run(new FrmAddCourses());
        }

        private void DelCourses()
        {
            Application.Run(new FrmDeleteCourses());
        }


    }
}
