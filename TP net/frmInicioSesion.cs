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
            UsuarioBE usu = new UsuarioBE();
            UsuarioBL us = new UsuarioBL();
            usu = us.Buscador(txtEmail.Text, txtContraseña.Text);
        }
    }
}

