using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessLogic;

namespace TP_net
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioBE usu = new UsuarioBE(txtEmail.Text, txtContraseña.Text);
            UsuarioBL us = new UsuarioBL();
            UsuarioBE usuario = us.Buscador(usu);

            if (usuario != null)
            {
                MessageBox.Show("Usuario encontrado");
            }
            else
            {
                MessageBox.Show("No se encontro el usuario");
            }
        }

        private void lnkCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro frm = new frmRegistro();
            frm.Show();
        }
    }
}

