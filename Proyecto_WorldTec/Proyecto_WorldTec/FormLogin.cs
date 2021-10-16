﻿using BL.Tecnologia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_WorldTec
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;
        public FormLogin()
        {
            InitializeComponent();
            _seguridad = new SeguridadBL();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar el Sistema?",
             "Saliendo del Sistema",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            var resultado = _seguridad.Autorizar(usuario, contrasena);
            
            if (resultado == true)
            {
                MessageBox.Show("Bienvenido al Sistema" + " " + usuario);
                this.Close();
            }
            else if ( resultado == false)
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
