using BusinessEntities;
using BusinessLogic;
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
            ProductoBL productoBL = new ProductoBL();
            List<ProductoBE> listado = new List<ProductoBE>();
            listado = productoBL.ObtenerProductos();

            foreach (ProductoBE producto in listado) // OK
            {
                Prod_Control productoControl = new Prod_Control();
                productoControl.txtNombreProd.Text = producto.Nombre.ToString();
                productoControl.txtPrecio.Text = "$"+ producto.PrecioUnitario.ToString();
                productoControl.txtPrecioX10.Text = "$"+ producto.PrecioX10.ToString();
                byte[] fotoProd = producto.imagen;
                if ( fotoProd != null )
                {
                    MemoryStream ms = new MemoryStream(fotoProd);
                    productoControl.pbxProd.Image = Image.FromStream(ms);
                }
                flowLayoutPanel1.Controls.Add(productoControl);
            }
        }
    }
}
