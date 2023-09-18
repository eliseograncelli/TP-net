using BusinessEntities;
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
    public partial class frmAdminUsuarios : Form
    {
        public frmAdminUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioBE usuNuevo = new UsuarioBE(int.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text, txtEmail.Text, null, txtContraseña.Text, cbxTipo.Text, cbxEstado.Text);
        }
    }
}
