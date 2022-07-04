﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOMY
{
    public partial class FrmRegistro_Estudiantes : Form
    {
        public FrmRegistro_Estudiantes()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();
                
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FileStream fs;  
            StreamWriter escribe;
            string linea;

            string rutbase = Directory.GetCurrentDirectory();

            string rutarchivo = rutbase.Replace(@"\bin\Debug", @"\Archivos\Usuario.txt");

            fs = new FileStream(rutarchivo, FileMode.Append);

            escribe = new StreamWriter(fs);
            
            linea = txtN_carne.Text + ";";
            linea += txtNombres.Text + ";";
            linea += txtApellidos.Text + ";";
            linea += cmbFacultad.SelectedItem.ToString();
            linea += txtCarrera.Text + ";";
            linea += txtAño.Text + ";";
            linea += txtPromedio.Text +";";
            linea += txtTelefono.Text + ";";
            linea += cmbDepto.SelectedItem.ToString();
            escribe.WriteLine(linea.ToUpper());
            escribe.Close();
            


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}