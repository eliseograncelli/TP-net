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
            LlenaDgv();
            txtId.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioBL usu = new UsuarioBL();
            UsuarioBE usuNuevo = new UsuarioBE(int.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text, txtEmail.Text, null, txtContraseña.Text, cbxTipo.Text, cbxEstado.Text);
            if (usu.Buscador(usuNuevo) == null)
            {
                usu.Agregar(usuNuevo);
                MessageBox.Show("Usuario: " + usuNuevo.Nombre.ToString() + " " + usuNuevo.Apellido.ToString() + " creado con éxito.");
            }
            else
            {
                MessageBox.Show("El mail ingresado ya posee una cuenta, del tipo " + usu.Buscador(usuNuevo).Tipo.ToString() + ". Si desea crear una cuenta de otro tipo ingrese otro email.");
            }
            limpiaEntradas();
            LlenaDgv();
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
            UsuarioBE us = SeleccionaUsuario();
            UsuarioBL usu = new UsuarioBL();
            MessageBox.Show(usu.Modificar(us));
            limpiaEntradas();
            LlenaDgv();
        }

        private UsuarioBE SeleccionaUsuario()
        {
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string contraseña = txtContraseña.Text;
            int dni = int.Parse(txtDNI.Text);
            string tipo = cbxTipo.Text;
            string estado = cbxEstado.Text;
            UsuarioBE usuario = new UsuarioBE(id, dni, nombre, apellido, email, null, contraseña, tipo, estado);
            return usuario;
        }

        private void LlenaDgv()
        {
            UsuarioBL usu = new UsuarioBL();
            dgvUsuarios.DataSource = usu.Listar().Tables[0];
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            UsuarioBL usu = new UsuarioBL();
            UsuarioBE usuABorrar = SeleccionaUsuario();
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el usuario " + usuABorrar.Nombre + " " + usuABorrar.Apellido +"? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    usu.Eliminar(usuABorrar);
                    MessageBox.Show("Usuario " + usuABorrar.Nombre + " " + usuABorrar.Apellido + " eliminado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
            limpiaEntradas();
            LlenaDgv();
        }
    }
}
