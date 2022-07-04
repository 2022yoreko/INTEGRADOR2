﻿using APPCOMY.Formularios;
using System;
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
    public partial class FrmMenu : Form
    {
        public static bool PnlVisible { get; internal set; }

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRegistro_Estudiantes_Click(object sender, EventArgs e)
        {
            FrmRegistro_Estudiantes administrador = new FrmRegistro_Estudiantes();
            administrador.ShowDialog();
        }

        private void btnPerfil_Alumnos_Click(object sender, EventArgs e)
        {
            FrmPerfil administrador = new FrmPerfil();
            administrador.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistro_Estudiantes administrador = new FrmRegistro_Estudiantes();
            administrador.ShowDialog();
        }

        private void btnInformacion_Personal_Click(object sender, EventArgs e)
        {
            FrmPerfil administrador = new FrmPerfil();
            administrador.ShowDialog();
        }

        private void btnTabla_Asistencia_Click(object sender, EventArgs e)
        {
            FrmAsistencia administrador = new FrmAsistencia();
            administrador.ShowDialog();
        }


        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil administrador = new FrmPerfil();
            administrador.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda administrador = new FrmAyuda();
            administrador.ShowDialog();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            var newForm1 = new FrmMenu();
            newForm1.Show();
            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}