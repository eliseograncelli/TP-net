using BusinessEntities;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

                if (ckbVendedor.Checked)
                {
                    tipo = "Vendedor";
                }

            
            if (txtDni.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtEmail.Text == "" || txtContraseña.Text == "" || imgFoto.Image == null)
            {
                MessageBox.Show("Todos los campos deben estar completos");
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                imgFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                UsuarioBE usuNuevo = new UsuarioBE(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, txtEmail.Text, ms.ToArray(), txtContraseña.Text, tipo);
                UsuarioBL usuario = new UsuarioBL();
                MessageBox.Show(usuario.Agregar(usuNuevo));
            }
        }

        private void ckbMayorista_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckbMayorista.Checked == true)
            //{
            //    ckbVendedor.ForeColor = Color.Gray;
            //    ckbVendedor.Checked = false;
            //}
            //else
            //{
            //    ckbVendedor.ForeColor = Color.White;
            //}
        }

        private void ckbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckbVendedor.Checked == true)
            //{
            //    ckbMayorista.ForeColor = Color.Gray;
            //    ckbMayorista.Checked = false;

            //}
            //else
            //{
            //    ckbMayorista.ForeColor = Color.White;
            //}
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "archivos de imagen (*jpg; *png;) | *jpg; *png;";
            if (file.ShowDialog() == DialogResult.OK)
            {
                imgFoto.Image = Image.FromFile(file.FileName);
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (txtDni.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            string email = txtEmail.Text.Trim();
            if (!Regex.IsMatch(email, emailPattern))
            {

                MessageBox.Show("Por favor, ingrese una dirección de correo electrónico válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
