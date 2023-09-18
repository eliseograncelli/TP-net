using BusinessEntities;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_net
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string tipo = null;
            if (ckbMayorista.Checked)
            {
                tipo = "Cliente mayorista";
            }
            else
            {
                if (ckbVendedor.Checked)
                {
                    tipo = "Vendedor";
                }

            }
            UsuarioBE usuNuevo = new UsuarioBE(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, txtEmail.Text, null, txtContraseña.Text, tipo);
            UsuarioBL usuario = new UsuarioBL();
            usuario.Agregar(usuNuevo);
        }

        private void ckbMayorista_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMayorista.Checked == true)
            {
                ckbVendedor.Enabled = false;
            }
            else
            {
                ckbVendedor.Enabled = true;
            }
        }

        private void ckbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVendedor.Checked == true)
            {
                ckbMayorista.Enabled = false;
            }
            else
            {
                ckbMayorista.Enabled = true;
            }
        }
    }
}
