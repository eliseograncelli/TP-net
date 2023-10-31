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
        internal UsuarioBE uss;
        private Venta v;

        public frmCliente(UsuarioBE us)
        {
            InitializeComponent();
            txtUsuario.Text = us.Nombre.ToString() + " " + us.Apellido.ToString();
            v = new Venta(us);
            AgregarControles(v);
            MessageBox.Show("¡SI COMPRAS 10 O MAS UNIDADES DE UN PRODUCTO OBTENES UN DESCUENTO!", "Te avisamos...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        List<ProductoBE> listado = new List<ProductoBE>();

        private void AgregarControles(Venta v)
        {
            ProductoBL productoBL = new ProductoBL();
            // List<ProductoBE> listado = new List<ProductoBE>();
            listado = productoBL.ObtenerProductos();

            foreach (ProductoBE producto in listado) // OK
            {
                Prod_Control productoControl = new Prod_Control(v);
                productoControl.txtNombreProd.Text = producto.Nombre.ToString();
                productoControl.txtPrecio.Text = "$" + producto.PrecioUnitario.ToString();
                productoControl.txtId.Text = producto.IdProd.ToString();
                byte[] fotoProd = producto.imagen;
                if (fotoProd != null)
                {
                    MemoryStream ms = new MemoryStream(fotoProd);
                    productoControl.pbxProd.Image = Image.FromStream(ms);
                }
                productoControl.Tag = listado.IndexOf(producto);
                productoControl.Click += ProdControl_Click;

                flowLayoutPanel1.Controls.Add(productoControl);
            }
        }

        private void ProdControl_Click(object sender, EventArgs e)
        {
            Prod_Control seleccionado = (Prod_Control)sender;
            int indiceSelec = (int)seleccionado.Tag;
            ProductoBE productoSeleccionado = listado[indiceSelec];
            string nombre = productoSeleccionado.Nombre;
            string marca = productoSeleccionado.Marca;
            float pcioUni = productoSeleccionado.PrecioUnitario;
            float pcio10 = productoSeleccionado.PrecioX10;
            int stck = productoSeleccionado.stock;
            string desc = productoSeleccionado.Descripcion;
            int vend = productoSeleccionado.IdVendedor;
            float pcioMay = productoSeleccionado.PrecioMayorista;
            byte[] foto = productoSeleccionado.imagen;

            ProductoBE prodAMostrar = new ProductoBE(nombre, marca, desc, pcioUni, pcio10, pcioMay, vend, foto, stck);

            frmDetalleProducto frm = new frmDetalleProducto();
            frm.MuestraProd(productoSeleccionado);
        }



        private void lblCarrito_MouseClick(object sender, MouseEventArgs e)
        {
            //frmCarrito frm = new frmCarrito();
            /*List<LineaVenta> lineas = new List<LineaVenta>();
            

            foreach (Prod_Control pc in flowLayoutPanel1.Controls)
            {
                if (int.Parse(pc.txtCantidad.Text) > 0)
                {
                    int indiceSelec = (int)pc.Tag;
                    ProductoBE productoSeleccionado = listado[indiceSelec];
                    ProductoBE p = new ProductoBE(productoSeleccionado.IdProd, productoSeleccionado.Nombre, productoSeleccionado.Marca, productoSeleccionado.Descripcion, productoSeleccionado.PrecioUnitario, productoSeleccionado.PrecioX10, productoSeleccionado.PrecioMayorista, productoSeleccionado.IdVendedor, productoSeleccionado.imagen, productoSeleccionado.stock);
                    LineaVenta lv = new LineaVenta(p, int.Parse(pc.txtCantidad.Text));
                    lineas.Add(lv);
                }
            } */
            
            //Venta v = new Venta(uss);
            if(v.Lineas.Count == 0)
            {
                MessageBox.Show("Carrito vacio");
            }
            else
            {
                frmCarrito frm = new frmCarrito(v);
                frm.Show();
            }


        }
    }
}
