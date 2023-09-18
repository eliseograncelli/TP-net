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
    public partial class frmAdminUsuarios : Form
    {
        public frmAdminUsuarios()
        {
            UsuarioBL us = new UsuarioBL();
            InitializeComponent();
            dgvUsuarios.DataSource = us.Listar().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioBE usuNuevo = new UsuarioBE(int.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text, txtEmail.Text, null, txtContraseña.Text, cbxTipo.Text, cbxEstado.Text);
        }

        private void limpiaEntradas()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtContraseña.Text = "";
            txtId.Text = "";
            cbxEstado.Text = "";
            cbxTipo.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiaEntradas();
        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            txtNombre.Text = dgvUsuarios.Rows[indice].Cells[2].Value.ToString();
            txtApellido.Text = dgvUsuarios.Rows[indice].Cells[3].Value.ToString();
            txtEmail.Text = dgvUsuarios.Rows[indice].Cells[4].Value.ToString();
            txtContraseña.Text = dgvUsuarios.Rows[indice].Cells[6].Value.ToString();
            txtId.Text = dgvUsuarios.Rows[indice].Cells[0].Value.ToString();
            txtDNI.Text = dgvUsuarios.Rows[indice].Cells[1].Value.ToString();
            cbxTipo.Text = dgvUsuarios.Rows[indice].Cells[7].Value.ToString();
            cbxEstado.Text = dgvUsuarios.Rows[indice].Cells[8].Value.ToString(); 

            UsuarioBE usu = new UsuarioBE(int.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text, txtEmail.Text, null, txtContraseña.Text, cbxTipo.Text, cbxEstado.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string contraseña = txtContraseña.Text;
            int dni = int.Parse(txtDNI.Text);
            string tipo = cbxTipo.Text;
            string estado = cbxEstado.Text;

            UsuarioBE usuModificado = new UsuarioBE(id, dni, nombre, apellido, email, null, contraseña, tipo, estado);
            UsuarioBL usu = new UsuarioBL();
            MessageBox.Show(usu.Modificar(usuModificado));
            dgvUsuarios.DataSource = usu.Listar().Tables[0];

        }
    }
}
