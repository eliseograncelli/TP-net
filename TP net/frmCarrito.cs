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
    public partial class frmCarrito : Form
    {
        private Venta v;
        public frmCarrito(Venta venta)
        {
            InitializeComponent();
            v= venta;
            UsuarioBE us = new UsuarioBE(v.IdCliente);
            UsuarioBL user = new UsuarioBL();
            us = user.BuscadorPorID(us);

            txtNombre.Text = us.Nombre + " " + us.Apellido;
            dgvCarrito.DataSource = v.MostrarLineas();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            VentaBL ventaBL = new VentaBL();
            MessageBox.Show(ventaBL.AgregarVenta(v)); 
        } 
    }
}
