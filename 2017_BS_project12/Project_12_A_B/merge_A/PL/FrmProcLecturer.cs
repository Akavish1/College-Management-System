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
    public partial class FrmProcLecturer : Form
    {
        public FrmProcLecturer()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void buttonAddLecturer_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToAdd);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void buttonRemoveLecturer_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(DeleteLec);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoBack()
        {
            Application.Run(new FrmSecretary());
        }

        private void Login()
        {
            Application.Run(new LogIn());
        }

        private void GoToAdd()
        {
            Application.Run(new AddLecturerForm());
        }

        private void DeleteLec()
        {
            Application.Run(new FrmDeleteLecturer());
        }

        private void GoToUpdateLect()
        {
            Application.Run(new UpdateLecturerForm());
        }

        private void buttonEditLecturer_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToUpdateLect);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
