using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_net
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            AgregarControles();
        }

        private void AgregarControles()
        {
            ProductoBE p1 = new ProductoBE("Gin", "Gordons", "hola perro", 1, 20, 15, 10,  null, 80 );
            ProductoBE p2 = new ProductoBE("Vino", "Rutini", "dogooo", 2, 20, 30, 22,  null , 10);

            List<ProductoBE> listado = new List<ProductoBE>
            {
             p1, p2
            };

            foreach (ProductoBE producto in listado)
            {
                Prod_Control productoControl = new Prod_Control();
                productoControl.txtNombreProd.Text = producto.Descripcion.ToString();
                productoControl.txtPrecio.Text = producto.PrecioUnitario.ToString();
                productoControl.pbxProd = null;

                // Agregar el control al FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(productoControl);
            }
        }

    }
}
