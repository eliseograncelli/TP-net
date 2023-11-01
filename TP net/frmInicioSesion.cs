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
                if (usuario.Tipo == "Cliente")
                {
                    
                    frmCliente frm = new frmCliente(usuario);
                    frm.Show();
                    borrarCampos();
                }
                else if (usuario.Tipo == "Vendedor")
                {
                    if (usuario.Estado == "Activo")
                    {
                        frmVendedor frm = new frmVendedor(usuario);
                        frm.Show();
                        borrarCampos();
                    }
                    else MessageBox.Show("Su cuenta sera activada a la brevedad, por favor espere.");
                }
                else if (usuario.Tipo == "Mayorista")
                {
                    MessageBox.Show("Usuario encontrado");
                    borrarCampos();
                }
                else if (usuario.Tipo == "Administrador")
                {
                    frmAdminUsuarios frm = new frmAdminUsuarios();
                    frm.Show();
                    borrarCampos();
                }
            }
            else
            {
                MessageBox.Show("No se encontro el usuario, por favor revise los datos de inicio de sesion");
                borrarCampos();
            }
        }
        private void lnkCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro frm = new frmRegistro();
            frm.Show();
        }
        private void borrarCampos()
        {
            this.txtEmail.Text = string.Empty;
            this.txtContraseña.Text = string.Empty;
        }
    }
}

