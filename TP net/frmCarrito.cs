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
    public partial class frmCarrito : Form
    {
        public frmCarrito(Venta v, UsuarioBE us)
        {
            InitializeComponent();

            txtNombre.Text = us.Nombre + " " + us.Apellido;
            dgvCarrito.DataSource = v.MostrarLineas();


            // v.Lineas.ToList();
        }

    }
}
