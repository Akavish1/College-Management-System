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
    public partial class FrmDelClassroom : Form
    {
        CodeLayer.Classroom c = new CodeLayer.Classroom();
        public FrmDelClassroom()
        {
            InitializeComponent();
        }

        private void DeleteCoursebtn_Click(object sender, EventArgs e)
        {
            c.Delete_Classroom((name.Text));
            MessageBox.Show("The classroom was successfully deleted from the database!", "Deleting Classroom", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void GoBack()
        {
            Application.Run(new FrmClassroom());
        }

        public void Login()
        {
            Application.Run(new LogIn());
        }
    }
}
