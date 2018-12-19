using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sce.PL
{
    public partial class FrmClassroom : Form
    {
        public FrmClassroom()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(AddClassroom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(DelClassroom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void AddClassroom()
        {
            Application.Run(new FrmAddClassroom());
        }

        private void DelClassroom()
        {
            Application.Run(new FrmDelClassroom());
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

        private void GoBack()
        {
            Application.Run(new FrmSecretary());
        }

        private void GoToLogin()
        {
            Application.Run(new LogIn());
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            var someForm = new FormEditClassroom();
            someForm.ShowDialog();
        }
    }
    }
