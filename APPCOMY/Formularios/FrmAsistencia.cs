﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOMY
{
    public partial class FrmAsistencia : Form
    {
        public FrmAsistencia()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu back = new FrmMenu();
            back.Show();


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();
        }

       

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();
        }

        private void imgAsistencia_Click(object sender, EventArgs e)
        {

        }
    }
}
