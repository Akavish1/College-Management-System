﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MetroFramework.Forms;

namespace Project_12_A_B
{
    public partial class YouTube : MetroForm
    {
        public YouTube()
        {
            InitializeComponent();
        }

        private void YouTube_Load(object sender, EventArgs e)
        {

        }

        private void SCEYouTube_Enter(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(BackToStudent);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void BackToStudent()
        {
            Application.Run(new Student());
        }
    }
}
