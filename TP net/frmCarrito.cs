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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace TP_net
{
    public partial class frmCarrito : Form
    {
        private Venta v;
        private float Monto = 0;
        public frmCarrito(Venta venta)
        {
            InitializeComponent();
            v = venta;
            UsuarioBE us = new UsuarioBE(v.IdCliente);
            UsuarioBL user = new UsuarioBL();
            us = user.BuscadorPorID(us);
            fecha.Text = DateTime.Now.ToString();
            txtNombre.Text = us.Nombre + " " + us.Apellido;
            //dgvCarrito.DataSource = v.MostrarLineas();
            Llenaflw();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (v.Lineas.Count() != 0)
            {
                foreach(LineaVenta lv in v.Lineas)
                {
                    ProductoBL.RestarStock(lv);
                }
                VentaBL ventaBL = new VentaBL();
                v.Monto = Monto;
                MessageBox.Show(ventaBL.AgregarVenta(v));
                DialogResult comprobante = MessageBox.Show("¿Desea imprimir comprobante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(comprobante == DialogResult.Yes)
                {
                    string paginaHtml = Properties.Resources.plantillahtml.ToString();
                    paginaHtml = paginaHtml.Replace("@USUARIO", this.txtNombre.Text);
                    paginaHtml = paginaHtml.Replace("@FECHA", v.fecha.ToString());
                    paginaHtml = paginaHtml.Replace("@NCOMPRA", v.Id.ToString());
                    var htmlRows = new StringBuilder();
                    foreach (Lineas_Control lc in this.flwCarrito.Controls)
                    {
                        htmlRows.Append("<tr>");
                        htmlRows.Append($"<td>{lc.txtNLinea.Text}</td>");
                        htmlRows.Append($"<td>{lc.txtNomProd.Text}</td>");
                        htmlRows.Append($"<td>{lc.txtMarca.Text}</td>");
                        htmlRows.Append($"<td>{lc.txtCantidad.Text}</td>");
                        htmlRows.Append($"<td>{lc.txtPrecioUni.Text}</td>");
                        htmlRows.Append($"<td>{lc.txtSubTotal.Text}</td>");
                        htmlRows.Append("</tr>");
                    }
                    paginaHtml = paginaHtml.Replace("@TOTAL", v.Monto.ToString());
                    paginaHtml = paginaHtml.Replace("@HtmlRows", htmlRows.ToString());

                    SaveFileDialog guardar = new SaveFileDialog();
                    guardar.FileName = DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";
                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                            pdfDoc.Open();
                            pdfDoc.Add(new Phrase(""));

                            using (StringReader sr = new StringReader(paginaHtml))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }
                            pdfDoc.Close();
                            stream.Close();
                        }
                    }
                }

                this.Dispose();
                LimpiarCarrito();
                UsuarioBE us = new UsuarioBE(v.IdCliente);
                UsuarioBL usuBL = new UsuarioBL();
                frmCliente frm = new frmCliente(usuBL.BuscadorPorID(us));
            }
            else MessageBox.Show("Agrega algun producto al carrito");
        }

        private void Llenaflw()
        {
            int numeroLinea = 1;

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
                Monto = Monto + subtotal;
            }
            this.txtMonto.Text = "$" + Monto.ToString();

        }

        private void flwCarrito_MouseUp(object sender, MouseEventArgs e)
        {
            flwCarrito.Refresh();
        }

        public void LimpiarCarrito()
        {
            foreach(Lineas_Control lc in  flwCarrito.Controls)
            {
                flwCarrito.Controls.Remove(lc);
            }
            //flwCarrito.Controls.Clear();
            //flwCarrito.Refresh();
            //foreach(Lineas_Control lc in  flwCarrito.Controls)
            //{
            //    lc.
            //}

        }
    }
}
