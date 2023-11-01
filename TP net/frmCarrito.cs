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
            v = venta;
            UsuarioBE us = new UsuarioBE(v.IdCliente);
            UsuarioBL user = new UsuarioBL();
            us = user.BuscadorPorID(us);

            txtNombre.Text = us.Nombre + " " + us.Apellido;
            //dgvCarrito.DataSource = v.MostrarLineas();
            Llenaflw();

        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            VentaBL ventaBL = new VentaBL();
            MessageBox.Show(ventaBL.AgregarVenta(v));
            UsuarioBE us = new UsuarioBE(v.IdCliente);
            UsuarioBL usuBL = new UsuarioBL();
            frmCliente frm = new frmCliente(usuBL.BuscadorPorID(us));
            this.Dispose();

        }

        private void Llenaflw()
        {
            int numeroLinea = 1;

            //foreach (LineaVenta lv in v.Lineas)
            //{
            //    float precio;
            //    ProductoBL p = new ProductoBL();
            //    ProductoBE prod = new ProductoBE(lv.IdProd);
            //    ProductoBE pBuscado = p.MostrarProducto(prod);

            //    Lineas_Control lc = new Lineas_Control(lv);
            //    lc.txtNLinea.Text = numeroLinea.ToString();
            //    numeroLinea++;
            //    lc.txtNomProd.Text = pBuscado.Nombre;
            //    lc.txtCantidad.Text = lv.Cantidad.ToString();
            //    lc.txtMarca.Text = pBuscado.Marca;
            //    if (int.Parse(lv.Cantidad.ToString()) >= 10)
            //    {
            //        precio = pBuscado.PrecioX10;
            //        lc.txtPrecioUni.Text = "$" + precio.ToString();
            //    }
            //    else
            //    {
            //        precio = pBuscado.PrecioUnitario;
            //        lc.txtPrecioUni.Text = "$"+ precio.ToString();
            //    }
            //    float subtotal = lv.Cantidad * precio;
            //    lc.txtSubTotal.Text = "$" + subtotal.ToString();
            //    //lc.Tag = lv.IdLinea;
            //    flwCarrito.Controls.Add(lc);
            //} 


            foreach (LineaVenta lv in v.Lineas)
            {
                float precio;
                ProductoBL p = new ProductoBL();
                ProductoBE prod = new ProductoBE(lv.IdProd);
                ProductoBE pBuscado = p.MostrarProducto(prod);

                Lineas_Control lc = new Lineas_Control(v);
                lc.txtNLinea.Text = numeroLinea.ToString();
                numeroLinea++;
                lc.txtNomProd.Text = pBuscado.Nombre;
                lc.txtCantidad.Text = lv.Cantidad.ToString();
                lc.txtMarca.Text = pBuscado.Marca;
                if (int.Parse(lv.Cantidad.ToString()) >= 10)
                {
                    precio = pBuscado.PrecioX10;
                    lc.txtPrecioUni.Text = "$" + precio.ToString();
                }
                else
                {
                    precio = pBuscado.PrecioUnitario;
                    lc.txtPrecioUni.Text = "$" + precio.ToString();
                }
                float subtotal = lv.Cantidad * precio;
                lc.txtSubTotal.Text = "$" + subtotal.ToString();
                lc.Tag = lv.IdLinea;
                flwCarrito.Controls.Add(lc);
            }




            /*        
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
              } */
        }

        private void flwCarrito_MouseUp(object sender, MouseEventArgs e)
        {
            flwCarrito.Refresh();
        }
    }
}
