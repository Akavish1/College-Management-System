using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sce.PL
{
    public partial class FormEditClassroom : Form
    {
        CodeLayer.Classroom c = new CodeLayer.Classroom();
        public FormEditClassroom()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            c.Update_Classroom(name.Text, Convert.ToInt32(numOfSeats.Text), Convert.ToBoolean(proj.Checked), Convert.ToBoolean(comp.Checked));
            MessageBox.Show("Success!", "Updating Classroom Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            name.Text = "";
            numOfSeats.Text = "";
            proj.Text = "";
            comp.Text = "";
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void proj_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void available_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numOfSeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
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

        private void name_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}
