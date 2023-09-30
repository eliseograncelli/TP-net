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
            ProductoBE p1 = new ProductoBE("Gin", "Gordons", "Floral", 20, 15, 10);
            ProductoBE p2 = new ProductoBE("Vino", "Rutini", "Notas a uva", 30, 15, 10);
            ProductoBE p3 = new ProductoBE("Vino", "Viña", "Para tomar con manacho", 5, 4, 2);
            ProductoBE p4 = new ProductoBE("Gin", "BullDog", "Tomalo con scheepes", 22, 21, 19);
            ProductoBE p5 = new ProductoBE("Vino", "Toro", "De Argentina al mundo", 6, 5, 2);
            ProductoBE p6 = new ProductoBE("Vino", "Colon", "Notas a roble", 11, 11, 10);

            List<ProductoBE> listado = new List<ProductoBE>
            {
             p1, p2, p3, p4, p5, p6
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
