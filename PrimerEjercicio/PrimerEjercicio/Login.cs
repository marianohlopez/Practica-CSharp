﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerEjercicio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if(txtClave.Text == "Contraseña")
            {
                txtClave.Text = "";
                txtClave.UseSystemPasswordChar = true;
            }

        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "Contraseña";
                txtClave.UseSystemPasswordChar = false;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Administrador" &&  txtClave.Text == "Admin1234")
            {
                Form formulario2 = new PrimerEjercicio();
                formulario2.Show();
            }
            else {
                MessageBox.Show("Error en los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
    }
}
