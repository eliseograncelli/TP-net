using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TP_net
{
    public partial class Prod_Control : UserControl
    {
        private Venta v;
        public Prod_Control(Venta venta)
        {
            InitializeComponent();
            v = venta;

        }

        private void Prod_Control_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_MouseClick(object sender, MouseEventArgs e)
        {
            int nro = int.Parse(txtCantidad.Text);
            nro++;
            txtCantidad.Text = nro.ToString();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int nro = int.Parse(txtCantidad.Text);
            if (nro > 0)
            {
                nro--;
            }
            txtCantidad.Text = nro.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad))

                {
                    ProductoBE p = new ProductoBE(int.Parse(txtId.Text));
                    v.AgregarProductos(p, cantidad);
            }
        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
